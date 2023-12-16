using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TdInterface.Model;

namespace TdInterface.Forms
{
    public partial class StockPreferenceForm : Form
    {
        public BindingList<StockPreference> _stockPreferences = null;

        public StockPreferenceForm()
        {
            InitializeComponent();

            var temp = Utility.LoadStockPreferences("StockPreferences.json");
            _stockPreferences = new BindingList<StockPreference>(temp);

            this.dataGridView1.DataSource = _stockPreferences;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Utility.SaveStockPreferences(_stockPreferences.ToList<StockPreference>());
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
