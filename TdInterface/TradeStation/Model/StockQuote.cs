using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TdInterface.TradeStation.Model
{
    public class StockQuote : TdInterface.Model.StockQuote
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
        }
        public override double askPrice
        {
            get
            {
                return Ask != null ? double.Parse(Ask) : 0.0;
            }
        }
        public override double lastPrice {
            get
            {
                return Last != null ? double.Parse(Last) : 0.0;
            }
        }
    }
}
