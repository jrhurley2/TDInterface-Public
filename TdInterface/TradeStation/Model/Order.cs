using System;
using System.Collections.Generic;
using System.Printing;
using System.Text;

namespace TdInterface.TradeStation.Model
{
    internal class Order
    {
        public string AccountID { get; set; }
        public string Symbol { get; set; }
        public string Quantity { get; set; }
        public string OrderType { get; set; }
        public string TradeAction { get; set; }
        public TimeInForceRequest TimeInForce { get; set; }
        public List<OrderRequestOSO> OSOs { get; set; } = new List<OrderRequestOSO>();
    }

    internal class TimeInForceRequest 
    {
        public string Duration { get; set; }
    }

    internal class OrderRequestOSO
    {
        public List<Order> Orders { get; set; }
        public string Type { get; set; }
    }

}
