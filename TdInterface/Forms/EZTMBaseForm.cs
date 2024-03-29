using System.Windows.Forms;
using EZTM.Forms.UI.Properties;

namespace EZTM.Forms.UI.Forms
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
