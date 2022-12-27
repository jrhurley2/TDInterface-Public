using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TdInterface.Model;

namespace TdInterface.Forms
{
    public partial class AccountInfoForm : Form
    {

        private AccountInfo _accountInfo = new AccountInfo();

        public AccountInfoForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _accountInfo.TdaConsumerKey = txtConsumerKey.Text;
            _accountInfo.TradeStationClientId = txtClientId.Text;
            _accountInfo.TradeStationClientSecret = txtClientSecret.Text;
            Utility.SaveAccountInfo(_accountInfo);
        }

        private void AccountInfoForm_Load(object sender, EventArgs e)
        {
            _accountInfo = Utility.GetAccountInfo();
            if (_accountInfo == null) _accountInfo = new AccountInfo();
            txtConsumerKey.Text = _accountInfo.TdaConsumerKey;
            txtClientId.Text = _accountInfo.TradeStationClientId;
            txtClientSecret.Text = _accountInfo.TradeStationClientSecret;
        }
    }
}
