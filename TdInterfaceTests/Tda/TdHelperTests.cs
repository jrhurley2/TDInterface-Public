using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TdInterface.Model;
using TdInterface.Tda.Model;

namespace TdInterface.Tda.Tests
{
    [TestClass()]
    public class TdHelperTests
    {

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            //var expectedAccountInfo = new AccountInfo
            //{
            //    TdaConsumerKey = "tdakey",
            //    UseTdaEquity = true
            //};

            //var _mockUtility = new Mock<Utility>();
            //_mockUtility.Setup(s => s.GetAccountInfo()).Returns(expectedAccountInfo);

        }

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

            TdHelper helper = new TdHelper(new AccountInfo());
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

            TdHelper helper = new TdHelper(new AccountInfo());
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

            TdHelper helper = new TdHelper(new AccountInfo());
            var _ = helper.SetStockQuote(expectedAaplQuote);

            var actual = helper.GetStockQuote(expectedAaplQuote.symbol);

            Assert.AreEqual(expectedAaplQuote.lastPrice, actual.lastPrice);
            Assert.AreEqual(expectedAaplQuote.askPrice, actual.askPrice);
            Assert.AreEqual(expectedAaplQuote.bidPrice, actual.bidPrice);
            Assert.AreEqual(expectedAaplQuote.symbol, actual.symbol);
        }

        //[TestMethod()]
        //public async Task GetAccessTokenTest()
        //{
        //    var expectedAccessToken = "akjdlajfljasdlfjas";
        //    var expectedRefreshToken = "refreshtoken";
        //    var expectedTokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;

        //    var expectedAccessContainer = new AccessTokenContainer
        //    {
        //        AccessToken = expectedAccessToken,
        //        RefreshToken = expectedRefreshToken,
        //    };

        //    Mock<HttpMessageHandler> handlerMock = SetupReturnJson(expectedAccessContainer);

        //    var httpClient = new HttpClient(handlerMock.Object);

        //    var sut = new TdHelper(httpClient, _mockUtility.Object);

        //    var actual = await sut.GetAccessToken("testauthtoken");

        //    Assert.AreEqual(expectedAccessToken, actual.AccessToken);
        //    Assert.AreEqual(expectedRefreshToken, actual.RefreshToken);
        //    Assert.AreEqual(expectedTokenSystem, actual.TokenSystem);
        //}

        private static Mock<HttpMessageHandler> SetupReturnJson(object expectedObject)
        {
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock.Protected()
                   .Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>()
               )
           // prepare the expected response of the mocked http call
           .ReturnsAsync(new HttpResponseMessage()
           {
               StatusCode = HttpStatusCode.OK,
               Content = new StringContent(JsonConvert.SerializeObject(expectedObject)),
           }).Verifiable();
            return handlerMock;
        }
    }
}