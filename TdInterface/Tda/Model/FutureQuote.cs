using System.Collections.Generic;

namespace EZTM.Forms.UI.Tda.Model
{
    public class FutureQuote : StockQuote
    {
        public FutureQuote() : base() { }
        public FutureQuote(Dictionary<string, string> keyValuePairs) : base(keyValuePairs)
        {
        }


    }
}
