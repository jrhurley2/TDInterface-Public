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
            _accountInfo.UseSchwabEquity = chkSchwabEnableEquity.Checked;
            _accountInfo.SchwabClientId = txtSchwabClientId.Text;
            _accountInfo.SchwabClientSecret = txtSchwabClientSecret.Text;
            _accountInfo.SchwabAccountNumber = txtSchwabAccountNumber.Text;

            Utility.SaveAccountInfo(_accountInfo);
            this.Close();
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            _accountInfo = Utility.GetAccountInfo();
            if (_accountInfo == null) _accountInfo = new AccountInfo();

            chkSchwabEnableEquity.Checked = _accountInfo.UseSchwabEquity;
            txtSchwabClientId.Text = _accountInfo.SchwabClientId;
            txtSchwabClientSecret.Text = _accountInfo.SchwabClientSecret;
            txtSchwabAccountNumber.Text = _accountInfo.SchwabAccountNumber;
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
