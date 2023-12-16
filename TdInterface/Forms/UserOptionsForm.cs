using System;
using System.Windows.Forms;
using TdInterface.Forms;

namespace TdInterface
{
    public partial class UserOptionsForm : EZTMBaseForm
    {
        public UserOptionsForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.Settings.TradeShares = chkTradeShares.Checked;
            Program.Settings.MaxRisk = string.IsNullOrEmpty(txtMaxRisk.Text) ? 0 : decimal.Parse(txtMaxRisk.Text);
            Program.Settings.MaxShares = int.Parse(txtMaxShares.Text);
            Program.Settings.UseBidAskOcoCalc = chkUseBidAskOcoCalc.Checked;
            Program.Settings.DisableFirstTargetProfitDefault = chkDisableFirstTarget.Checked;
            Program.Settings.OneRProfitPercenatage = int.Parse(txtOneRSharePct.Text);
            Program.Settings.MoveLimitPriceOnFill = chkMoveLimitOnFill.Checked;
            Program.Settings.DefaultLimitOffset = string.IsNullOrEmpty(txtDefaultLimitOffset.Text) ? 0 : decimal.Parse(txtDefaultLimitOffset.Text);
            Program.Settings.EnableMaxLossLimit = chkMaxLossLimit.Checked;
            Program.Settings.MaxLossLimitInR = Program.Settings.EnableMaxLossLimit ? decimal.Parse(txtMaxLossLimit.Text) : 0;
            Program.Settings.MinimumRisk = string.IsNullOrEmpty(txtMinRisk.Text) ? 0 : double.Parse(txtMinRisk.Text);
            Program.Settings.SendAltPrtScrOnOpen = chkSendPrtScrOnOpen.Checked;
            Program.Settings.ShowPnL = chkShowPnL.Checked;
            Program.Settings.PreventRiskExceedMaxLoss = chkPreventExceedMaxLoss.Checked;
            Program.Settings.AdjustRiskNotExceedMaxLoss = chkAdjustRiskForMaxLoss.Checked;
            Program.Settings.AlwaysOnTop = chkAlwaysOnTop.Checked;
            Program.Settings.CaptureScreenshotOnOpen = chkCaptureSSOnOpen.Checked;
            Program.Settings.HasTimeRestrict = chkTimeRestrict.Checked;
            Program.Settings.TimeRestrict = dtPickerTimeRestrict.Value;
            Program.Settings.HasTriggerOrderLimit = chkTriggerOrderLimit.Checked;
            Program.Settings.TriggerOrderLimit = int.Parse(txtTriggerOrderLimit.Text);

            Utility.SaveSettings(Program.Settings);
            this.Close();
        }

        private void UserOptionsForm_Load(object sender, EventArgs e)
        {
            Program.Settings = Utility.GetSettings();
            if (Program.Settings == null) Program.Settings = new Settings();

            chkTradeShares.Checked = Program.Settings.TradeShares;
            txtMaxRisk.Text = Program.Settings.MaxRisk.ToString("#.##");
            txtMaxShares.Text = Program.Settings.MaxShares.ToString();
            chkUseBidAskOcoCalc.Checked = Program.Settings.UseBidAskOcoCalc;
            chkDisableFirstTarget.Checked = Program.Settings.DisableFirstTargetProfitDefault;
            txtOneRSharePct.Text = Program.Settings.OneRProfitPercenatage.ToString();
            chkMoveLimitOnFill.Checked = Program.Settings.MoveLimitPriceOnFill;
            txtDefaultLimitOffset.Text = Program.Settings.DefaultLimitOffset.ToString("#.##");
            chkMaxLossLimit.Checked = Program.Settings.EnableMaxLossLimit;
            txtMaxLossLimit.Text = Program.Settings.MaxLossLimitInR.ToString("#.##");
            txtMinRisk.Text = Program.Settings.MinimumRisk.ToString("#.##");
            chkSendPrtScrOnOpen.Checked = Program.Settings.SendAltPrtScrOnOpen;
            chkShowPnL.Checked = Program.Settings.ShowPnL;
            chkPreventExceedMaxLoss.Checked = Program.Settings.PreventRiskExceedMaxLoss;
            chkAdjustRiskForMaxLoss.Checked = Program.Settings.AdjustRiskNotExceedMaxLoss;
            chkAlwaysOnTop.Checked = Program.Settings.AlwaysOnTop;
            chkCaptureSSOnOpen.Checked = Program.Settings.CaptureScreenshotOnOpen;
            chkTimeRestrict.Checked = Program.Settings.HasTimeRestrict;
            if (Program.Settings.TimeRestrict != null) dtPickerTimeRestrict.Value = Program.Settings.TimeRestrict.Value;
            chkTriggerOrderLimit.Checked = Program.Settings.HasTriggerOrderLimit;
            txtTriggerOrderLimit.Text = Program.Settings.TriggerOrderLimit.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
