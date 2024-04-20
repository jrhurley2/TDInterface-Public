using System;
using System.Windows.Forms;
using EZTM.Common.Schwab;
using EZTM.Common.Tda;

namespace EZTM.Forms.UI.Forms
{
    public partial class ThetaForm : Form
    {
        private SchwabHelper _tdHelper = null;
        public ThetaForm(SchwabHelper tdHelper)
        {
            _tdHelper = tdHelper;
            InitializeComponent();
        }

        private void btnGetTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
