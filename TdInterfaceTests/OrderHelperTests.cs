using Microsoft.VisualStudio.TestTools.UnitTesting;
using TdInterface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TdInterface.Tests
{
    [TestClass()]
    public class OrderHelperTests
    {
        [TestMethod()]
        public void CreateTriggerOcoOrderTest_Buy_Market()
        {
            var expectedOrderStrategyType = "TRIGGER";

            var expectedTriggerOrderType = "MARKET";
            var expectedSymbol = "AAPL";
            var expectedTriggerQuantity = 100;
            var expectedTriggerLimit = 0.0D;
            var expectedLimitQuantity = 25;
            var expectedInstruction = "BUY";
            var expectedStopPrice = 147.00D;
            var expectedLimitPrice = 148.00D;

            var expectedChildStrategy = "OCO";


            var actual = OrderHelper.CreateTriggerOcoOrder(expectedTriggerOrderType, expectedSymbol, expectedTriggerQuantity, expectedTriggerLimit, expectedLimitQuantity, expectedInstruction, expectedStopPrice, expectedLimitPrice);

            Assert.AreEqual(expectedOrderStrategyType, actual.orderStrategyType);
            Assert.AreEqual(expectedTriggerOrderType, actual.orderType);
            Assert.AreEqual(expectedSymbol, actual.orderLegCollection[0].instrument.symbol, expectedSymbol);
            Assert.AreEqual(expectedTriggerQuantity, actual.orderLegCollection[0].quantity);
            Assert.IsNull(actual.price);

            Assert.AreEqual(expectedChildStrategy, actual.childOrderStrategies[0].orderStrategyType);

            var stopOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "STOP").FirstOrDefault();
            Assert.IsNotNull(stopOrder);
            Assert.AreEqual(expectedSymbol, stopOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("STOP", stopOrder.orderType);
            Assert.AreEqual("SELL", stopOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedStopPrice.ToString("0.00"), stopOrder.stopPrice);


            var limitOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "LIMIT").FirstOrDefault();
            Assert.IsNotNull(limitOrder);
            Assert.AreEqual(expectedSymbol, limitOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("LIMIT", limitOrder.orderType);
            Assert.AreEqual("SELL", limitOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedLimitPrice.ToString("0.00"), limitOrder.price);


        }

        [TestMethod]
        public void CreateTriggerOcoOrderTest_Buy_Limit()
        {
            var expectedOrderStrategyType = "TRIGGER";

            var expectedTriggerOrderType = "LIMIT";
            var expectedSymbol = "AAPL";
            var expectedTriggerQuantity = 100;
            var expectedTriggerLimit = 147.50;
            var expectedLimitQuantity = 25;
            var expectedInstruction = "BUY";
            var expectedStopPrice = 147.00D;
            var expectedLimitPrice = 148.00D;

            var expectedChildStrategy = "OCO";


            var actual = OrderHelper.CreateTriggerOcoOrder(expectedTriggerOrderType, expectedSymbol, expectedTriggerQuantity, expectedTriggerLimit, expectedLimitQuantity, expectedInstruction, expectedStopPrice, expectedLimitPrice);

            Assert.AreEqual(expectedOrderStrategyType, actual.orderStrategyType);
            Assert.AreEqual(expectedTriggerOrderType, actual.orderType);
            Assert.AreEqual(expectedSymbol, actual.orderLegCollection[0].instrument.symbol, expectedSymbol);
            Assert.AreEqual(expectedTriggerQuantity, actual.orderLegCollection[0].quantity);
            Assert.AreEqual(expectedTriggerLimit.ToString("#.00"), actual.price);

            Assert.AreEqual(expectedChildStrategy, actual.childOrderStrategies[0].orderStrategyType);

            var stopOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "STOP").FirstOrDefault();
            Assert.IsNotNull(stopOrder);
            Assert.AreEqual(expectedSymbol, stopOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("STOP", stopOrder.orderType);
            Assert.AreEqual("SELL", stopOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedStopPrice.ToString("0.00"), stopOrder.stopPrice);


            var limitOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "LIMIT").FirstOrDefault();
            Assert.IsNotNull(limitOrder);
            Assert.AreEqual(expectedSymbol, limitOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("LIMIT", limitOrder.orderType);
            Assert.AreEqual("SELL", limitOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedLimitPrice.ToString("0.00"), limitOrder.price);
        }

        [TestMethod()]
        public void CreateTriggerOcoOrderTest_Sell_Market()
        {
            var expectedOrderStrategyType = "TRIGGER";

            var expectedTriggerOrderType = "MARKET";
            var expectedSymbol = "AAPL";
            var expectedTriggerQuantity = 100;
            var expectedTriggerLimit = 0.0D;
            var expectedLimitQuantity = 25;
            var expectedInstruction = "Sell";
            var expectedStopPrice = 148.00D;
            var expectedLimitPrice = 147.00D;

            var expectedChildStrategy = "OCO";


            var actual = OrderHelper.CreateTriggerOcoOrder(expectedTriggerOrderType, expectedSymbol, expectedTriggerQuantity, expectedTriggerLimit, expectedLimitQuantity, expectedInstruction, expectedStopPrice, expectedLimitPrice);

            Assert.AreEqual(expectedOrderStrategyType, actual.orderStrategyType);
            Assert.AreEqual(expectedTriggerOrderType, actual.orderType);
            Assert.AreEqual(expectedSymbol, actual.orderLegCollection[0].instrument.symbol, expectedSymbol);
            Assert.AreEqual(expectedTriggerQuantity, actual.orderLegCollection[0].quantity);
            Assert.IsNull(actual.price);

            Assert.AreEqual(expectedChildStrategy, actual.childOrderStrategies[0].orderStrategyType);

            var stopOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "STOP").FirstOrDefault();
            Assert.IsNotNull(stopOrder);
            Assert.AreEqual(expectedSymbol, stopOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("STOP", stopOrder.orderType);
            Assert.AreEqual("BUY", stopOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedStopPrice.ToString("0.00"), stopOrder.stopPrice);


            var limitOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "LIMIT").FirstOrDefault();
            Assert.IsNotNull(limitOrder);
            Assert.AreEqual(expectedSymbol, limitOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("LIMIT", limitOrder.orderType);
            Assert.AreEqual("BUY", limitOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedLimitPrice.ToString("0.00"), limitOrder.price);
        }

        [TestMethod]
        public void CreateTriggerOcoOrderTest_Sell_Limit()
        {
            var expectedOrderStrategyType = "TRIGGER";

            var expectedTriggerOrderType = "LIMIT";
            var expectedSymbol = "AAPL";
            var expectedTriggerQuantity = 100;
            var expectedTriggerLimit = 147.50;
            var expectedLimitQuantity = 25;
            var expectedInstruction = "SELL";
            var expectedStopPrice = 148.00D;
            var expectedLimitPrice = 147.00D;

            var expectedChildStrategy = "OCO";


            var actual = OrderHelper.CreateTriggerOcoOrder(expectedTriggerOrderType, expectedSymbol, expectedTriggerQuantity, expectedTriggerLimit, expectedLimitQuantity, expectedInstruction, expectedStopPrice, expectedLimitPrice);

            Assert.AreEqual(expectedOrderStrategyType, actual.orderStrategyType);
            Assert.AreEqual(expectedTriggerOrderType, actual.orderType);
            Assert.AreEqual(expectedSymbol, actual.orderLegCollection[0].instrument.symbol, expectedSymbol);
            Assert.AreEqual(expectedTriggerQuantity, actual.orderLegCollection[0].quantity);
            Assert.AreEqual(expectedTriggerLimit.ToString("#.00"), actual.price);

            Assert.AreEqual(expectedChildStrategy, actual.childOrderStrategies[0].orderStrategyType);

            var stopOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "STOP").FirstOrDefault();
            Assert.IsNotNull(stopOrder);
            Assert.AreEqual(expectedSymbol, stopOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("STOP", stopOrder.orderType);
            Assert.AreEqual("BUY", stopOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedStopPrice.ToString("0.00"), stopOrder.stopPrice);


            var limitOrder = actual.childOrderStrategies[0].childOrderStrategies.Where(o => o.orderType == "LIMIT").FirstOrDefault();
            Assert.IsNotNull(limitOrder);
            Assert.AreEqual(expectedSymbol, limitOrder.orderLegCollection[0].instrument.symbol);
            Assert.AreEqual("LIMIT", limitOrder.orderType);
            Assert.AreEqual("BUY", limitOrder.orderLegCollection[0].instruction);
            Assert.AreEqual(expectedLimitPrice.ToString("0.00"), limitOrder.price);
        }

    }
}