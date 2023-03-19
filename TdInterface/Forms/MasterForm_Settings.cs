using MaterialSkin.Controls;
using System;
using System.Diagnostics;

namespace TdInterface
{
    public partial class MasterForm // Settings Page
    {
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
            txtMaxLossLimit.Enabled = chkMaxLossLimit.Checked;
        }

        private void btnSettingsHelp_Click(object sender, EventArgs e)
        {
            Utility.OpenWebUrl(Properties.Resources.githubProjectOptionsUrl);
        }
    }
}
