using Microsoft.VisualStudio.TestTools.UnitTesting;
using TdInterface.Tda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TdInterface.Tda.Tests
{
    [TestClass()]
    public class TdHelperTests
    {
        [TestMethod()]
        public void SetStockQuoteTest()
        {
            var expectedAaplQuote = new TdInterface.Model.StockQuote
            {
                symbol = "AAPL",
                askPrice = 140.0,
                bidPrice = 139.95,
                lastPrice = 139.98
            };

            TdHelper helper = new TdHelper();
            var actual = helper.SetStockQuote(expectedAaplQuote);

            Assert.AreEqual(expectedAaplQuote.lastPrice, actual.lastPrice);
            Assert.AreEqual(expectedAaplQuote.askPrice, actual.askPrice);
            Assert.AreEqual(expectedAaplQuote.bidPrice, actual.bidPrice);
            Assert.AreEqual(expectedAaplQuote.symbol, actual.symbol);
        }

        [TestMethod()]
        public void SetStockQuoteTest_Incremental()
        {
            var initialAaplQuote = new TdInterface.Model.StockQuote
            {
                symbol = "AAPL",
                askPrice = 140.0,
                bidPrice = 139.95,
                lastPrice = 139.98
            };

            TdHelper helper = new TdHelper();
            var _ = helper.SetStockQuote(initialAaplQuote);

            var incrementalQuote = new TdInterface.Model.StockQuote
            {
                symbol = "AAPL",
                bidPrice = 139.96
            };

            var actual = helper.SetStockQuote(incrementalQuote);

            Assert.AreEqual(initialAaplQuote.lastPrice, actual.lastPrice);
            Assert.AreEqual(initialAaplQuote.askPrice, actual.askPrice);
            Assert.AreEqual(incrementalQuote.bidPrice, actual.bidPrice);
            Assert.AreEqual(initialAaplQuote.symbol, actual.symbol);
        }




        [TestMethod()]
        public void GetStockQuoteTest()
        {
            var expectedAaplQuote = new TdInterface.Model.StockQuote
            {
                symbol = "AAPL",
                askPrice = 140.0,
                bidPrice = 139.95,
                lastPrice = 139.98
            };

            TdHelper helper = new TdHelper();
            var _ = helper.SetStockQuote(expectedAaplQuote);

            var actual = helper.GetStockQuote(expectedAaplQuote.symbol);

            Assert.AreEqual(expectedAaplQuote.lastPrice, actual.lastPrice);
            Assert.AreEqual(expectedAaplQuote.askPrice, actual.askPrice);
            Assert.AreEqual(expectedAaplQuote.bidPrice, actual.bidPrice);
            Assert.AreEqual(expectedAaplQuote.symbol, actual.symbol);
        }

    }
}