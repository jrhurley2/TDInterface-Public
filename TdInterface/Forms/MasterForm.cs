using MaterialSkin.Controls;
using MaterialSkin.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Encodings.Web;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TdInterface.Forms;
using TdInterface.Interfaces;
using TdInterface.Model;
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

        private Settings _settings = Utility.GetSettings();
        private TextWriterTraceListener _textWriterTraceListener = null;
        private TdHelper _tdHelper = new TdHelper();
        private TradeStationHelper _tradeStationHelper;
        private IHelper _tradeHelper;
        private AccountInfo _accountInfo = new AccountInfo();

        public MasterForm()
        {
            try
            {
                string logFolder = Program.LogFolder;
                if (!Directory.Exists(logFolder))
                    Directory.CreateDirectory(logFolder);

                _textWriterTraceListener = new TextWriterTraceListener($"{logFolder}\\{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log");
                Trace.Listeners.Add(_textWriterTraceListener);

                Debug.WriteLine("Start Master Form");
                InitializeComponent();

                lblVersion.Text = $"Version: {Program.AppVersion}";

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
                _accountInfo = Utility.GetAccountInfo();
                if (_accountInfo == null)
                {
                    mtcMasterForm.SelectedTab = tpAccountSettings;
                }
                else
                {
                    var accessTokenContainer = Utility.GetAccessTokenContainer();
                    Utility.AccessTokenContainer = accessTokenContainer;

                    if (accessTokenContainer == null || (accessTokenContainer.TokenSystem == AccessTokenContainer.EnumTokenSystem.TDA && (accessTokenContainer.IsRefreshTokenExpired || accessTokenContainer.RefreshTokenExpiresInDays < 5)))
                    {
                        string loginUri = string.Empty;

                        if (_accountInfo.UseTdaEquity)
                        {
                            Utility.SplitTdaConsumerKey(_accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

                            loginUri = $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={UrlEncoder.Create().Encode(redirectUri)}&client_id={consumerKey}%40AMER.OAUTHAP";
                            var oAuthLoginForm = new OAuthLoginForm(loginUri);
                            int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                            Utility.AuthToken = oAuthLoginForm.Code;
                            accessTokenContainer = await _tdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken));
                            Utility.SaveAccessTokenContainer(accessTokenContainer);
                            Utility.AccessTokenContainer = accessTokenContainer;
                        }
                        else if (_accountInfo.UseTSEquity)
                        {
                            _tradeStationHelper = new TradeStationHelper(_accountInfo.TradeStationClientId, _accountInfo.TradeStationClientSecret);

                            var clientid = _accountInfo.TradeStationClientId;
                            var clientSecret = _accountInfo.TradeStationClientSecret;
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
                            mtcMasterForm.SelectedTab = tpAccountSettings;
                        }
                    }

                    if (_accountInfo.UseTdaEquity)
                    {
                        Utility.AccessTokenContainer = await _tdHelper.RefreshAccessToken(Utility.AccessTokenContainer);
                        Utility.UserPrincipal = await _tdHelper.GetUserPrincipals(Utility.AccessTokenContainer);
                        _equityAccountId = Utility.UserPrincipal.accounts[0].accountId;
                        _streamer = new TDStreamer(Utility.UserPrincipal);
                        _tradeHelper = new TdHelper();
                    }
                    else if (_accountInfo.UseTSEquity)
                    {

                        var clientid = _accountInfo.TradeStationClientId;
                        var clientSecret = _accountInfo.TradeStationClientSecret;

                        if (_accountInfo.TradeStationUseSimAccount)
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
                        if (equitiyAccount != null)
                        {
                            _equityAccountId = equitiyAccount.AccountID;
                        }

                        _streamer = new TradeStationStreamer(_tradeStationHelper, _equityAccountId);
                        ((TradeStationStreamer)_streamer).StartAccountStream();
                    }
                    timer1.Start();
                }
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

        private void MasterForm_Load(object sender, EventArgs e)
        {
            var settings = Utility.GetSettings();
            if (settings != null)
            {
                settings.OneRProfitPercenatage = settings.OneRProfitPercenatage == 0 ? _settings.OneRProfitPercenatage : settings.OneRProfitPercenatage;
                _settings = settings;
            }

        }

        private static Dictionary<string, MainForm> _mainForms = new Dictionary<string, MainForm>();
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
                if (_streamer != null) _streamer.Dispose();
                _textWriterTraceListener.Dispose();

                foreach (var frm in _mainForms)
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
        }

        private async void btnTicker_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            launchMainForm(btn.Tag != null ? btn.Tag.ToString() : String.Empty);
        }

        private void btnFuturesCalc_Click(object sender, EventArgs e)
        {
            var futureCalcFrom = new FurtureCalcForm(_streamer);
            futureCalcFrom.Show();
        }

         #region Settings
        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            _settings.TradeShares = chkTradeShares.Checked;
            _settings.MaxRisk = string.IsNullOrEmpty(txtMaxRisk.Text) ? 0 : decimal.Parse(txtMaxRisk.Text);
            _settings.MaxShares = int.Parse(txtMaxShares.Text);
            _settings.UseBidAskOcoCalc = chkUseBidAskOcoCalc.Checked;
            _settings.DisableFirstTargetProfitDefault = chkDisableFirstTarget.Checked;
            _settings.OneRProfitPercenatage = int.Parse(txtOneRSharePct.Text);
            _settings.MoveLimitPriceOnFill = chkMoveLimitOnFill.Checked;
            _settings.ReduceStopOnClose = chkReduceStopOnClose.Checked;
            _settings.DefaultLimitOffset = string.IsNullOrEmpty(txtDefaultLimitOffset.Text) ? 0 : decimal.Parse(txtDefaultLimitOffset.Text);
            _settings.EnableMaxLossLimit = chkMaxLossLimit.Checked;
            _settings.MaxLossLimitInR = _settings.EnableMaxLossLimit ? decimal.Parse(txtMaxLossLimit.Text) : 0;
            _settings.MinimumRisk = string.IsNullOrEmpty(txtMinRisk.Text) ? 0 : double.Parse(txtMinRisk.Text);
            _settings.SendAltPrtScrOnOpen = chkSendPrtScrOnOpen.Checked;
            _settings.ShowPnL = chkShowPnL.Checked;
            _settings.PreventRiskExceedMaxLoss = chkPreventExceedMaxLoss.Checked;
            _settings.AdjustRiskNotExceedMaxLoss = chkAdjustRiskForMaxLoss.Checked;
            _settings.AlwaysOnTop = chkAlwaysOnTop.Checked;
            _settings.CaptureScreenshotOnOpen = chkCaptureSSOnOpen.Checked;

            Utility.SaveSettings(_settings);
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Settings have been saved.", "OK", true);
            SnackBarMessage.Show(this);
            mtcMasterForm.SelectedTab = tpHome;
        }

        private void tpSettings_Enter(object sender, EventArgs e)
        {
            _settings = Utility.GetSettings();
            if (_settings == null) _settings = new Settings();

            chkTradeShares.Checked = _settings.TradeShares;
            txtMaxRisk.Text = _settings.MaxRisk.ToString("#.##");
            txtMaxShares.Text = _settings.MaxShares.ToString();
            chkUseBidAskOcoCalc.Checked = _settings.UseBidAskOcoCalc;
            chkDisableFirstTarget.Checked = _settings.DisableFirstTargetProfitDefault;
            txtOneRSharePct.Text = _settings.OneRProfitPercenatage.ToString();
            chkMoveLimitOnFill.Checked = _settings.MoveLimitPriceOnFill;
            chkReduceStopOnClose.Checked = _settings.ReduceStopOnClose;
            txtDefaultLimitOffset.Text = _settings.DefaultLimitOffset.ToString("#.##");
            chkMaxLossLimit.Checked = _settings.EnableMaxLossLimit;
            txtMaxLossLimit.Text = _settings.MaxLossLimitInR.ToString("#.##");
            txtMinRisk.Text = _settings.MinimumRisk.ToString("#.##");
            chkSendPrtScrOnOpen.Checked = _settings.SendAltPrtScrOnOpen;
            chkShowPnL.Checked = _settings.ShowPnL;
            chkPreventExceedMaxLoss.Checked = _settings.PreventRiskExceedMaxLoss;
            chkAdjustRiskForMaxLoss.Checked = _settings.AdjustRiskNotExceedMaxLoss;
            chkAlwaysOnTop.Checked = _settings.AlwaysOnTop;
            chkCaptureSSOnOpen.Checked = _settings.CaptureScreenshotOnOpen;
        }
        #endregion

        #region About
        private void mbtnGitHub_Click(object sender, EventArgs e)
        {
            Utility.OpenAppOnGitHub();
        }
        private async void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            if (await Utility.IsAppUpdateAvailable())
            {
                MaterialDialog materialDialog = new MaterialDialog(this, "New Version Available", "An updated version is available on GitHub. Would you like to see the latest version on GitHub for download?", "Yes", true, "No");
                DialogResult result = materialDialog.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    Utility.OpenAppLatestReleaseOnGitHub();
                };
            }
            else
            {
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("You have the latest available version.", "OK", true);
                SnackBarMessage.Show(this);
            }
        }
        #endregion

        #region Account Settings
        private async void btnSave_Click(object sender, EventArgs e)
        {
            _accountInfo.UseTdaEquity = chkTdaEnableEquity.Checked;
            _accountInfo.TdaConsumerKey = txtConsumerKey.Text;

            _accountInfo.UseTSEquity = chkTsEnableEquity.Checked;
            _accountInfo.TradeStationClientId = txtClientId.Text;
            _accountInfo.TradeStationClientSecret = txtClientSecret.Text;
            _accountInfo.TradeStationUseSimAccount = chkUseSimAccount.Checked;
            Utility.SaveAccountInfo(_accountInfo);
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Account settings have been saved.", "OK", true);
            SnackBarMessage.Show(this);
            await Login();
            mtcMasterForm.SelectedTab = tpHome;
        }

        private void chkTdaEnableEquity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTdaEnableEquity.Checked)
            {
                chkTsEnableEquity.Checked = false;
                toggleBrokerControls();
            }
        }

        private void chkTsEnableEquity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTsEnableEquity.Checked)
            {
                chkTdaEnableEquity.Checked = false;
                toggleBrokerControls();
            }
        }

        private void toggleBrokerControls()
        {
            txtConsumerKey.Enabled = chkTdaEnableEquity.Checked;
            txtClientId.Enabled = chkTsEnableEquity.Checked;
            txtClientSecret.Enabled = chkTsEnableEquity.Checked;
            chkUseSimAccount.Enabled = chkTsEnableEquity.Checked;
        }

        private void btnClearCreds_Click(object sender, EventArgs e)
        {
            Utility.ClearAccessTokenContainerFile();
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("All credentials have been cleared. Please restart the app.", "OK", true);
            SnackBarMessage.Show(this);
        }
        private void tpAccountSettings_Enter(object sender, EventArgs e)
        {
            _accountInfo = Utility.GetAccountInfo();
            if (_accountInfo == null) _accountInfo = new AccountInfo();
            chkTdaEnableEquity.Checked = _accountInfo.UseTdaEquity;
            txtConsumerKey.Text = _accountInfo.TdaConsumerKey;

            chkTsEnableEquity.Checked = _accountInfo.UseTSEquity;
            txtClientId.Text = _accountInfo.TradeStationClientId;
            txtClientSecret.Text = _accountInfo.TradeStationClientSecret;
            chkUseSimAccount.Checked = _accountInfo.TradeStationUseSimAccount;
        }
        #endregion



        private void tpHome_Enter(object sender, EventArgs e)
        {
            if (_accountInfo != null)
            {
                if (_accountInfo.UseTSEquity)
                {
                    pbCurrentAccountLogo.Image = Properties.Resources.Logo_TS;
                    lblSimAccount.Visible = _accountInfo.TradeStationUseSimAccount;
                }
                else if (_accountInfo.UseTdaEquity)
                {
                    pbCurrentAccountLogo.Image = Properties.Resources.Logo_TDA;
                    lblSimAccount.Visible = false;
                }
            }
            rpbAAPL.LoadAsync(Utility.GetTickerImage("AAPL"));
            rpbAMD.LoadAsync(Utility.GetTickerImage("AMD"));
            rpbAMZN.LoadAsync(Utility.GetTickerImage("AMZN"));
            rpbMETA.LoadAsync(Utility.GetTickerImage("META"));
            rpbMSFT.LoadAsync(Utility.GetTickerImage("MSFT"));
            rpbNVDA.LoadAsync(Utility.GetTickerImage("NVDA"));
            rpbTSLA.LoadAsync(Utility.GetTickerImage("TSLA"));
            rpbSPY.LoadAsync(Utility.GetTickerImage("SPY"));
            rpbQQQ.LoadAsync(Utility.GetTickerImage("QQQ"));
        }

        #region Tools
        private void btnScreenshots_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", Utility.ScreenshotPath());
                MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Opening screenshot folder.", "OK", true);
                SnackBarMessage.Show(this);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Program.LogFolder);
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Opening logs folder.", "OK", true);
            SnackBarMessage.Show(this);
        }

        private void btnReplays_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Program.ReplayFolder);
            MaterialSnackBar SnackBarMessage = new MaterialSnackBar("Opening logs folder.", "OK", true);
            SnackBarMessage.Show(this);
        }
        #endregion

        #region Settings
        private void chkDisableFirstTarget_CheckedChanged(object sender, EventArgs e)
        {
            txtOneRSharePct.Enabled = !chkDisableFirstTarget.Checked;
        }

        private void chkTradeShares_CheckedChanged(object sender, EventArgs e)
        {
            txtMaxShares.Enabled = chkTradeShares.Checked;
        }

        private void chkMaxLossLimit_CheckedChanged(object sender, EventArgs e)
        {
            txtMaxLossLimit.Enabled= chkMaxLossLimit.Checked;
        }

        private void btnSettingsHelp_Click(object sender, EventArgs e)
        {
            Utility.OpenWebUrl(Properties.Resources.githubProjectOptionsUrl);
        }
        #endregion
    }
}
