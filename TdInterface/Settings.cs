using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface
{
    public class Settings
    {
        public bool TradeShares { get; set; }
        public int MaxShares { get; set; }
        public decimal MaxRisk { get; set; }
        public bool UseBidAskOcoCalc { get; set; }
        public int OneRProfitPercenatage { get; set; }
        public bool MoveLimitPriceOnFill { get; set; }
        public bool ReduceStopOnClose { get; set; }
    }
}
