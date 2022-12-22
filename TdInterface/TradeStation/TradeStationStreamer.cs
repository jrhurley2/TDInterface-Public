using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading;
using TdInterface.Interfaces;
using TdInterface.Model;
using TdInterface.Tda.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace TdInterface.TradeStation
{
    internal class TradeStationStreamer : IStreamer
    {
        private HttpClient   _httpClient = new HttpClient();
        private List<string> _quoteSymbols = new List<string>();


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

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SubscribeChartData(UserPrincipal userPrincipals, string tickerSymbol)
        {
            throw new NotImplementedException();
        }

        public void SubscribeFuture(UserPrincipal userPrincipals, string tickerSymbol)
        {
            throw new NotImplementedException();
        }

        public void SubscribeQuote(UserPrincipal userPrincipals, string tickerSymbol)
        {
            if (!_quoteSymbols.Contains(tickerSymbol.ToUpper()))
            {
                _quoteSymbols.Add(tickerSymbol.ToUpper());
            }


            Thread t = new Thread(new ThreadStart(ProcessStreamQuotes));
            t.Start();
            //ProcessStreamQuotes(Utility.AccessTokenContainer);
            //var symbols = string.Join(",", _quoteSymbols);
        }

        private async void ProcessStreamQuotes() //AccessTokenContainer accessTokenContainer)
        {

            var accessTokenContainer = Utility.AccessTokenContainer;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(string.Format("https://api.tradestation.com/v3/marketdata/stream/quotes/{0}", string.Join(",", _quoteSymbols)))
            };

            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessTokenContainer.AccessToken);

            using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = await reader.ReadLineAsync();
                            if (line == null) break;

                            if (line.Contains("Heartbeat")) break;
                            var stockQuote = JsonConvert.DeserializeObject<TradeStation.Model.StockQuote>(line);
                            Debug.WriteLine(line);
                            _stockQuoteRecievedSubject.OnNext(stockQuote);
                        }
                    }
                }
            }

        }
    }
}
