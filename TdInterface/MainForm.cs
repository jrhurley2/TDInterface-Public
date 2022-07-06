using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDAmeritradeAPI.Client;
using TdInterface.Model;

namespace TdInterface
{
    public partial class MainForm : Form
    {
        private ILogger<MainForm> _logger;
        private TDStreamer _streamer;
        private StockQuote _stockQuote = new StockQuote();
        private Securitiesaccount _securitiesaccount;
        private Position _activePosition;
        private Position _initialPosition;
        private bool _trainingWheels = false;
        private Settings settings = new Settings() { TrainingWheels = false, MaxRisk = "10", MaxShares = "4" };
        private Dictionary<ulong, Order> _placedOrders = new Dictionary<ulong, Order>();

        public MainForm(ILogger<MainForm> logger)
        {
            try
            {

                _logger = logger;
                _logger.LogInformation("Start Main From");
                Debug.WriteLine("Start Main Form");
                InitializeComponent();

                var accessTokenContainer = Utility.GetAccessTokenContainer();

                if (accessTokenContainer == null || accessTokenContainer.IsRefreshTokenExpired || accessTokenContainer.RefreshTokenExpiresInDays < 5)
                {
                    var consumerKey = Utility.GetConsumerKey();
                    if(consumerKey == null)
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


                _streamer = new TDStreamer(Utility.UserPrincipal);
                _streamer.StockQuoteReceived.Subscribe(x => HandleStockQuote(x));
                _streamer.OrderRecieved.Subscribe(o => HandleOrderRecieved(o));
                _streamer.OrderFilled.Subscribe(o => HandleOrderFilled(o));

                //_securitiesaccount = TdHelper.GetAccount(Utility.AccessTokenContainer, Utility.UserPrincipal).Result;

                //dataGridView1.DataSource = _securitiesaccount.positions;
                //dataGridView1.DataSource = _securitiesaccount.


                timer1.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

        }

        #region Order Open 
        private async void btnSellMrkTriggerOco_Click(object sender, EventArgs e)
        {
            try
            {
                ResetInitialOrder();
                var stockQuote = _stockQuote;

                var stop = double.Parse(txtStop.Text);
                var riskPerShare = stop - stockQuote.lastPrice;
                var limit = stockQuote.lastPrice - riskPerShare;

                double calcShares;
                if (checkBox1.Checked)
                {
                    calcShares = double.Parse(txtRisk.Text);
                }
                else
                {
                    calcShares = double.Parse(txtRisk.Text) / riskPerShare;
                }

                var shares = Convert.ToInt32(calcShares);
                var limitShares = Convert.ToInt32(Math.Ceiling(shares * .25));

                var symbol = txtSymbol.Text;
                var quantity = shares;
                var instruction = "SELL";
                var stopPrice = stop;
                var limtPrice = limit;

                var triggerOrder = OrderHelper.CreateTriggerOcoOrder("MARKET", symbol, quantity, 0.0, limitShares, instruction, stopPrice, limtPrice);
                var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, triggerOrder, _placedOrders);
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
                ResetInitialOrder();

                var stockQuote = _stockQuote;
                var triggerLimit = double.Parse(txtLimit.Text);

                var stop = double.Parse(txtStop.Text);
                var riskPerShare = stop - triggerLimit;
                //var limit = stockQuote.lastPrice + riskPerShare;
                var limit = triggerLimit - riskPerShare;
                //var riskPerShare = stop - stockQuote.lastPrice;
                //var limit = stockQuote.lastPrice - riskPerShare;

                double calcShares;
                if (checkBox1.Checked)
                {
                    calcShares = double.Parse(txtRisk.Text);
                }
                else
                {
                    calcShares = double.Parse(txtRisk.Text) / riskPerShare;
                }
                
                var shares = Convert.ToInt32(calcShares);
                var limitShares = Convert.ToInt32(Math.Ceiling(shares * .25));

                var symbol = txtSymbol.Text;
                var quantity = shares;
                var instruction = "SELL";
                var stopPrice = stop;
                var limtPrice = limit;

                var triggerOrder = OrderHelper.CreateTriggerOcoOrder("LIMIT", symbol, quantity, triggerLimit, limitShares, instruction, stopPrice, limtPrice);
                var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, triggerOrder, _placedOrders);
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
                ResetInitialOrder();

                var stockQuote = _stockQuote;

                var stop = double.Parse(txtStop.Text);
                var riskPerShare = stockQuote.lastPrice - stop;
                var limit = stockQuote.lastPrice + riskPerShare;

                double calcShares;
                if (checkBox1.Checked)
                {
                    calcShares = double.Parse(txtRisk.Text);
                }
                else
                {
                    calcShares = double.Parse(txtRisk.Text) / riskPerShare;
                }

                var shares = Convert.ToInt32(calcShares);
                var limitShares = Convert.ToInt32(Math.Ceiling(shares * .25));

                var symbol = txtSymbol.Text;
                var quantity = shares;
                var instruction = "BUY";
                var stopPrice = stop;
                var limtPrice = limit;

                var triggerOrder = OrderHelper.CreateTriggerOcoOrder("MARKET", symbol, quantity, 0.0, limitShares, instruction, stopPrice, limtPrice);
                var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, triggerOrder, _placedOrders);
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
                ResetInitialOrder();

                var stockQuote = _stockQuote;

                var triggerLimit = double.Parse(txtLimit.Text);

                var stop = double.Parse(txtStop.Text);
                var riskPerShare = triggerLimit - stop;
                //var limit = stockQuote.lastPrice + riskPerShare;
                var limit = triggerLimit + riskPerShare;

                double calcShares;
                if (checkBox1.Checked)
                {
                    calcShares = double.Parse(txtRisk.Text);
                }
                else
                {
                    calcShares = double.Parse(txtRisk.Text) / riskPerShare;
                }

                var shares = Convert.ToInt32(calcShares);
                var limitShares = Convert.ToInt32(Math.Ceiling(shares * .25));

                var symbol = txtSymbol.Text;
                var quantity = shares;
                var instruction = "BUY";
                var stopPrice = stop;
                var limtPrice = limit;

                var triggerOrder = OrderHelper.CreateTriggerOcoOrder("LIMIT", symbol, quantity, triggerLimit, limitShares, instruction, stopPrice, limtPrice);
                var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, triggerOrder, _placedOrders);
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
                    stopInstruction = "SELL";
                    quantity = (int)_activePosition.longQuantity;
                }
                else if (_activePosition.shortQuantity > 0)
                {
                    stopInstruction = "BUY";
                    quantity = (int)_activePosition.shortQuantity;
                }
                else
                {
                    txtLastError.Text = "BreakEven Button Cant' Deterimine position";
                    return;
                }

                await PlaceStopOrder(_activePosition.instrument.symbol, quantity, stopInstruction, _activePosition.averagePrice);
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



        private async Task ExitMarket(int quantity)
        {
            string exitInstruction = GetExitInstruction(_activePosition);
            await PlaceMarketOrder(_activePosition.instrument.symbol, quantity, exitInstruction);
        }

        private static string GetExitInstruction(Position position)
        {
            var exitInstruction = "";
            if (position.longQuantity > 0)
            {
                exitInstruction = "SELL";
            }
            else if (position.shortQuantity > 0)
            {
                exitInstruction = "BUY";
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
            var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder, _placedOrders);
        }


        private async Task PlaceStopOrder(string symbol, int quantity, string instruction, double stopPrice)
        {
            var stopOrder = OrderHelper.CreateStopOrder(instruction, symbol, quantity, stopPrice);
            var orderKey = await TdHelper.PlaceOrder(Utility.AccessTokenContainer, Utility.UserPrincipal, stopOrder, _placedOrders);
        }
        #endregion

        private async void txtSymbol_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtSymbol.Text != String.Empty)
                {
                    _streamer.SubscribeQuote(Utility.UserPrincipal, txtSymbol.Text.ToUpper());
                    await SetPosition();
                }
            }
            catch (Exception) { }
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
        private void HandleStockQuote(StockQuote stockQuote)
        {

            _stockQuote = _stockQuote.Update(stockQuote);
            SafeUpdateTextBox(txtLastPrice, _stockQuote.lastPrice.ToString("0.00"));
            SafeUpdateTextBox(txtBid, _stockQuote.bidPrice.ToString("0.00"));
            SafeUpdateTextBox(txtAsk, _stockQuote.askPrice.ToString("0.00"));
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
            }
            catch (Exception ex)
            {
                SafeUpdateTextBox(txtLastError, ex.Message);
                Debug.WriteLine(ex.Message);
            }
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
            if (e.Control && e.KeyCode == Keys.B)
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
            _streamer.Dispose();
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
            if(_trainingWheels)
            {
                txtRisk.Text = settings.MaxShares;
            }
            else 
            {
                txtRisk.Text = settings.MaxRisk;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = settings.TrainingWheels;
        }
    }
}
