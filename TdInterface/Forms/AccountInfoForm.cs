using System;
using EZTM.Common.Model;
using EZTM.Common.Schwab;
using EZTM.Common.Tda;


namespace EZTM.Forms.UI.Forms
{
    public partial class AccountInfoForm : EZTMBaseForm
    {

        private AccountInfo _accountInfo = new AccountInfo();

        public AccountInfoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _accountInfo.UseTdaEquity = chkTdaEnableEquity.Checked;
            _accountInfo.TdaConsumerKey = txtConsumerKey.Text;

            _accountInfo.UseSchwabEquity = chkSchwabEnableEquity.Checked;
            _accountInfo.SchwabClientId = txtSchwabClientId.Text;
            _accountInfo.SchwabClientSecret = txtSchwabClientSecret.Text;

            _accountInfo.UseTSEquity = chkTsEnableEquity.Checked;
            _accountInfo.TradeStationClientId = txtClientId.Text;
            _accountInfo.TradeStationClientSecret = txtClientSecret.Text;
            _accountInfo.TradeStationUseSimAccount = chkUseSimAccount.Checked;
            Utility.SaveAccountInfo(_accountInfo);
            this.Close();
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            _accountInfo = Utility.GetAccountInfo();
            if (_accountInfo == null) _accountInfo = new AccountInfo();
            chkTdaEnableEquity.Checked = _accountInfo.UseTdaEquity;
            txtConsumerKey.Text = _accountInfo.TdaConsumerKey;

            chkSchwabEnableEquity.Checked = _accountInfo.UseSchwabEquity;
            txtSchwabClientId.Text = _accountInfo.SchwabClientId;
            txtSchwabClientSecret.Text = _accountInfo.SchwabClientSecret;

            chkTsEnableEquity.Checked = _accountInfo.UseTSEquity;
            txtClientId.Text = _accountInfo.TradeStationClientId;
            txtClientSecret.Text = _accountInfo.TradeStationClientSecret;
            chkUseSimAccount.Checked = _accountInfo.TradeStationUseSimAccount;
        }

        private void chkTdaEnableEquity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTdaEnableEquity.Checked)
            {
                chkTsEnableEquity.Checked = false;
            }
        }

        private void chkTsEnableEquity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTsEnableEquity.Checked)
            {
                chkTdaEnableEquity.Checked = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearCreds_Click(object sender, EventArgs e)
        {
            Utility.ClearAccessTokenContainerFile(SchwabHelper.ACCESSTOKENCONTAINER);
            //Utility.ClearAccessTokenContainerFile(TradeStationHelper.ACCESSTOKENCONTAINER);
        }
    }
}
