using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.Model
{
    public class FutureQuote : StockQuote
    {
        public FutureQuote() : base() { }
        public FutureQuote(Dictionary<String, string> keyValuePairs) : base(keyValuePairs)
        {
        }


    }
}
