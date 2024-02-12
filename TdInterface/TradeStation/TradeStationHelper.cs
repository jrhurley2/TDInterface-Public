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
using System.Threading.Tasks;
using TdInterface.Interfaces;
using TdInterface.Model;
using TdInterface.Tda.Model;
using TdInterface.TradeStation.Model;

namespace TdInterface.TradeStation
{
    public class TradeStationHelper : IBrokerage
    {
        private string accountId;

        public const string ACCESSTOKENCONTAINER = "ts-accesstokencontainer.json";

        public static HttpClient _httpClient = new HttpClient();
        public static Uri BaseUri = new Uri("https://api.tradestation.com/");
        public static Uri BaseUriSim = new Uri("https://sim-api.tradestation.com/");
        public static Uri TokenUri = new Uri("https://signin.tradestation.com/oauth/token");

        public const string routeGetToken = "v1/oauth2/token";
        public const string routePlaceOrder = "v3/orderexecution/orders";
        public const string routeReplaceOrder = "v3/orderexecution/orders/{0}";
        public const string routeCancelOrder = "v3/orderexecution/orders/{0}";
        public const string routeGetAccounts = "v3/brokerage/accounts";
        public const string routeGetOrders = "v3/brokerage/accounts/{0}/orders";
        public const string routeGetPositions = "v3/brokerage/accounts/{0}/positions";

        private Dictionary<string, TdInterface.Model.StockQuote> _stockQuotes = new();

        public AccountInfo AccountInfo { get; set; }

        private static Securitiesaccount _securitiesaccount;
        private readonly Subject<Securitiesaccount> _securitiesAccountSubject = new Subject<Securitiesaccount>();
        public IObservable<Securitiesaccount> SecuritiesAccountUpdated => _securitiesAccountSubject.AsObservable();

        private AccessTokenContainer accessTokenContainer;


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

        public AccessTokenContainer AccessTokenContainer
        {
            get
            {
                if (accessTokenContainer == null)
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

        public string LoginUri
        {
            get
            {
                return $"https://signin.tradestation.com/authorize?response_type=code&client_id={AccountInfo.TradeStationClientId}&redirect_uri=http%3A%2F%2Flocalhost&t&audience=https://api.tradestation.com&scope=openid offline_access MarketData ReadAccount Trade Matrix";

            }
        }

        public bool NeedTokenRefreshed
        {
            get
            {
                return AccessTokenContainer == null;
            }
        }

        public string AccountId
        {
            get
            {
                return accountId;
            }
        }

        public TradeStationHelper(AccountInfo ai)
        {
            AccountInfo = ai;
            BaseUri = ai.TradeStationUseSimAccount ? BaseUriSim : BaseUri;
            Task.Run(CheckTokenRefresh);
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

        /// <summary>
        /// Get access token.  This call is called only when a refresh token is needed.  TS should never expire and TDA expires once every 90 days.
        /// </summary>
        /// <param name="authToken"></param>
        /// <returns></returns>
        public async Task<AccessTokenContainer> GetAccessToken(string authToken)
        {
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
            postData.Add(new KeyValuePair<string, string>("code", $"{authToken}"));
            postData.Add(new KeyValuePair<string, string>("client_id", AccountInfo.TradeStationClientId));
            postData.Add(new KeyValuePair<string, string>("client_secret", AccountInfo.TradeStationClientSecret));
            postData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost"));

            FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
            var rawSTring = await content.ReadAsStringAsync();
            var request = new HttpRequestMessage(HttpMethod.Post, TokenUri)
            {
                Method = HttpMethod.Post,
                Content = content
            };

            var response = await _httpClient.SendAsync(request);

            AccessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
            AccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TradeStation;

            //Write the access token container, this should ahve the refresh token
            Utility.SaveAccessTokenContainer(ACCESSTOKENCONTAINER, AccessTokenContainer);

            return AccessTokenContainer;
        }

        public async Task<AccessTokenContainer> RefreshAccessToken() //, string clientId, string clientSecret)
        {
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                postData.Add(new KeyValuePair<string, string>("client_id", AccountInfo.TradeStationClientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", AccountInfo.TradeStationClientSecret));
                postData.Add(new KeyValuePair<string, string>("refresh_token", AccessTokenContainer.RefreshToken));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                var rawSTring = await content.ReadAsStringAsync();
                var request = new HttpRequestMessage(HttpMethod.Post, TokenUri)
                {
                    Method = HttpMethod.Post,
                    Content = content
                };

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

                var newAccessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
                //Add the refresh token back as it doesn't come back with the payload.
                newAccessTokenContainer.RefreshToken = AccessTokenContainer.RefreshToken;

                newAccessTokenContainer.RefreshTokenExpiresIn = int.MaxValue;
                newAccessTokenContainer.TokenSystem = AccessTokenContainer.EnumTokenSystem.TradeStation;

                AccessTokenContainer = newAccessTokenContainer;
                return AccessTokenContainer;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        private static Model.Order ConvertTdaOrder(Tda.Model.Order tdaOrder, string accountId)
        {
            TradeStation.Model.Order tsOrder = new Model.Order
            {
                AccountID = accountId,
                OrderType = ConvertOrderTypeToTradeStation(tdaOrder.orderType),
                Symbol = tdaOrder.orderLegCollection[0].instrument.symbol.ToUpper(),
                Quantity = tdaOrder.orderLegCollection[0].quantity.ToString(),
                TradeAction = ConvertTradeInstructionToTradeStation(tdaOrder.orderLegCollection[0].instruction),
                StopPrice = tdaOrder.stopPrice,
                LimitPrice = tdaOrder.price,
                TimeInForce = new TimeInForceRequest
                {
                    Duration = "GTC"
                }

            };

            if (tdaOrder.orderStrategyType.Equals("TRIGGER"))
            {
                tsOrder.OrderConfirmID = Guid.NewGuid().ToString();
                if (tdaOrder.childOrderStrategies[0].orderStrategyType == "OCO")
                {
                    var stop = ConvertTdaOrder(tdaOrder.childOrderStrategies[0].childOrderStrategies[0], accountId);
                    var limit = ConvertTdaOrder(tdaOrder.childOrderStrategies[0].childOrderStrategies[1], accountId);
                    var oso = new OrderRequestOSO
                    {
                        Type = "OCO"
                    };
                    oso.Orders = new List<Model.Order>();
                    oso.Orders.Add(stop);
                    oso.Orders.Add(limit);

                    tsOrder.OSOs.Add(oso);
                }
                else
                {
                    var oso = new OrderRequestOSO
                    {
                        Type = "NORMAL"
                    };

                    var stop = ConvertTdaOrder(tdaOrder.childOrderStrategies[0], accountId);
                    oso.Orders = new List<Model.Order>();
                    oso.Orders.Add(stop);
                    tsOrder.OSOs.Add(oso);

                }
            }

            return tsOrder;
        }

        private static string ConvertTradeInstructionToTradeStation(string tdaInstruction)
        {
            var instruction = tdaInstruction;

            switch (tdaInstruction.ToUpper())
            {
                case "SELL_SHORT":
                    instruction = "SELLSHORT";
                    break;
                case "BUY_TO_COVER":
                    instruction = "BUYTOCOVER";
                    break;
            }
            return instruction;
        }

        private static string ConvertOrderTypeToTradeStation(string tdaOrderType)
        {
            var orderType = tdaOrderType;

            switch (orderType.ToUpper())
            {
                case "STOP":
                    orderType = "STOPMARKET";
                    break;
            }

            return orderType;
        }

        private static string ConvertOrderTypeFromTradeStation(string tsOrderType)
        {
            var orderType = tsOrderType;

            switch (orderType.ToUpper())
            {
                case "STOPMARKET":
                    orderType = "STOP";
                    break;
            }

            return orderType;
        }

        public async Task<ulong> PlaceOrder(string accountId, Tda.Model.Order order)
        {

            var tsOrder = ConvertTdaOrder(order, accountId);

            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseUri, routePlaceOrder))
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(tsOrder), Encoding.UTF8, "application/json")
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var orders = Utility.DeserializeJsonFromStream<OrderResponses>(await response.Content.ReadAsStreamAsync());
            var o = orders.Orders.OrderByDescending(o => o.OrderID).FirstOrDefault();

            var orderNumber = ulong.Parse(o.OrderID);

            return orderNumber;
        }



        public async Task<ulong> ReplaceOrder(string accountId, string orderId, Tda.Model.Order newOrder)
        {
            var tsOrder = ConvertTdaOrder(newOrder, accountId);

            var uri = new Uri(BaseUri, string.Format(routeReplaceOrder, orderId));

            var request = new HttpRequestMessage(HttpMethod.Put, uri)
            {
                Method = HttpMethod.Put,
                Content = new StringContent(JsonConvert.SerializeObject(tsOrder), Encoding.UTF8, "application/json")
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(newOrder);
                throw new Exception($"Error Replacing Order {await response.Content.ReadAsStringAsync()} ");
            };


            Debug.Write($"replaceorder {response.Content.ReadAsStringAsync()}");
            //var orders = Utility.DeserializeJsonFromStream<OrderResponses>(await response.Content.ReadAsStreamAsync());
            //var o = orders.Orders.OrderByDescending(o => o.OrderID).FirstOrDefault();

            //var orderNumber = ulong.Parse(o.OrderID);

            ulong orderNumber = 0L;
            return orderNumber;
        }

        public async Task CancelOrder(string accountId, Tda.Model.Order order)
        {

            var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(BaseUri, string.Format(routeCancelOrder, order.orderId)))
            {
                Method = HttpMethod.Delete,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

        }

        public async Task<GetOrderResponse> GetOrders(string accountId)
        {


            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetOrders, accountId)));

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var orderResponse = JsonConvert.DeserializeObject<GetOrderResponse>(await response.Content.ReadAsStringAsync());

            return orderResponse;
        }

        public async Task<PositionResponse> GetPositions(string accountId)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetPositions, accountId)));

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var positionResponse = JsonConvert.DeserializeObject<PositionResponse>(await response.Content.ReadAsStringAsync());

            return positionResponse;
        }

        public async Task<Securitiesaccount> GetAccount(string accountId)
        {
            var securitiesaccount = new Securitiesaccount();
            var orderResponse = await GetOrders(accountId).ConfigureAwait(false);
            var postionResponse = await GetPositions(accountId).ConfigureAwait(false);


            var tdaPostion = new List<Tda.Model.Position>();

            foreach (var postion in postionResponse.Positions)
            {
                tdaPostion.Add(new Tda.Model.Position()
                {
                    averagePrice = float.Parse(postion.AveragePrice),
                    longQuantity = postion.LongShort.Equals("LONG", StringComparison.InvariantCultureIgnoreCase) ? float.Parse(postion.Quantity) : 0.0F,
                    shortQuantity = postion.LongShort.Equals("SHORT", StringComparison.InvariantCultureIgnoreCase) ? Math.Abs(float.Parse(postion.Quantity)) : 0.0F,
                    instrument = new Instrument { symbol = postion.Symbol }
                }); ;
            }
            securitiesaccount.positions = tdaPostion.ToArray();

            var tdaOrder = new List<Tda.Model.Order>();

            foreach (var order in orderResponse.Orders)
            {
                tdaOrder.Add(new Tda.Model.Order()
                {
                    status = ConvertOrderStatus(order.Status),
                    orderId = order.OrderID,
                    orderType = ConvertOrderTypeFromTradeStation(order.OrderType),
                    stopPrice = order.StopPrice,
                    price = order.LimitPrice,
                    orderLegCollection = new List<OrderLeg> { new OrderLeg { instrument = new Instrument { symbol = order.Legs[0].Symbol } } }
                });
            }
            securitiesaccount.orderStrategies = tdaOrder.ToArray();
            _securitiesAccountSubject.OnNext(securitiesaccount);

            return securitiesaccount;
        }

        private string ConvertOrderStatus(string orderStatus)
        {
            string status = string.Empty;
            switch (orderStatus)
            {
                case "DON":
                    status = "QUEUED";
                    break;
                case "ACK":
                    status = "PENDING_ACTIVATION";
                    break;
                default:
                    status = orderStatus;
                    break;
            }

            return status;
        }

        public async Task<List<Model.Account>> GetAccounts()
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts));

            //request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);
            var accounts = new List<Model.Account>();

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts))
            {
                Method = HttpMethod.Get,
                Headers =
    {
        { "Authorization", $"Bearer {AccessTokenContainer.AccessToken}" },
    },
            };

            //var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            using (var response = await _httpClient.SendAsync(request))
            {
                try
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    accounts = Model.Account.ParseJson(body);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            return accounts;
        }

        public Tda.Model.Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Tda.Model.Order triggerOrder)
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
            var openOrders = securitiesaccount.FlatOrders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") && o.orderLegCollection[0].instrument.symbol.Equals(symbol, StringComparison.InvariantCultureIgnoreCase));

            var tasks = new List<Task>();
            foreach (var order in openOrders)
            {
                var task = this.CancelOrder(accountId, order);
                tasks.Add(task);
            }

            await Task.WhenAll(tasks).ConfigureAwait(true);
        }

        public async Task<IStreamer> GetStreamer()
        {
            var accounts = await GetAccounts();
            //Lets get the first Margin account for equity trading.  Might need to change later, but see how this goes.
            var equitiyAccount = accounts.Where(a => a.AccountType.Equals("Margin", StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
            accountId = equitiyAccount.AccountID;

            var _streamer = new TradeStationStreamer(this);
            ((TradeStationStreamer)_streamer).StartAccountStream();
            return _streamer;
        }
    }
}
