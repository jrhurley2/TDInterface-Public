﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDAmeritradeAPI.Client;
using Websocket.Client;
using Moq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Diagnostics;
//using TdInterface.Model;
using TdInterface.Tda;
using TdInterface.Tda.Model;

namespace TdInterface.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        private MainForm _mainForm;

        [TestInitialize()]
        public void Init() 
        {
            var mockStreamer = new Mock<Interfaces.IStreamer>();
            var mockHelper = new Mock<Interfaces.IHelper>();

            _mainForm = new MainForm(mockStreamer.Object, new Settings(), "name", "accountId", mockHelper.Object);
        }

        [TestMethod()]
        [ExpectedException(typeof(DailyLossExceededException))]
        public void CreateGenericTriggerOcoOrder_DailyLoss_Exceeded()
        {

            var settings = new Settings();
            settings.MaxLossLimitInR = 3;
            settings.MaxRisk = 5;
            settings.EnableMaxLossLimit = true;

            var quote = new StockQuote { symbol = "AAPL", bidPrice = 150, lastPrice = 150.01, askPrice = 150.02 };
            var initialBalances = new Initialbalances { liquidationValue = 2500 };
            var currentBalances = new Currentbalances { liquidationValue = 2484 };
            var securitiesAccount = new Securitiesaccount { currentBalances = currentBalances, initialBalances= initialBalances };

            var actual = _mainForm.CreateGenericTriggerOcoOrder(quote, "MARKET", "AAPL", TDAOrderHelper.BUY, 0.0, 149.92, false, 5, securitiesAccount.DailyPnL, settings);
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

            var quote = new StockQuote { symbol = "AAPL", bidPrice = 150, lastPrice = 150.01, askPrice = 150.02 };
            var initialBalances = new Initialbalances { liquidationValue = 2500 };
            var currentBalances = new Currentbalances { liquidationValue = 2489 };
            var securitiesAccount = new Securitiesaccount { currentBalances = currentBalances, initialBalances = initialBalances };

            var actual = _mainForm.CreateGenericTriggerOcoOrder(quote, "MARKET", "AAPL", TDAOrderHelper.BUY, 0.0, 149.92, false, 5, securitiesAccount.DailyPnL, settings);
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


            var quote = new StockQuote { symbol = "AAPL", bidPrice = 149.99, lastPrice = 150.0, askPrice = 150.01 };
            var initialBalances = new Initialbalances { liquidationValue = 2500 };
            var currentBalances = new Currentbalances { liquidationValue = 2489 };
            var securitiesAccount = new Securitiesaccount { currentBalances = currentBalances, initialBalances = initialBalances };

            var expectedRiskPerShare = .20;
            var stop = quote.lastPrice - expectedRiskPerShare;

            var expectedShares = Convert.ToInt32( ((settings.MaxLossLimitInR * settings.MaxRisk) + Convert.ToDecimal(securitiesAccount.DailyPnL)) / Convert.ToDecimal(expectedRiskPerShare));

            var actual = _mainForm.CreateGenericTriggerOcoOrder(quote, "MARKET", "AAPL", TDAOrderHelper.BUY, 0.0, stop, false, 5, securitiesAccount.DailyPnL, settings);
            
            Assert.AreEqual(expectedShares, actual.orderLegCollection[0].quantity);
        }

    }
}