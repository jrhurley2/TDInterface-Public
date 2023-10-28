using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TdInterface.Tda;

namespace TdInterface.Forms
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
