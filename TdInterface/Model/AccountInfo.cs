namespace EZTM.Forms.UI.Model
{
    public class AccountInfo
    {
        public bool UseTdaEquity { get; set; }
        public string TdaConsumerKey { get; set; }

        public bool UseSchwabEquity { get; set; }
        public string SchwabClientId { get; set; }
        public string SchwabClientSecret { get; set; }

        public bool UseTSEquity { get; set; }
        public string TradeStationClientId { get; set; }
        public string TradeStationClientSecret { get; set; }
        public bool TradeStationUseSimAccount { get; set; }
    }
}
