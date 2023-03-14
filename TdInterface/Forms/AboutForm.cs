using System.Diagnostics;
using System.Reflection;
using System.Windows;
using TdInterface.Properties;

namespace TdInterface.Forms
{
    public partial class AboutForm : EZTMBaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Version: {Program.GetAppVersion()}";
        }

        private void lnkAppGithub_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.lnkAppGithub.LinkVisited = true;

            Utility.OpenAppOnGitHub();
        }
    }
}
