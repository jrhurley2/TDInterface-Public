using MaterialSkin.Controls;
using System;
using System.Diagnostics;

namespace TdInterface
{
    public partial class MasterForm // Tools Page
    {
        private void btnFuturesCalc_Click(object sender, EventArgs e)
        {
            var futureCalcFrom = new FurtureCalcForm(_streamer);
            futureCalcFrom.Show();
        }

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
    }
}
