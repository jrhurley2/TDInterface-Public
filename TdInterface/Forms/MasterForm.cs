using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TdInterface.Forms;
using TdInterface.Interfaces;
using TdInterface.Tda;
using TdInterface.Tda.Model;
using TdInterface.TradeStation;
using MessageBox = System.Windows.MessageBox;

namespace TdInterface
{
    public partial class MasterForm : EZTMBaseForm
    {
        private IStreamer _streamer;
        private string _equityAccountId;

        private Settings _settings = new() { TradeShares = false, MaxRisk = 5M, MaxShares = 4, OneRProfitPercenatage = 25 };
        private TextWriterTraceListener _textWriterTraceListener = null;
        private TdHelper _tdHelper = new TdHelper();
        private TradeStationHelper _tradeStationHelper;
        private IHelper _tradeHelper;

        public MasterForm()
        {
            try
            {
                string currentPath = Directory.GetCurrentDirectory();
                string logFolder = Path.Combine(currentPath, "logs");
                if (!Directory.Exists(logFolder))
                    Directory.CreateDirectory(logFolder);

                _textWriterTraceListener = new TextWriterTraceListener($"{logFolder}\\{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log");
                Trace.Listeners.Add(_textWriterTraceListener);

                Debug.WriteLine("Start Master Form");
                InitializeComponent();

                lblVersion.Text = $"Version: {Program.GetAppVersion()}";

                Login().ConfigureAwait(false);
            }
            catch (Exception)
            { 
            }
        }

        private async Task Login()
        {
            try
            {

                var accountInfo = Utility.GetAccountInfo();
                if (accountInfo == null)
                {
                    var frmAccountInfo = new AccountInfoForm();
                    frmAccountInfo.ShowDialog();
                    accountInfo = Utility.GetAccountInfo();
                }

                var accessTokenContainer = Utility.GetAccessTokenContainer();
                Utility.AccessTokenContainer = accessTokenContainer;

                if (accessTokenContainer == null || (accessTokenContainer.TokenSystem == AccessTokenContainer.EnumTokenSystem.TDA && (accessTokenContainer.IsRefreshTokenExpired || accessTokenContainer.RefreshTokenExpiresInDays < 5)))
                {
                    string loginUri = string.Empty;

                    if (accountInfo.UseTdaEquity)
                    {
                        Utility.SplitTdaConsumerKey(accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

                        loginUri = $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={UrlEncoder.Create().Encode(redirectUri)}&client_id={consumerKey}%40AMER.OAUTHAP";
                        var oAuthLoginForm = new OAuthLoginForm(loginUri);
                        int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                        Utility.AuthToken = oAuthLoginForm.Code;
                        accessTokenContainer = await _tdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken));
                        Utility.SaveAccessTokenContainer(accessTokenContainer);
                        Utility.AccessTokenContainer = accessTokenContainer;
                    }
                    else if (accountInfo.UseTSEquity)
                    {
                        _tradeStationHelper = new TradeStationHelper(accountInfo.TradeStationClientId, accountInfo.TradeStationClientSecret);

                        var clientid = accountInfo.TradeStationClientId;
                        var clientSecret = accountInfo.TradeStationClientSecret;
                        loginUri = $"https://signin.tradestation.com/authorize?response_type=code&client_id={clientid}&redirect_uri=http%3A%2F%2Flocalhost&t&audience=https://api.tradestation.com&scope=openid offline_access MarketData ReadAccount Trade Matrix";

                        var oAuthLoginForm = new OAuthLoginForm(loginUri);
                        int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                        Utility.AuthToken = oAuthLoginForm.Code;
                        accessTokenContainer = await _tradeStationHelper.GetAccessToken(Utility.AuthToken);
                        Utility.SaveAccessTokenContainer(accessTokenContainer);
                        Utility.AccessTokenContainer = await _tradeStationHelper.RefreshAccessToken(accessTokenContainer);
                    }
                    else
                    {
                        var frmAccountInfo = new AccountInfoForm();
                        frmAccountInfo.ShowDialog();
                        accountInfo = Utility.GetAccountInfo();
                    }
                }

                if (accountInfo.UseTdaEquity)
                {
                    Utility.AccessTokenContainer = await _tdHelper.RefreshAccessToken(Utility.AccessTokenContainer);
                    Utility.UserPrincipal = await _tdHelper.GetUserPrincipals(Utility.AccessTokenContainer);
                    _equityAccountId = Utility.UserPrincipal.accounts[0].accountId;
                    _streamer = new TDStreamer(Utility.UserPrincipal);
                    _tradeHelper = new TdHelper();
                }
                else if (accountInfo.UseTSEquity)
                {

                    var clientid = accountInfo.TradeStationClientId;
                    var clientSecret = accountInfo.TradeStationClientSecret;

                    if (accountInfo.TradeStationUseSimAccount)
                    {
                        //_tradeHelper = new TradeStationHelper("https://sim-api.tradestation.com/");
                        _tradeStationHelper = new TradeStationHelper("https://sim-api.tradestation.com/", clientid, clientSecret);
                    }
                    else
                    {
                        //_tradeHelper = new TradeStationHelper();
                        _tradeStationHelper = new TradeStationHelper(clientid, clientSecret);
                    }
                    _tradeHelper = _tradeStationHelper;


                    Utility.AccessTokenContainer = await _tradeStationHelper.RefreshAccessToken(Utility.AccessTokenContainer);


                    var accounts = await _tradeStationHelper.GetAccounts(Utility.AccessTokenContainer);
                    //Lets get the first Margin account for equity trading.  Might need to change later, but see how this goes.
                    var equitiyAccount = accounts.Where(a => a.AccountType.Equals("Margin", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                    _equityAccountId = equitiyAccount.AccountID;

                    _streamer = new TradeStationStreamer(_tradeStationHelper, _equityAccountId);
                    ((TradeStationStreamer)_streamer).StartAccountStream();
                }
                timer1.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show("Error Logging In, Clear Creds or enter account info, shut down and retry.");
            }
        }


        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (Utility.AccessTokenContainer.ExpiresIn < 100)
            {
                Utility.AccessTokenContainer = await _tradeHelper.RefreshAccessToken(Utility.AccessTokenContainer);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UserOptionsForm();
            frm.ShowDialog();
            _settings = Utility.GetSettings();
            //ApplySettings();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            var settings = Utility.GetSettings();
            if (settings != null)
            {
                settings.OneRProfitPercenatage = settings.OneRProfitPercenatage == 0 ? _settings.OneRProfitPercenatage : settings.OneRProfitPercenatage;    
                _settings = settings;
            }

        }

        private static Dictionary<string, MainForm> _mainForms = new  Dictionary<string, MainForm>();
        private void btnNewTrade_Click(object sender, EventArgs e)
        {
            launchMainForm(txtSymbol.Text);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var frm = sender as MainForm;
                _mainForms.Remove(frm.MainFormName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }



        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _textWriterTraceListener.Flush();
                _textWriterTraceListener.Close();
                if(_streamer != null) _streamer.Dispose();
                _textWriterTraceListener.Dispose();

                foreach(var frm in _mainForms)
                {
                    frm.Value.Close();
                    frm.Value.Dispose();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void launchMainForm(string name)
        {
            MainForm frm = null;

            var nameAsKey = String.Empty;

            if (string.IsNullOrEmpty(name))
            {
                nameAsKey = $"EZTM Form {_mainForms.Count}";
            }
            else
            {
                nameAsKey = name.ToUpper();
            }

            if (_mainForms.ContainsKey(nameAsKey))
            {
                frm = _mainForms[nameAsKey];
            }
            else
            {
                if (!string.IsNullOrEmpty(name))
                {
                    frm = new MainForm(_streamer, _settings, name, _equityAccountId, _tradeHelper);
                    frm.Tag = name;
                    _mainForms.Add(nameAsKey, frm);
                }
                else
                {
                    frm = new MainForm(_streamer, _settings, "Enter a symbol...", _equityAccountId, _tradeHelper);
                    _mainForms.Add(nameAsKey, frm);

                }
                frm.FormClosing += MainForm_FormClosing;
                frm.Show();
            }

            frm.Focus();
        }

        private void btnTicker_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            launchMainForm(btn.Tag != null ? btn.Tag.ToString() : String.Empty);
        }

        private void btnFuturesCalc_Click(object sender, EventArgs e)
        {
            var futureCalcFrom = new FurtureCalcForm(_streamer);
            futureCalcFrom.Show();
        }

        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accountInfoForm = new AccountInfoForm();
            accountInfoForm.Show();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnScreenshots_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", Utility.ScreenshotPath());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private async void checkForUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (await Utility.IsAppUpdateAvailable())
            {
                if (MessageBox.Show("Updated version is available on GitHub.\nWould you like to download it?", "New Version Available", System.Windows.MessageBoxButton.YesNo, MessageBoxImage.Asterisk) == MessageBoxResult.Yes)
                {
                    Utility.OpenAppLatestReleaseOnGitHub();
                };
            }
            else
            {
                MessageBox.Show("You have the latest version.");
            }
        }

        private void mbtnGitHub_Click(object sender, EventArgs e)
        {
            Utility.OpenAppOnGitHub();
        }
    }
}
