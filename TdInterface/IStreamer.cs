using System;
using TdInterface.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace TDAmeritradeAPI.Client
{
    public interface IStreamer
    {
        IObservable<AcctActivity> AcctActivity { get; }
        IObservable<DisconnectionInfo> Disconnection { get; }
        IObservable<StockQuote> FutureQuoteReceived { get; }
        IObservable<SocketNotify> HeartBeat { get; }
        IObservable<OrderFillMessage> OrderFilled { get; }
        IObservable<OrderEntryRequestMessage> OrderRecieved { get; }
        IObservable<ReconnectionInfo> Reconnection { get; }
        IObservable<StockQuote> StockQuoteReceived { get; }
        WebsocketClient WebsocketClient { get; }

        void Dispose();
        void SubscribeChartData(UserPrincipal userPrincipals, string tickerSymbol);
        void SubscribeFuture(UserPrincipal userPrincipals, string tickerSymbol);
        void SubscribeQuote(UserPrincipal userPrincipals, string tickerSymbol);
    }
}