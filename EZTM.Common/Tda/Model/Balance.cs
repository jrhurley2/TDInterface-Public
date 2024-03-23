namespace EZTM.Common.Tda.Model
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
            ["Cash balance"] = CashBalance.ToString("0.00"),
            ["Liquidation value"] = LiquidationValue.ToString("0.00"),
            ["Long market value"] = LongMarketValue.ToString("0.00"),
            ["Short market value"] = ShortMarketValue.ToString("0.00"),
            ["Short balance"] = ShortBalance.ToString("0.00"),
            ["Short margin value"] = ShortMarginValue.ToString("0.00"),
            ["Available funds"] = AvailableFunds.ToString("0.00"),
            ["Equity"] = Equity.ToString("0.00"),
            ["Margin balance"] = MarginBalance.ToString("0.00"),
            ["Buying power"] = BuyingPower.ToString("0.00"),
            ["Stock buying power"] = StockBuyingPower.ToString("0.00"),
            ["Option buying power"] = OptionBuyingPower.ToString("0.00")
        };
    }

}
