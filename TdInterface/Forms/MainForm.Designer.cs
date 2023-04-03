﻿
using System.Drawing;

namespace TdInterface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBuyMrkTriggerOco = new System.Windows.Forms.Button();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRisk = new System.Windows.Forms.TextBox();
            this.btnSellMrkTriggerOco = new System.Windows.Forms.Button();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLastError = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSellLmtTriggerOco = new System.Windows.Forms.Button();
            this.btnBuyLmtTriggerOco = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.txtStopToClose = new System.Windows.Forms.TextBox();
            this.btnBreakEven = new System.Windows.Forms.Button();
            this.txtAveragePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.lblShares = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAsk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.chkTradeShares = new System.Windows.Forms.CheckBox();
            this.txtHeartBeat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.txtLimitOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.txtPnL = new System.Windows.Forms.TextBox();
            this.lblPnL = new System.Windows.Forms.Label();
            this.timerGetSecuritiesAccount = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtOneToOne = new System.Windows.Forms.TextBox();
            this.chkDisableFirstTarget = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMoveStop = new System.Windows.Forms.Label();
            this.rbExitMarket = new System.Windows.Forms.RadioButton();
            this.rbExitBidAsk = new System.Windows.Forms.RadioButton();
            this.btnExit33 = new System.Windows.Forms.Button();
            this.btnExit50 = new System.Windows.Forms.Button();
            this.btnExit25 = new System.Windows.Forms.Button();
            this.btnExit100 = new System.Windows.Forms.Button();
            this.btnExit10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundedPanel1 = new TdInterface.CustomControls.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTickerDesc = new System.Windows.Forms.Label();
            this.rpbTickerLogo = new TdInterface.CustomControls.RoundedPictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuyMrkTriggerOco
            // 
            this.btnBuyMrkTriggerOco.AutoSize = true;
            this.btnBuyMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(136)))));
            this.btnBuyMrkTriggerOco.Location = new System.Drawing.Point(6, 23);
            this.btnBuyMrkTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuyMrkTriggerOco.Name = "btnBuyMrkTriggerOco";
            this.btnBuyMrkTriggerOco.Size = new System.Drawing.Size(174, 52);
            this.btnBuyMrkTriggerOco.TabIndex = 0;
            this.btnBuyMrkTriggerOco.TabStop = false;
            this.btnBuyMrkTriggerOco.Text = "Buy Market";
            this.btnBuyMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyMrkTriggerOco.Click += new System.EventHandler(this.btnBuyMrkTriggerOco_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSymbol.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSymbol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtSymbol.Location = new System.Drawing.Point(42, 12);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.PlaceholderText = "Symbol";
            this.txtSymbol.Size = new System.Drawing.Size(88, 24);
            this.txtSymbol.TabIndex = 1;
            this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
            this.txtSymbol.Enter += new System.EventHandler(this.txtSymbol_Enter);
            this.txtSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSymbol_KeyPress);
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            this.txtSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(819, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Risk";
            // 
            // txtRisk
            // 
            this.txtRisk.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRisk.Location = new System.Drawing.Point(819, 383);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(87, 34);
            this.txtRisk.TabIndex = 5;
            this.txtRisk.Text = "5";
            this.txtRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSellMrkTriggerOco
            // 
            this.btnSellMrkTriggerOco.AutoSize = true;
            this.btnSellMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(109)))));
            this.btnSellMrkTriggerOco.Location = new System.Drawing.Point(6, 85);
            this.btnSellMrkTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSellMrkTriggerOco.Name = "btnSellMrkTriggerOco";
            this.btnSellMrkTriggerOco.Size = new System.Drawing.Size(174, 51);
            this.btnSellMrkTriggerOco.TabIndex = 2;
            this.btnSellMrkTriggerOco.TabStop = false;
            this.btnSellMrkTriggerOco.Text = "Sell Market";
            this.btnSellMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellMrkTriggerOco.Click += new System.EventHandler(this.btnSellMrkTriggerOco_Click);
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Location = new System.Drawing.Point(633, 318);
            this.txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(87, 26);
            this.txtLastPrice.TabIndex = 10;
            this.txtLastPrice.TabStop = false;
            this.txtLastPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stop";
            // 
            // txtStop
            // 
            this.txtStop.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStop.Location = new System.Drawing.Point(540, 383);
            this.txtStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(85, 34);
            this.txtStop.TabIndex = 2;
            this.txtStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStop.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // txtLastError
            // 
            this.txtLastError.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastError.Location = new System.Drawing.Point(918, 605);
            this.txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.ReadOnly = true;
            this.txtLastError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLastError.Size = new System.Drawing.Size(291, 108);
            this.txtLastError.TabIndex = 34;
            this.txtLastError.TabStop = false;
            this.txtLastError.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLastError_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSellLmtTriggerOco);
            this.groupBox1.Controls.Add(this.btnBuyLmtTriggerOco);
            this.groupBox1.Controls.Add(this.btnSellMrkTriggerOco);
            this.groupBox1.Controls.Add(this.btnBuyMrkTriggerOco);
            this.groupBox1.Location = new System.Drawing.Point(540, 454);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 144);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " To Open";
            // 
            // btnSellLmtTriggerOco
            // 
            this.btnSellLmtTriggerOco.AutoSize = true;
            this.btnSellLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(109)))));
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(186, 83);
            this.btnSellLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            this.btnSellLmtTriggerOco.Size = new System.Drawing.Size(170, 51);
            this.btnSellLmtTriggerOco.TabIndex = 3;
            this.btnSellLmtTriggerOco.TabStop = false;
            this.btnSellLmtTriggerOco.Text = "Sell Limit";
            this.btnSellLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellLmtTriggerOco.Click += new System.EventHandler(this.btnSellLmtTriggerOco_Click);
            // 
            // btnBuyLmtTriggerOco
            // 
            this.btnBuyLmtTriggerOco.AutoSize = true;
            this.btnBuyLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(136)))));
            this.btnBuyLmtTriggerOco.Location = new System.Drawing.Point(186, 23);
            this.btnBuyLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            this.btnBuyLmtTriggerOco.Size = new System.Drawing.Size(170, 52);
            this.btnBuyLmtTriggerOco.TabIndex = 1;
            this.btnBuyLmtTriggerOco.TabStop = false;
            this.btnBuyLmtTriggerOco.Text = "Buy Limit";
            this.btnBuyLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyLmtTriggerOco.Click += new System.EventHandler(this.btnBuyLmtTriggerOco_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnCancelAll.Location = new System.Drawing.Point(729, 604);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(167, 58);
            this.btnCancelAll.TabIndex = 31;
            this.btnCancelAll.TabStop = false;
            this.btnCancelAll.Text = "Cancel All";
            this.btnCancelAll.UseVisualStyleBackColor = false;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // txtStopToClose
            // 
            this.txtStopToClose.Location = new System.Drawing.Point(546, 687);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.Size = new System.Drawing.Size(172, 26);
            this.txtStopToClose.TabIndex = 6;
            this.txtStopToClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStopToClose.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnBreakEven.Location = new System.Drawing.Point(546, 604);
            this.btnBreakEven.Name = "btnBreakEven";
            this.btnBreakEven.Size = new System.Drawing.Size(174, 58);
            this.btnBreakEven.TabIndex = 30;
            this.btnBreakEven.TabStop = false;
            this.btnBreakEven.Text = "Stop/BE";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // txtAveragePrice
            // 
            this.txtAveragePrice.Location = new System.Drawing.Point(918, 318);
            this.txtAveragePrice.Name = "txtAveragePrice";
            this.txtAveragePrice.ReadOnly = true;
            this.txtAveragePrice.Size = new System.Drawing.Size(104, 26);
            this.txtAveragePrice.TabIndex = 16;
            this.txtAveragePrice.TabStop = false;
            this.txtAveragePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(918, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Avg Price";
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(1028, 318);
            this.txtShares.Name = "txtShares";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(87, 26);
            this.txtShares.TabIndex = 18;
            this.txtShares.TabStop = false;
            this.txtShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShares.TextChanged += new System.EventHandler(this.txtShares_TextChanged);
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Location = new System.Drawing.Point(1033, 299);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(49, 19);
            this.lblShares.TabIndex = 17;
            this.lblShares.Text = "Shares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(726, 318);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(87, 26);
            this.txtBid.TabIndex = 12;
            this.txtBid.TabStop = false;
            this.txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(819, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ask";
            // 
            // txtAsk
            // 
            this.txtAsk.Location = new System.Drawing.Point(819, 318);
            this.txtAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.ReadOnly = true;
            this.txtAsk.Size = new System.Drawing.Size(87, 26);
            this.txtAsk.TabIndex = 14;
            this.txtAsk.TabStop = false;
            this.txtAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimit.Location = new System.Drawing.Point(631, 383);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(89, 34);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimit.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // chkTradeShares
            // 
            this.chkTradeShares.AutoSize = true;
            this.chkTradeShares.Location = new System.Drawing.Point(838, 419);
            this.chkTradeShares.Name = "chkTradeShares";
            this.chkTradeShares.Size = new System.Drawing.Size(68, 23);
            this.chkTradeShares.TabIndex = 5;
            this.chkTradeShares.Text = "Shares";
            this.chkTradeShares.UseVisualStyleBackColor = true;
            this.chkTradeShares.CheckedChanged += new System.EventHandler(this.chkTradeShares_CheckedChanged);
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.Location = new System.Drawing.Point(918, 888);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.ReadOnly = true;
            this.txtHeartBeat.Size = new System.Drawing.Size(285, 26);
            this.txtHeartBeat.TabIndex = 36;
            this.txtHeartBeat.TabStop = false;
            this.txtHeartBeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(918, 866);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "HeartBeat";
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(548, 888);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.Size = new System.Drawing.Size(318, 26);
            this.txtConnectionStatus.TabIndex = 38;
            this.txtConnectionStatus.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(549, 866);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(121, 19);
            this.lblConnectionStatus.TabIndex = 37;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimitOffset.Location = new System.Drawing.Point(726, 383);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.Size = new System.Drawing.Size(87, 34);
            this.txtLimitOffset.TabIndex = 4;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1122, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "R";
            // 
            // txtRValue
            // 
            this.txtRValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRValue.Location = new System.Drawing.Point(1122, 383);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.ReadOnly = true;
            this.txtRValue.Size = new System.Drawing.Size(87, 34);
            this.txtRValue.TabIndex = 28;
            this.txtRValue.TabStop = false;
            this.txtRValue.TextChanged += new System.EventHandler(this.txtRValue_TextChanged);
            // 
            // txtPnL
            // 
            this.txtPnL.Enabled = false;
            this.txtPnL.Location = new System.Drawing.Point(1122, 317);
            this.txtPnL.Name = "txtPnL";
            this.txtPnL.ReadOnly = true;
            this.txtPnL.Size = new System.Drawing.Size(87, 26);
            this.txtPnL.TabIndex = 20;
            this.txtPnL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPnL
            // 
            this.lblPnL.AutoSize = true;
            this.lblPnL.Location = new System.Drawing.Point(1122, 299);
            this.lblPnL.Name = "lblPnL";
            this.lblPnL.Size = new System.Drawing.Size(32, 19);
            this.lblPnL.TabIndex = 19;
            this.lblPnL.Text = "PnL";
            // 
            // timerGetSecuritiesAccount
            // 
            this.timerGetSecuritiesAccount.Enabled = true;
            this.timerGetSecuritiesAccount.Interval = 20000;
            this.timerGetSecuritiesAccount.Tick += new System.EventHandler(this.timerGetSecuritiesAccount_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(918, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "1:1";
            // 
            // txtOneToOne
            // 
            this.txtOneToOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOneToOne.Location = new System.Drawing.Point(918, 383);
            this.txtOneToOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOneToOne.Name = "txtOneToOne";
            this.txtOneToOne.ReadOnly = true;
            this.txtOneToOne.Size = new System.Drawing.Size(197, 34);
            this.txtOneToOne.TabIndex = 26;
            this.txtOneToOne.TabStop = false;
            // 
            // chkDisableFirstTarget
            // 
            this.chkDisableFirstTarget.AutoSize = true;
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(733, 664);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(143, 23);
            this.chkDisableFirstTarget.TabIndex = 7;
            this.chkDisableFirstTarget.Text = "Disable First Target";
            this.chkDisableFirstTarget.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(726, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Limit Offset";
            // 
            // txtMoveStop
            // 
            this.txtMoveStop.AutoSize = true;
            this.txtMoveStop.Location = new System.Drawing.Point(548, 665);
            this.txtMoveStop.Name = "txtMoveStop";
            this.txtMoveStop.Size = new System.Drawing.Size(94, 19);
            this.txtMoveStop.TabIndex = 32;
            this.txtMoveStop.Text = "Move Stop To";
            // 
            // rbExitMarket
            // 
            this.rbExitMarket.AutoSize = true;
            this.rbExitMarket.Checked = true;
            this.rbExitMarket.Location = new System.Drawing.Point(114, 23);
            this.rbExitMarket.Name = "rbExitMarket";
            this.rbExitMarket.Size = new System.Drawing.Size(79, 23);
            this.rbExitMarket.TabIndex = 39;
            this.rbExitMarket.TabStop = true;
            this.rbExitMarket.Text = "MARKET";
            this.rbExitMarket.UseVisualStyleBackColor = true;
            // 
            // rbExitBidAsk
            // 
            this.rbExitBidAsk.AutoSize = true;
            this.rbExitBidAsk.Location = new System.Drawing.Point(199, 23);
            this.rbExitBidAsk.Name = "rbExitBidAsk";
            this.rbExitBidAsk.Size = new System.Drawing.Size(86, 23);
            this.rbExitBidAsk.TabIndex = 40;
            this.rbExitBidAsk.Text = "BID / ASK";
            this.rbExitBidAsk.UseVisualStyleBackColor = true;
            // 
            // btnExit33
            // 
            this.btnExit33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExit33.Location = new System.Drawing.Point(120, 85);
            this.btnExit33.Name = "btnExit33";
            this.btnExit33.Size = new System.Drawing.Size(46, 39);
            this.btnExit33.TabIndex = 2;
            this.btnExit33.TabStop = false;
            this.btnExit33.Tag = ".33";
            this.btnExit33.Text = "33%";
            this.btnExit33.UseVisualStyleBackColor = false;
            this.btnExit33.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit50
            // 
            this.btnExit50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExit50.Location = new System.Drawing.Point(172, 85);
            this.btnExit50.Name = "btnExit50";
            this.btnExit50.Size = new System.Drawing.Size(46, 39);
            this.btnExit50.TabIndex = 3;
            this.btnExit50.TabStop = false;
            this.btnExit50.Tag = ".5";
            this.btnExit50.Text = "50%";
            this.btnExit50.UseVisualStyleBackColor = false;
            this.btnExit50.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit25
            // 
            this.btnExit25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExit25.Location = new System.Drawing.Point(68, 85);
            this.btnExit25.Name = "btnExit25";
            this.btnExit25.Size = new System.Drawing.Size(46, 39);
            this.btnExit25.TabIndex = 1;
            this.btnExit25.TabStop = false;
            this.btnExit25.Tag = ".25";
            this.btnExit25.Text = "25%";
            this.btnExit25.UseVisualStyleBackColor = false;
            this.btnExit25.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit100
            // 
            this.btnExit100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExit100.Location = new System.Drawing.Point(224, 85);
            this.btnExit100.Name = "btnExit100";
            this.btnExit100.Size = new System.Drawing.Size(52, 39);
            this.btnExit100.TabIndex = 4;
            this.btnExit100.TabStop = false;
            this.btnExit100.Tag = "1";
            this.btnExit100.Text = "100%";
            this.btnExit100.UseVisualStyleBackColor = false;
            this.btnExit100.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit10
            // 
            this.btnExit10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExit10.Location = new System.Drawing.Point(16, 85);
            this.btnExit10.Name = "btnExit10";
            this.btnExit10.Size = new System.Drawing.Size(46, 39);
            this.btnExit10.TabIndex = 0;
            this.btnExit10.TabStop = false;
            this.btnExit10.Tag = ".1";
            this.btnExit10.Text = "10%";
            this.btnExit10.UseVisualStyleBackColor = false;
            this.btnExit10.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbExitBidAsk);
            this.groupBox2.Controls.Add(this.btnExit10);
            this.groupBox2.Controls.Add(this.rbExitMarket);
            this.groupBox2.Controls.Add(this.btnExit100);
            this.groupBox2.Controls.Add(this.btnExit50);
            this.groupBox2.Controls.Add(this.btnExit25);
            this.groupBox2.Controls.Add(this.btnExit33);
            this.groupBox2.Location = new System.Drawing.Point(918, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 144);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Close";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(812, 866);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(54, 19);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(868, 887);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(44, 26);
            this.btnScreenshot.TabIndex = 40;
            this.btnScreenshot.Text = "🖼️";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.roundedPanel1);
            this.panel1.Controls.Add(this.lblTickerDesc);
            this.panel1.Controls.Add(this.rpbTickerLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 72);
            this.panel1.TabIndex = 0;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Controls.Add(this.txtSymbol);
            this.roundedPanel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.roundedPanel1.Location = new System.Drawing.Point(314, 12);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(150, 48);
            this.roundedPanel1.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TdInterface.Properties.Resources.magnify_24;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblTickerDesc
            // 
            this.lblTickerDesc.AutoSize = true;
            this.lblTickerDesc.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTickerDesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTickerDesc.Location = new System.Drawing.Point(66, 22);
            this.lblTickerDesc.Name = "lblTickerDesc";
            this.lblTickerDesc.Size = new System.Drawing.Size(166, 25);
            this.lblTickerDesc.TabIndex = 2;
            this.lblTickerDesc.Text = "Ticker Description";
            // 
            // rpbTickerLogo
            // 
            this.rpbTickerLogo.BackColor = System.Drawing.Color.DimGray;
            this.rpbTickerLogo.Location = new System.Drawing.Point(12, 12);
            this.rpbTickerLogo.Name = "rpbTickerLogo";
            this.rpbTickerLogo.Size = new System.Drawing.Size(48, 48);
            this.rpbTickerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpbTickerLogo.TabIndex = 42;
            this.rpbTickerLogo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(1284, 956);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.txtMoveStop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chkDisableFirstTarget);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnBreakEven);
            this.Controls.Add(this.txtOneToOne);
            this.Controls.Add(this.lblPnL);
            this.Controls.Add(this.txtPnL);
            this.Controls.Add(this.txtRValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLimitOffset);
            this.Controls.Add(this.txtStopToClose);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHeartBeat);
            this.Controls.Add(this.chkTradeShares);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAsk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblShares);
            this.Controls.Add(this.txtShares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAveragePrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLastError);
            this.Controls.Add(this.txtStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastPrice);
            this.Controls.Add(this.txtRisk);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EZTM - EZ Trade Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuyMrkTriggerOco;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRisk;
        private System.Windows.Forms.Button btnSellMrkTriggerOco;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLastError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBreakEven;
        private System.Windows.Forms.TextBox txtAveragePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Button btnSellLmtTriggerOco;
        private System.Windows.Forms.Button btnBuyLmtTriggerOco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAsk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.CheckBox chkTradeShares;
        private System.Windows.Forms.TextBox txtHeartBeat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TextBox txtStopToClose;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.TextBox txtLimitOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRValue;
        private System.Windows.Forms.TextBox txtPnL;
        private System.Windows.Forms.Label lblPnL;
        private System.Windows.Forms.Timer timerGetSecuritiesAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOneToOne;
        private System.Windows.Forms.CheckBox chkDisableFirstTarget;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtMoveStop;
        private System.Windows.Forms.RadioButton rbExitMarket;
        private System.Windows.Forms.RadioButton rbExitBidAsk;
        private System.Windows.Forms.Button btnExit33;
        private System.Windows.Forms.Button btnExit50;
        private System.Windows.Forms.Button btnExit25;
        private System.Windows.Forms.Button btnExit100;
        private System.Windows.Forms.Button btnExit10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RoundedPictureBox rpbTickerLogo;
        private System.Windows.Forms.Label lblTickerDesc;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

