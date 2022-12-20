using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using TdInterface.Interfaces;
using TdInterface.Tda.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace TdInterface.TradeStation
{
    internal class TradeStationStreamer : IStreamer
    {
        private HttpClient   _httpClient = new HttpClient();
        private List<string> _quoteSymbols = new List<string>();

        public IObservable<AcctActivity> AcctActivity => throw new NotImplementedException();

        public IObservable<DisconnectionInfo> Disconnection => throw new NotImplementedException();

        public IObservable<StockQuote> FutureQuoteReceived => throw new NotImplementedException();

        public IObservable<SocketNotify> HeartBeat => throw new NotImplementedException();

        public IObservable<OrderFillMessage> OrderFilled => throw new NotImplementedException();

        public IObservable<OrderEntryRequestMessage> OrderRecieved => throw new NotImplementedException();

        public IObservable<ReconnectionInfo> Reconnection => throw new NotImplementedException();

        public IObservable<StockQuote> StockQuoteReceived => throw new NotImplementedException();

        public WebsocketClient WebsocketClient => throw new NotImplementedException();

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

            //var symbols = string.Join(",", _quoteSymbols);
        }

        private async void ProcessStreamQuotes(CancellationToken cancellationToken)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.tradestation.com/v3/marketdata/stream/quotes/MSFT,BTCUSD"),
                Headers =   {
        { "Authorization", "Bearer TOKEN" },
    },
            };
            using (var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
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
                            Console.WriteLine(line);
                        }
                    }
                }
            }

        }
    }
}
