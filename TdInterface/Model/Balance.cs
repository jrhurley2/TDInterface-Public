using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Model
{
    public class Balance
    {
        public double CashBalance { get; set; }

        public double LiquidationValue { get; set; }

        public double LongMarketValue { get; set; }

        public double ShortMarketValue { get; set; }

        public double ShortBalance { get; set; }

        public double ShortMarginValue { get; set; }

        public double AvailableFunds { get; set; }

        public double Equity { get; set; }

        public double MarginBalance { get; set; }

        public double BuyingPower { get; set; }

        public double StockBuyingPower { get; set; }

        public double OptionBuyingPower { get; set; }

        public Dictionary<string, string> ToDictionary() => new Dictionary<string, string>()
        {
            ["Cash balance"] = this.CashBalance.ToString("0.00"),
            ["Liquidation value"] = this.LiquidationValue.ToString("0.00"),
            ["Long market value"] = this.LongMarketValue.ToString("0.00"),
            ["Short market value"] = this.ShortMarketValue.ToString("0.00"),
            ["Short balance"] = this.ShortBalance.ToString("0.00"),
            ["Short margin value"] = this.ShortMarginValue.ToString("0.00"),
            ["Available funds"] = this.AvailableFunds.ToString("0.00"),
            ["Equity"] = this.Equity.ToString("0.00"),
            ["Margin balance"] = this.MarginBalance.ToString("0.00"),
            ["Buying power"] = this.BuyingPower.ToString("0.00"),
            ["Stock buying power"] = this.StockBuyingPower.ToString("0.00"),
            ["Option buying power"] = this.OptionBuyingPower.ToString("0.00")
        };
    }

}
