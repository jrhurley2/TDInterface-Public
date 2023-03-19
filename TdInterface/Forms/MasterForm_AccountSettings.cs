using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using TdInterface.Model;

namespace TdInterface
{
    public partial class MasterForm // Account Settings Page
    {
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
    }
}
