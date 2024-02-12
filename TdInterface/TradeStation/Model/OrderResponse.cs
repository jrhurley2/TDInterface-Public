namespace TdInterface.TradeStation.Model
{

    public class OrderResponses
    {
        public OrderResponse[] Orders { get; set; }
        public ErrorResponse[] Errors { get; set; }
    }

    public class OrderResponse
    {
        public string Message { get; set; }
        public string OrderID { get; set; }
    }

    public class ErrorResponse
    {
        public string Error { get; set; }
        public string Message { get; set; }
        public string OrderID { get; set; }
    }

}
