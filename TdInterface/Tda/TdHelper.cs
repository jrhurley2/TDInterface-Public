using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TdInterface.Interfaces;
using TdInterface.Tda.Model;
//using TdInterface.TradeStation.Model;
using Websocket.Client;

namespace TdInterface.Tda
{
    public class TdHelper : IHelper
    {
        public static HttpClient _httpClient = new HttpClient();
        public static Uri BaseUri = new Uri("https://api.tdameritrade.com");
        public const string routeGetToken = "v1/oauth2/token";
        public const string routeGetAccount = "v1/accounts/{0}?fields=positions,orders";
        public const string routeGetAccounts = "v1/accounts";
        public const string routeCancelOrder = "v1/accounts/{0}/orders/{1}";
        public const string routePlaceOrder = "v1/accounts/{0}/orders";
        public const string routeReplaceOrder = "v1/accounts/{0}/orders/{1}";
        public const string routeGetQuote = "v1/marketdata/{0}/quotes";
        //public const string routeGetPriceHistory = "v1/marketdata/{0}/pricehistory?periodType=day&period=2&frequencyType=minute&frequency=1&needExtendedHoursData=true&startDate={1}&endDate={2}";
        public const string routeGetPriceHistory = "v1/marketdata/{0}/pricehistory?periodType=day&frequencyType=minute&frequency=1&needExtendedHoursData=true&startDate={1}&endDate={2}";
        public const string routeGetUserPrincipals = "v1/userprincipals?fields=streamerSubscriptionKeys,streamerConnectionInfo";
        public const string routeGetStreamerSubscriptionKeys = "v1/userprincipals/streamersubscriptionkeys?accountIds={0}";

        private static Securitiesaccount _securitiesaccount;

        public Securitiesaccount Securitiesaccount
        {
            get
            {
                return _securitiesaccount;
            }
            set
            {
                _securitiesaccount = value;
            }
        }


        public async Task<AccessTokenContainer> GetAccessToken(string authToken)
        {
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
            postData.Add(new KeyValuePair<string, string>("code", $"{authToken}"));
            postData.Add(new KeyValuePair<string, string>("client_id", $"{Utility.GetConsumerKey()}@AMER.OAUTHTD"));
            postData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost"));

            FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
            var rawSTring = await content.ReadAsStringAsync();
            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseUri, routeGetToken)) //Uri."https://api.tdameritrade.com/v1/oauth2/token"); // ; 
            {
                Method = HttpMethod.Post,
                Content = content
            };

            var response = await _httpClient.SendAsync(request);

            var accessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
            accessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;
            return accessTokenContainer;
        }

        public async Task<AccessTokenContainer> RefreshAccessToken(AccessTokenContainer accessTokenContainer)
        {
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                //postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
                postData.Add(new KeyValuePair<string, string>("refresh_token", accessTokenContainer.RefreshToken));
                postData.Add(new KeyValuePair<string, string>("client_id", $"{Utility.GetConsumerKey()}@AMER.OAUTHTD"));
                //postData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost"));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                var rawSTring = await content.ReadAsStringAsync();
                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseUri, routeGetToken)) //Uri."https://api.tdameritrade.com/v1/oauth2/token"); // ; 
                {
                    Method = HttpMethod.Post,
                    Content = content
                };

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

                var newAccessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
                //Add the refresh token back as it doesn't come back with the payload.
                newAccessTokenContainer.RefreshToken = accessTokenContainer.RefreshToken;
                newAccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;

                return newAccessTokenContainer;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public async Task<Securitiesaccount> GetAccount(AccessTokenContainer accessTokenContainer, string accountId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetAccount, accountId)))
            {
                Method = HttpMethod.Get,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

            var securitiesaccount = Securitiesaccount.ParseJson(await response.Content.ReadAsStringAsync());
            Debug.WriteLine(JsonConvert.SerializeObject(securitiesaccount));

            return securitiesaccount;
        }

        public async Task<List<Account>> GetAccounts(AccessTokenContainer accessTokenContainer)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts))
            {
                Method = HttpMethod.Get,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request);
            var account = Utility.DeserializeJsonFromStream<List<Account>>(await response.Content.ReadAsStreamAsync());

            return account;
        }

        public async Task<StockQuote> GetStockQuote(AccessTokenContainer accessTokenContainer, string symbol)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetQuote, symbol)))
            {
                Method = HttpMethod.Get,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request);
            var stockQuote = Utility.DeserializeJsonFromStream<Dictionary<string, StockQuote>>(await response.Content.ReadAsStreamAsync());

            return stockQuote[symbol.ToUpper()];
        }

        public async Task<CandleList> GetPriceHistoryAsync(AccessTokenContainer accessTokenContainer, string symbol)
        {
            var today = DateTimeOffset.Now;
            var startDate = new DateTimeOffset(today.Year, today.Month, today.Day, 4, 00, 00, new TimeSpan(-4, 0, 0));
            var endDate = new DateTimeOffset(today.Year, today.Month, today.Day, 19, 00, 00, new TimeSpan(-4, 0, 0));
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetPriceHistory, symbol, startDate.ToUnixTimeMilliseconds(), endDate.ToUnixTimeMilliseconds())))
            {
                Method = HttpMethod.Get,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request);
            var candleList = Utility.DeserializeJsonFromStream<CandleList>(await response.Content.ReadAsStreamAsync());

            foreach(var candle in candleList.candles)
            {
                Debug.WriteLine($"{candle.DateTime},{candle.open},{candle.close},{candle.high},{candle.low},{candle.volume}");
            }

            return candleList;
        }

        //public async Task<ulong> PlaceOrder(AccessTokenContainer accessTokenContainer, UserPrincipal userPrincipal, Order order)
        public async Task<ulong> PlaceOrder(AccessTokenContainer accessTokenContainer, string accountId, Order order)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routePlaceOrder, accountId)))
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json")
             };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if(response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                Debug.Write(order);
                throw new Exception($"Error Creating Order { await response.Content.ReadAsStringAsync()} ");
            };

            var orderNumberString = response.Headers.Location.PathAndQuery.Substring(response.Headers.Location.PathAndQuery.LastIndexOf("/") + 1);
            var orderNumber = ulong.Parse(orderNumberString);
            Debug.WriteLine(JsonConvert.SerializeObject(order));

            return orderNumber;
        }

        public async Task<ulong> ReplaceOrder(AccessTokenContainer accessTokenContainer, string accountId, string orderId, Order newOrder)
        {
            var uri = new Uri(BaseUri, string.Format(routeReplaceOrder, accountId, orderId));

            var request = new HttpRequestMessage(HttpMethod.Put, uri)
            {
                Method = HttpMethod.Put,
                Content = new StringContent(JsonConvert.SerializeObject(newOrder), Encoding.UTF8, "application/json")
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
            
            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                Debug.Write(newOrder);
                throw new Exception($"Error Replacing Order {await response.Content.ReadAsStringAsync()} ");
            };

            var orderNumberString = response.Headers.Location.PathAndQuery.Substring(response.Headers.Location.PathAndQuery.LastIndexOf("/") + 1);
            var orderNumber = ulong.Parse(orderNumberString);
            Debug.WriteLine(JsonConvert.SerializeObject(newOrder));

            return orderNumber;


        }

        public async Task CancelOrder(AccessTokenContainer accessTokenContainer, string accountId, Order order)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeCancelOrder, accountId, order.orderId)))
            {
                Method = HttpMethod.Delete,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(order);
                throw new Exception($"Error deleting Order {await response.Content.ReadAsStringAsync()} ");
            };
        }

        public async Task<UserPrincipal> GetUserPrincipals(AccessTokenContainer accessTokenContainer)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetUserPrincipals))
            {
                Method = HttpMethod.Get
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.WriteLine($"GetUserPrincipals: StatusCode: {response.StatusCode}");
                Debug.WriteLine($"GetUserPrincipals: {await response.Content.ReadAsStringAsync()}");
                throw new Exception("Error retreiving UserPrincipals");
            }

            var userPrincipal = Utility.DeserializeJsonFromStream<UserPrincipal>(await response.Content.ReadAsStreamAsync());

            return userPrincipal;
        }

        public async Task<string> GetStreamerSubscriptionKeys(AccessTokenContainer accessTokenContainer, UserPrincipal userPrincipal)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetStreamerSubscriptionKeys, userPrincipal.accounts[0].accountId)))
                {
                    Method = HttpMethod.Get
                };

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

                var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
                if (response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    throw new Exception("Error retreiving Streamer Subscription Keys");
                };

                var keys = Utility.DeserializeJsonFromStream<List<SubscriptionKeys>>(await response.Content.ReadAsStreamAsync());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return string.Empty;
        }

        public Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder)
        {
            var lmitOrder = triggerOrder.childOrderStrategies[0].childOrderStrategies.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION" || o.status == "AWAITING_PARENT_ORDER") && o.orderLegCollection[0].instrument.symbol.ToUpper() == triggerOrder.orderLegCollection[0].instrument.symbol.ToUpper() && o.orderType == "LIMIT").FirstOrDefault();
            return lmitOrder;
        }

    }
}
