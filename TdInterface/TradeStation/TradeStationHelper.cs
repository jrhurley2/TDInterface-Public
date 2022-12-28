using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TdInterface.Interfaces;
using TdInterface.Tda.Model;
using TdInterface.TradeStation.Model;
using System.Linq;

namespace TdInterface.TradeStation
{
    internal class TradeStationHelper : IHelper
    {
        public static HttpClient _httpClient = new HttpClient();
        public static Uri BaseUri = new Uri("https://api.tradestation.com/");
        public static Uri TokenUri = new Uri("https://signin.tradestation.com/oauth/token");

        public const string routeGetToken = "v1/oauth2/token";
        public const string routePlaceOrder = "v3/orderexecution/orders";
        public const string routeGetAccounts = "v3/brokerage/accounts";
        public const string routeGetOrders = "v3/brokerage/accounts/{0}/orders";
        public const string routeGetPositions = "v3/brokerage/accounts/{0}/positions";

        public TradeStationHelper() { }
        public TradeStationHelper(string baseUri)
        {
            BaseUri = new Uri(baseUri);
        }

        public async Task<AccessTokenContainer> GetAccessToken(string authToken, string clientId, string clientSecret)
        {
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
            postData.Add(new KeyValuePair<string, string>("code", $"{authToken}"));
            postData.Add(new KeyValuePair<string, string>("client_id", clientId));
            postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
            postData.Add(new KeyValuePair<string, string>("redirect_uri", "http://localhost"));

            FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
            var rawSTring = await content.ReadAsStringAsync();
            var request = new HttpRequestMessage(HttpMethod.Post, TokenUri) 
            {
                Method = HttpMethod.Post,
                Content = content
            };

            var response = await _httpClient.SendAsync(request);

            var accessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());

            return accessTokenContainer;
        }

        public async Task<AccessTokenContainer> RefreshAccessToken(AccessTokenContainer accessTokenContainer, string clientId, string clientSecret)
        {
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
                //postData.Add(new KeyValuePair<string, string>("refresh_token", System.Net.WebUtility.UrlEncode(accessTokenContainer.RefreshToken)));
                postData.Add(new KeyValuePair<string, string>("refresh_token", accessTokenContainer.RefreshToken));

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

                return newAccessTokenContainer;
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
                OrderType = ConvertOrderType(tdaOrder.orderType),
                Symbol = tdaOrder.orderLegCollection[0].instrument.symbol.ToUpper(),
                Quantity = tdaOrder.orderLegCollection[0].quantity.ToString(),
                TradeAction = tdaOrder.orderLegCollection[0].instruction,
                StopPrice = tdaOrder.stopPrice,
                LimitPrice = tdaOrder.price,
                TimeInForce = new TimeInForceRequest
                {
                    Duration = "GTC"
                }

            };

            if(tdaOrder.orderStrategyType.Equals("TRIGGER"))
            {
                tsOrder.OrderConfirmID = Guid.NewGuid().ToString();
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

            return tsOrder;
        }

        private static string ConvertOrderType(string tdaOrderType)
        {
            var orderType = tdaOrderType;

            switch(orderType.ToUpper())
            {
                case "STOP":
                    orderType = "STOPMARKET";
                    break;
            }

            return orderType;
        }

        public async Task<ulong> PlaceOrder(AccessTokenContainer accessTokenContainer, string accountId, Tda.Model.Order order)
        {

            var tsOrder = ConvertTdaOrder(order, accountId);

            var request = new HttpRequestMessage(HttpMethod.Post, new Uri(BaseUri, routePlaceOrder))
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(tsOrder), Encoding.UTF8, "application/json")
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

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


        public async Task<ulong> GetOrders(AccessTokenContainer accessTokenContainer, string accountId)
        {


            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetOrders, accountId)));

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var orderNumberString = response.Headers.Location.PathAndQuery.Substring(response.Headers.Location.PathAndQuery.LastIndexOf("/") + 1);
            var orderNumber = ulong.Parse(orderNumberString);
            //Debug.WriteLine(JsonConvert.SerializeObject(order));

            return orderNumber;
        }

        public async Task<ulong> GetPositions(AccessTokenContainer accessTokenContainer, string accountId)
        {


            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetPositions, accountId)));

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };



            var orderNumberString = response.Headers.Location.PathAndQuery.Substring(response.Headers.Location.PathAndQuery.LastIndexOf("/") + 1);
            var orderNumber = ulong.Parse(orderNumberString);
            //Debug.WriteLine(JsonConvert.SerializeObject(order));

            return orderNumber;
        }

        public async Task<Securitiesaccount> GetAccount(AccessTokenContainer accessTokenContainer, string accountId)
        {
            return new Securitiesaccount();
        }

        public static async Task<List<Model.Account>> GetAccounts(AccessTokenContainer accessTokenContainer)
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts));

            //request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);
            var accounts = new List<Model.Account>();

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.tradestation.com/v3/brokerage/accounts"),
                Headers =
    {
        { "Authorization", $"Bearer {accessTokenContainer.AccessToken}" },
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
                catch(Exception ex)
                {
                    Console.WriteLine();
                }
            }

            return accounts;
        }



    }
}
