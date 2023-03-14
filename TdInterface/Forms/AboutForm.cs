using System.Diagnostics;
using System.Reflection;
using TdInterface.Properties;

namespace TdInterface.Forms
{
    public partial class AboutForm : EZTMBaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Version: {Assembly.GetExecutingAssembly().GetName().Version}";
        }

        private void lnkAppGithub_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.lnkAppGithub.LinkVisited = true;

            ProcessStartInfo sInfo = new ProcessStartInfo { FileName = Resources.githubProjectURL, UseShellExecute = true };

            Process.Start(sInfo);
        }
    }
}
