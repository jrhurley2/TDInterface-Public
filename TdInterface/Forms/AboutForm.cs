namespace TdInterface.Forms
{
    public partial class AboutForm : EZTMBaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
            lblVersion.Text = $"Version: {Program.AppVersion}";
        }
    }
}
