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
using Websocket.Client.Models;
using Websocket.Client;
using System.IO;
using System.Reflection;
using System.Threading;

namespace TdInterface.Tda
{
    public class TdHelper : Brokerage
    {
        private string accountId;

        private StreamWriter _replayFile;

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

        public override AccountInfo AccountInfo { get; set; }

        private static Securitiesaccount _securitiesaccount;
        private readonly Subject<Securitiesaccount> _securitiesAccountSubject = new Subject<Securitiesaccount>();
        public override IObservable<Securitiesaccount> SecuritiesAccountUpdated => _securitiesAccountSubject.AsObservable();


        private Dictionary<string, TdInterface.Model.StockQuote> _stockQuotes = new();
        private AccessTokenContainer accessTokenContainer;

        public TdHelper(AccountInfo ai)
        {
            AccountInfo = ai;

            string currentPath = Directory.GetCurrentDirectory();
            string replayFolder = Path.Combine(currentPath, "replays");
            if (!Directory.Exists(replayFolder))
                Directory.CreateDirectory(replayFolder);

            _replayFile = new StreamWriter($"{replayFolder}\\{DateTime.Now.ToString("yyyyMMdd-HHmmss")}replay.txt");
            
        }


        public override void Initialize()
        {
            _ = RefreshAccessToken().Result;
            ConnectSocket();

            Task.Run(CheckTokenRefresh);

        }


        private int reconnectionCount = 0;
        private void SubscribeWebSocketMessages(UserPrincipal userPrincipals, WebsocketClient client)
        {
            client.DisconnectionHappened.Subscribe(dis =>
            {
                try
                {
                    _disconnectionInfo.OnNext(dis);
                    //Debug.WriteLine($"Disconnect sleeping");
                    //Thread.Sleep(10000);
                    //Debug.WriteLine($"Disconnect awake");
                    //if (reconnectionCount >= 100)
                    //{
                    //    Debug.WriteLine($"reconnectionCount exceeded retry.");
                    //}
                    //reconnectionCount++;

                    //Debug.WriteLine($"DisconnectionHappened {dis.Type}");
                    //Debug.WriteLine($"Calling ConnectSocket");
                    //ConnectSocket();
                    //Debug.WriteLine("Calling SubscribeQuote");
                    //SubscribeQuote();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Unable to connect {ex.Message}");
                    Debug.WriteLine(ex);
                }

            });

            client.ReconnectionHappened.Subscribe(info =>
            {
                Debug.WriteLine($"Reconnection happened, type: {info.Type}");
                reconnectionCount = 0;
                _reconnectionInfo.OnNext(info);
            });

            client.MessageReceived.Subscribe(msg =>
            {
                _socketNotify.OnNext(new SocketNotify());

                try
                {
                    if (_replayFile != null)
                        _replayFile.WriteLine(SanatizeAccountNumbers(userPrincipals, msg.Text));
                }
                catch
                {
                    Debug.WriteLine("error writing to replay file");
                }

                var v = JsonConvert.DeserializeObject<Dictionary<string, object>>(msg.Text);

                if (v.ContainsKey("response"))
                {
                    Debug.WriteLine(msg.Text);
                    var r = v["response"];
                    var response = JsonConvert.DeserializeObject<List<SocketResponse>>(v["response"].ToString());
                    var command = response[0].command;
                    if (command == "LOGIN")
                    {
                        var reqs = new List<StreamerSettings.Request>();
                        var acctAcivity = new StreamerSettings.Request
                        {
                            command = "SUBS",
                            service = "ACCT_ACTIVITY",
                            requestid = "2",
                            account = userPrincipals.accounts[0].accountId,
                            source = userPrincipals.streamerInfo.appId,
                            parameters = new StreamerSettings.Parameters
                            {
                                keys = userPrincipals.streamerSubscriptionKeys.keys[0].key,
                                fields = "0,1,2,3"
                            }

                        };


                        reqs.Add(acctAcivity);

                        var request = new StreamerSettings.Requests()
                        {
                            requests = reqs.ToArray()
                        };
                        var firstreq = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                        client.Send(firstreq);

                        Console.WriteLine(msg);
                    }
                    else if (command == "SUBS")
                    {
                        Debug.WriteLine(msg.Text);
                        Console.WriteLine(msg);
                    }
                }
                else if (v.ContainsKey("notify"))
                {
                    var notifyList = JsonConvert.DeserializeObject<List<SocketNotify>>(v["notify"].ToString());
                    foreach (var notify in notifyList)
                    {
                        _socketNotify.OnNext(notify);
                    }
                }
                else if (v.ContainsKey("data"))
                {
                    var r = v["data"];
                    var data = JsonConvert.DeserializeObject<List<SocketData>>(v["data"].ToString());

                    foreach (var socketData in data)
                    {
                        var command = socketData.command;
                        var service = socketData.service;
                        if (service == "QUOTE")
                        {
                            foreach (var quoteJson in socketData.content)
                            {

                                var stockQuote = new Model.StockQuote(quoteJson);
                                _stockQuoteRecievedSubject.OnNext(stockQuote);
                                Debug.WriteLine("TDStreamer:" + JsonConvert.SerializeObject(stockQuote));
                            }
                        }
                        else if (service == "LEVELONE_FUTURES")
                        {
                            foreach (var quoteJson in socketData.content)
                            {

                                var futureQuote = new Model.StockQuote(quoteJson);
                                _futureQuoteRecievedSubject.OnNext(futureQuote);
                                Debug.WriteLine(JsonConvert.SerializeObject(futureQuote));
                            }
                            Console.WriteLine($"Futures {socketData.content}");
                        }
                        else if (service == "ACCT_ACTIVITY")
                        {
                            //Signal we have Account Activity
                            _acctActivity.OnNext(new AcctActivity());

                            foreach (var content in socketData.content)
                            {

                                //if (content["2"] == "OrderEntryRequest")
                                //{
                                //    try
                                //    {
                                //        //Parsing was inconsitnat don't have a complete XML Schema, and wasn't using it on the other side.
                                //        //var orderEntryRequestMessage = OrderEntryRequestMessage.ParseXml(content["3"]);
                                //        var orderEntryRequestMessage = new OrderEntryRequestMessage();
                                //        _orderEntryRequestMessage.OnNext(orderEntryRequestMessage);
                                //    }
                                //    catch (Exception ex)
                                //    {
                                //        Debug.WriteLine(ex.Message);
                                //        Debug.WriteLine(ex.StackTrace);
                                //    }
                                //}
                                if (content["2"] == "OrderFill")
                                {
                                    try
                                    {
                                        Debug.WriteLine(content["3"]);
                                        //Check that the order is a stock order, will throw excption if it is options, etc...
                                        if (content["3"].Contains("EquityOrderT"))
                                        {
                                            var orderFillMessage = OrderFillMessage.ParseXml(content["3"]);
                                            _orderFillMessage.OnNext(orderFillMessage);
                                        }
                                        else
                                        {
                                            Debug.WriteLine("We don't handle messages other than EquityOrderT");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Debug.WriteLine(ex.Message);
                                        Debug.WriteLine(ex.StackTrace);
                                    }
                                }
                            }
                        }
                        else if (service == "CHART_EQUITY")
                        {
                            var stockChartBar = new StockChartBar(socketData.content[0]);
                            Debug.WriteLine(msg.Text);
                        }
                        else
                        {
                            Debug.WriteLine(msg.Text);
                        }
                        Console.WriteLine(msg);
                    }
                }
                Console.WriteLine($"Message received: {msg}");
            });
        }


        private async Task CheckTokenRefresh()
        {
            while (true)
            {
                if (AccessTokenContainer.ExpiresIn < 100)
                {
                    Debug.WriteLine("Refreshing Access Token");
                    await RefreshAccessToken();
                }

                // Wait for an hour before checking again
                await Task.Delay(TimeSpan.FromMilliseconds(30000));
            }
        }


        private readonly object _lockSecuritiesAccount = new object();

        public override Securitiesaccount Securitiesaccount
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

        public override AccessTokenContainer AccessTokenContainer
        {
            get
            {
                if (accessTokenContainer == null)
                {
                    accessTokenContainer = GetAccessTokenContainer(ACCESSTOKENCONTAINER);
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

        public override string LoginUri
        {
            get
            {
                SplitTdaConsumerKey(AccountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);
                return $"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri={UrlEncoder.Create().Encode(redirectUri)}&client_id={consumerKey}%40AMER.OAUTHAP";
            }
        }

        public override bool NeedTokenRefreshed
        {
            get
            {
                return (AccessTokenContainer == null || (AccessTokenContainer.TokenSystem == AccessTokenContainer.EnumTokenSystem.TDA && (AccessTokenContainer.IsRefreshTokenExpired || AccessTokenContainer.RefreshTokenExpiresInDays < 5)));
            }
        }

        public override string AccountId
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
        public override async Task<AccessTokenContainer> GetAccessToken(string authToken)
        {
            try
            {
                var accountInfo = Utility.GetAccountInfo();

                SplitTdaConsumerKey(accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

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

                AccessTokenContainer = DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
                AccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;

                //Write the access token container, this should ahve the refresh token
                SaveAccessTokenContainer(ACCESSTOKENCONTAINER, AccessTokenContainer);

                return AccessTokenContainer;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public override async Task<AccessTokenContainer> RefreshAccessToken()
        {
            try
            {
                Debug.WriteLine($"Calling RefreshAccessToken:  {DateTime.Now.ToShortTimeString()}");
                var accountInfo = Utility.GetAccountInfo();

                SplitTdaConsumerKey(accountInfo.TdaConsumerKey, out string consumerKey, out string redirectUri);

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

                var newAccessTokenContainer = DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());


                //Add the refresh token back as it doesn't come back with the payload.
                newAccessTokenContainer.RefreshToken = AccessTokenContainer.RefreshToken;
                newAccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TDA;

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

        public override async Task<Securitiesaccount> GetAccount(string accountId)
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
            var account = DeserializeJsonFromStream<List<Account>>(await response.Content.ReadAsStreamAsync());

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
            var candleList = DeserializeJsonFromStream<CandleList>(await response.Content.ReadAsStreamAsync());

            foreach (var candle in candleList.candles)
            {
                Debug.WriteLine($"{candle.DateTime},{candle.open},{candle.close},{candle.high},{candle.low},{candle.volume}");
            }

            return candleList;
        }

        public override async Task<ulong> PlaceOrder(string accountId, Order order)
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

        public override async Task<ulong> ReplaceOrder(string accountId, string orderId, Order newOrder)
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

        public override async Task CancelOrder(string accountId, Order order)
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

        public override async Task<UserPrincipal> GetUserPrincipals()
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

                var userPrincipal = DeserializeJsonFromStream<UserPrincipal>(await response.Content.ReadAsStreamAsync());

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

                var keys = DeserializeJsonFromStream<List<SubscriptionKeys>>(await response.Content.ReadAsStreamAsync());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return string.Empty;
        }

        public override Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder)
        {
            var lmitOrder = triggerOrder.childOrderStrategies[0].childOrderStrategies.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION" || o.status == "AWAITING_PARENT_ORDER") && o.orderLegCollection[0].instrument.symbol.ToUpper() == triggerOrder.orderLegCollection[0].instrument.symbol.ToUpper() && o.orderType == "LIMIT").FirstOrDefault();
            return lmitOrder;
        }

        public override TdInterface.Model.StockQuote SetStockQuote(TdInterface.Model.StockQuote stockQuote)
        {
            if (!_stockQuotes.ContainsKey(stockQuote.symbol))
            {
                _stockQuotes.Add(stockQuote.symbol, stockQuote);
            }

            _stockQuotes[stockQuote.symbol] = _stockQuotes[stockQuote.symbol].Update(stockQuote);

            return _stockQuotes[stockQuote.symbol];
        }

        public override TdInterface.Model.StockQuote GetStockQuote(string symbol)
        {
            if (!_stockQuotes.ContainsKey(symbol)) { return null; }

            return _stockQuotes[symbol];
        }

        public override async Task CancelAll(string accountId, string symbol)
        {
            var securitiesaccount = await this.GetAccount(accountId);

            if (securitiesaccount != null)
            {

                var openOrders = Brokerage.GetOpenOrders(securitiesaccount.FlatOrders, symbol);
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



        public override async Task<IStreamer> GetStreamer()
        {
            UserPrincipal up = await GetUserPrincipals();
            accountId = up.accounts[0].accountId;
            return this; // new TDStreamer(this);
        }

        public static void SplitTdaConsumerKey(string tdaConsumerKey, out string consumerKey, out string callback)
        {
            consumerKey = tdaConsumerKey;
            callback = "http://localhost";
            if (consumerKey.IndexOf("~") > 0)
            {
                var parts = consumerKey.Split('~');
                consumerKey = parts[0];
                callback = parts[1];
            }
        }


        #region IStreamer


        private bool _isConnected = false;
        private UserPrincipal _userPrincipal;
        private bool _isDisposing;
        private StreamerSettings.Credentials _credentials;
        private StreamerSettings.Request _loginRequest;

        private WebsocketClient _ws;
        private List<string> _quoteSymbols = new List<string>();
        public int _quoteRequestId = 0;


        private readonly Subject<TdInterface.Model.StockQuote> _stockQuoteRecievedSubject = new Subject<TdInterface.Model.StockQuote>();
        public override IObservable<TdInterface.Model.StockQuote> StockQuoteReceived => _stockQuoteRecievedSubject.AsObservable();

        private readonly Subject<Model.StockQuote> _futureQuoteRecievedSubject = new Subject<Model.StockQuote>();
        public override IObservable<Model.StockQuote> FutureQuoteReceived => _futureQuoteRecievedSubject.AsObservable();

        private readonly Subject<AcctActivity> _acctActivity = new Subject<AcctActivity>();
        public override IObservable<AcctActivity> AcctActivity => _acctActivity.AsObservable();

        private readonly Subject<OrderEntryRequestMessage> _orderEntryRequestMessage = new Subject<OrderEntryRequestMessage>();
        public override IObservable<OrderEntryRequestMessage> OrderRecieved => _orderEntryRequestMessage.AsObservable();

        private readonly Subject<OrderFillMessage> _orderFillMessage = new Subject<OrderFillMessage>();
        public override IObservable<OrderFillMessage> OrderFilled => _orderFillMessage.AsObservable();

        private readonly Subject<SocketNotify> _socketNotify = new Subject<SocketNotify>();
        public override IObservable<SocketNotify> HeartBeat => _socketNotify.AsObservable();

        private readonly Subject<DisconnectionInfo> _disconnectionInfo = new Subject<DisconnectionInfo>();
        public override IObservable<DisconnectionInfo> Disconnection => _disconnectionInfo.AsObservable();

        private readonly Subject<ReconnectionInfo> _reconnectionInfo = new Subject<ReconnectionInfo>();
        public override IObservable<ReconnectionInfo> Reconnection => _reconnectionInfo.AsObservable();

        public override WebsocketClient WebsocketClient
        {
            get
            {
                return _ws;
            }
        }


        private void ConnectSocket()
        {
            _userPrincipal = GetUserPrincipals().Result;
            _credentials = new StreamerSettings.Credentials
            {
                userid = _userPrincipal.accounts[0].accountId,
                token = _userPrincipal.streamerInfo.token,
                company = _userPrincipal.accounts[0].company,
                segment = _userPrincipal.accounts[0].segment,
                cddomain = _userPrincipal.accounts[0].accountCdDomainId,
                usergroup = _userPrincipal.streamerInfo.userGroup,
                accesslevel = _userPrincipal.streamerInfo.accessLevel,
                authorized = "Y",
                timestamp = Convert.ToInt64(ConvertToUnixTimestamp(Convert.ToDateTime(_userPrincipal.streamerInfo.tokenTimestamp))),
                appid = _userPrincipal.streamerInfo.appId,
                acl = _userPrincipal.streamerInfo.acl
            };

            //Convert credentials to dictionary
            var cred = _credentials.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(p => p.Name, p => p.GetValue(_credentials, null));

            var _reqs = new List<StreamerSettings.Request>();

            _loginRequest = new StreamerSettings.Request
            {
                service = "ADMIN",
                command = "LOGIN",
                requestid = "0",
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    credential = ToQueryString(cred),
                    token = _userPrincipal.streamerInfo.token,
                    version = "1.0",
                    qoslevel = "0"
                }
            };

            _reqs.Add(_loginRequest);

            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };


            var exitEvent = new ManualResetEvent(false);

            var url = new Uri($"wss://{_userPrincipal.streamerInfo.streamerSocketUrl}/ws");

            _ws = new WebsocketClient(url);
            _ws.ReconnectTimeout = TimeSpan.FromSeconds(30);

            SubscribeWebSocketMessages(_userPrincipal, _ws);

            _ws.Start();

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }


        private static string SanatizeAccountNumbers(UserPrincipal userPrincipal, string message)
        {
            int index = 0;
            string newMessage = message;
            foreach (var account in userPrincipal.accounts)
            {
                newMessage = newMessage.Replace(account.accountId, $"sanatizedAccountNumber{index}");
            }

            return newMessage;
        }




        public override void SubscribeQuote(string tickerSymbol)
        {
            if (!_quoteSymbols.Contains(tickerSymbol.ToUpper()))
            {
                _quoteSymbols.Add(tickerSymbol.ToUpper());
            }

            SubscribeQuote();
        }

        private  void SubscribeQuote()
        {
            var symbols = string.Join(",", _quoteSymbols);

            var _reqs = new List<StreamerSettings.Request>();

            _quoteRequestId++;
            var quoteRequest = new StreamerSettings.Request
            {
                service = "QUOTE",
                command = "SUBS",
                requestid = "1", //_quoteRequestId.ToString(),
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    keys = symbols,
                    fields = "0,1,2,3"
                }
            };
            _reqs.Add(quoteRequest);
            //}
            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }

        List<string> _futureSymbols = new List<string>();

        public override void SubscribeFuture(string tickerSymbol)
        {
            if (!_futureSymbols.Contains(tickerSymbol.ToUpper()))
            {
                _futureSymbols.Add(tickerSymbol.ToUpper());
            }

            var symbols = string.Join(",", _futureSymbols);

            var _reqs = new List<StreamerSettings.Request>();

            _quoteRequestId++;
            var quoteRequest = new StreamerSettings.Request
            {
                service = "LEVELONE_FUTURES",
                command = "SUBS",
                requestid = "1", //_quoteRequestId.ToString(),
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    keys = symbols,
                    fields = "0,1,2,3,4"
                }
            };
            _reqs.Add(quoteRequest);
            //}
            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }

        //List<string> _futureSymbols= new List<string>();

        //public void SubscribeFuture(UserPrincipal userPrincipals, string tickerSymbol)
        //{
        //    if (!_futureSymbols.Contains(tickerSymbol.ToUpper()))
        //    {
        //        _futureSymbols.Add(tickerSymbol.ToUpper());
        //    }

        //    var symbols = string.Join(",", _futureSymbols);

        //    var _reqs = new List<StreamerSettings.Request>();

        //    int requestId = 0;
        //    //foreach (var symbol in _quoteSymbols)
        //    //{
        //    //requestId++;
        //    _quoteRequestId++;
        //    var quoteRequest = new StreamerSettings.Request
        //    {
        //        service = "LEVELONE_FUTURES",
        //        command = "SUBS",
        //        requestid = "1", //_quoteRequestId.ToString(),
        //        account = userPrincipals.accounts[0].accountId,
        //        source = userPrincipals.streamerInfo.appId,
        //        parameters = new StreamerSettings.Parameters
        //        {
        //            keys = symbols,
        //            fields = "0,1,2,3,4"
        //        }
        //    };
        //    _reqs.Add(quoteRequest);
        //    //}
        //    var request = new StreamerSettings.Requests()
        //    {
        //        requests = _reqs.ToArray()
        //    };

        //    var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        //    _ws.Send(req);
        //}

        public override void SubscribeChartData(string tickerSymbol)
        {
            var _reqs = new List<StreamerSettings.Request>();
            var chartRequest = new StreamerSettings.Request
            {
                service = "CHART_EQUITY",
                command = "SUBS",
                requestid = "1",
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    keys = tickerSymbol,
                    fields = "0,1,2,3,4,5,6,7,8"
                }
            };
            _reqs.Add(chartRequest);

            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }
        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalMilliseconds);
        }
        #endregion

        public static string ToQueryString(Dictionary<string, object> dict)
        {
            if (dict.Count == 0) return string.Empty;

            var buffer = new StringBuilder();
            int count = 0;
            bool end = false;

            foreach (var key in dict.Keys)
            {
                if (count == dict.Count - 1) end = true;

                if (end)
                    buffer.AppendFormat("{0}={1}", key, dict[key]);
                else
                    buffer.AppendFormat("{0}={1}&", key, dict[key]);

                count++;
            }

            return buffer.ToString();
        }
        public override void Dispose()
        {
            if (_ws != null) _ws.Dispose();
            if (_replayFile != null)
            {
                _replayFile.Flush();
                _replayFile.Dispose();
            }
            _stockQuoteRecievedSubject.Dispose();
        }
    }

}
