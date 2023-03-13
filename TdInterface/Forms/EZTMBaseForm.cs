using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
