using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TdInterface.Model
{

    public class Rootobject
    {
        public Securitiesaccount securitiesAccount { get; set; }
    }

    public class Securitiesaccount
    {
        public static Securitiesaccount ParseJson(string json)
        {
            return JsonConvert.DeserializeObject<Rootobject>(json).securitiesAccount;
        }

        public string type { get; set; }
        public string accountId { get; set; }
        public int roundTrips { get; set; }
        public bool isDayTrader { get; set; }
        public bool isClosingOnlyRestricted { get; set; }
        public Position[] positions { get; set; }
        public Initialbalances initialBalances { get; set; }
        public Currentbalances currentBalances { get; set; }
        public Projectedbalances projectedBalances { get; set; }
        public Order[] orderStrategies { get; set; }

        public List<Order> FlatOrders
        {
            get
            {
                return this.orderStrategies != null ? FlattenOrders(this.orderStrategies.ToList<Order>()) : new List<Order>();
            }
        }

        public float DailyPnL
        {
            get
            {
                return this.currentBalances.liquidationValue - this.initialBalances.liquidationValue;
                    //return this.positions != null ? this.positions.Where(p => p.instrument.assetType == "EQUITY").Sum(p => p.currentDayProfitLoss) : 0;
            }
        }

        private static List<Order> FlattenOrders(List<Order> orders)
        {
            List<Order> result = new List<Order>();

            foreach (var order in orders)
            {
                result.Add(order);
                if (order.childOrderStrategies != null && order.childOrderStrategies.Count > 0)
                {
                    var childOrders = FlattenOrders(order.childOrderStrategies);
                    foreach (var childOrderStrategy in childOrders)
                    {
                        result.Add((Order)childOrderStrategy);
                    }
                }

            }
            return result;
        }


    }

    public class Initialbalances
    {
        public float accruedInterest { get; set; }
        public float availableFundsNonMarginableTrade { get; set; }
        public float bondValue { get; set; }
        public float buyingPower { get; set; }
        public float cashBalance { get; set; }
        public float cashAvailableForTrading { get; set; }
        public float cashReceipts { get; set; }
        public float dayTradingBuyingPower { get; set; }
        public float dayTradingBuyingPowerCall { get; set; }
        public float dayTradingEquityCall { get; set; }
        public float equity { get; set; }
        public float equityPercentage { get; set; }
        public float liquidationValue { get; set; }
        public float longMarginValue { get; set; }
        public float longOptionMarketValue { get; set; }
        public float longStockValue { get; set; }
        public float maintenanceCall { get; set; }
        public float maintenanceRequirement { get; set; }
        public float margin { get; set; }
        public float marginEquity { get; set; }
        public float moneyMarketFund { get; set; }
        public float mutualFundValue { get; set; }
        public float regTCall { get; set; }
        public float shortMarginValue { get; set; }
        public float shortOptionMarketValue { get; set; }
        public float shortStockValue { get; set; }
        public float totalCash { get; set; }
        public bool isInCall { get; set; }
        public float pendingDeposits { get; set; }
        public float marginBalance { get; set; }
        public float shortBalance { get; set; }
        public float accountValue { get; set; }
    }

    public class Currentbalances
    {
        public float accruedInterest { get; set; }
        public float cashBalance { get; set; }
        public float cashReceipts { get; set; }
        public float longOptionMarketValue { get; set; }
        public float liquidationValue { get; set; }
        public float longMarketValue { get; set; }
        public float moneyMarketFund { get; set; }
        public float savings { get; set; }
        public float shortMarketValue { get; set; }
        public float pendingDeposits { get; set; }
        public float availableFunds { get; set; }
        public float availableFundsNonMarginableTrade { get; set; }
        public float buyingPower { get; set; }
        public float buyingPowerNonMarginableTrade { get; set; }
        public float dayTradingBuyingPower { get; set; }
        public float equity { get; set; }
        public float equityPercentage { get; set; }
        public float longMarginValue { get; set; }
        public float maintenanceCall { get; set; }
        public float maintenanceRequirement { get; set; }
        public float marginBalance { get; set; }
        public float regTCall { get; set; }
        public float shortBalance { get; set; }
        public float shortMarginValue { get; set; }
        public float shortOptionMarketValue { get; set; }
        public float sma { get; set; }
        public float mutualFundValue { get; set; }
        public float bondValue { get; set; }
    }

    public class Projectedbalances
    {
        public float availableFunds { get; set; }
        public float availableFundsNonMarginableTrade { get; set; }
        public float buyingPower { get; set; }
        public float dayTradingBuyingPower { get; set; }
        public float dayTradingBuyingPowerCall { get; set; }
        public float maintenanceCall { get; set; }
        public float regTCall { get; set; }
        public bool isInCall { get; set; }
        public float stockBuyingPower { get; set; }
    }
}
