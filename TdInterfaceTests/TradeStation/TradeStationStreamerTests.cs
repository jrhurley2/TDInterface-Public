using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TdInterface.Tda.Model;

namespace TdInterface.TradeStation.Tests
{
    [TestClass()]
    public class TradeStationStreamerTests
    {
        [TestMethod()]
        public void FindNewFilledOrderTest()
        {
            var lastOrders = new List<Order>();
            lastOrders.Add(new Order { orderId = "test1", status = "FLL" });
            lastOrders.Add(new Order { orderId = "test2", status = "FLL" });

            var lastSecuritiesAccount = new Securitiesaccount();
            lastSecuritiesAccount.orderStrategies = lastOrders.ToArray();

            lastOrders.Add(new Order { orderId = "NEWoRDER", status = "FLL" });

            var currentSecuritiesAccunt = new Securitiesaccount();
            currentSecuritiesAccunt.orderStrategies = lastOrders.ToArray();

            var actual = TradeStationStreamer.FindNewFilledOrder(lastSecuritiesAccount, currentSecuritiesAccunt);

        }
    }
}