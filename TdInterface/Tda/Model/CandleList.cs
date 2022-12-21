using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.Tda.Model
{
    public class CandleList
    {
        public Candle[] candles { get; set; }
        public string symbol { get; set; }
        public bool empty { get; set; }
    }

    public class Candle
    {
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public long datetime { get; set; }
        public DateTimeOffset DateTime { get { return DateTimeOffset.FromUnixTimeMilliseconds(datetime).LocalDateTime; } }
    }

}
