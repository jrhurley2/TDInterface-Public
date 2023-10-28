using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using TdInterface.Interfaces;
using TdInterface.Model;
using TdInterface.Tda.Model;

namespace TdInterface.Tda
{
    public class TdHelper : IBrokerage
    {
        private string accountId;

        public const string ACCESSTOKENCONTAINER = "tda-accesstokencontainer.json";
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
        public const string routeGetTransactions = "v1/accounts/{0}/transactions";

        public AccountInfo AccountInfo { get;  set; }

        private static Securitiesaccount _securitiesaccount;
        private readonly Subject<Securitiesaccount> _securitiesAccountSubject = new Subject<Securitiesaccount>();
        public IObservable<Securitiesaccount> SecuritiesAccountUpdated => _securitiesAccountSubject.AsObservable();


        private Dictionary<string, TdInterface.Model.StockQuote> _stockQuotes = new();
        private AccessTokenContainer accessTokenContainer;

        public TdHelper(AccountInfo ai) { AccountInfo = ai; }



        private readonly object _lockSecuritiesAccount = new object();

        public Securitiesaccount Securitiesaccount
        {
            get
            {
                lock (_lockSecuritiesAccount)
                {
                    return _securitiesaccount;
                }
            }
            set
            {
                lock (_lockSecuritiesAccount)
                {
                    _securitiesaccount = value;
                }
            }
        }

        public AccessTokenContainer AccessTokenContainer
        {
            get
            {
                if (accessTokenContainer== null)
                {
                    accessTokenContainer = Utility.GetAccessTokenContainer(ACCESSTOKENCONTAINER);
                }
                return accessTokenContainer;
            }
            set
            {
                Debug.WriteLine("***********************ACCESSTOKENCONTAINER BEING SET");
                accessTokenContainer = value;
            }
        }

        //Utility.SplitTdaConsumerKey(_broker.AccountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

        //loginUri = $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={UrlEncoder.Create().Encode(redirectUri)}&client_id={consumerKey}%40AMER.OAUTHAP";

        public string LoginUri
        {
            get
            {
                Utility.SplitTdaConsumerKey(AccountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);
                return $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={UrlEncoder.Create().Encode(redirectUri)}&client_id={consumerKey}%40AMER.OAUTHAP";
            }
        }

        public bool NeedTokenRefreshed
        {
            get
            {
                return (AccessTokenContainer == null || (AccessTokenContainer.TokenSystem == AccessTokenContainer.EnumTokenSystem.TDA && (AccessTokenContainer.IsRefreshTokenExpired || AccessTokenContainer.RefreshTokenExpiresInDays < 5)));
            }
        }

        public string AccountId
        {
            get
            {
                return accountId;
            }
        }


        /// <summary>
        /// Get access token.  This call is called only when a refresh token is needed.  TS should never expire and TDA expires once every 90 days.
        /// </summary>
        /// <param name="authToken"></param>
        /// <returns></returns>
        public async Task<AccessTokenContainer> GetAccessToken(string authToken)
        {
            try
            {
                Debug.WriteLine($"*******8   Why are we calling this, it should only get called ever 90 or so days  Calling GetAccessToken:  {DateTime.Now.ToShortTimeString()}");
                var accountInfo = Utility.GetAccountInfo();

                Utility.SplitTdaConsumerKey(accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
                postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
                postData.Add(new KeyValuePair<string, string>("code", $"{authToken}"));
                postData.Add(new KeyValuePair<string, string>("client_id", $"{consumerKey}@AMER.OAUTHTD"));
                postData.Add(new KeyValuePair<string, string>("redirect_uri", $"{redirectUri}"));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                var rawSTring = await content.ReadAsStringAsync();
                var request = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseUri, routeGetToken)) //Uri."https://api.tdameritrade.com/v1/oauth2/token"); // ; 
                {
                    Method = HttpMethod.Post,
                    Content = content
                };

                var response = await _httpClient.SendAsync(request);

                AccessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
                AccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;

                //Write the access token container, this should ahve the refresh token
                Utility.SaveAccessTokenContainer(ACCESSTOKENCONTAINER, AccessTokenContainer);

                return AccessTokenContainer;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;  
            }
        }

        public async Task<AccessTokenContainer> RefreshAccessToken()
        {
            try
            {
                Debug.WriteLine($"Calling RefreshAccessToken:  {DateTime.Now.ToShortTimeString()}");
                var accountInfo = Utility.GetAccountInfo();

                Utility.SplitTdaConsumerKey(accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

                Debug.WriteLine($"Old AccessToken Container: {JsonConvert.SerializeObject(AccessTokenContainer)}");

                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                postData.Add(new KeyValuePair<string, string>("refresh_token", AccessTokenContainer.RefreshToken));
                postData.Add(new KeyValuePair<string, string>("client_id", $"{consumerKey}@AMER.OAUTHTD"));

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
                newAccessTokenContainer.RefreshToken = AccessTokenContainer.RefreshToken;
                newAccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;

                Debug.WriteLine($"New AccessToken Container: {JsonConvert.SerializeObject(newAccessTokenContainer)}");

                AccessTokenContainer = newAccessTokenContainer;
                return AccessTokenContainer;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public async Task<Securitiesaccount> GetAccount(string accountId)
        {
            Securitiesaccount securitiesaccount = null;
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetAccount, accountId)))
                {
                    Method = HttpMethod.Get,
                };

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);


                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        securitiesaccount = Securitiesaccount.ParseJson(await response.Content.ReadAsStringAsync());
                        Debug.WriteLine(JsonConvert.SerializeObject(securitiesaccount));

                        //Store it in tdhelper class.
                        Securitiesaccount = securitiesaccount;
                        //TODO:  When 2 windows are open this will cause the app to hang.
                        _securitiesAccountSubject.OnNext(securitiesaccount);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        Debug.WriteLine($"Message Content: {await response.Content.ReadAsStringAsync()} ");
                    }
                }
                else
                {
                    Debug.WriteLine("Call to get Securities Account failed!");
                    Debug.WriteLine($"GetAccount Response {response.StatusCode}: {response.Content}");
                    Debug.WriteLine($"AccessContainerToken.ExpiresIn: {AccessTokenContainer.ExpiresIn}");
                    Debug.WriteLine($"AccessTokenContainer.IsTokenExpired: {AccessTokenContainer.IsTokenExpired}");
                    Debug.WriteLine($"{await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception ex) 
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

            return Securitiesaccount;
        }

        public async Task<List<Account>> GetAccounts()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts))
            {
                Method = HttpMethod.Get,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request);
            var account = Utility.DeserializeJsonFromStream<List<Account>>(await response.Content.ReadAsStreamAsync());

            return account;
        }

        public async Task<Securitiesaccount> GetTransactions(string accountId, string symbol)
        {
            Securitiesaccount securitiesaccount = null;
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetTransactions, accountId)))
                {
                    Method = HttpMethod.Get,
                };

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);


                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        securitiesaccount = Securitiesaccount.ParseJson(await response.Content.ReadAsStringAsync());
                        Debug.WriteLine(JsonConvert.SerializeObject(securitiesaccount));

                        //Store it in tdhelper class.
                        Securitiesaccount = securitiesaccount;
                        //TODO:  When 2 windows are open this will cause the app to hang.
                        _securitiesAccountSubject.OnNext(securitiesaccount);
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        Debug.WriteLine($"Message Content: {await response.Content.ReadAsStringAsync()} ");
                    }
                }
                else
                {
                    Debug.WriteLine("Call to get Securities Account failed!");
                    Debug.WriteLine($"GetAccount Response {response.StatusCode}: {response.Content}");
                    Debug.WriteLine($"AccessContainerToken.ExpiresIn: {AccessTokenContainer.ExpiresIn}");
                    Debug.WriteLine($"AccessTokenContainer.IsTokenExpired: {AccessTokenContainer.IsTokenExpired}");
                    Debug.WriteLine($"{await response.Content.ReadAsStringAsync()}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
            }

            return Securitiesaccount;
        }



        public async Task<CandleList> GetPriceHistoryAsync(string symbol)
        {
            var today = DateTimeOffset.Now;
            var startDate = new DateTimeOffset(today.Year, today.Month, today.Day, 4, 00, 00, new TimeSpan(-4, 0, 0));
            var endDate = new DateTimeOffset(today.Year, today.Month, today.Day, 19, 00, 00, new TimeSpan(-4, 0, 0));
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetPriceHistory, symbol, startDate.ToUnixTimeMilliseconds(), endDate.ToUnixTimeMilliseconds())))
            {
                Method = HttpMethod.Get,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request);
            var candleList = Utility.DeserializeJsonFromStream<CandleList>(await response.Content.ReadAsStreamAsync());

            foreach (var candle in candleList.candles)
            {
                Debug.WriteLine($"{candle.DateTime},{candle.open},{candle.close},{candle.high},{candle.low},{candle.volume}");
            }

            return candleList;
        }

        public async Task<ulong> PlaceOrder(string accountId, Order order)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routePlaceOrder, accountId)))
            {
                Method = HttpMethod.Post,
                Content = Serialize(order)
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var orderNumberString = response.Headers.Location.PathAndQuery.Substring(response.Headers.Location.PathAndQuery.LastIndexOf("/") + 1);
            var orderNumber = ulong.Parse(orderNumberString);
            Debug.WriteLine(JsonConvert.SerializeObject(order));

            return orderNumber;
        }

        private static StringContent Serialize(Order order)
        {
            return new StringContent(JsonConvert.SerializeObject(order,
                                                                                    Formatting.None,
                                                                                    new JsonSerializerSettings
                                                                                    {
                                                                                        NullValueHandling = NullValueHandling.Ignore,
                                                                                        DefaultValueHandling = DefaultValueHandling.Ignore
                                                                                    }),
                            Encoding.UTF8, "application/json");
        }

        public async Task<ulong> ReplaceOrder(string accountId, string orderId, Order newOrder)
        {
            var uri = new Uri(BaseUri, string.Format(routeReplaceOrder, accountId, orderId));

            var request = new HttpRequestMessage(HttpMethod.Put, uri)
            {
                Method = HttpMethod.Put,
                Content = Serialize(newOrder)
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);
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

        public async Task CancelOrder(string accountId, Order order)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeCancelOrder, accountId, order.orderId)))
            {
                Method = HttpMethod.Delete,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(order);
                throw new Exception($"Error deleting Order {await response.Content.ReadAsStringAsync()} ");
            };
        }

        public async Task<UserPrincipal> GetUserPrincipals()
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetUserPrincipals))
                {
                    Method = HttpMethod.Get
                };

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

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
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
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

        public TdInterface.Model.StockQuote SetStockQuote(TdInterface.Model.StockQuote stockQuote)
        {
            if (!_stockQuotes.ContainsKey(stockQuote.symbol))
            {
                _stockQuotes.Add(stockQuote.symbol, stockQuote);
            }

            _stockQuotes[stockQuote.symbol] = _stockQuotes[stockQuote.symbol].Update(stockQuote);

            return _stockQuotes[stockQuote.symbol];
        }

        public TdInterface.Model.StockQuote GetStockQuote(string symbol)
        {
            if (!_stockQuotes.ContainsKey(symbol)) { return null; }

            return _stockQuotes[symbol];
        }

        public async Task CancelAll(string accountId, string symbol)
        {
            var securitiesaccount = await this.GetAccount(accountId);

            if (securitiesaccount != null)
            {

                var openOrders = TDAOrderHelper.GetOpenOrders(securitiesaccount.FlatOrders, symbol);
                //var openOrders = securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol.Equals(symbol, StringComparison.InvariantCultureIgnoreCase));

                var tasks = new List<Task>();
                foreach (var order in openOrders)
                {
                    var task = this.CancelOrder(accountId, order);
                    tasks.Add(task);
                }

                await Task.WhenAll(tasks).ConfigureAwait(true);
            }
            else
            {
                Debug.WriteLine("CancelAll - securitiesAccount is null");
            }
        }

        public async Task<IStreamer> GetStreamer()
        {
            UserPrincipal up = await GetUserPrincipals();
            accountId = up.accounts[0].accountId;
            return new TDStreamer(this);
        }
    }
}
