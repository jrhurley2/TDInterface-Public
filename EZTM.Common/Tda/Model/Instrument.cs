namespace EZTM.Common.Tda.Model
{
    public class Instrument
    {
        public string symbol { get; set; }
        public string? underlyingSymbol { get; set; }
        public string optionExpirationDate { get; set; }
        public int optionStrikePrice { get; set; }
        public string putCall { get; set; }
        public string cusip { get; set; }
        public string description { get; set; }
        public string assetType { get; set; }
        public string bondMaturityDate { get; set; }
        public int bondInterestRate { get; set; }

        //public string assetType { get; set; }
        //public string cusip { get; set; }
        //public string symbol { get; set; }
        //public string description { get; set; }
        //public string type { get; set; }
    }
}
