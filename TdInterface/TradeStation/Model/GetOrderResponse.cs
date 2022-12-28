using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.TradeStation.Model
{

    public class GetOrderResponse
    {
        public Order[] Orders { get; set; }
        public object[] Errors { get; set; }
        public string NextToken { get; set; }
    }
}
