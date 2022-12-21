using System;
using System.Collections.Generic;
using System.Text;

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
