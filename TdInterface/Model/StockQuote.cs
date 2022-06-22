using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Model
{
    public class StockQuote
    {

        public string symbol { get; set; }
        public string description { get; set; }
        public double bidPrice { get; set; }
        public double askPrice { get; set; }
        public double lastPrice { get; set; }


        public const string FIELD_QUOTE_SYMBOL = "key";
        public const string FIELD_QUOTE_BID_PRICE = "1";
        public const string FIELD_QUOTE_ASK_PRICE = "2";
        public const string FIELD_QUOTE_lAST_PRICE = "3";


        public StockQuote() { }

        public StockQuote Update(StockQuote stockQuote) 
        {
            symbol = stockQuote.symbol;
            bidPrice = stockQuote.bidPrice != 0.0 ? stockQuote.bidPrice : bidPrice;
            askPrice = stockQuote.askPrice != 0.0 ? stockQuote.askPrice : askPrice;
            lastPrice = stockQuote.lastPrice != 0.0 ? stockQuote.lastPrice : lastPrice;
            return this;
        }

        public StockQuote(Dictionary<String,string> keyValuePairs)
        {
            foreach(var key in keyValuePairs.Keys)
            {
                if(key.Equals(FIELD_QUOTE_SYMBOL))
                {
                    symbol = keyValuePairs[key];    
                }
                else if(key.Equals(FIELD_QUOTE_BID_PRICE))
                {
                    bidPrice = float.Parse(keyValuePairs[key]);
                }
                else if(key.Equals(FIELD_QUOTE_ASK_PRICE))
                {
                    askPrice = float.Parse(keyValuePairs[key]);
                }
                else if (key.Equals(FIELD_QUOTE_lAST_PRICE))
                {
                    lastPrice = float.Parse(keyValuePairs[key]);
                }
            }
        }
        //        "bidSize": 0,
        //  "bidId": "string",
        //  "askPrice": 0,
        //  "askSize": 0,
        //  "askId": "string",
        //  "lastSize": 0,
        //  "lastId": "string",
        //  "openPrice": 0,
        //  "highPrice": 0,
        //  "lowPrice": 0,
        //  "closePrice": 0,
        //  "netChange": 0,
        //  "totalVolume": 0,
        //  "quoteTimeInLong": 0,
        //  "tradeTimeInLong": 0,
        //  "mark": 0,
        //  "exchange": "string",
        //  "exchangeName": "string",
        //  "marginable": false,
        //  "shortable": false,
        //  "volatility": 0,
        //  "digits": 0,
        //  "52WkHigh": 0,
        //  "52WkLow": 0,
        //  "peRatio": 0,
        //  "divAmount": 0,
        //  "divYield": 0,
        //  "divDate": "string",
        //  "securityStatus": "string",
        //  "regularMarketLastPrice": 0,
        //  "regularMarketLastSize": 0,
        //  "regularMarketNetChange": 0,
        //  "regularMarketTradeTimeInLong": 0
        //}
    }
}
