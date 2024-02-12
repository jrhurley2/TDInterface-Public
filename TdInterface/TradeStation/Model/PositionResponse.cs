using System;

namespace TdInterface.TradeStation.Model
{

    public class PositionResponse
    {
        public Position[] Positions { get; set; }
        public PositionErrorResponse[] Errors { get; set; }
    }

    public class Position
    {
        public string AccountID { get; set; }
        public string AveragePrice { get; set; }
        public string AssetType { get; set; }
        public string Last { get; set; }
        public string Bid { get; set; }
        public string Ask { get; set; }
        public string ConversionRate { get; set; }
        public string DayTradeRequirement { get; set; }
        public string InitialRequirement { get; set; }
        public string PositionID { get; set; }
        public string LongShort { get; set; }
        public string Quantity { get; set; }
        public string Symbol { get; set; }
        public DateTime Timestamp { get; set; }
        public string TodaysProfitLoss { get; set; }
        public string TotalCost { get; set; }
        public string MarketValue { get; set; }
        public string MarkToMarketPrice { get; set; }
        public string UnrealizedProfitLoss { get; set; }
        public string UnrealizedProfitLossPercent { get; set; }
        public string UnrealizedProfitLossQty { get; set; }
    }

    public class PositionErrorResponse
    {
        public string AccountID { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
    }
}
