using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDAmeritradeAPI.Client;
using TdInterface.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace TdInterface
{
    public partial class MainForm : Form
    {
        private TDStreamer _streamer;
        private StockQuote _stockQuote = new StockQuote();
        private Securitiesaccount _securitiesaccount;
        private Position _activePosition;
        private Position _initialPosition;
        private CandleList _candleList;
        private bool _trainingWheels = false;
        private Settings _settings = new Settings() { TradeShares = false, MaxRisk = 5M, MaxShares = 4, OneRProfitPercenatage = 25 };
        private Dictionary<ulong, Order> _placedOrders = new Dictionary<ulong, Order>();
        private TextWriterTraceListener _textWriterTraceListener = null;

        public MainForm(TDStreamer tdStreamer, Settings settings, string name)
        {
            InitializeComponent();

            this.Text = name;

            _settings = settings;

            _streamer = tdStreamer;
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

        }
        public MainForm()
        {
            try
            {
                _textWriterTraceListener = new TextWriterTraceListener($"{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log");
                Trace.Listeners.Add(_textWriterTraceListener);

                Debug.WriteLine("Start Main Form");
                InitializeComponent();

                var accessTokenContainer = Utility.GetAccessTokenContainer();

                if (accessTokenContainer == null || accessTokenContainer.IsRefreshTokenExpired || accessTokenContainer.RefreshTokenExpiresInDays < 5)
                {
                    var consumerKey = Utility.GetConsumerKey();
                    if (consumerKey == null)
                    {
                        var frm = new frmConsmerKey();
                        frm.ShowDialog();
                        consumerKey = frm.ConsumerKey;
                        Utility.SaveConsumerKey(consumerKey);
                    }
                    var oAuthLoginForm = new OAuthLoginForm($"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri=http%3A%2F%2Flocalhost&client_id={consumerKey}%40AMER.OAUTHAP");
                    int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                    Utility.AuthToken = oAuthLoginForm.Code;
                    accessTokenContainer = TdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken)).Result;
                    Utility.SaveAccessTokenContainer(accessTokenContainer);
                }

                Utility.AccessTokenContainer = accessTokenContainer;

                Utility.AccessTokenContainer = TdHelper.RefreshAccessToken(Utility.AccessTokenContainer).Result;
                Utility.UserPrincipal = TdHelper.GetUserPrincipals(Utility.AccessTokenContainer).Result;

                CreateStreamer();

                timer1.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

        }

        private void CreateStreamer()
        {
            _streamer = new TDStreamer(Utility.UserPrincipal);
            _streamer.StockQuoteReceived.Subscribe(x => HandleStockQuote(x));
            _streamer.AcctActivity.Subscribe(a => HandleAcctActivity(a));
            _streamer.OrderRecieved.Subscribe(o => HandleOrderRecieved(o));
            _streamer.OrderFilled.Subscribe(o => HandleOrderFilled(o));
            _streamer.HeartBeat.Subscribe(s => HandleHeartBeat(s));
            _streamer.Reconnection.Subscribe(r => HandleReconnection(r));
            _streamer.Disconnection.Subscribe(d => HandleDisconnect(d));
        }


        #region Order Open 
        private async void btnSellMrkTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                var stockQuote = _stockQuote;

                var orderType = "MARKET";
                var symbol = txtSymbol.Text;
                var instruction = OrderHelper.SELL_SHORT;
                var triggerLimit = double.Parse("0.0");

                await GenericTriggerOco(stockQuote, orderType, symbol, instruction, triggerLimit);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
            }
        }

        private async Task GenericTriggerOco(StockQuote stockQuote, string orderType, string symbol, string instruction, double triggerLimit)
        {
            if (_streamer.WebsocketClient.NativeClient.State != System.Net.WebSockets.WebSocketState.Open) throw new Exception($"Socket not open, restart application {_streamer.WebsocketClient.NativeClient.State.ToString()}");
            var stopPrice = double.Parse(txtStop.Text);
            var trainingWheels = checkBox1.Checked;
            var maxRisk = txtRisk.Text;

            var isShort = instruction.Equals(OrderHelper.SELL_SHORT);

            var bidAskPrice = isShort ? stockQuote.bidPrice : stockQuote.askPrice;
            var ocoCalcPrice = orderType == "MARKET" ? _settings.UseBidAskOcoCalc ? bidAskPrice : stockQuote.lastPrice : triggerLimit;
            var riskPerShare = isShort ? stopPrice - ocoCalcPrice : ocoCalcPrice - stopPrice;
            var firstTargetlimtPrice = isShort ? ocoCalcPrice - riskPerShare : ocoCalcPrice + riskPerShare;

            int quantity = CalcShares(riskPerShare, maxRisk, trainingWheels);

            var firstTargetLimitShares = Convert.ToInt32(Math.Ceiling(quantity * decimal.Divide(_settings.OneRProfitPercenatage, 100)));

            ResetInitialOrder();
            var triggerOrder = OrderHelper.CreateTriggerOcoOrder(orderType, symbol, instruction, quantity, triggerLimit, firstTargetLimitShares, firstTargetlimtPrice, stopPrice);
            var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, triggerOrder);
            txtLastError.Text = JsonConvert.SerializeObject(triggerOrder);
            AddInitialOrder(symbol, orderKey, triggerOrder);

        }
        private Dictionary<string, Dictionary<ulong, Order>> _initialOrders = new Dictionary<string, Dictionary<ulong, Order>>();

        private void AddInitialOrder(string symbol, ulong orderKey, Order order)
        {
            if (!_initialOrders.ContainsKey(symbol.ToUpper()))
            {
                _initialOrders.Add(symbol.ToUpper(), new Dictionary<ulong, Order>());
            }

            _initialOrders[symbol.ToUpper()].Add(orderKey, order);
        }

        private static int CalcShares(double riskPerShare, string maxRisk, bool trainingWheels = false)
        {
            double calcShares;

            if (trainingWheels)
            {
                calcShares = double.Parse(maxRisk);
            }
            else
            {
                calcShares = double.Parse(maxRisk) / riskPerShare;
            }

            var quantity = Convert.ToInt32(calcShares);

            return quantity;
        }

        private async void btnSellLmtTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                var stockQuote = _stockQuote;
                var orderType = "LIMIT";
                var symbol = txtSymbol.Text;
                var instruction = OrderHelper.SELL_SHORT;

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
                var stockQuote = _stockQuote;
                var orderType = "MARKET";
                var symbol = txtSymbol.Text;
                var instruction = OrderHelper.BUY;
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
                var stockQuote = _stockQuote;
                var orderType = "LIMIT";
                var symbol = txtSymbol.Text;
                var instruction = OrderHelper.BUY;
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
            _initialPosition = null;
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

                var stopInstruction = "";
                int quantity = 0;
                if (_activePosition.longQuantity > 0)
                {
                    stopInstruction = OrderHelper.SELL;
                    quantity = (int)_activePosition.longQuantity;
                }
                else if (_activePosition.shortQuantity > 0)
                {
                    stopInstruction = OrderHelper.BUY_TO_COVER;
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
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async void btnExitMark10_Click(object sender, EventArgs e)
        {
            double percentage = .10D;
            await ExitMarketPercentage(percentage);
        }

        private async void btnExitMark25_Click(object sender, EventArgs e)
        {
            double percentage = .25D;
            await ExitMarketPercentage(percentage);
        }

        private async void btnExitMark33_Click(object sender, EventArgs e)
        {
            double percentage = .33D;
            await ExitMarketPercentage(percentage);
        }

        private async void btnExitMark50_Click(object sender, EventArgs e)
        {
            double percentage = .50D;
            await ExitMarketPercentage(percentage);
        }
        private async void btnExitMark100_Click(object sender, EventArgs e)
        {
            double percentage = 1.0D;
            await ExitMarketPercentage(percentage);

        }



        private async Task ExitMarketPercentage(double percenntage)
        {
            try
            {
                var quantity = (int)Math.Ceiling(_activePosition.Quantity * percenntage);
                await ExitMarket(quantity);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private async Task ExitLimitPercentage(double percenntage)
        {
            try
            {
                var quantity = (int)Math.Ceiling(_activePosition.Quantity * percenntage);
                await ExitBidOrAsk(quantity);
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
            string exitInstruction = GetExitInstruction(_activePosition);
            var limitPrice = 0.0;
            if (exitInstruction == OrderHelper.SELL)
            {
                limitPrice = _stockQuote.askPrice;
            }
            else
            {
                limitPrice = _stockQuote.bidPrice;
            }

            var stopOrder = _securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "STOP").FirstOrDefault();

            if (stopOrder != null  && _settings.ReduceStopOnClose)
            {
                //Change the stop order to a Limit order to take profit and repladce
                var newOrder = OrderHelper.CreateLimitOrder(exitInstruction, _activePosition.instrument.symbol, quantity, limitPrice);
                await TdHelper.ReplaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder.orderId, newOrder);
                var newStopOrder = OrderHelper.CreateStopOrder(exitInstruction, _activePosition.instrument.symbol, _activePosition.Quantity - quantity, Double.Parse(stopOrder.stopPrice));
                await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, newStopOrder);
            }
            else
            {
                await PlaceLimitOrder(_activePosition.instrument.symbol, quantity, exitInstruction, limitPrice);
            }
        }

        private async Task ExitMarket(int quantity)
        {
            string exitInstruction = GetExitInstruction(_activePosition);
            var stopOrder = _securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "STOP").FirstOrDefault();

            if (stopOrder != null && _settings.ReduceStopOnClose)
            {
                //Change the stop order to a Limit order to take profit and repladce
                var newOrder = OrderHelper.CreateMarketOrder(exitInstruction, _activePosition.instrument.symbol, quantity);
                await TdHelper.ReplaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder.orderId, newOrder);
                var newStopOrder = OrderHelper.CreateStopOrder(exitInstruction, _activePosition.instrument.symbol, _activePosition.Quantity - quantity, Double.Parse(stopOrder.stopPrice));
                await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, newStopOrder);
            }
            else
            {
                await PlaceMarketOrder(_activePosition.instrument.symbol, quantity, exitInstruction);
            }
        }

        private static string GetExitInstruction(Position position)
        {
            var exitInstruction = "";
            if (position.longQuantity > 0)
            {
                exitInstruction = OrderHelper.SELL;
            }
            else if (position.shortQuantity > 0)
            {
                exitInstruction = OrderHelper.BUY_TO_COVER;
            }
            else
            {
                throw new Exception("Sell Market Button Cant' Deterimine position");
            }

            return exitInstruction;
        }

        private async Task PlaceMarketOrder(string symbol, int quantity, string instruction)
        {
            var stopOrder = OrderHelper.CreateMarketOrder(instruction, symbol, quantity);
            var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder);
        }

        private async Task PlaceLimitOrder(string symbol, int quantity, string instruction, double limitPrice)
        {
            var stopOrder = OrderHelper.CreateLimitOrder(instruction, symbol, quantity, limitPrice);
            var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder);
        }


        private async Task PlaceStopOrder(string symbol, int quantity, string instruction, double stopPrice)
        {
            var stopOrder = OrderHelper.CreateStopOrder(instruction, symbol, quantity, stopPrice);
            var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder);
        }
        #endregion

        private async void txtSymbol_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSymbol.Text != String.Empty)
                {
                    _streamer.SubscribeQuote(Utility.UserPrincipal, txtSymbol.Text.ToUpper());
                    //_streamer.SubscribeChartData(Utility.UserPrincipal, txtSymbol.Text.ToUpper());
                    //await UpdatePriceHistory();
                    this.Text = txtSymbol.Text.ToUpper();
                    txtStop.Text = String.Empty;
                    txtLimit.Text = String.Empty;
                    txtStopToClose.Text = String.Empty;
                    await SetPosition();
                }
            }
            catch (Exception) { }
        }


        private async Task UpdatePriceHistory()
        {
            _candleList = await TdHelper.GetPriceHistoryAsync(Utility.AccessTokenContainer, txtSymbol.Text.ToUpper());
            //var fMin = _candleList.candles.GroupBy(c => c.datetime / TimeSpan.TicksPerMinute / 5).ToList<>;
            var currentDate = _candleList.candles.Max(c => c.DateTime).ToString("MM/dd/yyyy");
            var swings = CalculateSwingHighs(_candleList.candles.Where(c => c.DateTime >= DateTimeOffset.Parse($"{currentDate} 09:30") &&
                                                                       c.DateTime <= DateTimeOffset.Parse($"{currentDate} 16:00")).ToArray());
            var pmStats = CalculatePMHighsAndLows(_candleList.candles.Where(c => c.DateTime >= DateTimeOffset.Parse($"{currentDate} 04:00") &&
                                                                       c.DateTime < DateTimeOffset.Parse($"{currentDate} 09:30")).ToArray());

            //SafeUpdateButton(btnLastSwingLow, swings.Item1[swings.Item1.Count - 1].ToString("#.##"));
            //SafeUpdateButton(btnLastSwingHigh, swings.Item2[swings.Item2.Count - 1].ToString("#.##"));
        }

        private Tuple<List<double>, List<double>> CalculateSwingHighs(Candle[] candles)
        {
            var swingHighs = new List<double>();
            var swingLows = new List<double>();
            double tempHigh = 0;


            for (int i = 0; i < candles.Length - 1; i++)
            {
                if (i == 0) continue;
                if (candles[i - 1].high < candles[i].high &&
                    candles[i + 1].high < candles[i].high)
                {
                    swingHighs.Add(candles[i].high);
                }

                if (candles[i - 1].low > candles[i].low &&
                    candles[i + 1].low > candles[i].low)
                {
                    swingLows.Add(candles[i].low);
                }

            }

            return new Tuple<List<double>, List<double>>(swingLows, swingHighs);
        }

        private Tuple<double, double> CalculatePMHighsAndLows(Candle[] candles)
        {
            var swingHighs = new List<double>();
            var swingLows = new List<double>();
            double high = 0;
            double low = double.MaxValue;

            for (int i = 0; i < candles.Length; i++)
            {
                if (candles[i].DateTime.LocalDateTime.TimeOfDay.Hours == 8 &&
                    candles[i].DateTime.LocalDateTime.TimeOfDay.Minutes == 0) continue;
                if (candles[i].high > high) high = candles[i].high;
                if (candles[i].low < low) low = candles[i].low;
            }

            return new Tuple<double, double>(low, high);
        }

        private delegate void SafeCallDelegate(TextBox textBox, string text);

        private void SafeUpdateTextBox(TextBox textBox, string text)
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
        private void SafeUpdateButton(Button button, string text)
        {
            if (button.InvokeRequired)
            {
                var d = new SafeCallDelegate(SafeUpdateTextBox);
                button.Invoke(d, new object[] { button, text });
            }
            else
            {
                button.Text = text;
            }

        }

        private void HandleStockQuote(StockQuote stockQuote)
        {
            if (!stockQuote.symbol.Equals(txtSymbol.Text, StringComparison.InvariantCultureIgnoreCase)) return;
            _stockQuote = _stockQuote.Update(stockQuote);
            SafeUpdateTextBox(txtLastPrice, _stockQuote.lastPrice.ToString("0.00"));
            SafeUpdateTextBox(txtBid, _stockQuote.bidPrice.ToString("0.00"));
            SafeUpdateTextBox(txtAsk, _stockQuote.askPrice.ToString("0.00"));

            try
            {
                if (_activePosition != null)
                {
                    var avgPrice = _activePosition.averagePrice;
                    var initialStop = float.Parse(txtStop.Text);

                    float risk = Math.Abs(avgPrice - initialStop);
                    float reward = Math.Abs((float)_stockQuote.lastPrice - avgPrice);

                    var rValue = reward / risk;
                    SafeUpdateTextBox(txtRValue, rValue.ToString("0.00"));
                }
                else
                {
                    SafeUpdateTextBox(txtRValue, "0");
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
            _securitiesaccount = await TdHelper.GetAccount(Utility.AccessTokenContainer, Utility.UserPrincipal);
        }

        private async void HandleOrderRecieved(OrderEntryRequestMessage orderEntryRequestMessage)
        {
            _securitiesaccount = await TdHelper.GetAccount(Utility.AccessTokenContainer, Utility.UserPrincipal);
        }

        private async void HandleOrderFilled(OrderFillMessage orderFillMessage)
        {
            try
            {
                await SetPosition();

                Debug.Write($"HandleOrderFill {JsonConvert.SerializeObject(orderFillMessage)}");
                if (_settings.MoveLimitPriceOnFill)
                {

                    Debug.WriteLine($"_settings.MoveLimitPriceOnFill: {_settings.MoveLimitPriceOnFill}");
                    var symbol = orderFillMessage.Order.Security.Symbol;
                    if (_initialOrders.ContainsKey(symbol.ToUpper()))
                    {
                        Debug.WriteLine("_initialOrders.ContainsKey(symbol)");
                        //Initial Trigger Order filled, adjust limit
                        if (_initialOrders[symbol].ContainsKey(orderFillMessage.Order.OrderKey))
                        {
                            Debug.WriteLine("Found OrderKey");
                            _securitiesaccount = await TdHelper.GetAccount(Utility.AccessTokenContainer, Utility.UserPrincipal);
                            var triggerOrder = _securitiesaccount.orderStrategies.Where(o => ulong.Parse(o.orderId) == orderFillMessage.Order.OrderKey).FirstOrDefault();
                            //Get Trigger order by key and from there look at child strats to find the limit,  orders are not flat like I thought.
                            //So the Trigger has an OCO that has the limit and stop.  
                            var lmitOrder = triggerOrder.childOrderStrategies[0].childOrderStrategies.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION" || o.status == "AWAITING_PARENT_ORDER") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderType == "LIMIT").FirstOrDefault();

                            if (lmitOrder != null)
                            {
                                Debug.WriteLine($"Found Limit Order {JsonConvert.SerializeObject(lmitOrder)} ");
                                var stop = float.Parse(txtStop.Text);
                                var avgPrice = _activePosition.averagePrice;
                                var risk = Math.Abs(avgPrice - stop);


                                string exitInstruction = GetExitInstruction(_activePosition);

                                var firstTargetlimtPrice = exitInstruction == "SELL" ? avgPrice + risk : avgPrice - risk;

                                Debug.WriteLine($"stop: {stop} ; avgPrice: {avgPrice} ; risk: {risk} ; exitInsturction: {exitInstruction} ; firstTargetLimitPrice: {firstTargetlimtPrice}");

                                var newLimitOrder = OrderHelper.CreateLimitOrder(exitInstruction, symbol, Convert.ToInt32(Math.Round(lmitOrder.orderLegCollection[0].quantity)), firstTargetlimtPrice);
                                await TdHelper.ReplaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, lmitOrder.orderId, newLimitOrder);
                            }
                        }
                    }
                }

                Debug.WriteLine(orderFillMessage.Order.OrderKey);
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


        private async Task SetPosition()
        {
            Position position = await GetPosition(txtSymbol.Text.ToUpper(), Utility.AccessTokenContainer, Utility.UserPrincipal);

            if (position != null)
            {
                if (_initialPosition == null)
                {
                    _initialPosition = position;
                }

                _activePosition = position;
                SafeUpdateTextBox(txtAveragePrice, _activePosition.averagePrice.ToString("0.00"));
                SafeUpdateTextBox(txtShares, _activePosition.Quantity.ToString());
            }
            else
            {
                _activePosition = null;
                SafeUpdateTextBox(txtAveragePrice, string.Empty);
                SafeUpdateTextBox(txtShares, string.Empty);
                Debug.WriteLine($"Error getting postion for {txtSymbol.Text.ToUpper()}");
            }
        }

        private async Task<Position> GetPosition(string symbol, AccessTokenContainer accessTokenContainer, UserPrincipal userPrincipal)
        {
            Position position = null;

            try
            {
                _securitiesaccount = await TdHelper.GetAccount(accessTokenContainer, userPrincipal);
                if (_securitiesaccount.positions != null)
                {
                    position = _securitiesaccount.positions.Where(p => p != null && p.instrument.symbol == symbol).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
            return position;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (Utility.AccessTokenContainer.ExpiresIn < 100)
            {
                Utility.AccessTokenContainer = await TdHelper.RefreshAccessToken(Utility.AccessTokenContainer);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
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
            else if (e.KeyCode == Keys.F1)
            {
                btnExitMark10.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnExitMark25.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnExitMark33.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnExitMark50.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnExitMark100.PerformClick();
                e.SuppressKeyPress = true;
            }

        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //_textWriterTraceListener.Flush();
                //_textWriterTraceListener.Close();
                ////_streamer.Dispose();
                //_textWriterTraceListener.Dispose();
            }
            catch (Exception ex)
            {

            }

        }

        private void clearCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.ClearAccessTokenContainerFile();
        }

        private async void saveCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accessTokenContainer = await TdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken));
            Utility.SaveAccessTokenContainer(accessTokenContainer);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _trainingWheels = checkBox1.Checked;
            _settings.TradeShares = _trainingWheels;
            ApplySettings();
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
            checkBox1.Checked = _settings.TradeShares;
            if (_settings.TradeShares)
            {
                txtRisk.Text = _settings.MaxShares.ToString("#");
            }
            else
            {
                txtRisk.Text = _settings.MaxRisk.ToString("#.##");
            }
        }

        private void btnLastSwingLow_Click(object sender, EventArgs e)
        {
            txtStop.Text = (double.Parse(((Button)sender).Text) - .05).ToString("#.##");
        }

        private void btnLastSwingHigh_Click(object sender, EventArgs e)
        {
            txtStop.Text = (double.Parse(((Button)sender).Text) + .05).ToString("#.##");
        }

        private void txtStop_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //await UpdatePriceHistory();
        }

        private async void btnCancelAll_Click(object sender, EventArgs e)
        {
            try
            {

                _securitiesaccount = await TdHelper.GetAccount(Utility.AccessTokenContainer, Utility.UserPrincipal);
                Debug.WriteLine(JsonConvert.SerializeObject(_securitiesaccount.orderStrategies));
                var openOrders = _securitiesaccount.orderStrategies.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper());

                var tasks = new List<Task>();
                foreach (var order in openOrders)
                {
                    Debug.WriteLine(JsonConvert.SerializeObject(order));
                    var task = TdHelper.CancelOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, order);
                    tasks.Add(task);
                }

                await Task.WhenAll(tasks).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                txtLastError.Text = ex.Message;
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UserOptionsForm();
            frm.ShowDialog();
            _settings = Utility.GetSettings();
            ApplySettings();
        }

        private async void btnExitAsk10_Click(object sender, EventArgs e)
        {
            await ExitLimitPercentage(.10D);
        }

        private async void btnExitAsk25_Click(object sender, EventArgs e)
        {
            await ExitLimitPercentage(.25D);
        }

        private async void btnExitAsk33_Click(object sender, EventArgs e)
        {
            await ExitLimitPercentage(.33D);
        }

        private async void btnExitAsk50_Click(object sender, EventArgs e)
        {
            await ExitLimitPercentage(.50D);
        }

        private async void btnExitAsk100_Click(object sender, EventArgs e)
        {
            await ExitLimitPercentage(1.0D);
        }

        private void txtBid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStop_Leave(object sender, EventArgs e)
        {
            Decimal d;
            TextBox txtBox = (TextBox)sender;

            d = ValidateOcoStopAndLimit(txtBox);
        }

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
            SetToOpenButtons();
            return d;
        }

        private void SetToOpenButtons()
        {
            decimal d;
            if (!string.IsNullOrEmpty(txtStop.Text.Trim()) && decimal.TryParse(txtStop.Text.Trim(), out d))
            {
                btnBuyMrkTriggerOco.Enabled = true;
                btnSellMrkTriggerOco.Enabled = true;
            }
            else
            {
                btnBuyMrkTriggerOco.Enabled = false;
                btnSellMrkTriggerOco.Enabled = false;
                btnBuyLmtTriggerOco.Enabled = false;
                btnSellLmtTriggerOco.Enabled = false;
                return;
            }

            btnBuyLmtTriggerOco.Enabled = false;
            btnSellLmtTriggerOco.Enabled = false;

            if (!string.IsNullOrEmpty(txtLimit.Text.Trim()))
            {
                if (decimal.TryParse(txtLimit.Text.Trim(), out d))
                {
                    btnBuyLmtTriggerOco.Enabled = true;
                    btnSellLmtTriggerOco.Enabled = true;
                }
            }
            else if (!string.IsNullOrEmpty(txtLimitOffset.Text.Trim()))
            {
                if (decimal.TryParse(txtLimitOffset.Text.Trim(), out d))
                {
                    btnBuyLmtTriggerOco.Enabled = true;
                    btnSellLmtTriggerOco.Enabled = true;
                }
            }


        }

        private void txtLimit_Leave(object sender, EventArgs e)
        {
            Decimal d;
            TextBox txtBox = (TextBox)sender;

            d = ValidateOcoStopAndLimit(txtBox);

        }

        private void txtLimitOffset_Leave(object sender, EventArgs e)
        {
            Decimal d;
            TextBox txtBox = (TextBox)sender;

            d = ValidateOcoStopAndLimit(txtBox);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var trigger = _securitiesaccount.orderStrategies.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol == txtSymbol.Text.ToUpper() && o.orderStrategyType == "TRIGGER").FirstOrDefault();
            var orderFill = new OrderFillMessage()
            {
                Order = new OrderFillMessageOrder
                {
                    OrderKey = ulong.Parse(trigger.orderId),
                    Security = new OrderFillMessageOrderSecurity
                    {
                        Symbol = txtSymbol.Text.ToUpper()
                    }
                }
            };
            AddInitialOrder(trigger.orderLegCollection[0].instrument.symbol, ulong.Parse(trigger.orderId), trigger);
            HandleOrderFilled(orderFill);

        }

        private async void btnReconnect_Click(object sender, EventArgs e)
        {
            await _streamer.WebsocketClient.NativeClient.CloseAsync(System.Net.WebSockets.WebSocketCloseStatus.NormalClosure, "Create New Client", new System.Threading.CancellationToken());
            _streamer.Dispose();
            CreateStreamer();
            txtSymbol_Leave(sender, e);
        }
    }
}
