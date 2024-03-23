using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
//using TdInterface.Model;

namespace TdInterface.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        private MainForm _mainForm;

        [TestInitialize()]
        public void Init()
        {
        }


        [TestMethod()]
        [ExpectedException(typeof(DailyLossExceededException))]
        public void CreateGenericTriggerOcoOrder_DailyLoss_Exceeded()
        {

            var settings = new Settings();
            settings.MaxLossLimitInR = 3;
            settings.MaxRisk = 5;
            settings.EnableMaxLossLimit = true;

            var quote = new Model.StockQuote { symbol = "AAPL", bidPrice = 150, lastPrice = 150.01, askPrice = 150.02 };
            var initialBalances = new Initialbalances { liquidationValue = 2500 };
            var currentBalances = new Currentbalances { liquidationValue = 2484 };
            var securitiesAccount = new Securitiesaccount { currentBalances = currentBalances, initialBalances = initialBalances };

            var actual = MainForm.CreateGenericTriggerOcoOrder(quote, "MARKET", "AAPL", Brokerage.BUY, 0.0, 149.92, false, 5, securitiesAccount.DailyPnL, false, settings);
        }

        [TestMethod()]
        [ExpectedException(typeof(DailyLossExceededException))]
        public void CreateGenericTriggerOcoOrder_DailyLoss_Will_Be_Exceeded()
        {

            var settings = new Settings();
            settings.MaxLossLimitInR = 3;
            settings.MaxRisk = 5;
            settings.EnableMaxLossLimit = true;
            settings.PreventRiskExceedMaxLoss = true;

            var quote = new Model.StockQuote { symbol = "AAPL", bidPrice = 150, lastPrice = 150.01, askPrice = 150.02 };
            var initialBalances = new Initialbalances { liquidationValue = 2500 };
            var currentBalances = new Currentbalances { liquidationValue = 2489 };
            var securitiesAccount = new Securitiesaccount { currentBalances = currentBalances, initialBalances = initialBalances };

            var actual = MainForm.CreateGenericTriggerOcoOrder(quote, "MARKET", "AAPL", Brokerage.BUY, 0.0, 149.92, false, 5, securitiesAccount.DailyPnL, false, settings);
        }

        [TestMethod()]
        public void CreateGenericTriggerOcoOrder_DailyLoss_Will_Be_Exceeded_AdjustRisk()
        {

            var settings = new Settings();
            settings.MaxLossLimitInR = 3;
            settings.MaxRisk = 5;
            settings.EnableMaxLossLimit = true;
            settings.PreventRiskExceedMaxLoss = true;
            settings.AdjustRiskNotExceedMaxLoss = true;
            settings.UseBidAskOcoCalc = false;


            var quote = new Model.StockQuote { symbol = "AAPL", bidPrice = 149.99, lastPrice = 150.0, askPrice = 150.01 };
            var initialBalances = new Initialbalances { liquidationValue = 2500 };
            var currentBalances = new Currentbalances { liquidationValue = 2489 };
            var securitiesAccount = new Securitiesaccount { currentBalances = currentBalances, initialBalances = initialBalances };

            var expectedRiskPerShare = .20;
            var stop = quote.lastPrice - expectedRiskPerShare;

            var expectedShares = Convert.ToInt32(((settings.MaxLossLimitInR * settings.MaxRisk) + Convert.ToDecimal(securitiesAccount.DailyPnL)) / Convert.ToDecimal(expectedRiskPerShare));

            var actual = MainForm.CreateGenericTriggerOcoOrder(quote, "MARKET", "AAPL", Brokerage.BUY, 0.0, stop, false, 5, securitiesAccount.DailyPnL, false, settings);

            Assert.AreEqual(expectedShares, actual.orderLegCollection[0].quantity);
        }

        [TestMethod]
        public void CheckMaxRisk_Under_Daily()
        {
            double expectedMaxRisk = 5;
            double dailyPnl = 0;
            Settings settings = new Settings()
            {
                EnableMaxLossLimit = true,
                MaxRisk = 5,
                MaxLossLimitInR = 3,
                AdjustRiskNotExceedMaxLoss = false,
            };
            //var actual = Brokerage.CheckMaxRisk(expectedMaxRisk, dailyPnl, settings);

            //Assert.AreEqual(expectedMaxRisk, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DailyLossExceededException))]
        public void CheckMaxRisk_Over_Daily_ExpectException()
        {
            double expectedMaxRisk = 5;
            double dailyPnl = -16;
            Settings settings = new Settings()
            {
                EnableMaxLossLimit = true,
                MaxRisk = 5,
                MaxLossLimitInR = 3,
                AdjustRiskNotExceedMaxLoss = false,
            };
            //var actual = Brokerage.CheckMaxRisk(expectedMaxRisk, dailyPnl, settings);
        }

        [TestMethod()]
        public void AddInitialOrderTest()
        {
            var initialOrders = new Dictionary<string, List<ulong>>();


            initialOrders.Add("TEST", new List<ulong>());
            initialOrders["TEST"].Add(1234UL);

            Assert.IsTrue(initialOrders["TEST"].Contains(1234UL));

        }
    }
}