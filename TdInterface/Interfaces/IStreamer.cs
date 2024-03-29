using System;
using EZTM.Forms.UI.Tda.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace EZTM.Forms.UI.Interfaces
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
        IObservable<EZTM.Forms.UI.Model.StockQuote> StockQuoteReceived { get; }
        WebsocketClient WebsocketClient { get; }

        void Dispose();
        void SubscribeChartData(string tickerSymbol);
        void SubscribeFuture(string tickerSymbol);
        void SubscribeQuote(string tickerSymbol);
    }
}