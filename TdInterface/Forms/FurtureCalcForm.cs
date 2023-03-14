using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TdInterface.Forms;
using TdInterface.Interfaces;
using TdInterface.Tda.Model;

namespace TdInterface
{
    public partial class FurtureCalcForm : EZTMBaseForm
    {
        IStreamer _streamer = null;

        private List<FutureInfo> _futureInfos = new List<FutureInfo>() {
            new FutureInfo { Symbol = "/ES", TicksPerPoint = 4, TickValue = 12.50 } ,
            new FutureInfo { Symbol = "/MES", TicksPerPoint = 4, TickValue = 1.25 } ,
            new FutureInfo { Symbol = "/NQ", TicksPerPoint = 4, TickValue = 5.00 } ,
            new FutureInfo { Symbol = "/MNQ", TicksPerPoint = 4, TickValue = .50 }

        };

        public FurtureCalcForm(IStreamer streamer)
        {
            InitializeComponent();

            _streamer = streamer;

            _streamer.FutureQuoteReceived.Subscribe(f => HandleFutureQuote(f));

        }


        private void txtSymbol_Leave(object sender, EventArgs e)
        {
            _streamer.SubscribeFuture(Utility.UserPrincipal, txtSymbol.Text);

            var futureInfo = _futureInfos.Where(f => f.Symbol.ToLower() == txtSymbol.Text.ToLower()).FirstOrDefault();
            if (futureInfo!=null)
            {
                txtTicksPerPoint.Text = futureInfo.TicksPerPoint.ToString("#");
                txtTickValue.Text = futureInfo.TickValue.ToString("#.00");
            }
        }

        private StockQuote _stockQuote = new StockQuote();
        private void HandleFutureQuote(StockQuote stockQuote)
        {
            try
            {
                if (!stockQuote.symbol.Equals(txtSymbol.Text, StringComparison.InvariantCultureIgnoreCase)) return;
                _stockQuote = _stockQuote.Update(stockQuote);
                SafeUpdateTextBox(txtLastPrice, _stockQuote.lastPrice.ToString("0.00"));
                SafeUpdateTextBox(txtBid, _stockQuote.bidPrice.ToString("0.00"));
                SafeUpdateTextBox(txtAsk, _stockQuote.askPrice.ToString("0.00"));

                var risk = Double.Parse(txtRisk.Text);
                var stop = Double.Parse(txtStop.Text);
                var tickValuePerContract = Double.Parse(txtTickValue.Text);
                var ticksPerPoint = Double.Parse(txtTicksPerPoint.Text);

                var shares = risk / (((Math.Abs(_stockQuote.lastPrice - stop) * ticksPerPoint) * tickValuePerContract));

                SafeUpdateTextBox(txtShares, shares.ToString("0.00"));

                /*
                 * Buy (Using ASK) = Risk / (((Ask - Stop) * ticks per point) * tick value per contract)

                   Sell (Using BID) = Risk / (((Stop - Bid)  * ticks per point) * tick value per contract) (edited)

                 */
            }
            catch { }

        }

        private delegate void SafeCallDelegate(TextBox textBox, string text);

        private void SafeUpdateTextBox(TextBox textBox, string text)
        {
            try
            {
                if (textBox.InvokeRequired)
                {
                    var d = new SafeCallDelegate(SafeUpdateTextBox);
                    textBox.Invoke(d, new object[] { textBox, text });
                }
                else
                {
                    textBox.Text = text;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }
    }

    internal class FutureInfo
    {
        public string Symbol { get; set; }
        public double TicksPerPoint { get; set; }
        public double TickValue { get; set; }
    }
}
