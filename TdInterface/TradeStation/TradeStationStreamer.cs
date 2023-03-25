using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using TdInterface.Interfaces;
using TdInterface.Tda.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace TdInterface.TradeStation
{
    public class TradeStationStreamer : IStreamer
    {
        private HttpClient _httpClient = new HttpClient();
        private List<string> _quoteSymbols = new List<string>();
        private IBrokerage _broker = null;

        private readonly Subject<AcctActivity> _acctActivity = new Subject<AcctActivity>();
        public IObservable<AcctActivity> AcctActivity => _acctActivity.AsObservable();

        private readonly Subject<OrderEntryRequestMessage> _orderEntryRequestMessage = new Subject<OrderEntryRequestMessage>();
        public IObservable<OrderEntryRequestMessage> OrderRecieved => _orderEntryRequestMessage.AsObservable();

        private readonly Subject<OrderFillMessage> _orderFillMessage = new Subject<OrderFillMessage>();
        public IObservable<OrderFillMessage> OrderFilled => _orderFillMessage.AsObservable();

        private readonly Subject<SocketNotify> _socketNotify = new Subject<SocketNotify>();
        public IObservable<SocketNotify> HeartBeat => _socketNotify.AsObservable();


        private readonly Subject<DisconnectionInfo> _disconnectionInfo = new Subject<DisconnectionInfo>();
        public IObservable<DisconnectionInfo> Disconnection => _disconnectionInfo.AsObservable();

        private readonly Subject<ReconnectionInfo> _reconnectionInfo = new Subject<ReconnectionInfo>();
        public IObservable<ReconnectionInfo> Reconnection => _reconnectionInfo.AsObservable();


        public WebsocketClient WebsocketClient => throw new NotImplementedException();

        IObservable<Tda.Model.StockQuote> IStreamer.FutureQuoteReceived => throw new NotImplementedException();

        private readonly Subject<TdInterface.Model.StockQuote> _stockQuoteRecievedSubject = new Subject<TdInterface.Model.StockQuote>();
        public IObservable<TdInterface.Model.StockQuote> StockQuoteReceived => _stockQuoteRecievedSubject.AsObservable();

        public TradeStationStreamer(IBrokerage tradeStationHelper)
        {
            _broker = tradeStationHelper;
        }

        public void StartAccountStream()
        {
            var t = new Thread(new ThreadStart(ProcessStreamAccount));
            t.Start();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SubscribeChartData(string tickerSymbol)
        {
            throw new NotImplementedException();
        }

        public void SubscribeFuture(string tickerSymbol)
        {
            throw new NotImplementedException();
        }

        private static Thread _quoteStreamThread = null;

        public void SubscribeQuote(string tickerSymbol)
        {
            if (!_quoteSymbols.Contains(tickerSymbol.ToUpper()))
            {
                _quoteSymbols.Add(tickerSymbol.ToUpper());
            }

            _quoteStreamThread = new Thread(new ThreadStart(ProcessStreamQuotes));
            _quoteStreamThread.Start();
        }

        public static List<Order> FindNewFilledOrder(Securitiesaccount previousAccount, Securitiesaccount currentAccount)
        {
            var x = currentAccount.orderStrategies.Except(currentAccount.orderStrategies.Join(previousAccount.orderStrategies, c => c.orderId, p => p.orderId, (c, p) => c)).ToList<Order>();
            return x;
        }
        private async void ProcessStreamAccount()
        {
            Securitiesaccount lastSecuritiesaccount = null;
            while (true)
            {
                try
                {
                    var securitiesaccount = await _broker.GetAccount(_broker.AccountId).ConfigureAwait(false);
                    _broker.Securitiesaccount = securitiesaccount;
                    if (lastSecuritiesaccount != null)
                    {

                        ////Order Filled
                        if (lastSecuritiesaccount.orderStrategies.Where(o => o.status.Equals("FLL")).Count() != securitiesaccount.orderStrategies.Where(o => o.status.Equals("FLL")).Count())
                        {
                            var newOrders = FindNewFilledOrder(lastSecuritiesaccount, securitiesaccount);
                            foreach (var order in newOrders)
                            {
                                _orderFillMessage.OnNext(new OrderFillMessage { Order = new OrderFillMessageOrder { OrderKey = ulong.Parse(order.orderId), Security = new OrderFillMessageOrderSecurity { Symbol = order.orderLegCollection[0].instrument.symbol } } });
                            }
                        }
                    }

                    _acctActivity.OnNext(new Tda.Model.AcctActivity());

                    lastSecuritiesaccount = securitiesaccount;
                    _broker.Securitiesaccount = securitiesaccount;
                }
                catch(Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    Debug.WriteLine(ex.StackTrace);

                }

                Thread.Sleep(2000);
            }
        }

        private async void ProcessStreamQuotes() 
        {

            while (true)
            {
                var accessTokenContainer = _broker.AccessTokenContainer;
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(string.Format("https://api.tradestation.com/v3/marketdata/stream/quotes/{0}", string.Join(",", _quoteSymbols)))
                };

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

                using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
                {
                    try
                    {
                        response.EnsureSuccessStatusCode();
                        using (var stream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                while (!reader.EndOfStream)
                                {
                                    var line = await reader.ReadLineAsync().ConfigureAwait(false);
                                    if (line == null) break;

                                    if (line.Contains("Heartbeat")) continue;
                                    Debug.WriteLine(line);
                                    var stockQuote = JsonConvert.DeserializeObject<TradeStation.Model.StockQuote>(line);
                                    _stockQuoteRecievedSubject.OnNext(stockQuote);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
