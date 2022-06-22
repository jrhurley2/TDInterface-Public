using System;
using System.Collections.Generic;
using System.Text;
using TdInterface.Model;

namespace TdInterface
{
    public class OrderHelper
    {
        public static Order CreateTriggerOcoOrder(string triggerOrderType, string symbol, int quantity, double triggerLimit, int limitQuantity, string instruction, double stopPrice, double limitPrice)
        {
            var exitInstruction = instruction == "BUY" ? "SELL" : "BUY";

            Order triggerOrder = null;

            if(triggerOrderType.Equals("MARKET"))
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

            //var triggerOrder = new Order()
            //{
            //    orderStrategyType = "TRIGGER",
            //    orderType = triggerOrderType,
            //    session = "NORMAL",
            //    duration = "DAY",
            //    price = triggerOrderType == "LIMIT" ? triggerLimit.ToString("0.00") : String.Empty,
            //    orderLegCollection = new List<OrderLeg>() {
            //        {
            //            new OrderLeg
            //            {
            //                instruction = instruction,
            //                quantity = quantity,
            //                instrument = new Instrument()
            //                {
            //                    assetType = "EQUITY",
            //                    symbol = symbol
            //                }
            //            }
            //        }
            //    },
            //    childOrderStrategies = new List<Order>()
            //};

            var ocoOrder = new Order()
            {
                orderStrategyType = "OCO",
                childOrderStrategies = new List<Order>()
            };
            triggerOrder.childOrderStrategies.Add(ocoOrder);


            var stopOrder = CreateStopOrder(exitInstruction, symbol, quantity, stopPrice);

            ocoOrder.childOrderStrategies.Add(stopOrder);

            var limitOrder = CreateLimitOrder(exitInstruction, symbol, limitQuantity, limitPrice);

            ocoOrder.childOrderStrategies.Add(limitOrder);

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


    }
}
