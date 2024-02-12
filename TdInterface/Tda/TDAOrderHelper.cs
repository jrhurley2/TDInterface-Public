using System;
using System.Collections.Generic;
using System.Linq;
using TdInterface.Tda.Model;

namespace TdInterface.Tda
{
    public class TDAOrderHelper
    {
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

        public static double CheckMaxRisk(double maxRisk, double dailyPnl, Settings settings)
        {
            if (!settings.TradeShares && settings.EnableMaxLossLimit)
            {
                var maxLoss = Convert.ToDouble(settings.MaxLossLimitInR * settings.MaxRisk) * -1;

                if (dailyPnl < maxLoss)
                {
                    throw new DailyLossExceededException("You have exceeded your daily loss limit");
                }

                if (settings.PreventRiskExceedMaxLoss)
                {
                    if ((Convert.ToDouble(dailyPnl) - maxRisk) < maxLoss)
                    {
                        if (settings.AdjustRiskNotExceedMaxLoss)
                        {
                            maxRisk = Math.Abs(maxLoss - dailyPnl);
                        }
                        else
                        {
                            throw new DailyLossExceededException("This trade will put you over your daily loss limit");
                        }
                    }
                }
            }

            return maxRisk;
        }

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
    }
}
