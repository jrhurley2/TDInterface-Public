using EZTM.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using EZTM.Common;

namespace EZTM.Forms.UI.Forms
{
    public partial class OptionsForm : Form
    {
        private IBrokerage _brokerage;
        public OptionsForm(IBrokerage brokerage)
        {
            InitializeComponent();
            _brokerage = brokerage;
        }

        private async void txtSymbol_Leave(object sender, EventArgs e)
        {
            var expirationList = await _brokerage.GetOptionExpirationChain(txtSymbol.Text);
            dgExpirationDates.DataSource = expirationList.expirationList.Select(x => new
            {
                x.expirationDate,
                x.daysToExpiration,
                x.expirationType,
                x.standard
            }).ToList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var selectedExDates = dgExpirationDates.SelectedRows;
            // Linq query to get the minimum expiration date from selectedExDates
            var minDate = selectedExDates.Cast<DataGridViewRow>()
                .Select(row => DateTime.Parse(row.Cells["expirationDate"].Value.ToString()))
                .Min().ToString("yyyy-MM-dd");
            var maxDate = selectedExDates.Cast<DataGridViewRow>()
                .Select(row => DateTime.Parse(row.Cells["expirationDate"].Value.ToString()))
                .Max().ToString("yyyy-MM-dd");

            var optionsChain = await _brokerage.GetOptionChain(txtSymbol.Text, minDate, maxDate);
            // Remove from the CallExpDateMap all OptionsContracts whose Deltas are below .10
            foreach (var expDate in optionsChain.CallExpDateMap.Keys.ToList())
            {
                var strikeMap = optionsChain.CallExpDateMap[expDate];
                foreach (var strike in strikeMap.Keys.ToList())
                {
                    var contracts = strikeMap[strike];
                    // Remove contracts with Delta < 0.10 (absolute value, in case of negative deltas)
                    contracts.RemoveAll(c => Math.Abs(c.Delta) < 0.10m);
                    // If no contracts remain for this strike, remove the strike entry
                    if (contracts.Count == 0)
                    {
                        strikeMap.Remove(strike);
                    }
                }
                // If no strikes remain for this expiration date, remove the expiration date entry
                if (strikeMap.Count == 0)
                {
                    optionsChain.CallExpDateMap.Remove(expDate);
                }
            }

            // Remove from the PutExpDateMap all OptionsContracts whose Deltas are above -.10 (absolute value, in case of negative deltas)
            foreach (var expDate in optionsChain.PutExpDateMap.Keys.ToList())
            {
                var strikeMap = optionsChain.PutExpDateMap[expDate];
                foreach (var strike in strikeMap.Keys.ToList())
                {
                    var contracts = strikeMap[strike];
                    // Remove contracts with Delta > -0.10 (absolute value, in case of negative deltas)
                    contracts.RemoveAll(c => Math.Abs(c.Delta) > 0.10m);
                    // If no contracts remain for this strike, remove the strike entry
                    if (contracts.Count == 0)
                    {
                        strikeMap.Remove(strike);
                    }
                }
                // If no strikes remain for this expiration date, remove the expiration date entry
                if (strikeMap.Count == 0)
                {
                    optionsChain.PutExpDateMap.Remove(expDate);
                }
            }

            txtOptionChain.Text = JsonConvert.SerializeObject(optionsChain, Formatting.Indented);

            var payload = CreateGrokPayload(txtSymbol.Text.ToUpper(), txtOptionChain.Text);
            var grok = new Grok(); // Ensure you have set the API key in the Grok class constructor or property
            //var result = await grok.PostAsync("chat/completions", payload);

            // Fix for CS1501: Provide an anonymous type instance to match the overload
            //txtGrokResult.Text = result;
        }



        private object CreateGrokPayload(string stock, string jsonChain)
        {
            var payload = new
            {
                model = "grok-3",
                messages = new[]
    {
                    new
                    {
                        role = "system",
                        content = string.Format("\"You are a financial analyst specializing in options trading. Use the provided {0} options chain data to design a Short Strangle strategy. Assume delta approximates the probability of being in-the-money at expiration.\"", stock)
                    },
                    new
                    {
                        role = "user",
                        content = string.Format("\"Using the following {1} options chain data for expiration June 6, 2025 (6 days away, underlying price $200.355), create a Short Strangle with an ~80% chance of not being assigned (i.e., stock price stays between strikes). Select OTM call and put strikes with deltas ~0.10–0.20. Provide: strike prices, premiums (bid prices), total credit, breakeven points, approximate probability of success (based on deltas), and max loss. {0} \"", jsonChain, stock)
                    }
                },
                temperature = 0.2
            };

            return payload;
        }
    }
}
