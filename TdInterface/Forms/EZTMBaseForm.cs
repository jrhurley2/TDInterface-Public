using System.Windows.Forms;
using TdInterface.Properties;

namespace TdInterface.Forms
{
    public partial class EZTMBaseForm : Form
    {
        public EZTMBaseForm()
        {
            InitializeComponent();
            //this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.Icon = Resources.logo;
        }
    }
}
