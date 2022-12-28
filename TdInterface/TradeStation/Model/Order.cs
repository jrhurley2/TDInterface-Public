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
        public string CommissionFee { get; set; }
        public string Currency { get; set; }
        public string Duration { get; set; }
        public DateTime GoodTillDate { get; set; }
        public Leg[] Legs { get; set; }
        public Marketactivationrule[] MarketActivationRules { get; set; }
        public string OrderID { get; set; }
        public DateTime OpenedDateTime { get; set; }
        public string OrderType { get; set; }
        public string PriceUsedForBuyingPower { get; set; }
        public string Routing { get; set; }
        public string Status { get; set; }
        public string StatusDescription { get; set; }
        public string AdvancedOptions { get; set; }
        public Timeactivationrule[] TimeActivationRules { get; set; }
        public string UnbundledRouteFee { get; set; }
        public DateTime ClosedDateTime { get; set; }
        public string FilledPrice { get; set; }
        public Conditionalorder[] ConditionalOrders { get; set; }
        public string GroupName { get; set; }
        public string LimitPrice { get; set; }
        public string StopPrice { get; set; }



        public string Symbol { get; set; }
        public string Quantity { get; set; }
        public string TradeAction { get; set; }
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

    public class Leg
    {
        public string OpenOrClose { get; set; }
        public string QuantityOrdered { get; set; }
        public string ExecQuantity { get; set; }
        public string QuantityRemaining { get; set; }
        public string BuyOrSell { get; set; }
        public string Symbol { get; set; }
        public string AssetType { get; set; }
    }

    public class Marketactivationrule
    {
        public string RuleType { get; set; }
        public string Symbol { get; set; }
        public string Predicate { get; set; }
        public string TriggerKey { get; set; }
        public string Price { get; set; }
    }

    public class Timeactivationrule
    {
        public DateTime TimeUtc { get; set; }
    }

    public class Conditionalorder
    {
        public string Relationship { get; set; }
        public string OrderID { get; set; }
    }


}
