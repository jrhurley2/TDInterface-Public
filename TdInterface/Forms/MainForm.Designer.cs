
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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.btnSellLmtTriggerOco = new System.Windows.Forms.Button();
            this.btnBuyLmtTriggerOco = new System.Windows.Forms.Button();
            this.txtStopToClose = new System.Windows.Forms.TextBox();
            this.btnBreakEven = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.chkTradeShares = new System.Windows.Forms.CheckBox();
            this.txtLimitOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRValue = new System.Windows.Forms.TextBox();
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
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.lblLastPrice = new System.Windows.Forms.Label();
            this.roundedPanel1 = new TdInterface.CustomControls.RoundedPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTickerDesc = new System.Windows.Forms.Label();
            this.rpbTickerLogo = new TdInterface.CustomControls.RoundedPictureBox();
            this.lblPerShare = new System.Windows.Forms.Label();
            this.lblSharesRisk = new System.Windows.Forms.Label();
            this.lblRisk = new System.Windows.Forms.Label();
            this.txtStop = new System.Windows.Forms.NumericUpDown();
            this.roundedPanel5 = new TdInterface.CustomControls.RoundedPanel();
            this.txtRisk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuyMrkTriggerOco = new TdInterface.CustomControls.RoundedButton();
            this.btnSellMrkTriggerOco = new TdInterface.CustomControls.RoundedButton();
            this.btnCancelAll = new TdInterface.CustomControls.RoundedButton();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tssVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLastMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHeartbeat = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPositionState = new System.Windows.Forms.Label();
            this.lblShares = new System.Windows.Forms.Label();
            this.lblAveragePrice = new System.Windows.Forms.Label();
            this.pnlStop = new TdInterface.CustomControls.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new TdInterface.CustomControls.RoundedPanel();
            this.roundedPanel6 = new TdInterface.CustomControls.RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel7 = new TdInterface.CustomControls.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStop)).BeginInit();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRisk)).BeginInit();
            this.ssStatus.SuspendLayout();
            this.pnlStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.BackColor = System.Drawing.Color.White;
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSymbol.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.txtSymbol.Location = new System.Drawing.Point(42, 6);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(60, 22);
            this.txtSymbol.TabIndex = 0;
            this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
            this.txtSymbol.Enter += new System.EventHandler(this.txtSymbol_Enter);
            this.txtSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSymbol_KeyPress);
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            this.txtSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_Enter);
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.BackColor = System.Drawing.Color.Transparent;
            this.lblStop.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblStop.ForeColor = System.Drawing.Color.White;
            this.lblStop.Location = new System.Drawing.Point(12, 7);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(85, 21);
            this.lblStop.TabIndex = 21;
            this.lblStop.Text = "Stop Price";
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStop.Click += new System.EventHandler(this.lblStop_Click);
            // 
            // btnSellLmtTriggerOco
            // 
            this.btnSellLmtTriggerOco.AutoSize = true;
            this.btnSellLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(109)))));
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(850, 336);
            this.btnSellLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            this.btnSellLmtTriggerOco.Size = new System.Drawing.Size(74, 51);
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
            this.btnBuyLmtTriggerOco.Location = new System.Drawing.Point(772, 336);
            this.btnBuyLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            this.btnBuyLmtTriggerOco.Size = new System.Drawing.Size(76, 52);
            this.btnBuyLmtTriggerOco.TabIndex = 1;
            this.btnBuyLmtTriggerOco.TabStop = false;
            this.btnBuyLmtTriggerOco.Text = "Buy Limit";
            this.btnBuyLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyLmtTriggerOco.Click += new System.EventHandler(this.btnBuyLmtTriggerOco_Click);
            // 
            // txtStopToClose
            // 
            this.txtStopToClose.Location = new System.Drawing.Point(161, 407);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.Size = new System.Drawing.Size(172, 26);
            this.txtStopToClose.TabIndex = 5;
            this.txtStopToClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStopToClose.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnBreakEven.Location = new System.Drawing.Point(20, 385);
            this.btnBreakEven.Name = "btnBreakEven";
            this.btnBreakEven.Size = new System.Drawing.Size(135, 58);
            this.btnBreakEven.TabIndex = 30;
            this.btnBreakEven.TabStop = false;
            this.btnBreakEven.Text = "Stop/BE";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(926, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimit.Location = new System.Drawing.Point(926, 353);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(89, 34);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimit.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // chkTradeShares
            // 
            this.chkTradeShares.AutoSize = true;
            this.chkTradeShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chkTradeShares.Location = new System.Drawing.Point(75, 623);
            this.chkTradeShares.Name = "chkTradeShares";
            this.chkTradeShares.Size = new System.Drawing.Size(68, 23);
            this.chkTradeShares.TabIndex = 5;
            this.chkTradeShares.Text = "Shares";
            this.chkTradeShares.UseVisualStyleBackColor = true;
            this.chkTradeShares.CheckedChanged += new System.EventHandler(this.chkTradeShares_CheckedChanged);
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimitOffset.Location = new System.Drawing.Point(1021, 353);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.Size = new System.Drawing.Size(87, 34);
            this.txtLimitOffset.TabIndex = 4;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 529);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "R";
            // 
            // txtRValue
            // 
            this.txtRValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRValue.Location = new System.Drawing.Point(746, 548);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.ReadOnly = true;
            this.txtRValue.Size = new System.Drawing.Size(87, 34);
            this.txtRValue.TabIndex = 28;
            this.txtRValue.TabStop = false;
            this.txtRValue.TextChanged += new System.EventHandler(this.txtRValue_TextChanged);
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
            this.label10.Location = new System.Drawing.Point(542, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "1:1";
            // 
            // txtOneToOne
            // 
            this.txtOneToOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOneToOne.Location = new System.Drawing.Point(542, 548);
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
            this.chkDisableFirstTarget.BackColor = System.Drawing.Color.Transparent;
            this.chkDisableFirstTarget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkDisableFirstTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(75, 652);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(144, 19);
            this.chkDisableFirstTarget.TabIndex = 7;
            this.chkDisableFirstTarget.Text = "DISABLE FIRST TARGET";
            this.chkDisableFirstTarget.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1021, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Limit Offset";
            // 
            // txtMoveStop
            // 
            this.txtMoveStop.AutoSize = true;
            this.txtMoveStop.Location = new System.Drawing.Point(161, 385);
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
            this.btnExit33.Location = new System.Drawing.Point(120, 52);
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
            this.btnExit50.Location = new System.Drawing.Point(172, 52);
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
            this.btnExit25.Location = new System.Drawing.Point(68, 52);
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
            this.btnExit100.Location = new System.Drawing.Point(224, 52);
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
            this.btnExit10.Location = new System.Drawing.Point(16, 52);
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
            this.groupBox2.Location = new System.Drawing.Point(17, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 104);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Close";
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.Location = new System.Drawing.Point(198, 449);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(44, 26);
            this.btnScreenshot.TabIndex = 40;
            this.btnScreenshot.Text = "🖼️";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnScreenshot_Click);
            // 
            // lblLastPrice
            // 
            this.lblLastPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblLastPrice.Location = new System.Drawing.Point(148, 166);
            this.lblLastPrice.Name = "lblLastPrice";
            this.lblLastPrice.Size = new System.Drawing.Size(98, 36);
            this.lblLastPrice.TabIndex = 41;
            this.lblLastPrice.Text = "$";
            this.lblLastPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.Controls.Add(this.txtSymbol);
            this.roundedPanel1.ForeColor = System.Drawing.Color.White;
            this.roundedPanel1.Location = new System.Drawing.Point(270, 12);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(114, 36);
            this.roundedPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TdInterface.Properties.Resources.magnify_24;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // lblTickerDesc
            // 
            this.lblTickerDesc.AutoEllipsis = true;
            this.lblTickerDesc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTickerDesc.ForeColor = System.Drawing.Color.White;
            this.lblTickerDesc.Location = new System.Drawing.Point(54, 12);
            this.lblTickerDesc.Name = "lblTickerDesc";
            this.lblTickerDesc.Size = new System.Drawing.Size(210, 36);
            this.lblTickerDesc.TabIndex = 2;
            this.lblTickerDesc.Text = "Ticker Description";
            this.lblTickerDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTickerDesc.UseCompatibleTextRendering = true;
            // 
            // rpbTickerLogo
            // 
            this.rpbTickerLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rpbTickerLogo.Location = new System.Drawing.Point(12, 12);
            this.rpbTickerLogo.Name = "rpbTickerLogo";
            this.rpbTickerLogo.Size = new System.Drawing.Size(36, 36);
            this.rpbTickerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rpbTickerLogo.TabIndex = 42;
            this.rpbTickerLogo.TabStop = false;
            // 
            // lblPerShare
            // 
            this.lblPerShare.BackColor = System.Drawing.Color.Transparent;
            this.lblPerShare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblPerShare.Location = new System.Drawing.Point(150, 98);
            this.lblPerShare.Name = "lblPerShare";
            this.lblPerShare.Size = new System.Drawing.Size(96, 19);
            this.lblPerShare.TabIndex = 41;
            this.lblPerShare.Text = "/ share";
            this.lblPerShare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSharesRisk
            // 
            this.lblSharesRisk.BackColor = System.Drawing.Color.Transparent;
            this.lblSharesRisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblSharesRisk.Location = new System.Drawing.Point(150, 115);
            this.lblSharesRisk.Name = "lblSharesRisk";
            this.lblSharesRisk.Size = new System.Drawing.Size(96, 19);
            this.lblSharesRisk.TabIndex = 42;
            this.lblSharesRisk.Text = "shares";
            this.lblSharesRisk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRisk
            // 
            this.lblRisk.AutoSize = true;
            this.lblRisk.BackColor = System.Drawing.Color.Transparent;
            this.lblRisk.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblRisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.lblRisk.Location = new System.Drawing.Point(252, 72);
            this.lblRisk.Name = "lblRisk";
            this.lblRisk.Size = new System.Drawing.Size(52, 21);
            this.lblRisk.TabIndex = 43;
            this.lblRisk.Text = "$ Risk";
            this.lblRisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRisk.Click += new System.EventHandler(this.lblRisk_Click);
            // 
            // txtStop
            // 
            this.txtStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStop.DecimalPlaces = 2;
            this.txtStop.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStop.ForeColor = System.Drawing.Color.White;
            this.txtStop.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtStop.Location = new System.Drawing.Point(31, 33);
            this.txtStop.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(168, 30);
            this.txtStop.TabIndex = 53;
            this.txtStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStop_KeyDown);
            this.txtStop.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.White;
            this.roundedPanel5.Controls.Add(this.txtRisk);
            this.roundedPanel5.Controls.Add(this.label2);
            this.roundedPanel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel5.Location = new System.Drawing.Point(252, 98);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(132, 36);
            this.roundedPanel5.TabIndex = 44;
            // 
            // txtRisk
            // 
            this.txtRisk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRisk.DecimalPlaces = 2;
            this.txtRisk.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.txtRisk.Location = new System.Drawing.Point(20, 3);
            this.txtRisk.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(102, 30);
            this.txtRisk.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 30);
            this.label2.TabIndex = 59;
            this.label2.Text = "$";
            // 
            // btnBuyMrkTriggerOco
            // 
            this.btnBuyMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnBuyMrkTriggerOco.FlatAppearance.BorderSize = 0;
            this.btnBuyMrkTriggerOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMrkTriggerOco.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBuyMrkTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnBuyMrkTriggerOco.Location = new System.Drawing.Point(12, 166);
            this.btnBuyMrkTriggerOco.Name = "btnBuyMrkTriggerOco";
            this.btnBuyMrkTriggerOco.Size = new System.Drawing.Size(132, 36);
            this.btnBuyMrkTriggerOco.TabIndex = 45;
            this.btnBuyMrkTriggerOco.Text = "BUY MARKET";
            this.btnBuyMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyMrkTriggerOco.Click += new System.EventHandler(this.btnBuyMrkTriggerOco_Click);
            // 
            // btnSellMrkTriggerOco
            // 
            this.btnSellMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSellMrkTriggerOco.FlatAppearance.BorderSize = 0;
            this.btnSellMrkTriggerOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMrkTriggerOco.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSellMrkTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSellMrkTriggerOco.Location = new System.Drawing.Point(252, 166);
            this.btnSellMrkTriggerOco.Name = "btnSellMrkTriggerOco";
            this.btnSellMrkTriggerOco.Size = new System.Drawing.Size(132, 36);
            this.btnSellMrkTriggerOco.TabIndex = 46;
            this.btnSellMrkTriggerOco.Text = "SELL MARKET";
            this.btnSellMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellMrkTriggerOco.Click += new System.EventHandler(this.btnSellMrkTriggerOco_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnCancelAll.FlatAppearance.BorderSize = 0;
            this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAll.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelAll.Location = new System.Drawing.Point(12, 768);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(336, 40);
            this.btnCancelAll.TabIndex = 47;
            this.btnCancelAll.Text = "CANCEL ALL ORDERS";
            this.btnCancelAll.UseVisualStyleBackColor = false;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // ssStatus
            // 
            this.ssStatus.AutoSize = false;
            this.ssStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ssStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssVersion,
            this.tssConnectionStatus,
            this.tssLastMessage,
            this.tssHeartbeat});
            this.ssStatus.Location = new System.Drawing.Point(0, 820);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.ShowItemToolTips = true;
            this.ssStatus.Size = new System.Drawing.Size(1235, 36);
            this.ssStatus.SizingGrip = false;
            this.ssStatus.TabIndex = 48;
            // 
            // tssVersion
            // 
            this.tssVersion.BackColor = System.Drawing.Color.Transparent;
            this.tssVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssVersion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tssVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tssVersion.Name = "tssVersion";
            this.tssVersion.Size = new System.Drawing.Size(50, 31);
            this.tssVersion.Text = "v 0.0.0";
            // 
            // tssConnectionStatus
            // 
            this.tssConnectionStatus.BackColor = System.Drawing.Color.Transparent;
            this.tssConnectionStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tssConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tssConnectionStatus.Name = "tssConnectionStatus";
            this.tssConnectionStatus.Size = new System.Drawing.Size(1142, 31);
            this.tssConnectionStatus.Spring = true;
            // 
            // tssLastMessage
            // 
            this.tssLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.tssLastMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tssLastMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tssLastMessage.Name = "tssLastMessage";
            this.tssLastMessage.Size = new System.Drawing.Size(28, 31);
            this.tssLastMessage.Text = "📄";
            this.tssLastMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tssLastMessage.Visible = false;
            this.tssLastMessage.Click += new System.EventHandler(this.tssLastMessage_Click);
            // 
            // tssHeartbeat
            // 
            this.tssHeartbeat.BackColor = System.Drawing.Color.Transparent;
            this.tssHeartbeat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tssHeartbeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.tssHeartbeat.Name = "tssHeartbeat";
            this.tssHeartbeat.Size = new System.Drawing.Size(28, 31);
            this.tssHeartbeat.Text = "💓";
            this.tssHeartbeat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPositionState
            // 
            this.lblPositionState.AutoSize = true;
            this.lblPositionState.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionState.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPositionState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblPositionState.Location = new System.Drawing.Point(327, 229);
            this.lblPositionState.Name = "lblPositionState";
            this.lblPositionState.Size = new System.Drawing.Size(54, 21);
            this.lblPositionState.TabIndex = 50;
            this.lblPositionState.Text = "NONE";
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.BackColor = System.Drawing.Color.Transparent;
            this.lblShares.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblShares.Location = new System.Drawing.Point(335, 255);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(49, 19);
            this.lblShares.TabIndex = 51;
            this.lblShares.Text = "Shares";
            this.lblShares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShares.TextChanged += new System.EventHandler(this.txtShares_TextChanged);
            // 
            // lblAveragePrice
            // 
            this.lblAveragePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblAveragePrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAveragePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.lblAveragePrice.Location = new System.Drawing.Point(293, 277);
            this.lblAveragePrice.Name = "lblAveragePrice";
            this.lblAveragePrice.Size = new System.Drawing.Size(91, 19);
            this.lblAveragePrice.TabIndex = 52;
            this.lblAveragePrice.Text = "$";
            this.lblAveragePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlStop
            // 
            this.pnlStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pnlStop.Controls.Add(this.txtStop);
            this.pnlStop.Controls.Add(this.label1);
            this.pnlStop.Controls.Add(this.lblStop);
            this.pnlStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlStop.Location = new System.Drawing.Point(497, 166);
            this.pnlStop.Name = "pnlStop";
            this.pnlStop.Size = new System.Drawing.Size(213, 72);
            this.pnlStop.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 30);
            this.label1.TabIndex = 58;
            this.label1.Text = "$";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel2.Location = new System.Drawing.Point(12, 60);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(372, 3);
            this.roundedPanel2.TabIndex = 57;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel6.Location = new System.Drawing.Point(12, 146);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(372, 3);
            this.roundedPanel6.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(12, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 59;
            this.label3.Text = "Position Info";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.roundedPanel7.Location = new System.Drawing.Point(12, 214);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(372, 3);
            this.roundedPanel7.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label4.Location = new System.Drawing.Point(12, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 61;
            this.label4.Text = "SHARES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label5.Location = new System.Drawing.Point(12, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 62;
            this.label5.Text = "AVG PRICE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 63;
            this.label6.Text = "TOTAL VALUE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1235, 856);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPositionState);
            this.Controls.Add(this.roundedPanel7);
            this.Controls.Add(this.lblShares);
            this.Controls.Add(this.lblAveragePrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.lblPerShare);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.lblSharesRisk);
            this.Controls.Add(this.lblRisk);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.btnSellMrkTriggerOco);
            this.Controls.Add(this.btnBuyMrkTriggerOco);
            this.Controls.Add(this.pnlStop);
            this.Controls.Add(this.chkDisableFirstTarget);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.lblLastPrice);
            this.Controls.Add(this.lblTickerDesc);
            this.Controls.Add(this.btnSellLmtTriggerOco);
            this.Controls.Add(this.btnBuyLmtTriggerOco);
            this.Controls.Add(this.rpbTickerLogo);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.txtMoveStop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBreakEven);
            this.Controls.Add(this.txtOneToOne);
            this.Controls.Add(this.txtRValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLimitOffset);
            this.Controls.Add(this.txtStopToClose);
            this.Controls.Add(this.chkTradeShares);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EZTM - EZ Trade Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStop)).EndInit();
            this.roundedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRisk)).EndInit();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.pnlStop.ResumeLayout(false);
            this.pnlStop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Button btnBreakEven;
        private System.Windows.Forms.Button btnSellLmtTriggerOco;
        private System.Windows.Forms.Button btnBuyLmtTriggerOco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.CheckBox chkTradeShares;
        private System.Windows.Forms.TextBox txtStopToClose;
        private System.Windows.Forms.TextBox txtLimitOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRValue;
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
        private System.Windows.Forms.Button btnScreenshot;
        private CustomControls.RoundedPictureBox rpbTickerLogo;
        private System.Windows.Forms.Label lblTickerDesc;
        private CustomControls.RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLastPrice;
        private System.Windows.Forms.Label lblRisk;
        private System.Windows.Forms.Label lblPerShare;
        private System.Windows.Forms.Label lblSharesRisk;
        private CustomControls.RoundedPanel roundedPanel5;
        private CustomControls.RoundedButton btnBuyMrkTriggerOco;
        private CustomControls.RoundedButton btnSellMrkTriggerOco;
        private CustomControls.RoundedButton btnCancelAll;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssVersion;
        private System.Windows.Forms.ToolStripStatusLabel tssHeartbeat;
        private System.Windows.Forms.ToolStripStatusLabel tssLastMessage;
        private System.Windows.Forms.ToolStripStatusLabel tssConnectionStatus;
        private System.Windows.Forms.Label lblPositionState;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Label lblAveragePrice;
        private System.Windows.Forms.NumericUpDown txtStop;
        private CustomControls.RoundedPanel pnlStop;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.NumericUpDown txtRisk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RoundedPanel roundedPanel6;
        private System.Windows.Forms.Label label3;
        private CustomControls.RoundedPanel roundedPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

