
using System.Drawing;

namespace EZTM.UI
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
            components = new System.ComponentModel.Container();
            btnBuyMrkTriggerOco = new System.Windows.Forms.Button();
            txtSymbol = new System.Windows.Forms.TextBox();
            lblSymbol = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtRisk = new System.Windows.Forms.TextBox();
            btnSellMrkTriggerOco = new System.Windows.Forms.Button();
            txtLastPrice = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtStop = new System.Windows.Forms.TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            txtLastError = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnSellLmtTriggerOco = new System.Windows.Forms.Button();
            btnBuyLmtTriggerOco = new System.Windows.Forms.Button();
            btnCancelAll = new System.Windows.Forms.Button();
            txtStopToClose = new System.Windows.Forms.TextBox();
            btnBreakEven = new System.Windows.Forms.Button();
            txtAveragePrice = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtShares = new System.Windows.Forms.TextBox();
            lblShares = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtBid = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            txtAsk = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtLimit = new System.Windows.Forms.TextBox();
            chkTradeShares = new System.Windows.Forms.CheckBox();
            txtHeartBeat = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtConnectionStatus = new System.Windows.Forms.TextBox();
            lblConnectionStatus = new System.Windows.Forms.Label();
            txtLimitOffset = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            txtRValue = new System.Windows.Forms.TextBox();
            txtPnL = new System.Windows.Forms.TextBox();
            lblPnL = new System.Windows.Forms.Label();
            timerGetSecuritiesAccount = new System.Windows.Forms.Timer(components);
            label10 = new System.Windows.Forms.Label();
            txtOneToOne = new System.Windows.Forms.TextBox();
            chkDisableFirstTarget = new System.Windows.Forms.CheckBox();
            label11 = new System.Windows.Forms.Label();
            txtMoveStop = new System.Windows.Forms.Label();
            rbExitMarket = new System.Windows.Forms.RadioButton();
            rbExitBidAsk = new System.Windows.Forms.RadioButton();
            btnExit33 = new System.Windows.Forms.Button();
            btnExit50 = new System.Windows.Forms.Button();
            btnExit25 = new System.Windows.Forms.Button();
            btnExit100 = new System.Windows.Forms.Button();
            btnExit10 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            lblVersion = new System.Windows.Forms.Label();
            btnScreenshot = new System.Windows.Forms.Button();
            label12 = new System.Windows.Forms.Label();
            txtOrderCoount = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuyMrkTriggerOco
            // 
            btnBuyMrkTriggerOco.AutoSize = true;
            btnBuyMrkTriggerOco.BackColor = Color.FromArgb(0, 194, 136);
            btnBuyMrkTriggerOco.Location = new Point(6, 23);
            btnBuyMrkTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuyMrkTriggerOco.Name = "btnBuyMrkTriggerOco";
            btnBuyMrkTriggerOco.Size = new Size(174, 52);
            btnBuyMrkTriggerOco.TabIndex = 0;
            btnBuyMrkTriggerOco.TabStop = false;
            btnBuyMrkTriggerOco.Text = "Buy Market";
            btnBuyMrkTriggerOco.UseVisualStyleBackColor = false;
            btnBuyMrkTriggerOco.Click += btnBuyMrkTriggerOco_Click;
            // 
            // txtSymbol
            // 
            txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            txtSymbol.Location = new Point(12, 28);
            txtSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new Size(87, 26);
            txtSymbol.TabIndex = 0;
            txtSymbol.Enter += txtSymbol_Enter;
            txtSymbol.KeyPress += txtSymbol_KeyPress;
            txtSymbol.Leave += txtSymbol_Leave;
            txtSymbol.MouseUp += txtSymbol_Enter;
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Location = new Point(12, 9);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new Size(59, 20);
            lblSymbol.TabIndex = 8;
            lblSymbol.Text = "Symbol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 74);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 24;
            label1.Text = "Risk";
            // 
            // txtRisk
            // 
            txtRisk.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRisk.Location = new Point(291, 93);
            txtRisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtRisk.Name = "txtRisk";
            txtRisk.Size = new Size(87, 34);
            txtRisk.TabIndex = 4;
            txtRisk.Text = "5";
            txtRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSellMrkTriggerOco
            // 
            btnSellMrkTriggerOco.AutoSize = true;
            btnSellMrkTriggerOco.BackColor = Color.FromArgb(255, 82, 109);
            btnSellMrkTriggerOco.Location = new Point(6, 85);
            btnSellMrkTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSellMrkTriggerOco.Name = "btnSellMrkTriggerOco";
            btnSellMrkTriggerOco.Size = new Size(174, 51);
            btnSellMrkTriggerOco.TabIndex = 2;
            btnSellMrkTriggerOco.TabStop = false;
            btnSellMrkTriggerOco.Text = "Sell Market";
            btnSellMrkTriggerOco.UseVisualStyleBackColor = false;
            btnSellMrkTriggerOco.Click += btnSellMrkTriggerOco_Click;
            // 
            // txtLastPrice
            // 
            txtLastPrice.Location = new Point(105, 28);
            txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLastPrice.Name = "txtLastPrice";
            txtLastPrice.ReadOnly = true;
            txtLastPrice.Size = new Size(87, 26);
            txtLastPrice.TabIndex = 10;
            txtLastPrice.TabStop = false;
            txtLastPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 74);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 21;
            label2.Text = "Stop";
            // 
            // txtStop
            // 
            txtStop.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStop.Location = new Point(12, 93);
            txtStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtStop.Name = "txtStop";
            txtStop.Size = new Size(85, 34);
            txtStop.TabIndex = 1;
            txtStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtStop.Leave += txtWithValidation_Leave;
            // 
            // txtLastError
            // 
            txtLastError.BackColor = SystemColors.Control;
            txtLastError.Location = new Point(390, 315);
            txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLastError.Multiline = true;
            txtLastError.Name = "txtLastError";
            txtLastError.ReadOnly = true;
            txtLastError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtLastError.Size = new Size(291, 108);
            txtLastError.TabIndex = 34;
            txtLastError.TabStop = false;
            txtLastError.MouseDoubleClick += txtLastError_MouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSellLmtTriggerOco);
            groupBox1.Controls.Add(btnBuyLmtTriggerOco);
            groupBox1.Controls.Add(btnSellMrkTriggerOco);
            groupBox1.Controls.Add(btnBuyMrkTriggerOco);
            groupBox1.Location = new Point(12, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 144);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = " To Open";
            // 
            // btnSellLmtTriggerOco
            // 
            btnSellLmtTriggerOco.AutoSize = true;
            btnSellLmtTriggerOco.BackColor = Color.FromArgb(255, 82, 109);
            btnSellLmtTriggerOco.Location = new Point(186, 83);
            btnSellLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            btnSellLmtTriggerOco.Size = new Size(170, 51);
            btnSellLmtTriggerOco.TabIndex = 3;
            btnSellLmtTriggerOco.TabStop = false;
            btnSellLmtTriggerOco.Text = "Sell Limit";
            btnSellLmtTriggerOco.UseVisualStyleBackColor = false;
            btnSellLmtTriggerOco.Click += btnSellLmtTriggerOco_Click;
            // 
            // btnBuyLmtTriggerOco
            // 
            btnBuyLmtTriggerOco.AutoSize = true;
            btnBuyLmtTriggerOco.BackColor = Color.FromArgb(0, 194, 136);
            btnBuyLmtTriggerOco.Location = new Point(186, 23);
            btnBuyLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            btnBuyLmtTriggerOco.Size = new Size(170, 52);
            btnBuyLmtTriggerOco.TabIndex = 1;
            btnBuyLmtTriggerOco.TabStop = false;
            btnBuyLmtTriggerOco.Text = "Buy Limit";
            btnBuyLmtTriggerOco.UseVisualStyleBackColor = false;
            btnBuyLmtTriggerOco.Click += btnBuyLmtTriggerOco_Click;
            // 
            // btnCancelAll
            // 
            btnCancelAll.BackColor = Color.FromArgb(179, 237, 220);
            btnCancelAll.Location = new Point(201, 314);
            btnCancelAll.Name = "btnCancelAll";
            btnCancelAll.Size = new Size(167, 58);
            btnCancelAll.TabIndex = 31;
            btnCancelAll.TabStop = false;
            btnCancelAll.Text = "Cancel All";
            btnCancelAll.UseVisualStyleBackColor = false;
            btnCancelAll.Click += btnCancelAll_Click;
            // 
            // txtStopToClose
            // 
            txtStopToClose.Location = new Point(18, 397);
            txtStopToClose.Name = "txtStopToClose";
            txtStopToClose.Size = new Size(172, 26);
            txtStopToClose.TabIndex = 6;
            txtStopToClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtStopToClose.Leave += txtWithValidation_Leave;
            // 
            // btnBreakEven
            // 
            btnBreakEven.BackColor = Color.FromArgb(255, 203, 212);
            btnBreakEven.Location = new Point(18, 314);
            btnBreakEven.Name = "btnBreakEven";
            btnBreakEven.Size = new Size(174, 58);
            btnBreakEven.TabIndex = 30;
            btnBreakEven.TabStop = false;
            btnBreakEven.Text = "Stop/BE";
            btnBreakEven.UseVisualStyleBackColor = false;
            btnBreakEven.Click += btnBreakEven_Click;
            // 
            // txtAveragePrice
            // 
            txtAveragePrice.Location = new Point(390, 28);
            txtAveragePrice.Name = "txtAveragePrice";
            txtAveragePrice.ReadOnly = true;
            txtAveragePrice.Size = new Size(104, 26);
            txtAveragePrice.TabIndex = 16;
            txtAveragePrice.TabStop = false;
            txtAveragePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 9);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 15;
            label3.Text = "Avg Price";
            // 
            // txtShares
            // 
            txtShares.Location = new Point(500, 28);
            txtShares.Name = "txtShares";
            txtShares.ReadOnly = true;
            txtShares.Size = new Size(87, 26);
            txtShares.TabIndex = 18;
            txtShares.TabStop = false;
            txtShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtShares.TextChanged += txtShares_TextChanged;
            // 
            // lblShares
            // 
            lblShares.AutoSize = true;
            lblShares.Location = new Point(505, 9);
            lblShares.Name = "lblShares";
            lblShares.Size = new Size(52, 20);
            lblShares.TabIndex = 17;
            lblShares.Text = "Shares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 9);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 9;
            label4.Text = "Last";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 9);
            label5.Name = "label5";
            label5.Size = new Size(31, 20);
            label5.TabIndex = 11;
            label5.Text = "Bid";
            // 
            // txtBid
            // 
            txtBid.Location = new Point(198, 28);
            txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBid.Name = "txtBid";
            txtBid.ReadOnly = true;
            txtBid.Size = new Size(87, 26);
            txtBid.TabIndex = 12;
            txtBid.TabStop = false;
            txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(291, 9);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 13;
            label6.Text = "Ask";
            // 
            // txtAsk
            // 
            txtAsk.Location = new Point(291, 28);
            txtAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAsk.Name = "txtAsk";
            txtAsk.ReadOnly = true;
            txtAsk.Size = new Size(87, 26);
            txtAsk.TabIndex = 14;
            txtAsk.TabStop = false;
            txtAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(103, 74);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 22;
            label7.Text = "Limit";
            // 
            // txtLimit
            // 
            txtLimit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLimit.Location = new Point(103, 93);
            txtLimit.Name = "txtLimit";
            txtLimit.Size = new Size(89, 34);
            txtLimit.TabIndex = 2;
            txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            txtLimit.Leave += txtWithValidation_Leave;
            // 
            // chkTradeShares
            // 
            chkTradeShares.AutoSize = true;
            chkTradeShares.Location = new Point(310, 129);
            chkTradeShares.Name = "chkTradeShares";
            chkTradeShares.Size = new Size(74, 24);
            chkTradeShares.TabIndex = 5;
            chkTradeShares.Text = "Shares";
            chkTradeShares.UseVisualStyleBackColor = true;
            chkTradeShares.CheckedChanged += chkTradeShares_CheckedChanged;
            // 
            // txtHeartBeat
            // 
            txtHeartBeat.Location = new Point(396, 453);
            txtHeartBeat.Name = "txtHeartBeat";
            txtHeartBeat.ReadOnly = true;
            txtHeartBeat.Size = new Size(285, 26);
            txtHeartBeat.TabIndex = 36;
            txtHeartBeat.TabStop = false;
            txtHeartBeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(396, 430);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 35;
            label8.Text = "HeartBeat";
            // 
            // txtConnectionStatus
            // 
            txtConnectionStatus.Location = new Point(20, 453);
            txtConnectionStatus.Name = "txtConnectionStatus";
            txtConnectionStatus.ReadOnly = true;
            txtConnectionStatus.Size = new Size(318, 26);
            txtConnectionStatus.TabIndex = 38;
            txtConnectionStatus.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.Location = new Point(20, 430);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(128, 20);
            lblConnectionStatus.TabIndex = 37;
            lblConnectionStatus.Text = "Connection Status";
            // 
            // txtLimitOffset
            // 
            txtLimitOffset.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLimitOffset.Location = new Point(198, 93);
            txtLimitOffset.Name = "txtLimitOffset";
            txtLimitOffset.Size = new Size(87, 34);
            txtLimitOffset.TabIndex = 3;
            txtLimitOffset.Leave += txtWithValidation_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(594, 74);
            label9.Name = "label9";
            label9.Size = new Size(18, 20);
            label9.TabIndex = 27;
            label9.Text = "R";
            // 
            // txtRValue
            // 
            txtRValue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRValue.Location = new Point(594, 93);
            txtRValue.Name = "txtRValue";
            txtRValue.ReadOnly = true;
            txtRValue.Size = new Size(87, 34);
            txtRValue.TabIndex = 28;
            txtRValue.TabStop = false;
            txtRValue.TextChanged += txtRValue_TextChanged;
            // 
            // txtPnL
            // 
            txtPnL.Enabled = false;
            txtPnL.Location = new Point(594, 27);
            txtPnL.Name = "txtPnL";
            txtPnL.ReadOnly = true;
            txtPnL.Size = new Size(87, 26);
            txtPnL.TabIndex = 20;
            txtPnL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPnL
            // 
            lblPnL.AutoSize = true;
            lblPnL.Location = new Point(594, 9);
            lblPnL.Name = "lblPnL";
            lblPnL.Size = new Size(32, 20);
            lblPnL.TabIndex = 19;
            lblPnL.Text = "PnL";
            // 
            // timerGetSecuritiesAccount
            // 
            timerGetSecuritiesAccount.Enabled = true;
            timerGetSecuritiesAccount.Interval = 20000;
            timerGetSecuritiesAccount.Tick += timerGetSecuritiesAccount_Tick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(390, 74);
            label10.Name = "label10";
            label10.Size = new Size(28, 20);
            label10.TabIndex = 25;
            label10.Text = "1:1";
            // 
            // txtOneToOne
            // 
            txtOneToOne.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtOneToOne.Location = new Point(390, 93);
            txtOneToOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtOneToOne.Name = "txtOneToOne";
            txtOneToOne.ReadOnly = true;
            txtOneToOne.Size = new Size(197, 34);
            txtOneToOne.TabIndex = 26;
            txtOneToOne.TabStop = false;
            // 
            // chkDisableFirstTarget
            // 
            chkDisableFirstTarget.AutoSize = true;
            chkDisableFirstTarget.Location = new Point(205, 374);
            chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            chkDisableFirstTarget.Size = new Size(157, 24);
            chkDisableFirstTarget.TabIndex = 7;
            chkDisableFirstTarget.Text = "Disable First Target";
            chkDisableFirstTarget.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(198, 74);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 23;
            label11.Text = "Limit Offset";
            // 
            // txtMoveStop
            // 
            txtMoveStop.AutoSize = true;
            txtMoveStop.Location = new Point(20, 375);
            txtMoveStop.Name = "txtMoveStop";
            txtMoveStop.Size = new Size(101, 20);
            txtMoveStop.TabIndex = 32;
            txtMoveStop.Text = "Move Stop To";
            // 
            // rbExitMarket
            // 
            rbExitMarket.AutoSize = true;
            rbExitMarket.Checked = true;
            rbExitMarket.Location = new Point(114, 23);
            rbExitMarket.Name = "rbExitMarket";
            rbExitMarket.Size = new Size(87, 24);
            rbExitMarket.TabIndex = 39;
            rbExitMarket.TabStop = true;
            rbExitMarket.Text = "MARKET";
            rbExitMarket.UseVisualStyleBackColor = true;
            // 
            // rbExitBidAsk
            // 
            rbExitBidAsk.AutoSize = true;
            rbExitBidAsk.Location = new Point(199, 23);
            rbExitBidAsk.Name = "rbExitBidAsk";
            rbExitBidAsk.Size = new Size(95, 24);
            rbExitBidAsk.TabIndex = 40;
            rbExitBidAsk.Text = "BID / ASK";
            rbExitBidAsk.UseVisualStyleBackColor = true;
            // 
            // btnExit33
            // 
            btnExit33.BackColor = Color.FromArgb(179, 237, 220);
            btnExit33.Location = new Point(120, 85);
            btnExit33.Name = "btnExit33";
            btnExit33.Size = new Size(46, 39);
            btnExit33.TabIndex = 2;
            btnExit33.TabStop = false;
            btnExit33.Tag = ".33";
            btnExit33.Text = "33%";
            btnExit33.UseVisualStyleBackColor = false;
            btnExit33.Click += btnExitPercentage_Click;
            // 
            // btnExit50
            // 
            btnExit50.BackColor = Color.FromArgb(179, 237, 220);
            btnExit50.Location = new Point(172, 85);
            btnExit50.Name = "btnExit50";
            btnExit50.Size = new Size(46, 39);
            btnExit50.TabIndex = 3;
            btnExit50.TabStop = false;
            btnExit50.Tag = ".5";
            btnExit50.Text = "50%";
            btnExit50.UseVisualStyleBackColor = false;
            btnExit50.Click += btnExitPercentage_Click;
            // 
            // btnExit25
            // 
            btnExit25.BackColor = Color.FromArgb(179, 237, 220);
            btnExit25.Location = new Point(68, 85);
            btnExit25.Name = "btnExit25";
            btnExit25.Size = new Size(46, 39);
            btnExit25.TabIndex = 1;
            btnExit25.TabStop = false;
            btnExit25.Tag = ".25";
            btnExit25.Text = "25%";
            btnExit25.UseVisualStyleBackColor = false;
            btnExit25.Click += btnExitPercentage_Click;
            // 
            // btnExit100
            // 
            btnExit100.BackColor = Color.FromArgb(179, 237, 220);
            btnExit100.Location = new Point(224, 85);
            btnExit100.Name = "btnExit100";
            btnExit100.Size = new Size(52, 39);
            btnExit100.TabIndex = 4;
            btnExit100.TabStop = false;
            btnExit100.Tag = "1";
            btnExit100.Text = "100%";
            btnExit100.UseVisualStyleBackColor = false;
            btnExit100.Click += btnExitPercentage_Click;
            // 
            // btnExit10
            // 
            btnExit10.BackColor = Color.FromArgb(179, 237, 220);
            btnExit10.Location = new Point(16, 85);
            btnExit10.Name = "btnExit10";
            btnExit10.Size = new Size(46, 39);
            btnExit10.TabIndex = 0;
            btnExit10.TabStop = false;
            btnExit10.Tag = ".1";
            btnExit10.Text = "10%";
            btnExit10.UseVisualStyleBackColor = false;
            btnExit10.Click += btnExitPercentage_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbExitBidAsk);
            groupBox2.Controls.Add(btnExit10);
            groupBox2.Controls.Add(rbExitMarket);
            groupBox2.Controls.Add(btnExit100);
            groupBox2.Controls.Add(btnExit50);
            groupBox2.Controls.Add(btnExit25);
            groupBox2.Controls.Add(btnExit33);
            groupBox2.Location = new Point(390, 164);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(291, 144);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "To Close";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new Point(280, 430);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(57, 20);
            lblVersion.TabIndex = 39;
            lblVersion.Text = "Version";
            lblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnScreenshot
            // 
            btnScreenshot.Location = new Point(344, 453);
            btnScreenshot.Name = "btnScreenshot";
            btnScreenshot.Size = new Size(44, 26);
            btnScreenshot.TabIndex = 40;
            btnScreenshot.Text = "🖼️";
            btnScreenshot.UseVisualStyleBackColor = true;
            btnScreenshot.Click += btnScreenshot_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(709, 9);
            label12.Name = "label12";
            label12.Size = new Size(90, 20);
            label12.TabIndex = 41;
            label12.Text = "Order Count";
            // 
            // txtOrderCoount
            // 
            txtOrderCoount.Enabled = false;
            txtOrderCoount.Location = new Point(709, 32);
            txtOrderCoount.Name = "txtOrderCoount";
            txtOrderCoount.ReadOnly = true;
            txtOrderCoount.Size = new Size(87, 26);
            txtOrderCoount.TabIndex = 42;
            txtOrderCoount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            ClientSize = new Size(833, 496);
            Controls.Add(txtOrderCoount);
            Controls.Add(label12);
            Controls.Add(btnScreenshot);
            Controls.Add(lblVersion);
            Controls.Add(txtMoveStop);
            Controls.Add(label11);
            Controls.Add(chkDisableFirstTarget);
            Controls.Add(label10);
            Controls.Add(btnCancelAll);
            Controls.Add(btnBreakEven);
            Controls.Add(txtOneToOne);
            Controls.Add(lblPnL);
            Controls.Add(txtPnL);
            Controls.Add(txtRValue);
            Controls.Add(label9);
            Controls.Add(txtLimitOffset);
            Controls.Add(txtStopToClose);
            Controls.Add(lblConnectionStatus);
            Controls.Add(txtConnectionStatus);
            Controls.Add(label8);
            Controls.Add(txtHeartBeat);
            Controls.Add(chkTradeShares);
            Controls.Add(txtLimit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtAsk);
            Controls.Add(label5);
            Controls.Add(txtBid);
            Controls.Add(label4);
            Controls.Add(lblShares);
            Controls.Add(txtShares);
            Controls.Add(label3);
            Controls.Add(txtAveragePrice);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtLastError);
            Controls.Add(txtStop);
            Controls.Add(label2);
            Controls.Add(txtLastPrice);
            Controls.Add(txtRisk);
            Controls.Add(label1);
            Controls.Add(lblSymbol);
            Controls.Add(txtSymbol);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "EZTM - EZ Trade Manager";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            KeyDown += MainForm_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnBuyMrkTriggerOco;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblSymbol;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrderCoount;
    }
}

