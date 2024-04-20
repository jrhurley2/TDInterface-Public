using EZTM.Common.Schwab;
using EZTM.Common.Tda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZTM.Forms.UI.Forms
{
    public partial class TestHanessForm : Form
    {
        private SchwabHelper _schwabHelper = null;
        public TestHanessForm(SchwabHelper schwabHelper)
        {
            InitializeComponent();
            _schwabHelper = schwabHelper;
        }

        private void btnRefreshToken_Click(object sender, EventArgs e)
        {
            try
            {
                txtResults.Text = string.Empty;

                ((Button)sender).BackColor = Color.Yellow;
                txtResults.Text = $"Old AccesToken: {_schwabHelper.AccessTokenContainer.AccessToken.ToString()}{Environment.NewLine}";

                var token = _schwabHelper.RefreshAccessToken().Result;

                txtResults.Text += $"New AccesToken: {token.AccessToken.ToString()}{Environment.NewLine}";

                ((Button)sender).BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                txtResults.Text += ex.Message;
                txtResults.Text += ex.StackTrace;
                ((Button)sender).BackColor = Color.Red;
            }


        }

        private async void btnAccountNumberHash_Click(object sender, EventArgs e)
        {
            try
            {
                txtResults.Text = string.Empty;

                ((Button)sender).BackColor = Color.Yellow;
                var actual = await _schwabHelper.GetAccountNumberHash().ConfigureAwait(true);

                foreach (var accountNumberHash in actual)
                {
                    txtResults.Text += $"{accountNumberHash.accountNumber}:{accountNumberHash.hashValue}{Environment.NewLine}";
                }
                ((Button)sender).BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                txtResults.Text += ex.Message;
                txtResults.Text += ex.StackTrace;
                ((Button)sender).BackColor = Color.Red;
            }
        }

        private async void btnAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                txtResults.Text = string.Empty;

                ((Button)sender).BackColor = Color.Yellow;
                var actual = await _schwabHelper.GetAccounts().ConfigureAwait(true);

                if(actual != null)
                {
                    foreach (var account in actual)
                    {
                        txtResults.Text += $"{account.accountNumber}:{account.type}{Environment.NewLine}";
                    }
                }

                ((Button)sender).BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                txtResults.Text += ex.Message;
                txtResults.Text += ex.StackTrace;
                ((Button)sender).BackColor = Color.Red;
            }

        }

        private async void btnRefreshRefreshToken_Click(object sender, EventArgs e)
        {
            try
            {
                txtResults.Text = string.Empty;

                var oldToken = _schwabHelper.AccessTokenContainer.RefreshToken;
                ((Button)sender).BackColor = Color.Yellow;
                txtResults.Text = $"Old AccesToken: {_schwabHelper.AccessTokenContainer.RefreshToken.ToString()}{Environment.NewLine}";

                var token = await _schwabHelper.RefreshRefreshToken().ConfigureAwait(true);

                txtResults.Text += $"New AccesToken: {token.RefreshToken.ToString()}{Environment.NewLine}";

                ((Button)sender).BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                txtResults.Text += ex.Message;
                txtResults.Text += ex.StackTrace;
                ((Button)sender).BackColor = Color.Red;
            }


        }
    }
}
