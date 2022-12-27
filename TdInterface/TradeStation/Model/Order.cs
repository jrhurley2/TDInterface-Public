using System;
using System.Collections.Generic;
using System.Printing;
using System.Security.Permissions;
using System.Text;

namespace TdInterface.TradeStation.Model
{
    public class Order
    {
        public string AccountID { get; set; }
        public string Symbol { get; set; }
        public string Quantity { get; set; }
        public string OrderType { get; set; }
        public string TradeAction { get; set; }
        public string StopPrice { get; set; }
        public string LimitPrice { get; set; }
        public string OrderConfirmID { get; set; }
        public TimeInForceRequest TimeInForce { get; set; }
        public List<OrderRequestOSO> OSOs { get; set; } = new List<OrderRequestOSO>();
    }

    public class TimeInForceRequest 
    {
        public string Duration { get; set; }
    }

    public class OrderRequestOSO
    {
        public List<Order> Orders { get; set; }
        public string Type { get; set; }
    }

}
