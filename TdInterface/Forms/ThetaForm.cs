using System;
using System.Windows.Forms;
using EZTM.Forms.UI.Tda;

namespace EZTM.Forms.UI.Forms
{
    public partial class ThetaForm : Form
    {
        private TdHelper _tdHelper = null;
        public ThetaForm(TdHelper tdHelper)
        {
            _tdHelper = tdHelper;
            InitializeComponent();
        }

        private void btnGetTransactions_Click(object sender, EventArgs e)
        {

        }
    }
}
