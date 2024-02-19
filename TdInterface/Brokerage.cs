using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using TdInterface.Tda.Model;
using TdInterface.Interfaces;
using System;
using TdInterface.Model;
using System.Threading.Tasks;
using Websocket.Client;
using Websocket.Client.Models;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;

namespace TdInterface
{
    public abstract class Brokerage : IBrokerage, IStreamer
    {
        public abstract void Initialize();

        #region IBrokerage Abstract Properties
        public abstract AccessTokenContainer AccessTokenContainer { get; set; }
        public abstract IObservable<Securitiesaccount> SecuritiesAccountUpdated { get; }
        public abstract Securitiesaccount Securitiesaccount { get; set; }
        public abstract AccountInfo AccountInfo { get; set; }
        public abstract string LoginUri { get; }
        public abstract bool NeedTokenRefreshed { get; }
        public abstract string AccountId { get; }
        #endregion

        #region IStreamer Abstract Properites
        public abstract IObservable<AcctActivity> AcctActivity { get; }
        public abstract IObservable<DisconnectionInfo> Disconnection { get; }
        public abstract IObservable<Tda.Model.StockQuote> FutureQuoteReceived { get; }
        public abstract IObservable<SocketNotify> HeartBeat { get; }
        public abstract IObservable<OrderFillMessage> OrderFilled { get; }
        public abstract IObservable<OrderEntryRequestMessage> OrderRecieved { get; }
        public abstract IObservable<ReconnectionInfo> Reconnection { get; }
        public abstract IObservable<Model.StockQuote> StockQuoteReceived { get; }
        public abstract WebsocketClient WebsocketClient { get; }
        #endregion

        #region IBrokerage Abstract Methods
        public abstract Task<AccessTokenContainer> GetAccessToken(string authToken);
        public abstract Task<AccessTokenContainer> RefreshAccessToken();
        public abstract Task<ulong> PlaceOrder(string accountId, Order order);
        public abstract Task<Securitiesaccount> GetAccount(string accountId);
        public abstract Task<ulong> ReplaceOrder(string accountId, string orderId, Order newOrder);
        public abstract Task CancelOrder(string accountId, Order order);
        public abstract Order GetInitialLimitOrder(Securitiesaccount securitiesaccount, Order triggerOrder);
        public abstract Model.StockQuote SetStockQuote(Model.StockQuote stockQuote);
        public abstract Model.StockQuote GetStockQuote(string symbol);
        public abstract Task CancelAll(string accountId, string symbol);
        public abstract Task<IStreamer> GetStreamer();
        public abstract Task<UserPrincipal> GetUserPrincipals();
        #endregion

        #region IStreamer Abstract Methods
        public abstract void Dispose();
        public abstract void SubscribeChartData(string tickerSymbol);
        public abstract void SubscribeFuture(string tickerSymbol);
        public abstract void SubscribeQuote(string tickerSymbol);
        #endregion


        #region OrderHelper
        public const string BUY = "BUY";
        public const string BUY_TO_COVER = "BUY_TO_COVER";
        public const string SELL = "SELL";
        public const string SELL_SHORT = "SELL_SHORT";

        public static Order CreateTriggerOcoOrder(string triggerOrderType, string symbol, string instruction, int quantity, double triggerLimit, int firstTargetLimitQuantity, double firstTargetLimitPrice, double stopPrice)
        {
            var exitInstruction = instruction == BUY ? SELL : BUY_TO_COVER;

            Order triggerOrder = null;

            if (triggerOrderType.Equals("MARKET"))
            {
                triggerOrder = CreateMarketOrder(instruction, symbol, quantity);
            }
            else if (triggerOrderType.Equals("LIMIT"))
            {
                triggerOrder = CreateLimitOrder(instruction, symbol, quantity, triggerLimit);
            }
            else
            {
                throw new Exception("Unknow triggerOrderType");
            }

            triggerOrder.orderStrategyType = "TRIGGER";

            var ocoOrder = new Order()
            {
                orderStrategyType = "OCO",
                childOrderStrategies = new List<Order>()
            };
            triggerOrder.childOrderStrategies.Add(ocoOrder);


            var stopOrder = CreateStopOrder(exitInstruction, symbol, quantity, stopPrice);
            ocoOrder.childOrderStrategies.Add(stopOrder);

            var limitOrder = CreateLimitOrder(exitInstruction, symbol, firstTargetLimitQuantity, firstTargetLimitPrice);
            ocoOrder.childOrderStrategies.Add(limitOrder);

            return triggerOrder;
        }

        public static Order CreateTriggerStopOrder(string triggerOrderType, string symbol, string instruction, int quantity, double triggerLimit, double stopPrice)
        {
            var exitInstruction = instruction == BUY ? SELL : BUY_TO_COVER;

            Order triggerOrder = null;

            if (triggerOrderType.Equals("MARKET"))
            {
                triggerOrder = CreateMarketOrder(instruction, symbol, quantity);
            }
            else if (triggerOrderType.Equals("LIMIT"))
            {
                triggerOrder = CreateLimitOrder(instruction, symbol, quantity, triggerLimit);
            }
            else
            {
                throw new Exception("Unknow triggerOrderType");
            }

            triggerOrder.orderStrategyType = "TRIGGER";

            var stopOrder = CreateStopOrder(exitInstruction, symbol, quantity, stopPrice);
            triggerOrder.childOrderStrategies.Add(stopOrder);

            return triggerOrder;
        }

        public static Order CreateLimitOrder(string instruction, string symbol, int quanity, double limitPrice)
        {
            var limitOrder = new Order()
            {
                orderType = "LIMIT",
                session = "NORMAL",
                duration = "DAY",
                price = limitPrice.ToString("0.00"),
                orderStrategyType = "SINGLE",
                orderLegCollection = new List<OrderLeg>() {
                    {
                        new OrderLeg
                        {
                            instruction = instruction,
                            quantity = quanity,
                            instrument = new Instrument
                            {
                                assetType = "EQUITY",
                                symbol = symbol
                            }
                        }
                    }
                },
                childOrderStrategies = new List<Order>()
            };

            return limitOrder;
        }

        public static Order CreateStopOrder(string instuction, string symbol, int quantity, double stopPrice)
        {
            var stopOrder = new Order()
            {
                orderType = "STOP",
                session = "NORMAL",
                duration = "DAY",
                stopPrice = stopPrice.ToString("0.00"),
                orderStrategyType = "SINGLE",
                orderLegCollection = new List<OrderLeg>() { { new OrderLeg { instruction = instuction, quantity = quantity, instrument = new Instrument { assetType = "EQUITY", symbol = symbol } } } },
                childOrderStrategies = new List<Order>()

            };

            return stopOrder;
        }

        public static Order CreateMarketOrder(string instuction, string symbol, int quantity)
        {
            var marketOrder = new Order()
            {
                orderType = "MARKET",
                session = "NORMAL",
                duration = "DAY",
                orderStrategyType = "SINGLE",
                orderLegCollection = new List<OrderLeg>() { { new OrderLeg { instruction = instuction, quantity = quantity, instrument = new Instrument { assetType = "EQUITY", symbol = symbol } } } },
                childOrderStrategies = new List<Order>()
            };

            return marketOrder;
        }


        public static Order GetParentOrder(Order[] orders, Order childOrder)
        {
            if (orders != null)
            {
                foreach (Order order in orders)
                {
                    Order parent = GetParentOrder(order, childOrder);
                    if (parent != null)
                    {
                        return parent;
                    }
                }
            }

            return null;
        }

        public static Order GetStopOrder(List<Order> orders, string symbol)
        {
            return orders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") &&
                                     (o.orderLegCollection != null && o.orderLegCollection[0].instrument.symbol.Equals(symbol, StringComparison.CurrentCultureIgnoreCase)) &&
                                      o.orderType == "STOP").FirstOrDefault();
        }

        public static List<Order> GetOpenOrders(List<Order> orders, string symbol)
        {
            return orders.Where(o => (o.status == "QUEUED" || o.status == "WORKING" || o.status == "PENDING_ACTIVATION") &&
                                     (o.orderLegCollection != null && o.orderLegCollection[0].instrument.symbol.Equals(symbol, StringComparison.CurrentCultureIgnoreCase))).ToList<Order>();

        }

        public static int CalculateShares(double riskPerShare, double maxRisk, double minRisk, bool tradeShares = false)
        {
            double calcShares;

            // If trade shares is true, use the value in maxRisk which will be a max share amount instead of a dollar amount
            if (tradeShares)
            {
                calcShares = maxRisk;
            }
            else
            {
                // check if the user has the option enabled to minimize how little the risk can be to help avoid issues with slippp
                var rps = riskPerShare > minRisk ? riskPerShare : minRisk;
                calcShares = maxRisk / rps;
            }

            var quantity = Convert.ToInt32(calcShares);

            return quantity;
        }

        //TODO: UNCOMMENT AND GET WORKING AGAIN, SEPERATE THE SETTINGS FROM THE FORMS APP
        //public static double CheckMaxRisk(double maxRisk, double dailyPnl, Settings settings)
        //{
        //    if (!settings.TradeShares && settings.EnableMaxLossLimit)
        //    {
        //        var maxLoss = Convert.ToDouble(settings.MaxLossLimitInR * settings.MaxRisk) * -1;

        //        if (dailyPnl < maxLoss)
        //        {
        //            throw new DailyLossExceededException("You have exceeded your daily loss limit");
        //        }

        //        if (settings.PreventRiskExceedMaxLoss)
        //        {
        //            if ((Convert.ToDouble(dailyPnl) - maxRisk) < maxLoss)
        //            {
        //                if (settings.AdjustRiskNotExceedMaxLoss)
        //                {
        //                    maxRisk = Math.Abs(maxLoss - dailyPnl);
        //                }
        //                else
        //                {
        //                    throw new DailyLossExceededException("This trade will put you over your daily loss limit");
        //                }
        //            }
        //        }
        //    }

        //    return maxRisk;
        //}

        private static Order GetParentOrder(Order order, Order child)
        {
            if (order == child)
            {
                return null;
            }

            if (order.childOrderStrategies != null)
            {
                foreach (Order childOrder in order.childOrderStrategies)
                {
                    if (childOrder == child)
                    {
                        return order;
                    }

                    Order parentOrder = GetParentOrder(childOrder, child);
                    if (parentOrder != null)
                    {
                        return parentOrder;
                    }
                }
            }

            return null;
        }
        #endregion

        public static T DeserializeJsonFromStream<T>(Stream stream)
        {
            if (stream == null || stream.CanRead == false)
                return default(T);

            using (var sr = new StreamReader(stream))
            using (var jtr = new JsonTextReader(sr))
            {
                var js = new JsonSerializer();
                var searchResult = js.Deserialize<T>(jtr);
                return searchResult;
            }

        }

        public static AccessTokenContainer GetAccessTokenContainer(string tokenFile)
        {
            try
            {
                var bytesToDecrypt = File.ReadAllBytes(tokenFile);
                var decrypted = ProtectedData.Unprotect(bytesToDecrypt, GetEntropy(), DataProtectionScope.CurrentUser);

                var accessTokenContainerSTring = UnicodeEncoding.ASCII.GetString(decrypted);
                return JsonConvert.DeserializeObject<AccessTokenContainer>(accessTokenContainerSTring);
            }
            catch
            {
                return null;
            }
        }

        public static void SaveAccessTokenContainer(string tokenFileName, AccessTokenContainer accessTokenContainer)
        {
            var accessTokenAsString = JsonConvert.SerializeObject(accessTokenContainer);

            var bytesToEncrypt = UnicodeEncoding.ASCII.GetBytes(accessTokenAsString);
            var encrypted = ProtectedData.Protect(bytesToEncrypt, GetEntropy(), DataProtectionScope.CurrentUser);
            File.WriteAllBytes(tokenFileName, encrypted);
        }

        public static byte[] GetEntropy()
        {
            return UnicodeEncoding.ASCII.GetBytes("TDInterface");
        }

    }
}
