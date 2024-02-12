using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TdInterface.Tests
{
    [TestClass()]
    public class UtilityTests
    {
        [TestMethod()]
        public void SplitTdaConsumerKey_ConsumerKey()
        {
            var expectedConsumerKey = "TDAConsumerKey";
            var expectedRedirectUri = "http://localhost";

            Utility.SplitTdaConsumerKey(expectedConsumerKey, out string consumerKey, out string redirectUri);

            Assert.AreEqual(expectedConsumerKey, consumerKey);
            Assert.AreEqual(expectedRedirectUri, redirectUri);
        }

        [TestMethod()]
        public void SplitTdaConsumerKey_ConsumerKey_And_RedirectUri()
        {
            var expectedConsumerKey = "TDAConsumerKey";
            var expectedRedirectUri = "http://someotheruri";
            var accountInfoConsumerKey = $"{expectedConsumerKey}~{expectedRedirectUri}";

            Utility.SplitTdaConsumerKey(accountInfoConsumerKey, out string consumerKey, out string redirectUri);

            Assert.AreEqual(expectedConsumerKey, consumerKey);
            Assert.AreEqual(expectedRedirectUri, redirectUri);
        }

    }
}