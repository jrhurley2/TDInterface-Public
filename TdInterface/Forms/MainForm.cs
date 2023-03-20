using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using TdInterface.Forms;
using TdInterface.Interfaces;
using TdInterface.Tda;
using TdInterface.Tda.Model;
using TdInterface.TradeStation;
using Websocket.Client;
using Websocket.Client.Models;

namespace TdInterface
{
    public partial class MainForm : EZTMBaseForm
    {
        private IStreamer _streamer;
        private string _accountId;

        private IHelper _tradeHelper;
      
        private string curSymbol = String.Empty;

        private TdInterface.Model.StockQuote _stockQuote = null;

      
        // Made Public for testing.
        public bool isTda = false;
        public bool isTradeStation = true;

        public Securitiesaccount _securitiesaccount;
        private Position _activePosition;
        private bool _tradeShares = false;
        private Settings _settings = new Settings() { TradeShares = false, MaxRisk = 5M, MaxShares = 4, OneRProfitPercenatage = 25 };

        public string MainFormName{ get; private set; }

        public MainForm(IStreamer streamer, Settings settings, string name, string accountId, IHelper helper)
        {
            InitializeComponent();

            _tradeHelper = helper;

            MainFormName = name;
            this.Text = name;

            _settings = settings;
            _accountId = accountId;

            txtPnL.Visible = _settings.ShowPnL;
            lblPnL.Visible = _settings.ShowPnL;

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

            var securitiesaccount = _tradeHelper.GetAccount(Utility.AccessTokenContainer, _accountId).Result;

            // Handle always on top setting
            this.TopMost = settings.AlwaysOnTop;

            lblVersion.Text = $"v {Program.AppVersion}";

            _stockQuote = new StockQuote();

            lblLastPrice.DataBindings.Add("Text", _stockQuote, "LastPrice", true, DataSourceUpdateMode.OnPropertyChanged, "NaN", "0.00");
        }


        public static Order CreateGenericTriggerOcoOrder(TdInterface.Model.StockQuote stockQuote, string orderType, string symbol, string instruction, double triggerLimit, double stopPrice, bool tradeShares, double maxRisk, double dailyPnl, bool disableFirstTarget, Settings settings)
        {
            maxRisk = CheckMaxRisk(maxRisk, dailyPnl, settings);

            var isShort = instruction.Equals(TDAOrderHelper.SELL_SHORT);

            var bidAskPrice = isShort ? stockQuote.bidPrice : stockQuote.askPrice;
            var ocoCalcPrice = orderType == "MARKET" ? settings.UseBidAskOcoCalc ? bidAskPrice : stockQuote.LastPrice : triggerLimit;
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

        public static double CheckMaxRisk(double maxRisk, double dailyPnl, Settings settings)
        {
            if (!settings.TradeShares && settings.EnableMaxLossLimit)
            {
                var maxLoss = Convert.ToDouble(settings.MaxLossLimitInR * settings.MaxRisk) * -1;

                if (dailyPnl < maxLoss)
                {
                    throw new DailyLossExceededException("You have exceeded your daily loss limit");
                }

                if (settings.PreventRiskExceedMaxLoss)
                {
                    if ((Convert.ToDouble(dailyPnl) - maxRisk) < maxLoss)
                    {
                        if (settings.AdjustRiskNotExceedMaxLoss)
                        {
                            maxRisk = Math.Abs(maxLoss - dailyPnl);
                        }
                        else
                        {
                            throw new DailyLossExceededException("This trade will put you over your daily loss limit");
                        }
                    }
                }
            }

            return maxRisk;
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
                    triggerOrder = CreateGenericTriggerOcoOrder(stockQuote, orderType, symbol, instruction, triggerLimit, stopPrice, tradeShares, maxRisk, _securitiesaccount.DailyPnL, chkDisableFirstTarget.Checked,  _settings);
                    orderKey = await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, triggerOrder);
                }
                else if (isTradeStation)
                {
                    triggerOrder = CreateGenericTriggerOcoOrder(stockQuote, orderType, symbol, instruction, triggerLimit, stopPrice, tradeShares, maxRisk, 0.0, chkDisableFirstTarget.Checked, _settings);
                    orderKey = await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, triggerOrder);
                }

                ResetInitialOrder();
                txtLastError.Text = JsonConvert.SerializeObject(triggerOrder);
                AddInitialOrder(symbol, orderKey);

                // Capture Screenshots if requested
                if (_settings.SendAltPrtScrOnOpen) { InputSender.PrintScreen(); }
                if (_settings.CaptureScreenshotOnOpen) { _ = Task.Run(() => Utility.CaptureScreen(txtSymbol.Text)); }
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
                var stockQuote = _tradeHelper.GetStockQuote(txtSymbol.Text);

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
                var stockQuote = _tradeHelper.GetStockQuote(txtSymbol.Text);
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
                var stockQuote = _tradeHelper.GetStockQuote(txtSymbol.Text);
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
                var stockQuote = _tradeHelper.GetStockQuote(txtSymbol.Text);
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
            var stockQuote = _tradeHelper.GetStockQuote(txtSymbol.Text);
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

            var stopOrder = _securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "STOP").FirstOrDefault();

            if (stopOrder != null  && _settings.ReduceStopOnClose)
            {
                //Change the stop order to a Limit order to take profit and repladce
                var newOrder = TDAOrderHelper.CreateLimitOrder(exitInstruction, _activePosition.instrument.symbol, quantity, limitPrice);
                await _tradeHelper.ReplaceOrder(Utility.AccessTokenContainer, _accountId, stopOrder.orderId, newOrder);
                var newStopOrder = TDAOrderHelper.CreateStopOrder(exitInstruction, _activePosition.instrument.symbol, _activePosition.Quantity - quantity, Double.Parse(stopOrder.stopPrice));
                await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, newStopOrder);
            }
            else
            {
                await PlaceLimitOrder(_activePosition.instrument.symbol, quantity, exitInstruction, limitPrice);
            }
        }

        private async Task ExitMarket(int quantity)
        {
            string exitInstruction = GetExitInstruction(_activePosition);
            var stopOrder = _securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol.Equals(txtSymbol.Text, StringComparison.InvariantCultureIgnoreCase)  && o.orderType == "STOP").FirstOrDefault();

            //TODO:  THIS WILL NOT WORK FOR TRADESTATION AS THE ORDERS ARE FLAT.
            var parent = TDAOrderHelper.GetParentOrder(_securitiesaccount.orderStrategies, stopOrder);

            if (stopOrder != null && _settings.ReduceStopOnClose)
            {
                if (parent != null && parent.orderStrategyType.Equals("OCO"))
                {
                    await CancelAll();
                    await PlaceMarketOrder(_activePosition.instrument.symbol, quantity, exitInstruction);
                }
                else
                {
                    //Change the stop order to a Limit order to take profit and repladce
                    var newOrder = TDAOrderHelper.CreateMarketOrder(exitInstruction, _activePosition.instrument.symbol, quantity);
                    await _tradeHelper.ReplaceOrder(Utility.AccessTokenContainer, _accountId, stopOrder.orderId, newOrder);
                    var newStopOrder = TDAOrderHelper.CreateStopOrder(exitInstruction, _activePosition.instrument.symbol, _activePosition.Quantity - quantity, Double.Parse(stopOrder.stopPrice));
                    await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, newStopOrder);
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
            var orderKey = await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, stopOrder);
        }

        private async Task PlaceLimitOrder(string symbol, int quantity, string instruction, double limitPrice)
        {
            var stopOrder = TDAOrderHelper.CreateLimitOrder(instruction, symbol, quantity, limitPrice);
            var orderKey = await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, stopOrder);
        }


        private async Task PlaceStopOrder(string symbol, int quantity, string instruction, double stopPrice)
        {
            var stopOrder = TDAOrderHelper.CreateStopOrder(instruction, symbol, quantity, stopPrice);
            var orderKey = await _tradeHelper.PlaceOrder(Utility.AccessTokenContainer, _accountId, stopOrder);
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
            await _tradeHelper.CancelAll(Utility.AccessTokenContainer, _accountId, txtSymbol.Text);
        }
        #endregion

        #region Handle Streamer Events
        private void HandleStockQuote(TdInterface.Model.StockQuote stockQuote)
        {
            if (!stockQuote.symbol.Equals(txtSymbol.Text, StringComparison.InvariantCultureIgnoreCase)) return;
            stockQuote = _tradeHelper.SetStockQuote(stockQuote);
            SafeUpdateControl(txtBid, stockQuote.bidPrice.ToString("0.00"));
            SafeUpdateControl(txtAsk, stockQuote.askPrice.ToString("0.00"));
            SafeUpdateControl(lblSymbol, stockQuote.symbol);
            SafeUpdateControl(lblDescription, stockQuote.description);
            //SafeUpdateControl(lblLastPrice, stockQuote.LastPrice.ToString("0.00"));

            this.Invoke(new Action(() => _stockQuote.Update(stockQuote)));

            rpbTickerLogo.LoadAsync(Utility.GetTickerImageURL(stockQuote.symbol));

            try
            {
                if (_activePosition != null && txtStop.Text != String.Empty)
                {
                    var avgPrice = _activePosition.averagePrice;
                    var initialStop = float.Parse(txtStop.Text);

                    float risk = Math.Abs(avgPrice - initialStop);
                    float reward = (float)stockQuote.LastPrice - avgPrice;
                    reward = reward * (_activePosition.shortQuantity > 0 ? -1 : 1);

                    var rValue = reward / risk;
                    SafeUpdateControl(txtRValue, rValue.ToString("0.00"));

                    double oneToOne;
                    if (_activePosition.longQuantity > 0)
                        oneToOne = avgPrice + risk;
                    else
                    {
                        oneToOne = avgPrice - risk;
                    }

                    SafeUpdateControl(txtOneToOne, oneToOne.ToString("0.00"));
                }
                else
                {
                    SafeUpdateControl(txtRValue, "0");
                    double stop;

                    if (double.TryParse(txtStop.Text, out stop))
                    {
                        double oneToOne;
                        if (stop < stockQuote.LastPrice)
                        {
                            oneToOne = (stockQuote.LastPrice - stop) + stockQuote.LastPrice;
                        }
                        else
                        {
                            oneToOne = stockQuote.LastPrice - (stop - stockQuote.LastPrice);
                        }
                        SafeUpdateControl(txtOneToOne, oneToOne.ToString("0.00"));
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
                _securitiesaccount = _tradeHelper.Securitiesaccount;
                await SetPosition();
                _securitiesaccount = await GetSecuritiesaccountAsync();

                if (typeof(TdHelper) == _tradeHelper.GetType() && _securitiesaccount != null)
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
            if (typeof(TdHelper) == _tradeHelper.GetType())
            {
                securitiesaccount = await _tradeHelper.GetAccount(Utility.AccessTokenContainer, _accountId);
            }
            else
            {
                securitiesaccount = _tradeHelper.Securitiesaccount;
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

                    if (_settings.MoveLimitPriceOnFill)
                    {

                        Debug.WriteLine($"_settings.MoveLimitPriceOnFill: {_settings.MoveLimitPriceOnFill}");
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
                                        await _tradeHelper.ReplaceOrder(Utility.AccessTokenContainer, _accountId, lmitOrder.orderId, newLimitOrder);
                                    }
                                }
                            }
                        }
                    }

                    //TODO:  IF THIS WORKS MOVE IT AND CONSOLIDATE IT WITH THE MOVE PRICE CODE
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
                SafeUpdateControl(txtLastError, ex.Message);
                Debug.WriteLine(ex.Message);
            }
        }

        private async void HandleHeartBeat(SocketNotify notify)
        {
            SafeUpdateControl(txtHeartBeat, DateTime.Now.ToString());
        }

        private async void HandleDisconnect(DisconnectionInfo disconnectionInfo)
        {
            try
            {
                SafeUpdateControl(txtConnectionStatus, "Disconnected - Attemptinng to Reconnect");
                await _streamer.WebsocketClient.ReconnectOrFail();
            }
            catch (Exception ex)
            {
                SafeUpdateControl(txtLastError, ex.Message);
                Debug.WriteLine(ex.Message);
                SafeUpdateControl(txtConnectionStatus, "Disconnected - COULD NOT RECONNECT-  RESTART APPLICATION");

            }
        }

        private async void HandleReconnection(ReconnectionInfo reconnectionInfo)
        {
            SafeUpdateControl(txtConnectionStatus, reconnectionInfo.Type.ToString());
        }
        #endregion

        #region Thread Safe UI Helpers
        private void SafeUpdateControl(Control sender, string text)
        {
            try
            {
                sender.InvokeIfRequired(() =>
                {
                    // Do anything you want with the control here
                    sender.Text = text;
                });
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
            Position position = await GetPosition(txtSymbol.Text.ToUpper(), Utility.AccessTokenContainer, _accountId);

            if (position != null)
            {
                _activePosition = position;
                SafeUpdateControl(txtAveragePrice, _activePosition.averagePrice.ToString("0.00"));
                SafeUpdateControl(txtShares, _activePosition.DisplayQuantity.ToString());
            }
            else
            {
                _activePosition = null;
                SafeUpdateControl(txtAveragePrice, string.Empty);
                SafeUpdateControl(txtShares, string.Empty);
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
                        SafeUpdateControl(txtPnL, _securitiesaccount.DailyPnL.ToString("#.##"));
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
            var settings = Utility.GetSettings();
            if (settings != null)
            {
                settings.OneRProfitPercenatage = settings.OneRProfitPercenatage == 0 ? _settings.OneRProfitPercenatage : settings.OneRProfitPercenatage;
                _settings = settings;
            }
            ApplySettings();
        }

        private void ApplySettings()
        {
            chkTradeShares.Checked = _settings.TradeShares;
            chkDisableFirstTarget.Checked = _settings.DisableFirstTargetProfitDefault;

            if (_settings.TradeShares)
            {
                txtRisk.Text = _settings.MaxShares.ToString("#");
            }
            else
            {
                txtRisk.Text = _settings.MaxRisk.ToString("#.##");
            }
            if (_settings.DefaultLimitOffset != 0)
            {
                txtLimitOffset.Text = _settings.DefaultLimitOffset.ToString("#.##");
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
                    //_streamer.SubscribeChartData(Utility.UserPrincipal, txtSymbol.Text.ToUpper());
                    //await UpdatePriceHistory();
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
            _tradeShares = chkTradeShares.Checked;
            _settings.TradeShares = _tradeShares;
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

        private bool validateDecimalTextBox(Control txtBox)
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
                if (_tradeHelper.GetType() == typeof(TdHelper) && _securitiesaccount != null)
                {
                    SafeUpdateControl(txtPnL, _securitiesaccount.DailyPnL.ToString("#.##"));
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

        private void rpbTickerLogo_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                rpbTickerLogo.Image = Properties.Resources.abc_24;
            }
        }
    }
}
