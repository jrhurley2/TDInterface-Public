//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TdInterface.Model;

//namespace TdInterface.TradeStation.Tests
//{
//    [TestClass()]
//    public class TradeStationHelperTests
//    {
//        [TestMethod()]
//        public void SetStockQuoteTest()
//        {
//            var expectedAaplQuote = new StockQuote
//            {
//                symbol = "AAPL",
//                askPrice = 140.0,
//                bidPrice = 139.95,
//                lastPrice = 139.98
//            };

//            var helper = new TradeStationHelper(new AccountInfo());
//            var actual = helper.SetStockQuote(expectedAaplQuote);

//            Assert.AreEqual(expectedAaplQuote.lastPrice, actual.lastPrice);
//            Assert.AreEqual(expectedAaplQuote.askPrice, actual.askPrice);
//            Assert.AreEqual(expectedAaplQuote.bidPrice, actual.bidPrice);
//            Assert.AreEqual(expectedAaplQuote.symbol, actual.symbol);
//        }

//        [TestMethod()]
//        public void SetStockQuoteTest_Incremental()
//        {
//            var initialAaplQuote = new StockQuote
//            {
//                symbol = "AAPL",
//                askPrice = 140.0,
//                bidPrice = 139.95,
//                lastPrice = 139.98
//            };

//            var helper = new TradeStationHelper(new AccountInfo());
//            var _ = helper.SetStockQuote(initialAaplQuote);

//            var incrementalQuote = new StockQuote
//            {
//                symbol = "AAPL",
//                bidPrice = 139.96
//            };

//            var actual = helper.SetStockQuote(incrementalQuote);

//            Assert.AreEqual(initialAaplQuote.lastPrice, actual.lastPrice);
//            Assert.AreEqual(initialAaplQuote.askPrice, actual.askPrice);
//            Assert.AreEqual(incrementalQuote.bidPrice, actual.bidPrice);
//            Assert.AreEqual(initialAaplQuote.symbol, actual.symbol);
//        }


//        [TestMethod()]
//        public void GetStockQuoteTest()
//        {
//            var expectedAaplQuote = new StockQuote
//            {
//                symbol = "AAPL",
//                askPrice = 140.0,
//                bidPrice = 139.95,
//                lastPrice = 139.98
//            };

//            var helper = new TradeStationHelper(new AccountInfo());

//            var _ = helper.SetStockQuote(expectedAaplQuote);

//            var actual = helper.GetStockQuote(expectedAaplQuote.symbol);

//            Assert.AreEqual(expectedAaplQuote.lastPrice, actual.lastPrice);
//            Assert.AreEqual(expectedAaplQuote.askPrice, actual.askPrice);
//            Assert.AreEqual(expectedAaplQuote.bidPrice, actual.bidPrice);
//            Assert.AreEqual(expectedAaplQuote.symbol, actual.symbol);
//        }
//    }
//}