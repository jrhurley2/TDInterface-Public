using System;
using System.Collections.Generic;
using System.Text;

namespace TdInterface.TradeStation.Model
{

    public class BalanceResponse
    {
        public Balance[] Balances { get; set; }
        public BalanceResponseError[] Errors { get; set; }
    }

    public class Balance
    {
        public string AccountID { get; set; }
        public string AccountType { get; set; }
        public string CashBalance { get; set; }
        public string BuyingPower { get; set; }
        public string Equity { get; set; }
        public string MarketValue { get; set; }
        public string TodaysProfitLoss { get; set; }
        public string UnclearedDeposit { get; set; }
        public Balancedetail BalanceDetail { get; set; }
        public string Commission { get; set; }
        public Currencydetail[] CurrencyDetails { get; set; }
    }

    public class Balancedetail
    {
        public string CostOfPositions { get; set; }
        public string DayTrades { get; set; }
        public string MaintenanceRate { get; set; }
        public string OptionBuyingPower { get; set; }
        public string OptionsMarketValue { get; set; }
        public string OvernightBuyingPower { get; set; }
        public string RequiredMargin { get; set; }
        public string RealizedProfitLoss { get; set; }
        public string UnrealizedProfitLoss { get; set; }
        public string DayTradeExcess { get; set; }
        public string DayTradeOpenOrderMargin { get; set; }
        public string OpenOrderMargin { get; set; }
        public string DayTradeMargin { get; set; }
        public string InitialMargin { get; set; }
        public string MaintenanceMargin { get; set; }
        public string TradeEquity { get; set; }
        public string SecurityOnDeposit { get; set; }
        public string TodayRealTimeTradeEquity { get; set; }
    }

    public class Currencydetail
    {
        public string Currency { get; set; }
        public string Commission { get; set; }
        public string CashBalance { get; set; }
        public string RealizedProfitLoss { get; set; }
        public string UnrealizedProfitLoss { get; set; }
        public string InitialMargin { get; set; }
        public string MaintenanceMargin { get; set; }
        public string AccountConversionRate { get; set; }
    }

    public class BalanceResponseError
    {
        public string AccountID { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
    }
}
