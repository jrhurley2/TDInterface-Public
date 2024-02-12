using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TdInterface.Forms;
using TdInterface.Interfaces;
using TdInterface.Tda;
using TdInterface.TradeStation;
using MessageBox = System.Windows.MessageBox;

namespace TdInterface
{
    public partial class MasterForm : EZTMBaseForm
    {
        private IStreamer _streamer;

        private IBrokerage _broker;

        public const int NumberStockButtons = 9;
        public Button[] StockButtons = new Button[NumberStockButtons];



        public MasterForm()
        {
            try
            {

                Debug.WriteLine("Start Master Form");
                Debug.WriteLine($"version: {Program.AppVersion}");

                InitializeComponent();

                // TODO: Move Getting AccountInfo logic to a function - maybe this happens in Program before MainForm even exists?
                var accountInfo = Utility.GetAccountInfo();
                if (accountInfo == null)
                {
                    var frmAccountInfo = new AccountInfoForm();
                    frmAccountInfo.ShowDialog();
                    accountInfo = Utility.GetAccountInfo();
                }
                if (accountInfo != null)
                {
                    _broker = accountInfo.UseTSEquity ? new TradeStationHelper(accountInfo) : new TdHelper(accountInfo);
                }
                StockButtons = new Button[] { btnStock1,
                                              btnStock2,
                                              btnStock3,
                                              btnStock4,
                                              btnStock5,
                                              btnStock6,
                                              btnStock7,
                                              btnStock8,
                                              btnStock9 };

                var stockPreferences = Utility.LoadStockPreferences("StockPreferences.json");

                if (stockPreferences != null)
                {
                    for (int i = 0; i < stockPreferences.Count; i++)
                    {
                        StockButtons[i].Tag = stockPreferences[i].Stock.ToUpper();
                        StockButtons[i].Text = stockPreferences[i].Stock.ToUpper();
                    }
                }

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
                if (_broker.NeedTokenRefreshed)
                {
                    var oAuthLoginForm = new OAuthLoginForm(_broker.LoginUri);
                    int num2 = (int)oAuthLoginForm.ShowDialog(this);
                    Utility.AuthToken = oAuthLoginForm.Code;
                    _ = await _broker.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken));
                }

                _ = await _broker.RefreshAccessToken();

                _streamer = await _broker.GetStreamer();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                MessageBox.Show("Error Logging In, Clear Creds or enter account info, shut down and retry.");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UserOptionsForm();
            frm.ShowDialog();
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
                if (_streamer != null) _streamer.Dispose();

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
                    frm = new MainForm(_streamer, name, _broker);
                    frm.Tag = name;
                    _mainForms.Add(nameAsKey, frm);
                }
                else
                {
                    frm = new MainForm(_streamer, "Enter a symbol...", _broker);
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

        private void btnThetaForm_Click(object sender, EventArgs e)
        {
            var theThetaForm = new ThetaForm((TdHelper)_broker);
            theThetaForm.Show();
        }


        private void accountSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accountInfoForm = new AccountInfoForm();
            accountInfoForm.Show();
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

        private void stockPreferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stockPreferenceForm = new StockPreferenceForm();
            stockPreferenceForm.Show();

        }
    }
}
