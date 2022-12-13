﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using TDAmeritradeAPI.Client;
using TdInterface.Model;

namespace TdInterface
{
    public partial class MasterForm : Form
    {
        private IStreamer _streamer;
        private StockQuote _stockQuote = new StockQuote();
        private Securitiesaccount _securitiesaccount;
        private Position _activePosition;
        private Position _initialPosition;
        private CandleList _candleList;
        private bool _trainingWheels = false;
        private Settings _settings = new Settings() { TradeShares = false, MaxRisk = 5M, MaxShares = 4, OneRProfitPercenatage = 25 };
        private Dictionary<ulong, Order> _placedOrders = new Dictionary<ulong, Order>();
        private TextWriterTraceListener _textWriterTraceListener = null;

        public MasterForm()
        {
            try
            {
                _textWriterTraceListener = new TextWriterTraceListener($"{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.log");
                Trace.Listeners.Add(_textWriterTraceListener);

                Debug.WriteLine("Start Master Form");
                InitializeComponent();

                var accessTokenContainer = Utility.GetAccessTokenContainer();

                if (accessTokenContainer == null || accessTokenContainer.IsRefreshTokenExpired || accessTokenContainer.RefreshTokenExpiresInDays < 5)
                {
                    var consumerKey = Utility.GetConsumerKey();
                    if (consumerKey == null)
                    {
                        var frm = new frmConsmerKey();
                        frm.ShowDialog();
                        consumerKey = frm.ConsumerKey;
                        Utility.SaveConsumerKey(consumerKey);
                    }
                    var oAuthLoginForm = new OAuthLoginForm($"https://auth.tdameritrade.com/auth?response_type=code&redirect_uri=http%3A%2F%2Flocalhost&client_id={consumerKey}%40AMER.OAUTHAP");
                    int num2 = (int)oAuthLoginForm.ShowDialog((System.Windows.Forms.IWin32Window)this);
                    Utility.AuthToken = oAuthLoginForm.Code;
                    accessTokenContainer = TdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken)).Result;
                    Utility.SaveAccessTokenContainer(accessTokenContainer);
                }

                Utility.AccessTokenContainer = accessTokenContainer;

                Utility.AccessTokenContainer = TdHelper.RefreshAccessToken(Utility.AccessTokenContainer).Result;
                Utility.UserPrincipal = TdHelper.GetUserPrincipals(Utility.AccessTokenContainer).Result;


                _streamer = new TDStreamer(Utility.UserPrincipal);
                //_streamer.StockQuoteReceived.Subscribe(x => HandleStockQuote(x));
                //_streamer.AcctActivity.Subscribe(a => HandleAcctActivity(a));
                //_streamer.OrderRecieved.Subscribe(o => HandleOrderRecieved(o));
                //_streamer.OrderFilled.Subscribe(o => HandleOrderFilled(o));
                //_streamer.HeartBeat.Subscribe(s => HandleHeartBeat(s));
                //_streamer.Reconnection.Subscribe(r => HandleReconnection(r));
                //_streamer.Disconnection.Subscribe(d => HandleDisconnect(d));


                //var f = new MainForm(_streamer, _settings);
                //f.Show();

                timer1.Start();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                throw;
            }


            //InitializeComponent();
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (Utility.AccessTokenContainer.ExpiresIn < 100)
            {
                Utility.AccessTokenContainer = await TdHelper.RefreshAccessToken(Utility.AccessTokenContainer);
            }
        }

        private void clearCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utility.ClearAccessTokenContainerFile();
        }

        private async void saveCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var accessTokenContainer = await TdHelper.GetAccessToken(WebUtility.UrlDecode(Utility.AuthToken));
            Utility.SaveAccessTokenContainer(accessTokenContainer);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new UserOptionsForm();
            frm.ShowDialog();
            _settings = Utility.GetSettings();
            //ApplySettings();
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            var settings = Utility.GetSettings();
            if (settings != null)
            {
                settings.OneRProfitPercenatage = settings.OneRProfitPercenatage == 0 ? _settings.OneRProfitPercenatage : settings.OneRProfitPercenatage;
                _settings = settings;
            }

        }

        private static Dictionary<string, MainForm> _mainForms = new  Dictionary<string, MainForm>();
        private void btnNewTrade_Click(object sender, EventArgs e)
        {
            var name = $"TdInterface Form {_mainForms.Count}";

            MainForm frm = null;

            if (_mainForms.ContainsKey(txtSymbol.Text.ToUpper()))
            {
                frm = _mainForms[txtSymbol.Text.ToUpper()];
            }
            else
            {
                if (!string.IsNullOrEmpty(txtSymbol.Text))
                {
                    frm = new MainForm(_streamer, _settings, txtSymbol.Text.ToUpper());
                    _mainForms.Add(txtSymbol.Text.ToUpper(), frm);
                }
                else
                {
                    frm = new MainForm(_streamer, _settings, name);
                    _mainForms.Add(name, frm);

                }
                frm.FormClosing += MainForm_FormClosing;
                frm.Show();
            }

            frm.Focus();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                var frm = sender as MainForm;
                _mainForms.Remove(frm.MainFormName);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }



        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _textWriterTraceListener.Flush();
                _textWriterTraceListener.Close();
                _streamer.Dispose();
                _textWriterTraceListener.Dispose();

                foreach(var frm in _mainForms)
                {
                    frm.Value.Close();
                    frm.Value.Dispose();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var futureCalcFrom = new FurtureCalcForm(_streamer);
            futureCalcFrom.Show();
        }
    }
}
