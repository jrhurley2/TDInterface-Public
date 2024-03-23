using System.Text.Json.Serialization;

namespace EZTM.UI.TradeStation.Model
{
    public class StockQuote : EZTM.Common.Model.StockQuote
    {
        [JsonPropertyName("Symbol")]
        public override string symbol { get; set; }
        //[JsonPropertyName("Bid")]
        public string Bid { get; set; }
        public string Ask { get; set; }
        public string Last { get; set; }
        public override double bidPrice
        {
            get
            {
                return Bid != null ? double.Parse(Bid) : 0.0;
            }
            set
            {
                Bid = value.ToString();
            }
        }
        public override double askPrice
        {
            get
            {
                return Ask != null ? double.Parse(Ask) : 0.0;
            }
            set
            {
                Ask = value.ToString();
            }
        }
        public override double lastPrice
        {
            get
            {
                return Last != null ? double.Parse(Last) : 0.0;
            }
            set
            {
                Last = value.ToString();
            }
        }
    }
}
