using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Tda.Model
{
    public class StockQuote : TdInterface.Model.StockQuote
    {
        public const string FIELD_QUOTE_SYMBOL = "key";
        public const string FIELD_QUOTE_BID_PRICE = "1";
        public const string FIELD_QUOTE_ASK_PRICE = "2";
        public const string FIELD_QUOTE_LAST_PRICE = "3";
        public const string FIELD_QUOTE_DESCRIPTION = "25";


        public StockQuote() { }

        public virtual StockQuote Update(StockQuote stockQuote)
        {
            symbol = stockQuote.symbol;
            bidPrice = stockQuote.bidPrice != 0.0 ? stockQuote.bidPrice : bidPrice;
            askPrice = stockQuote.askPrice != 0.0 ? stockQuote.askPrice : askPrice;
            LastPrice = stockQuote.LastPrice != 0.0 ? stockQuote.LastPrice : LastPrice;
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
                else if (key.Equals(FIELD_QUOTE_LAST_PRICE))
                {
                    LastPrice = float.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_QUOTE_DESCRIPTION))
                {
                    description = keyValuePairs[key];
                    if (!String.IsNullOrEmpty(description))
                    {
                        description = description.Split('-')[0];
                    }
                }
            }
        }
    }
}
