using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

        private TdHelper _tdHelper = new TdHelper();
        private TradeStationHelper _tradeStationHelper;
        private IHelper _tradeHelper;

        public MasterForm()
        {
            try
            {
                Debug.WriteLine("Start Master Form");
                InitializeComponent();

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

                string loginUri = string.Empty;

                if (accountInfo.UseTdaEquity)
                {
                    if (_tdHelper.AccessTokenContainer == null || (_tdHelper.AccessTokenContainer.TokenSystem == AccessTokenContainer.EnumTokenSystem.TDA && (_tdHelper.AccessTokenContainer.IsRefreshTokenExpired || _tdHelper.AccessTokenContainer.RefreshTokenExpiresInDays < 5)))
                    {
                        Utility.SplitTdaConsumerKey(accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

                        loginUri = $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={UrlEncoder.Create().Encode(redirectUri)}&client_id={consumerKey}%40AMER.OAUTHAP";
                        var oAuthLoginForm = new OAuthLoginForm(loginUri);
                        int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                        Utility.AuthToken = oAuthLoginForm.Code;
                        _ = await _tdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken));
                    }
                    _ = await _tdHelper.RefreshAccessToken();

                    Utility.UserPrincipal = await _tdHelper.GetUserPrincipals();
                    _equityAccountId = Utility.UserPrincipal.accounts[0].accountId;
                    _streamer = new TDStreamer(Utility.UserPrincipal);
                    _tradeHelper = _tdHelper;

                }
                else if (accountInfo.UseTSEquity)
                {
                    var clientid = accountInfo.TradeStationClientId;
                    var clientSecret = accountInfo.TradeStationClientSecret;

                    _tradeStationHelper = new TradeStationHelper(clientid, clientSecret, accountInfo.TradeStationUseSimAccount);

                    if (_tradeStationHelper.AccessTokenContainer == null)
                    {
                        loginUri = $"https://signin.tradestation.com/authorize?response_type=code&client_id={clientid}&redirect_uri=http%3A%2F%2Flocalhost&t&audience=https://api.tradestation.com&scope=openid offline_access MarketData ReadAccount Trade Matrix";

                        var oAuthLoginForm = new OAuthLoginForm(loginUri);
                        int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                        Utility.AuthToken = oAuthLoginForm.Code;
                        _ = await _tradeStationHelper.GetAccessToken(Utility.AuthToken);
                    }

                    _tradeHelper = _tradeStationHelper;


                    _ = await _tradeStationHelper.RefreshAccessToken();

                    var accounts = await _tradeStationHelper.GetAccounts();
                    //Lets get the first Margin account for equity trading.  Might need to change later, but see how this goes.
                    var equitiyAccount = accounts.Where(a => a.AccountType.Equals("Margin", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                    _equityAccountId = equitiyAccount.AccountID;

                    _streamer = new TradeStationStreamer(_tradeStationHelper, _equityAccountId);
                    ((TradeStationStreamer)_streamer).StartAccountStream();
                }
                else
                {
                    var frmAccountInfo = new AccountInfoForm();
                    frmAccountInfo.ShowDialog();
                    accountInfo = Utility.GetAccountInfo();
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
            if (_tradeHelper.AccessTokenContainer.ExpiresIn < 100)
            {
                _ = await _tradeHelper.RefreshAccessToken();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UserOptionsForm();
            frm.ShowDialog();
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
                if(_streamer != null) _streamer.Dispose();

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
                    frm = new MainForm(_streamer, name, _equityAccountId, _tradeHelper);
                    frm.Tag = name;
                    _mainForms.Add(nameAsKey, frm);
                }
                else
                {
                    frm = new MainForm(_streamer, "Enter a symbol...", _equityAccountId, _tradeHelper);
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.Show();

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
    }
}
