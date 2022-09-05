using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TdInterface
{
    public partial class UserOptionsForm : Form
    {
        public Settings _settings;
        public UserOptionsForm()
        {
            InitializeComponent();
        }

        private void chkTrainingWheels_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _settings.TradeShares = chkTrainingWheels.Checked;
            _settings.MaxRisk = Decimal.Parse(txtMaxRisk.Text);
            _settings.MaxShares = int.Parse(txtMaxShares.Text);
            Utility.SaveSettings(_settings);
            this.Close();
        }

        private void UserOptionsForm_Load(object sender, EventArgs e)
        {
            _settings = Utility.GetSettings();
            if(_settings == null) _settings = new Settings();

            chkTrainingWheels.Checked = _settings.TradeShares;
            txtMaxRisk.Text = _settings.MaxRisk.ToString("#.##");
            txtMaxShares.Text = _settings.MaxShares.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
