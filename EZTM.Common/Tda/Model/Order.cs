namespace EZTM.Common.Tda.Model
{
    public class Order
    {
        public string orderId { get; set; }
        public string orderType { get; set; }
        public string session { get; set; }
        public string duration { get; set; }
        public string price { get; set; }
        public string stopPrice { get; set; }
        public string orderStrategyType { get; set; }
        public string status { get; set; }
        public List<OrderLeg> orderLegCollection { get; set; }

        public List<Order> childOrderStrategies { get; set; }
    }


    public class OrderLeg
    {
        public string instruction { get; set; }
        public float quantity { get; set; }
        public Instrument instrument { get; set; }
    }

}
