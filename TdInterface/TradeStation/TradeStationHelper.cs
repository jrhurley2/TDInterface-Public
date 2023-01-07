﻿using Newtonsoft.Json;
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
using System.Net.Http.Headers;

namespace TdInterface.TradeStation
{
    public class TradeStationHelper : IHelper
    {
        public static HttpClient _httpClient = new HttpClient();
        public static Uri BaseUri = new Uri("https://api.tradestation.com/");
        public static Uri TokenUri = new Uri("https://signin.tradestation.com/oauth/token");
        public string _clientId;
        public string _clientSecret;

        public const string routeGetToken = "v1/oauth2/token";
        public const string routePlaceOrder = "v3/orderexecution/orders";
        public const string routeReplaceOrder = "v3/orderexecution/orders/{0}";
        public const string routeCancelOrder = "v3/orderexecution/orders/{0}";
        public const string routeGetAccounts = "v3/brokerage/accounts";
        public const string routeGetOrders = "v3/brokerage/accounts/{0}/orders";
        public const string routeGetPositions = "v3/brokerage/accounts/{0}/positions";

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

        public TradeStationHelper(string clientId, string clientSecret) 
        { 
            _clientId = clientId;
            _clientSecret = clientSecret;
        }
        public TradeStationHelper(string baseUri, string clientId, string clientSecret) : this(clientId, clientSecret)
        {
            BaseUri = new Uri(baseUri);
        }

        public async Task<AccessTokenContainer> GetAccessToken(string authToken) //, string clientId, string clientSecret)
        {
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "authorization_code"));
            postData.Add(new KeyValuePair<string, string>("access_type", "offline"));
            postData.Add(new KeyValuePair<string, string>("code", $"{authToken}"));
            postData.Add(new KeyValuePair<string, string>("client_id", _clientId));
            postData.Add(new KeyValuePair<string, string>("client_secret", _clientSecret));
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

        public async Task<AccessTokenContainer> RefreshAccessToken(AccessTokenContainer accessTokenContainer) //, string clientId, string clientSecret)
        {
            try
            {
                List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", "refresh_token"));
                postData.Add(new KeyValuePair<string, string>("client_id", _clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", _clientSecret));
                //postData.Add(new KeyValuePair<string, string>("refresh_token", System.Net.WebUtility.UrlEncode(accessTokenContainer.RefreshToken)));
                postData.Add(new KeyValuePair<string, string>("refresh_token", accessTokenContainer.RefreshToken));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                var rawSTring = await content.ReadAsStringAsync();
                var request = new HttpRequestMessage(HttpMethod.Post, TokenUri) // new Uri(BaseUri, routeGetToken)) //Uri."https://api.tdameritrade.com/v1/oauth2/token"); // ; 
                {
                    Method = HttpMethod.Post,
                    Content = content
                };

                var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

                var newAccessTokenContainer = Utility.DeserializeJsonFromStream<AccessTokenContainer>(await response.Content.ReadAsStreamAsync());
                //Add the refresh token back as it doesn't come back with the payload.
                newAccessTokenContainer.RefreshToken = accessTokenContainer.RefreshToken;

                newAccessTokenContainer.RefreshTokenExpiresIn = int.MaxValue;
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

        private static string ConvertTradeInstructionToTradeStation(string tdaInstruction)
        {
            var instruction = tdaInstruction;

            switch(tdaInstruction.ToUpper())
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

            switch(orderType.ToUpper())
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



        public async Task ReplaceOrder(AccessTokenContainer accessTokenContainer, string accountId, string orderId, Tda.Model.Order newOrder)
        {
            var tsOrder = ConvertTdaOrder(newOrder, accountId);

            var uri = new Uri(BaseUri, string.Format(routeReplaceOrder, orderId));

            var request = new HttpRequestMessage(HttpMethod.Put, uri)
            {
                Method = HttpMethod.Put,
                Content = new StringContent(JsonConvert.SerializeObject(tsOrder), Encoding.UTF8, "application/json")
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(newOrder);
                throw new Exception($"Error Replacing Order {await response.Content.ReadAsStringAsync()} ");
            };


        }

        public async Task CancelOrder(AccessTokenContainer accessTokenContainer, string accountId, Tda.Model.Order order)
        {

            var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(BaseUri, string.Format(routeCancelOrder, order.orderId)))
            {
                Method = HttpMethod.Delete,
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(true);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

        }



        public async Task<GetOrderResponse> GetOrders(AccessTokenContainer accessTokenContainer, string accountId)
        {


            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetOrders, accountId)));

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var orderResponse = JsonConvert.DeserializeObject<GetOrderResponse>(await response.Content.ReadAsStringAsync());

            return orderResponse;
        }

        public async Task<PositionResponse> GetPositions(AccessTokenContainer accessTokenContainer, string accountId)
        {

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, string.Format(routeGetPositions, accountId)));

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //Debug.Write(order);
                throw new Exception($"Error Creating Order {await response.Content.ReadAsStringAsync()} ");
            };

            var positionResponse = JsonConvert.DeserializeObject<PositionResponse>(await response.Content.ReadAsStringAsync());

            return positionResponse;
        }

        public async Task<Securitiesaccount> GetAccount(AccessTokenContainer accessTokenContainer, string accountId)
        {
            var securitiesaccount = new Securitiesaccount();
            var orderResponse = await GetOrders(accessTokenContainer, accountId).ConfigureAwait(false);
            var postionResponse = await GetPositions(accessTokenContainer, accountId).ConfigureAwait(false);


            var tdaPostion = new List<Tda.Model.Position>();

            foreach(var postion in postionResponse.Positions)
            {
                tdaPostion.Add(new Tda.Model.Position()
                {
                    averagePrice = float.Parse(postion.AveragePrice),
                    longQuantity = postion.LongShort.Equals("LONG", StringComparison.InvariantCultureIgnoreCase) ? float.Parse(postion.Quantity) : 0.0F,
                    shortQuantity = postion.LongShort.Equals("SHORT", StringComparison.InvariantCultureIgnoreCase) ? Math.Abs(float.Parse(postion.Quantity)) : 0.0F,
                    instrument = new Instrument { symbol = postion.Symbol}
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
                    orderType= ConvertOrderTypeFromTradeStation(order.OrderType),
                    stopPrice = order.StopPrice,
                    price = order.LimitPrice,
                    orderLegCollection = new List<OrderLeg> { new OrderLeg { instrument = new Instrument { symbol = order.Legs[0].Symbol } } }
                }); 
            }
            securitiesaccount.orderStrategies = tdaOrder.ToArray();

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
                    status= orderStatus; 
                    break;
            }

            return status;
        }

        public async Task<List<Model.Account>> GetAccounts(AccessTokenContainer accessTokenContainer)
        {
            //var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts));

            //request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);
            var accounts = new List<Model.Account>();

            var request = new HttpRequestMessage(HttpMethod.Get, new Uri(BaseUri, routeGetAccounts))
            {
                Method = HttpMethod.Get,
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
