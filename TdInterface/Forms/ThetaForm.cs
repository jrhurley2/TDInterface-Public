using EZTM.Common.Tda;
using System;
using System.Windows.Forms;

namespace EZTM.UI.Forms
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
