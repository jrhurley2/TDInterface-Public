using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDAmeritradeAPI.Client;
using System;
using System.Collections.Generic;
using System.Text;
using Websocket.Client;
using System.IO;

namespace TDAmeritradeAPI.Client.Tests
{
    [TestClass()]
    public class TDStreamerTests
    {
        [TestMethod()]
        public void TDStreamerTest()
        {
            var websocketClient = new WebsocketClient(new Uri("https://fakeuri"));
            var client = new TDStreamer(websocketClient);


            using (var replayFile = new StreamReader($"20220831-102516replay.txt"))
            {
                string message;
                while ((message = replayFile.ReadLine()) != null) 
                {
                    if (message.Contains("LOGIN")) continue;
                    websocketClient.StreamFakeMessage(ResponseMessage.TextMessage(message));
                }
            }



            Assert.Fail();
        }
    }
}