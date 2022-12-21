using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.Model
{
    public class StockQuote
    {
        public virtual string symbol { get; set; }
        public virtual double bidPrice { get; set; }
        public virtual double askPrice { get; set; }
        public virtual double lastPrice { get; set; }
    }
}
