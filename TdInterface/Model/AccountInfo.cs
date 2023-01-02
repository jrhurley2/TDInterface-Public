using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.Model
{
    public class AccountInfo
    {
        public bool LoginTda { get;set; }
        public string TdaConsumerKey { get; set; }
        
        public bool LoginTradeStation { get; set; }
        public string TradeStationClientId { get; set; }
        public string TradeStationClientSecret { get; set; }
        public bool TradeStationUseSimAccount { get; set; }
    }
}
