﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Reflection;
using System.Text;
using System.Threading;
using TdInterface.Interfaces;
using TdInterface.Tda.Model;
using Websocket.Client;
using Websocket.Client.Models;

namespace TdInterface.Tda
{
    public class TDStreamer : IDisposable, IStreamer
    {
        private bool _isConnected = false;
        private IBrokerage _brokerage;
        private UserPrincipal _userPrincipal;
        private bool _isDisposing;
        private StreamerSettings.Credentials _credentials;
        private StreamerSettings.Request _loginRequest;

        private WebsocketClient _ws;
        private List<string> _quoteSymbols = new List<string>();


        private readonly Subject<TdInterface.Model.StockQuote> _stockQuoteRecievedSubject = new Subject<TdInterface.Model.StockQuote>();
        public IObservable<TdInterface.Model.StockQuote> StockQuoteReceived => _stockQuoteRecievedSubject.AsObservable();

        private readonly Subject<StockQuote> _futureQuoteRecievedSubject = new Subject<StockQuote>();
        public IObservable<StockQuote> FutureQuoteReceived => _futureQuoteRecievedSubject.AsObservable();

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

        private StreamWriter _replayFile;

        public WebsocketClient WebsocketClient
        {
            get
            {
                return _ws;
            }
        }

        public TDStreamer(WebsocketClient testSocketClient)
        {
            _ws = testSocketClient;
            SubscribeWebSocketMessages(new UserPrincipal(), testSocketClient);
        }

        public TDStreamer(IBrokerage brokerage)
        {
            _brokerage = brokerage;
            //_userPrincipal = brokerage.GetUserPrincipals().Result;
            //}
            //public TDStreamer(UserPrincipal userPrincipals)
            //{
            //    _userPrincipal = userPrincipals;

            string currentPath = Directory.GetCurrentDirectory();
            string replayFolder = Path.Combine(currentPath, "replays");
            if (!Directory.Exists(replayFolder))
                Directory.CreateDirectory(replayFolder);

            _replayFile = new StreamWriter($"{replayFolder}\\{DateTime.Now.ToString("yyyyMMdd-HHmmss")}replay.txt");

            ConnectSocket();
        }

        private void ConnectSocket()
        {
            _userPrincipal = _brokerage.GetUserPrincipals().Result;
            _credentials = new StreamerSettings.Credentials
            {
                userid = _userPrincipal.accounts[0].accountId,
                token = _userPrincipal.streamerInfo.token,
                company = _userPrincipal.accounts[0].company,
                segment = _userPrincipal.accounts[0].segment,
                cddomain = _userPrincipal.accounts[0].accountCdDomainId,
                usergroup = _userPrincipal.streamerInfo.userGroup,
                accesslevel = _userPrincipal.streamerInfo.accessLevel,
                authorized = "Y",
                timestamp = Convert.ToInt64(ConvertToUnixTimestamp(Convert.ToDateTime(_userPrincipal.streamerInfo.tokenTimestamp))),
                appid = _userPrincipal.streamerInfo.appId,
                acl = _userPrincipal.streamerInfo.acl
            };

            //Convert credentials to dictionary
            var cred = _credentials.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(p => p.Name, p => p.GetValue(_credentials, null));

            var _reqs = new List<StreamerSettings.Request>();

            _loginRequest = new StreamerSettings.Request
            {
                service = "ADMIN",
                command = "LOGIN",
                requestid = "0",
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    credential = ToQueryString(cred),
                    token = _userPrincipal.streamerInfo.token,
                    version = "1.0",
                    qoslevel = "0"
                }
            };

            _reqs.Add(_loginRequest);

            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };


            var exitEvent = new ManualResetEvent(false);

            var url = new Uri($"wss://{_userPrincipal.streamerInfo.streamerSocketUrl}/ws");

            _ws = new WebsocketClient(url);
            _ws.ReconnectTimeout = TimeSpan.FromSeconds(30);

            SubscribeWebSocketMessages(_userPrincipal, _ws);

            _ws.Start();

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }

        private static string SanatizeAccountNumbers(UserPrincipal userPrincipal, string message)
        {
            int index = 0;
            string newMessage = message;
            foreach (var account in userPrincipal.accounts)
            {
                newMessage = newMessage.Replace(account.accountId, $"sanatizedAccountNumber{index}");
            }

            return newMessage;
        }


        private int reconnectionCount = 0;
        private void SubscribeWebSocketMessages(UserPrincipal userPrincipals, WebsocketClient client)
        {
            client.DisconnectionHappened.Subscribe(dis =>
            {
                try
                {
                    _disconnectionInfo.OnNext(dis);
                    //Debug.WriteLine($"Disconnect sleeping");
                    //Thread.Sleep(10000);
                    //Debug.WriteLine($"Disconnect awake");
                    //if (reconnectionCount >= 100)
                    //{
                    //    Debug.WriteLine($"reconnectionCount exceeded retry.");
                    //}
                    //reconnectionCount++;

                    //Debug.WriteLine($"DisconnectionHappened {dis.Type}");
                    //Debug.WriteLine($"Calling ConnectSocket");
                    //ConnectSocket();
                    //Debug.WriteLine("Calling SubscribeQuote");
                    //SubscribeQuote();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Unable to connect {ex.Message}");
                    Debug.WriteLine(ex);
                }

            });

            client.ReconnectionHappened.Subscribe(info =>
            {
                Debug.WriteLine($"Reconnection happened, type: {info.Type}");
                reconnectionCount = 0;
                _reconnectionInfo.OnNext(info);
            });

            client.MessageReceived.Subscribe(msg =>
            {
                _socketNotify.OnNext(new SocketNotify());

                try
                {
                    if (_replayFile != null)
                        _replayFile.WriteLine(SanatizeAccountNumbers(userPrincipals, msg.Text));
                }
                catch
                {
                    Debug.WriteLine("error writing to replay file");
                }

                var v = JsonConvert.DeserializeObject<Dictionary<string, object>>(msg.Text);

                if (v.ContainsKey("response"))
                {
                    Debug.WriteLine(msg.Text);
                    var r = v["response"];
                    var response = JsonConvert.DeserializeObject<List<SocketResponse>>(v["response"].ToString());
                    var command = response[0].command;
                    if (command == "LOGIN")
                    {
                        var reqs = new List<StreamerSettings.Request>();
                        var acctAcivity = new StreamerSettings.Request
                        {
                            command = "SUBS",
                            service = "ACCT_ACTIVITY",
                            requestid = "2",
                            account = userPrincipals.accounts[0].accountId,
                            source = userPrincipals.streamerInfo.appId,
                            parameters = new StreamerSettings.Parameters
                            {
                                keys = userPrincipals.streamerSubscriptionKeys.keys[0].key,
                                fields = "0,1,2,3"
                            }

                        };


                        reqs.Add(acctAcivity);

                        var request = new StreamerSettings.Requests()
                        {
                            requests = reqs.ToArray()
                        };
                        var firstreq = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
                        client.Send(firstreq);

                        Console.WriteLine(msg);
                    }
                    else if (command == "SUBS")
                    {
                        Debug.WriteLine(msg.Text);
                        Console.WriteLine(msg);
                    }
                }
                else if (v.ContainsKey("notify"))
                {
                    var notifyList = JsonConvert.DeserializeObject<List<SocketNotify>>(v["notify"].ToString());
                    foreach (var notify in notifyList)
                    {
                        _socketNotify.OnNext(notify);
                    }
                }
                else if (v.ContainsKey("data"))
                {
                    var r = v["data"];
                    var data = JsonConvert.DeserializeObject<List<SocketData>>(v["data"].ToString());

                    foreach (var socketData in data)
                    {
                        var command = socketData.command;
                        var service = socketData.service;
                        if (service == "QUOTE")
                        {
                            foreach (var quoteJson in socketData.content)
                            {

                                var stockQuote = new StockQuote(quoteJson);
                                _stockQuoteRecievedSubject.OnNext(stockQuote);
                                Debug.WriteLine("TDStreamer:" + JsonConvert.SerializeObject(stockQuote));
                            }
                        }
                        else if (service == "LEVELONE_FUTURES")
                        {
                            foreach (var quoteJson in socketData.content)
                            {

                                var futureQuote = new StockQuote(quoteJson);
                                _futureQuoteRecievedSubject.OnNext(futureQuote);
                                Debug.WriteLine(JsonConvert.SerializeObject(futureQuote));
                            }
                            Console.WriteLine($"Futures {socketData.content}");
                        }
                        else if (service == "ACCT_ACTIVITY")
                        {
                            //Signal we have Account Activity
                            _acctActivity.OnNext(new AcctActivity());

                            foreach (var content in socketData.content)
                            {

                                //if (content["2"] == "OrderEntryRequest")
                                //{
                                //    try
                                //    {
                                //        //Parsing was inconsitnat don't have a complete XML Schema, and wasn't using it on the other side.
                                //        //var orderEntryRequestMessage = OrderEntryRequestMessage.ParseXml(content["3"]);
                                //        var orderEntryRequestMessage = new OrderEntryRequestMessage();
                                //        _orderEntryRequestMessage.OnNext(orderEntryRequestMessage);
                                //    }
                                //    catch (Exception ex)
                                //    {
                                //        Debug.WriteLine(ex.Message);
                                //        Debug.WriteLine(ex.StackTrace);
                                //    }
                                //}
                                if (content["2"] == "OrderFill")
                                {
                                    try
                                    {
                                        Debug.WriteLine(content["3"]);
                                        //Check that the order is a stock order, will throw excption if it is options, etc...
                                        if (content["3"].Contains("EquityOrderT"))
                                        {
                                            var orderFillMessage = OrderFillMessage.ParseXml(content["3"]);
                                            _orderFillMessage.OnNext(orderFillMessage);
                                        }
                                        else
                                        {
                                            Debug.WriteLine("We don't handle messages other than EquityOrderT");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Debug.WriteLine(ex.Message);
                                        Debug.WriteLine(ex.StackTrace);
                                    }
                                }
                            }
                        }
                        else if (service == "CHART_EQUITY")
                        {
                            var stockChartBar = new StockChartBar(socketData.content[0]);
                            Debug.WriteLine(msg.Text);
                        }
                        else
                        {
                            Debug.WriteLine(msg.Text);
                        }
                        Console.WriteLine(msg);
                    }
                }
                Console.WriteLine($"Message received: {msg}");
            });
        }

        public int _quoteRequestId = 0;

        public void SubscribeQuote(string tickerSymbol)
        {
            if (!_quoteSymbols.Contains(tickerSymbol.ToUpper()))
            {
                _quoteSymbols.Add(tickerSymbol.ToUpper());
            }

            SubscribeQuote();
        }

        private void SubscribeQuote()
        {
            var symbols = string.Join(",", _quoteSymbols);

            var _reqs = new List<StreamerSettings.Request>();

            _quoteRequestId++;
            var quoteRequest = new StreamerSettings.Request
            {
                service = "QUOTE",
                command = "SUBS",
                requestid = "1", //_quoteRequestId.ToString(),
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    keys = symbols,
                    fields = "0,1,2,3"
                }
            };
            _reqs.Add(quoteRequest);
            //}
            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }

        List<string> _futureSymbols = new List<string>();

        public void SubscribeFuture(string tickerSymbol)
        {
            if (!_futureSymbols.Contains(tickerSymbol.ToUpper()))
            {
                _futureSymbols.Add(tickerSymbol.ToUpper());
            }

            var symbols = string.Join(",", _futureSymbols);

            var _reqs = new List<StreamerSettings.Request>();

            _quoteRequestId++;
            var quoteRequest = new StreamerSettings.Request
            {
                service = "LEVELONE_FUTURES",
                command = "SUBS",
                requestid = "1", //_quoteRequestId.ToString(),
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    keys = symbols,
                    fields = "0,1,2,3,4"
                }
            };
            _reqs.Add(quoteRequest);
            //}
            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }

        //List<string> _futureSymbols= new List<string>();

        //public void SubscribeFuture(UserPrincipal userPrincipals, string tickerSymbol)
        //{
        //    if (!_futureSymbols.Contains(tickerSymbol.ToUpper()))
        //    {
        //        _futureSymbols.Add(tickerSymbol.ToUpper());
        //    }

        //    var symbols = string.Join(",", _futureSymbols);

        //    var _reqs = new List<StreamerSettings.Request>();

        //    int requestId = 0;
        //    //foreach (var symbol in _quoteSymbols)
        //    //{
        //    //requestId++;
        //    _quoteRequestId++;
        //    var quoteRequest = new StreamerSettings.Request
        //    {
        //        service = "LEVELONE_FUTURES",
        //        command = "SUBS",
        //        requestid = "1", //_quoteRequestId.ToString(),
        //        account = userPrincipals.accounts[0].accountId,
        //        source = userPrincipals.streamerInfo.appId,
        //        parameters = new StreamerSettings.Parameters
        //        {
        //            keys = symbols,
        //            fields = "0,1,2,3,4"
        //        }
        //    };
        //    _reqs.Add(quoteRequest);
        //    //}
        //    var request = new StreamerSettings.Requests()
        //    {
        //        requests = _reqs.ToArray()
        //    };

        //    var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        //    _ws.Send(req);
        //}

        public void SubscribeChartData(string tickerSymbol)
        {
            var _reqs = new List<StreamerSettings.Request>();
            var chartRequest = new StreamerSettings.Request
            {
                service = "CHART_EQUITY",
                command = "SUBS",
                requestid = "1",
                account = _userPrincipal.accounts[0].accountId,
                source = _userPrincipal.streamerInfo.appId,
                parameters = new StreamerSettings.Parameters
                {
                    keys = tickerSymbol,
                    fields = "0,1,2,3,4,5,6,7,8"
                }
            };
            _reqs.Add(chartRequest);

            var request = new StreamerSettings.Requests()
            {
                requests = _reqs.ToArray()
            };

            var req = JsonConvert.SerializeObject(request, Formatting.None, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            _ws.Send(req);
        }
        public static double ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalMilliseconds);
        }

        public static string ToQueryString(Dictionary<string, object> dict)
        {
            if (dict.Count == 0) return string.Empty;

            var buffer = new StringBuilder();
            int count = 0;
            bool end = false;

            foreach (var key in dict.Keys)
            {
                if (count == dict.Count - 1) end = true;

                if (end)
                    buffer.AppendFormat("{0}={1}", key, dict[key]);
                else
                    buffer.AppendFormat("{0}={1}&", key, dict[key]);

                count++;
            }

            return buffer.ToString();
        }

        public void Dispose()
        {
            if (_ws != null) _ws.Dispose();
            if (_replayFile != null)
            {
                _replayFile.Flush();
                _replayFile.Dispose();
            }
            _stockQuoteRecievedSubject.Dispose();
        }
    }
}
