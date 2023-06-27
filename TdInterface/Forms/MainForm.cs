using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TdInterface.Forms;
using TdInterface.Interfaces;
using TdInterface.Tda;
using TdInterface.Tda.Model;
using Websocket.Client;
using Websocket.Client.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TdInterface
{
    public partial class MainForm : EZTMBaseForm
    {
        private IStreamer _streamer;

        private IBrokerage _broker;
      
        private string curSymbol = String.Empty;

      
        // Made Public for testing.
        public bool isTda = false;
        public bool isTradeStation = true;

        public Securitiesaccount _securitiesaccount;
        private Position _activePosition;

        public string MainFormName{ get; private set; }

        public MainForm(IStreamer streamer, string name, IBrokerage helper)
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.Font;

            _broker = helper;

            MainFormName = name;
            this.Text = name;

            txtPnL.Visible = Program.Settings.ShowPnL;
            lblPnL.Visible = Program.Settings.ShowPnL;

            _streamer = streamer;
            _streamer.StockQuoteReceived.Subscribe(x => HandleStockQuote(x));
            _streamer.AcctActivity.Subscribe(a => HandleAcctActivity(a));
            _streamer.OrderRecieved.Subscribe(o => HandleOrderRecieved(o));
            _streamer.OrderFilled.Subscribe(o => HandleOrderFilled(o));
            _streamer.HeartBeat.Subscribe(s => HandleHeartBeat(s));
            _streamer.Reconnection.Subscribe(r => HandleReconnection(r));
            _streamer.Disconnection.Subscribe(d => HandleDisconnect(d));

            btnBuyLmtTriggerOco.Enabled = false;
            btnBuyMrkTriggerOco.Enabled = false;
            btnSellLmtTriggerOco.Enabled = false;
            btnSellMrkTriggerOco.Enabled = false;
            btnExit10.Enabled = false;
            btnExit25.Enabled = false;
            btnExit33.Enabled = false;
            btnExit50.Enabled = false;
            btnExit100.Enabled = false;
            btnBreakEven.Enabled = false;

            var securitiesaccount = _broker.GetAccount(_broker.AccountId).Result;

            // Handle always on top setting
            this.TopMost = Program.Settings.AlwaysOnTop;

            lblVersion.Text = $"v {Program.AppVersion}";
        }


        public static Order CreateGenericTriggerOcoOrder(TdInterface.Model.StockQuote stockQuote, string orderType, string symbol, string instruction, double triggerLimit, double stopPrice, bool tradeShares, double maxRisk, double dailyPnl, bool disableFirstTarget, Settings settings)
        {
            maxRisk = TDAOrderHelper.CheckMaxRisk(maxRisk, dailyPnl, settings);

            var isShort = instruction.Equals(TDAOrderHelper.SELL_SHORT);

            var bidAskPrice = isShort ? stockQuote.bidPrice : stockQuote.askPrice;
            var ocoCalcPrice = orderType == "MARKET" ? settings.UseBidAskOcoCalc ? bidAskPrice : stockQuote.lastPrice : triggerLimit;
            var riskPerShare = isShort ? stopPrice - ocoCalcPrice : ocoCalcPrice - stopPrice;
            var firstTargetlimtPrice = isShort ? ocoCalcPrice - riskPerShare : ocoCalcPrice + riskPerShare;

            if (riskPerShare < 0)
            {
                throw new Exception("Risk Per Share was negative.");
            }

            int quantity = TDAOrderHelper.CalculateShares(riskPerShare, maxRisk, settings.MinimumRisk, tradeShares);

            var firstTargetLimitShares = Convert.ToInt32(Math.Ceiling(quantity * decimal.Divide(settings.OneRProfitPercenatage, 100)));

            Order triggerOrder = null;

            if (disableFirstTarget)
            {
                triggerOrder = TDAOrderHelper.CreateTriggerStopOrder(orderType, symbol, instruction, quantity, triggerLimit, stopPrice);
            }
            else
            {
                triggerOrder = TDAOrderHelper.CreateTriggerOcoOrder(orderType, symbol, instruction, quantity, triggerLimit, firstTargetLimitShares, firstTargetlimtPrice, stopPrice);
            }

            return triggerOrder;
        }

        public async Task GenericTriggerOco(TdInterface.Model.StockQuote stockQuote, string orderType, string symbol, string instruction, double triggerLimit)
        {

            try
            {
                var stopPrice = double.Parse(txtStop.Text);
                var tradeShares = chkTradeShares.Checked;
                var maxRisk = double.Parse(txtRisk.Text);

                ulong orderKey = 0;
                Order triggerOrder= null;
                if (isTda)
                {
                    if (isTda && _streamer.WebsocketClient.NativeClient.State != System.Net.WebSockets.WebSocketState.Open) throw new Exception($"Socket not open, restart application {_streamer.WebsocketClient.NativeClient.State.ToString()}");
                    triggerOrder = CreateGenericTriggerOcoOrder(stockQuote, orderType, symbol, instruction, triggerLimit, stopPrice, tradeShares, maxRisk, _securitiesaccount.DailyPnL, chkDisableFirstTarget.Checked, Program.Settings);
                    orderKey = await _broker.PlaceOrder(_broker.AccountId, triggerOrder);
                }
                else if (isTradeStation)
                {
                    triggerOrder = CreateGenericTriggerOcoOrder(stockQuote, orderType, symbol, instruction, triggerLimit, stopPrice, tradeShares, maxRisk, 0.0, chkDisableFirstTarget.Checked, Program.Settings);
                    orderKey = await _broker.PlaceOrder(_broker.AccountId, triggerOrder);
                }

                ResetInitialOrder();
                txtLastError.Text = JsonConvert.SerializeObject(triggerOrder);
                AddInitialOrder(symbol, orderKey);

                // Capture Screenshots if requested
                if (Program.Settings.SendAltPrtScrOnOpen) { InputSender.PrintScreen(); }
                if (Program.Settings.CaptureScreenshotOnOpen) { _ = Task.Run(() => Utility.CaptureScreen(txtSymbol.Text)); }
            }
            catch (Exception ex)
            {
                var msgBox = MessageBox.Show(ex.Message);
            }

        }

        private Dictionary<string, List<ulong>> _initialOrders = new Dictionary<string, List<ulong>>();

        public void AddInitialOrder(string symbol, ulong orderKey)
        {
            if (!_initialOrders.ContainsKey(symbol.ToUpper()))
            {
                _initialOrders.Add(symbol.ToUpper(), new List<ulong>());
            }

            _initialOrders[symbol.ToUpper()].Add(orderKey);
        }

        #region Order Open 
        private async void btnSellMrkTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                var stockQuote = _broker.GetStockQuote(txtSymbol.Text);

                var orderType = "MARKET";
                var symbol = txtSymbol.Text;
                var instruction = TDAOrderHelper.SELL_SHORT;
                var triggerLimit = double.Parse("0.0");

                await GenericTriggerOco(stockQuote, orderType, symbol, instruction, triggerLimit);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
            }
        }

        private async void btnSellLmtTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                var stockQuote = _broker.GetStockQuote(txtSymbol.Text);
                var orderType = "LIMIT";
                var symbol = txtSymbol.Text;
                var instruction = TDAOrderHelper.SELL_SHORT;

                double triggerLimit = double.MinValue;

                if (string.IsNullOrEmpty(txtLimit.Text))
                {
                    triggerLimit = stockQuote.bidPrice - double.Parse(txtLimitOffset.Text);
                }
                else
                {
                    triggerLimit = double.Parse(txtLimit.Text);
                }

                await GenericTriggerOco(stockQuote, orderType, symbol, instruction, triggerLimit);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
            }

        }

        private async void btnBuyMrkTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                var stockQuote = _broker.GetStockQuote(txtSymbol.Text);
                var orderType = "MARKET";
                var symbol = txtSymbol.Text;
                var instruction = TDAOrderHelper.BUY;
                var triggerLimit = double.Parse("0.0");

                await GenericTriggerOco(stockQuote, orderType, symbol, instruction, triggerLimit);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
            }
        }

        private async void btnBuyLmtTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                var stockQuote = _broker.GetStockQuote(txtSymbol.Text);
                var orderType = "LIMIT";
                var symbol = txtSymbol.Text;
                var instruction = TDAOrderHelper.BUY;
                double triggerLimit = double.MinValue;
                if (string.IsNullOrEmpty(txtLimit.Text))
                {
                    triggerLimit = stockQuote.askPrice + double.Parse(txtLimitOffset.Text);
                }
                else
                {
                    triggerLimit = double.Parse(txtLimit.Text);
                }

                await GenericTriggerOco(stockQuote, orderType, symbol, instruction, triggerLimit);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
            }

        }


        private void ResetInitialOrder()
        {
            txtAveragePrice.Text = string.Empty;
            txtShares.Text = string.Empty;
            txtStopToClose.Text = string.Empty;
        }

        #endregion

        #region Order Close
        private async void btnBreakEven_Click(object sender, EventArgs e)
        {
            try
            {
                if (_activePosition != null)
                {
                    var stopInstruction = "";
                    int quantity = 0;
                    if (_activePosition.longQuantity > 0)
                    {
                        stopInstruction = TDAOrderHelper.SELL;
                        quantity = (int)_activePosition.longQuantity;
                    }
                    else if (_activePosition.shortQuantity > 0)
                    {
                        stopInstruction = TDAOrderHelper.BUY_TO_COVER;
                        quantity = (int)_activePosition.shortQuantity;
                    }
                    else
                    {
                        txtLastError.Text = "BreakEven Button Cant' Deterimine position";
                        return;
                    }

                    var stopPrice = _activePosition.averagePrice;
                    if (!string.IsNullOrEmpty(txtStopToClose.Text))
                    {
                        stopPrice = float.Parse(txtStopToClose.Text);
                    }

                    await PlaceStopOrder(_activePosition.instrument.symbol, quantity, stopInstruction, stopPrice);
                }
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async void btnExitPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Button && _activePosition != null)
                {
                    Button btn = (Button)sender;

                    double exitPercentage = Double.Parse(btn.Tag.ToString());
                    var quantity = (int)Math.Ceiling(_activePosition.Quantity * exitPercentage);

                    if (rbExitMarket.Checked == true) // MARKET
                    {
                        await ExitMarket(quantity);
                    }
                    else if (rbExitBidAsk.Checked == true) // BID / ASK
                    {
                        await ExitBidOrAsk(quantity);
                    }
                    else
                    {
                        Debug.WriteLine("Invalid Exit Method Selection");
                    }
                }
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async Task ExitBidOrAsk(int quantity)
        {
            var stockQuote = _broker.GetStockQuote(txtSymbol.Text);
            string exitInstruction = GetExitInstruction(_activePosition);
            var limitPrice = 0.0;
            if (exitInstruction == TDAOrderHelper.SELL)
            {
                limitPrice = stockQuote.askPrice;
            }
            else
            {
                limitPrice = stockQuote.bidPrice;
            }

            if (_securitiesaccount == null)
            {
                _securitiesaccount = await GetSecuritiesaccountAsync();
            }

            var stopOrder = _securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "STOP").FirstOrDefault();
            var parent = TDAOrderHelper.GetParentOrder(_securitiesaccount.orderStrategies, stopOrder);

            if (stopOrder != null)
            {
                if (parent != null && parent.orderStrategyType.Equals("OCO"))
                {
                    await CancelAll();
                    await PlaceLimitOrder(_activePosition.instrument.symbol, quantity, exitInstruction, limitPrice);
                }
                else
                {
                    var activeQuantity = _activePosition.Quantity;
                    //Change the stop order to a Limit order to take profit and repladce
                    var newOrder = TDAOrderHelper.CreateLimitOrder(exitInstruction, _activePosition.instrument.symbol, quantity, limitPrice);
                    await _broker.ReplaceOrder(_broker.AccountId, stopOrder.orderId, newOrder);
                    await Task.Delay(Program.Settings.SleepBetweenReduceOrderOnClose);
                    var newStopOrder = TDAOrderHelper.CreateStopOrder(exitInstruction, _activePosition.instrument.symbol, activeQuantity - quantity, Double.Parse(stopOrder.stopPrice));
                    await _broker.PlaceOrder(_broker.AccountId, newStopOrder);
                }
            }
            else
            {
                await PlaceLimitOrder(_activePosition.instrument.symbol, quantity, exitInstruction, limitPrice);
            }
        }

        private async Task ExitMarket(int quantity)
        {
            string exitInstruction = GetExitInstruction(_activePosition);
            if(_securitiesaccount == null)
            {
                _securitiesaccount = await GetSecuritiesaccountAsync();
            }
            var stopOrder = _securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol.Equals(txtSymbol.Text, StringComparison.InvariantCultureIgnoreCase)  && o.orderType == "STOP").FirstOrDefault();

            // TODO: THIS WILL NOT WORK FOR TRADESTATION AS THE ORDERS ARE FLAT.
            var parent = TDAOrderHelper.GetParentOrder(_securitiesaccount.orderStrategies, stopOrder);

            if (stopOrder != null)
            {
                if (parent != null && parent.orderStrategyType.Equals("OCO"))
                {
                    await CancelAll();
                    await PlaceMarketOrder(_activePosition.instrument.symbol, quantity, exitInstruction);
                }
                else
                {
                    var activeQuantity = _activePosition.Quantity;
                    //Change the stop order to a Limit order to take profit and repladce
                    var newOrder = TDAOrderHelper.CreateMarketOrder(exitInstruction, _activePosition.instrument.symbol, quantity);
                    await _broker.ReplaceOrder(_broker.AccountId, stopOrder.orderId, newOrder);
                    await Task.Delay(Program.Settings.SleepBetweenReduceOrderOnClose);
                    var newStopOrder = TDAOrderHelper.CreateStopOrder(exitInstruction, _activePosition.instrument.symbol, activeQuantity - quantity, Double.Parse(stopOrder.stopPrice));
                    await _broker.PlaceOrder(_broker.AccountId, newStopOrder);
                }
            }
            else
            {
                await PlaceMarketOrder(_activePosition.instrument.symbol, quantity, exitInstruction);
            }
        }



        /// <summary>
        /// Get Exit Instruction, uses TDAHelper as the Tradestaton helper will convert this to what it needs on execution.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static string GetExitInstruction(Position position)
        {
            var exitInstruction = "";
            if (position.longQuantity > 0)
            {
                exitInstruction = TDAOrderHelper.SELL;
            }
            else if (position.shortQuantity > 0)
            {
                exitInstruction = TDAOrderHelper.BUY_TO_COVER;
            }
            else
            {
                throw new Exception("Sell Market Button Cant' Deterimine position");
            }

            return exitInstruction;
        }

        private async Task PlaceMarketOrder(string symbol, int quantity, string instruction)
        {
            var stopOrder = TDAOrderHelper.CreateMarketOrder(instruction, symbol, quantity);
            var orderKey = await _broker.PlaceOrder(_broker.AccountId, stopOrder);
        }

        private async Task PlaceLimitOrder(string symbol, int quantity, string instruction, double limitPrice)
        {
            var stopOrder = TDAOrderHelper.CreateLimitOrder(instruction, symbol, quantity, limitPrice);
            var orderKey = await _broker.PlaceOrder(_broker.AccountId, stopOrder);
        }


        private async Task PlaceStopOrder(string symbol, int quantity, string instruction, double stopPrice)
        {
            var stopOrder = TDAOrderHelper.CreateStopOrder(instruction, symbol, quantity, stopPrice);
            var orderKey = await _broker.PlaceOrder(_broker.AccountId, stopOrder);
        }
        #endregion

        #region Cancel Order
        private async void btnCancelAll_Click(object sender, EventArgs e)
        {
            try
            {
                await CancelAll();
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async Task CancelAll()
        {
            await _broker.CancelAll(_broker.AccountId, txtSymbol.Text);
        }
        #endregion

        #region Handle Streamer Events
        private void HandleStockQuote(TdInterface.Model.StockQuote stockQuote)
        {
            if (!stockQuote.symbol.Equals(txtSymbol.Text, StringComparison.InvariantCultureIgnoreCase)) return;
            stockQuote = _broker.SetStockQuote(stockQuote);
            SafeUpdateTextBox(txtLastPrice, stockQuote.lastPrice.ToString("0.00"));
            SafeUpdateTextBox(txtBid, stockQuote.bidPrice.ToString("0.00"));
            SafeUpdateTextBox(txtAsk, stockQuote.askPrice.ToString("0.00"));


            try
            {
                if (_activePosition != null && txtStop.Text != String.Empty)
                {
                    var avgPrice = _activePosition.averagePrice;
                    var initialStop = float.Parse(txtStop.Text);

                    float risk = Math.Abs(avgPrice - initialStop);
                    float reward = (float)stockQuote.lastPrice - avgPrice;
                    reward = reward * (_activePosition.shortQuantity > 0 ? -1 : 1);

                    var rValue = reward / risk;
                    SafeUpdateTextBox(txtRValue, rValue.ToString("0.00"));

                    double oneToOne;
                    if (_activePosition.longQuantity > 0)
                        oneToOne = avgPrice + risk;
                    else
                    {
                        oneToOne = avgPrice - risk;
                    }

                    SafeUpdateTextBox(txtOneToOne, oneToOne.ToString("0.00"));
                }
                else
                {
                    SafeUpdateTextBox(txtRValue, "0");
                    double stop;

                    if (double.TryParse(txtStop.Text, out stop))
                    {
                        double oneToOne;
                        if (stop < stockQuote.lastPrice)
                        {
                            oneToOne = (stockQuote.lastPrice - stop) + stockQuote.lastPrice;
                        }
                        else
                        {
                            oneToOne = stockQuote.lastPrice - (stop - stockQuote.lastPrice);
                        }
                       SafeUpdateTextBox(txtOneToOne, oneToOne.ToString("0.00"));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

        }

        private async void HandleAcctActivity(AcctActivity a)
        {
            try
            {
                _securitiesaccount = _broker.Securitiesaccount;
                await SetPosition();
                _securitiesaccount = await GetSecuritiesaccountAsync();

                if (typeof(TdHelper) == _broker.GetType() && _securitiesaccount != null)
                {
                    txtPnL.Text = _securitiesaccount.DailyPnL.ToString("#.##");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async Task<Securitiesaccount> GetSecuritiesaccountAsync()
        {
            var securitiesaccount = new Securitiesaccount();
            if (typeof(TdHelper) == _broker.GetType())
            {
                securitiesaccount = await _broker.GetAccount(_broker.AccountId);
            }
            else
            {
                securitiesaccount = _broker.Securitiesaccount;
            }

            return securitiesaccount;

        }
        private async void HandleOrderRecieved(OrderEntryRequestMessage orderEntryRequestMessage)
        {
            try
            {
                _securitiesaccount = await GetSecuritiesaccountAsync();

                var symbol = orderEntryRequestMessage.Order.Security.Symbol;
                Debug.WriteLine($"HandleOrderReceived: symbol {symbol}");
                Debug.WriteLine($"HandleOrderReceived: initial orders {JsonConvert.SerializeObject(_initialOrders)}");

                if (_initialOrders.ContainsKey(symbol.ToUpper()))
                {
                    Debug.WriteLine("HandleOrderReceived: Found Initial Order by symbol");
                    //We have an initial order lets find the limit and save it off
                    if (_initialOrders[symbol].Contains(orderEntryRequestMessage.Order.OrderKey) && _securitiesaccount != null)
                    {
                        Debug.WriteLine("HandleOrderReceived: Found Initial Order by OrderKey");
                        var triggerOrder = _securitiesaccount.orderStrategies.Where(o => ulong.Parse(o.orderId) == orderEntryRequestMessage.Order.OrderKey).FirstOrDefault();
                        //Get Trigger order by key and from there look at child strats to find the limit,  orders are not flat like I thought.
                        //So the Trigger has an OCO that has the limit and stop.  
                        if (triggerOrder.childOrderStrategies[0].childOrderStrategies != null)
                        {
                            _initialLimitOrder = triggerOrder.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "LIMIT").FirstOrDefault();
                        }

                        Debug.WriteLine($"HandleOrderReceived: _initialLimitOrder {JsonConvert.SerializeObject(_initialLimitOrder)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async void HandleOrderFilled(OrderFillMessage orderFillMessage)
        {
            try
            {
                if (orderFillMessage != null)
                {
                    await SetPosition();

                    Debug.Write($"HandleOrderFill {JsonConvert.SerializeObject(orderFillMessage)}");

                    var symbol = orderFillMessage.Order.Security.Symbol;
                    Debug.WriteLine($"HandleOrderFilled: symbol {symbol}");
                    Debug.WriteLine($"HandleOrderFilled: initial orders {JsonConvert.SerializeObject(_initialOrders)}");

                    // Capture a screenshot after 1 second, as it takes time for ToS to actually show the orders on the screen.... may need to tweak this.
                    if (Program.Settings.CaptureScreenshotOnOpen) { _ = Task.Run(() => { Task.Delay(1000); Utility.CaptureScreen(txtSymbol.Text); }); };

                    //check to see if this is the initial Limit order, if it is, set the stop to BE.
                    if (_initialLimitOrder != null)
                    {
                        Debug.WriteLine($"HandleOrderFilled equals Order Key {orderFillMessage.Order.OrderKey} {JsonConvert.SerializeObject(_initialLimitOrder)}");
                        if (_initialLimitOrder.orderId.Equals(orderFillMessage.Order.OrderKey))
                        {
                            Debug.WriteLine($"HandleOrderFilled equals Order Key {JsonConvert.SerializeObject(_initialLimitOrder)}");
                            btnBreakEven.PerformClick();
                        }
                    }

                    if (Program.Settings.MoveLimitPriceOnFill)
                    {

                        Debug.WriteLine($"Settings.MoveLimitPriceOnFill: {Program.Settings.MoveLimitPriceOnFill}");
                        //var symbol = orderFillMessage.Order.Security.Symbol;
                        if (_initialOrders.ContainsKey(symbol.ToUpper()))
                        {
                            Debug.WriteLine("_initialOrders.ContainsKey(symbol)");
                            //Initial Trigger Order filled, adjust limit
                            if (_initialOrders[symbol].Contains(orderFillMessage.Order.OrderKey))
                            {
                                Debug.WriteLine("Found OrderKey");

                                _securitiesaccount = await GetSecuritiesaccountAsync();

                                if (_securitiesaccount != null)
                                {
                                    var triggerOrder = _securitiesaccount.orderStrategies.Where(o => ulong.Parse(o.orderId) == orderFillMessage.Order.OrderKey).FirstOrDefault();
                                    //Get Trigger order by key and from there look at child strats to find the limit,  orders are not flat like I thought.
                                    //So the Trigger has an OCO that has the limit and stop.
                                    //
                                    Order lmitOrder = null;

                                    if (triggerOrder.childOrderStrategies[0].childOrderStrategies != null)
                                    {
                                        lmitOrder = triggerOrder.childOrderStrategies[0].childOrderStrategies.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION" || o.status == "AWAITING_PARENT_ORDER") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "LIMIT").FirstOrDefault();
                                    }

                                    if (lmitOrder != null)
                                    {
                                        Debug.WriteLine($"Found Limit Order {JsonConvert.SerializeObject(lmitOrder)} ");
                                        var stop = float.Parse(txtStop.Text);
                                        var avgPrice = _activePosition.averagePrice;
                                        var risk = Math.Abs(avgPrice - stop);


                                        string exitInstruction = GetExitInstruction(_activePosition);

                                        var firstTargetlimtPrice = exitInstruction == "SELL" ? avgPrice + risk : avgPrice - risk;

                                        Debug.WriteLine($"stop: {stop} ; avgPrice: {avgPrice} ; risk: {risk} ; exitInsturction: {exitInstruction} ; firstTargetLimitPrice: {firstTargetlimtPrice}");

                                        var newLimitOrder = TDAOrderHelper.CreateLimitOrder(exitInstruction, symbol, Convert.ToInt32(Math.Round(lmitOrder.orderLegCollection[0].quantity)), firstTargetlimtPrice);
                                        await _broker.ReplaceOrder(_broker.AccountId, lmitOrder.orderId, newLimitOrder);
                                    }
                                }
                            }
                        }
                    }

                    // TODO: IF THIS WORKS MOVE IT AND CONSOLIDATE IT WITH THE MOVE PRICE CODE
                    //if (_initialOrders.ContainsKey(symbol.ToUpper()))
                    //{
                    //    Debug.WriteLine("HandleOrderFilled: Found Initial Order by symbol");
                    //    //We have an initial order lets find the limit and save it off
                    //    if (_initialOrders[symbol].ContainsKey(orderFillMessage.Order.OrderKey))
                    //    {
                    //        Debug.WriteLine("HandleOrderFilled: Found Initial Order by OrderKey");
                    //        var triggerOrder = _securitiesaccount.orderStrategies.Where(o => ulong.Parse(o.orderId) == orderFillMessage.Order.OrderKey).FirstOrDefault();
                    //        //Get Trigger order by key and from there look at child strats to find the limit,  orders are not flat like I thought.
                    //        //So the Trigger has an OCO that has the limit and stop.  
                    //        _initialLimitOrder = triggerOrder.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "LIMIT").FirstOrDefault();
                    //        Debug.WriteLine($"HandleOrderFilled: _initialLimitOrder {JsonConvert.SerializeObject(_initialLimitOrder)}");
                    //    }
                    //}

                    Debug.WriteLine(orderFillMessage.Order.OrderKey);
                }
            }
            catch (Exception ex)
            {
                SafeUpdateTextBox(txtLastError, ex.Message);
                Debug.WriteLine(ex.Message);
            }
        }

        private async void HandleHeartBeat(SocketNotify notify)
        {
            SafeUpdateTextBox(txtHeartBeat, DateTime.Now.ToString());
        }

        private async void HandleDisconnect(DisconnectionInfo disconnectionInfo)
        {
            try
            {
                SafeUpdateTextBox(txtConnectionStatus, "Disconnected - Attemptinng to Reconnect");
                await _streamer.WebsocketClient.ReconnectOrFail();
            }
            catch (Exception ex)
            {
                SafeUpdateTextBox(txtLastError, ex.Message);
                Debug.WriteLine(ex.Message);
                SafeUpdateTextBox(txtConnectionStatus, "Disconnected - COULD NOT RECONNECT-  RESTART APPLICATION");

            }
        }

        private async void HandleReconnection(ReconnectionInfo reconnectionInfo)
        {
            SafeUpdateTextBox(txtConnectionStatus, reconnectionInfo.Type.ToString());
        }
        #endregion

        #region Thread Safe UI Helpers
        private delegate void SafeCallDelegate(TextBox textBox, string text);

        private void SafeUpdateTextBox(TextBox textBox, string text)
        {
            try
            {
                if (textBox.InvokeRequired)
                {
                    var d = new SafeCallDelegate(SafeUpdateTextBox);
                    textBox.Invoke(d, new object[] { textBox, text });
                }
                else
                {
                    textBox.Text = text;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
        #endregion

        private Order _initialLimitOrder;


        private async Task SetPosition()
        {
            Position position = await GetPosition(txtSymbol.Text.ToUpper(), Utility.AccessTokenContainer, _broker.AccountId);

            if (position != null)
            {
                _activePosition = position;
                SafeUpdateTextBox(txtAveragePrice, _activePosition.averagePrice.ToString("0.00"));
                SafeUpdateTextBox(txtShares, _activePosition.DisplayQuantity.ToString());
            }
            else
            {
                _activePosition = null;
                SafeUpdateTextBox(txtAveragePrice, string.Empty);
                SafeUpdateTextBox(txtShares, string.Empty);
                Debug.WriteLine($"No position found for txtSymbol:{txtSymbol.Text.ToUpper()} | curSymbol: {curSymbol}");
            }
        }

        private async Task<Position> GetPosition(string symbol, AccessTokenContainer accessTokenContainer, string accountId)
        {
            Position position = null;

            try
            {
                _securitiesaccount = await GetSecuritiesaccountAsync();

                if (_securitiesaccount != null)
                {
                    try
                    {
                        SafeUpdateTextBox(txtPnL, _securitiesaccount.DailyPnL.ToString("#.##"));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine("Can't Update PnL");
                        Debug.WriteLine(ex.Message);
                        Debug.WriteLine(ex.StackTrace);
                    }

                    if (_securitiesaccount.positions != null)
                    {
                        position = _securitiesaccount.positions.Where(p => p != null && p.instrument.symbol == symbol).FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"GetPosition: {ex.Message}");
                Debug.WriteLine(ex.StackTrace);
            }
            return position;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.KeyCode == Keys.Oemtilde)
            //{
            //    _parent.Focus();
            //    e.SuppressKeyPress = true;
            //}
            //else
            if(e.Alt && e.KeyCode == Keys.R) 
            {
                e.SuppressKeyPress = false; 
                e.Handled = false;
            }

            if (e.Control && e.KeyCode == Keys.A)
            {
                btnCancelAll.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.B)
            {
                btnBuyMrkTriggerOco.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                btnSellMrkTriggerOco.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                btnBreakEven.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.B)
            {
                btnBuyLmtTriggerOco.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.Alt && e.KeyCode == Keys.S)
            {
                btnSellLmtTriggerOco.PerformClick();
                e.SuppressKeyPress = true;
            }
            //else if (e.KeyCode == Keys.F1)
            //{
            //    btnExitMark10.PerformClick();
            //    e.SuppressKeyPress = true;
            //}
            //else if (e.KeyCode == Keys.F2)
            //{
            //    btnExitMark25.PerformClick();
            //    e.SuppressKeyPress = true;
            //}
            //else if (e.KeyCode == Keys.F3)
            //{
            //    btnExitMark33.PerformClick();
            //    e.SuppressKeyPress = true;
            //}
            //else if (e.KeyCode == Keys.F4)
            //{
            //    btnExitMark50.PerformClick();
            //    e.SuppressKeyPress = true;
            //}
            //else if (e.KeyCode == Keys.F5)
            //{
            //    btnExitMark100.PerformClick();
            //    e.SuppressKeyPress = true;
            //}
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            chkTradeShares.Checked = Program.Settings.TradeShares;
            chkDisableFirstTarget.Checked = Program.Settings.DisableFirstTargetProfitDefault;

            if (Program.Settings.TradeShares)
            {
                txtRisk.Text = Program.Settings.MaxShares.ToString("#");
            }
            else
            {
                txtRisk.Text = Program.Settings.MaxRisk.ToString("#.##");
            }
            if (Program.Settings.DefaultLimitOffset != 0)
            {
                txtLimitOffset.Text = Program.Settings.DefaultLimitOffset.ToString("#.##");
            }
        }




        #region UI Event Handlers

        private async void txtSymbol_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSymbol.Text != String.Empty && !txtSymbol.Text.Equals(curSymbol, StringComparison.OrdinalIgnoreCase))
                {
                    curSymbol = txtSymbol.Text;
                    _streamer.SubscribeQuote(txtSymbol.Text.ToUpper());
                    txtStop.Text = String.Empty;
                    txtLimit.Text = String.Empty;
                    txtStopToClose.Text = String.Empty;
                    txtOneToOne.Text = String.Empty;
                    txtRValue.Text = String.Empty;
                    this.Text = txtSymbol.Text;
                    await SetPosition();
                }
            }
            catch (Exception) { }
        }

        private void txtWithValidation_Leave(object sender, EventArgs e)
        {
            Decimal d;
            TextBox txtBox = (TextBox)sender;

            d = ValidateOcoStopAndLimit(txtBox);
        }

        private void chkTradeShares_CheckedChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }
        
        private void SetButtonsState()
        {
            bool isLimitValid = validateDecimalTextBox(txtLimit) || validateDecimalTextBox(txtLimitOffset);
            btnBuyLmtTriggerOco.Enabled = isLimitValid;
            btnSellLmtTriggerOco.Enabled = isLimitValid;

            bool isStopValid = validateDecimalTextBox(txtStop);
            btnBuyMrkTriggerOco.Enabled = isStopValid;
            btnSellMrkTriggerOco.Enabled = isStopValid;
            btnBreakEven.Enabled = isStopValid || validateDecimalTextBox(txtStopToClose);
        }

        private void txtLastError_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(txtLastError.Text, "Last Message");
        }

        private void txtSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
                txtStop.Focus();
            }
        }

        private void txtSymbol_Enter(object sender, EventArgs e)
        {
            txtSymbol.SelectAll();
        }
        private void txtRValue_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRValue.Text))
            {
                float rValue = (float)Convert.ToDouble(txtRValue.Text);
                if (rValue < 0)
                {
                    txtRValue.ForeColor = Color.FromArgb(255, 82, 109);
                }
                else
                {
                    txtRValue.ForeColor = Color.FromArgb(0, 194, 136);
                }

                // workaround UI framework bug to force readonly text box colors to update.
                txtRValue.BackColor = txtRValue.BackColor;
            }
        }

        private void txtShares_TextChanged(object sender, EventArgs e)
        {
            // don't want to change anything with quantiy as it is used in other calculations....
            if (_activePosition != null && _activePosition.DisplayQuantity > 0)
            {
                txtShares.ForeColor = Color.FromArgb(0, 194, 136);
            }
            else
            {
                txtShares.ForeColor = Color.FromArgb(255, 82, 109);
            }
            txtShares.BackColor = txtShares.BackColor;

            bool hasPosition = _activePosition != null && _activePosition.DisplayQuantity != 0;
            // No Active Position, so we should disable exit buttons
            btnExit10.Enabled = hasPosition;
            btnExit25.Enabled = hasPosition;
            btnExit33.Enabled = hasPosition;
            btnExit50.Enabled = hasPosition;
            btnExit100.Enabled = hasPosition;
            btnBreakEven.Enabled = hasPosition;
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            string startingTicker = this.Tag != null ? this.Tag.ToString() : String.Empty;

            if (!string.IsNullOrEmpty(startingTicker))
            {
                txtSymbol.Text = startingTicker;
                txtStop.Focus();
            }
        }
        #endregion

        #region Validations

        private decimal ValidateOcoStopAndLimit(TextBox txtBox)
        {
            decimal d = decimal.MinValue;
            if (string.IsNullOrEmpty(txtBox.Text.Trim()))
            {

            }
            else
            {
                var canParse = Decimal.TryParse(txtBox.Text, out d);
                if (!canParse)
                {
                    txtBox.SelectAll();
                    txtBox.Focus();
                    txtLastError.Text = $"Can't Parse {txtBox.Name}";
                }
                else
                {
                    txtBox.Text = d.ToString("0.00");
                }
            }
            SetButtonsState();
            return d;
        }

        private bool validateDecimalTextBox(TextBox txtBox)
        {
            return (!string.IsNullOrEmpty(txtBox.Text.Trim()) && decimal.TryParse(txtBox.Text.Trim(), out decimal d));
        }
        #endregion

        #region Timers
        private async void timerGetSecuritiesAccount_Tick(object sender, EventArgs e)
        {
            _securitiesaccount = await GetSecuritiesaccountAsync();

            try
            {
                if (_broker.GetType() == typeof(TdHelper) && _securitiesaccount != null)
                {
                    SafeUpdateTextBox(txtPnL, _securitiesaccount.DailyPnL.ToString("#.##"));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Can't Update PnL");
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }


        }

        #endregion

        private void btnScreenshot_Click(object sender, EventArgs e)
        {
            Utility.CaptureScreen(txtSymbol.Text);
        }
    }
}
