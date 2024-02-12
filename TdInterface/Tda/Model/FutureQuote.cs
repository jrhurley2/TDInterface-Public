using System.Collections.Generic;

namespace TdInterface.Tda.Model
{
    public class FutureQuote : StockQuote
    {
        public FutureQuote() : base() { }
        public FutureQuote(Dictionary<string, string> keyValuePairs) : base(keyValuePairs)
        {
        }


    }
}
