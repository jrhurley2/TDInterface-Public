namespace EZTM.Common.Tda.Model
{
    public class StockQuote : EZTM.Common.Model.StockQuote
    {

        //public string symbol { get; set; }
        //public string description { get; set; }
        //public double bidPrice { get; set; }
        //public double askPrice { get; set; }
        //public double lastPrice { get; set; }


        public const string FIELD_QUOTE_SYMBOL = "key";
        public const string FIELD_QUOTE_BID_PRICE = "1";
        public const string FIELD_QUOTE_ASK_PRICE = "2";
        public const string FIELD_QUOTE_lAST_PRICE = "3";


        public StockQuote() { }

        public virtual StockQuote Update(StockQuote stockQuote)
        {
            symbol = stockQuote.symbol;
            bidPrice = stockQuote.bidPrice != 0.0 ? stockQuote.bidPrice : bidPrice;
            askPrice = stockQuote.askPrice != 0.0 ? stockQuote.askPrice : askPrice;
            lastPrice = stockQuote.lastPrice != 0.0 ? stockQuote.lastPrice : lastPrice;
            return this;
        }

        public StockQuote(Dictionary<string, string> keyValuePairs)
        {
            foreach (var key in keyValuePairs.Keys)
            {
                if (key.Equals(FIELD_QUOTE_SYMBOL))
                {
                    symbol = keyValuePairs[key];
                }
                else if (key.Equals(FIELD_QUOTE_BID_PRICE))
                {
                    bidPrice = float.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_QUOTE_ASK_PRICE))
                {
                    askPrice = float.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_QUOTE_lAST_PRICE))
                {
                    lastPrice = float.Parse(keyValuePairs[key]);
                }
            }
        }
    }
}
