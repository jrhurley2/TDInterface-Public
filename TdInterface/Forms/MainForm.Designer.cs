
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblRisk = new System.Windows.Forms.Label();
            this.txtRisk = new System.Windows.Forms.TextBox();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLastError = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExitAsk10 = new System.Windows.Forms.Button();
            this.btnExitAsk100 = new System.Windows.Forms.Button();
            this.btnExitAsk25 = new System.Windows.Forms.Button();
            this.btnExitAsk50 = new System.Windows.Forms.Button();
            this.btnExitAsk33 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExitMark10 = new System.Windows.Forms.Button();
            this.btnExitMark25 = new System.Windows.Forms.Button();
            this.btnExitMark33 = new System.Windows.Forms.Button();
            this.btnExitMark50 = new System.Windows.Forms.Button();
            this.btnExitMark100 = new System.Windows.Forms.Button();
            this.txtStopToClose = new System.Windows.Forms.TextBox();
            this.txtAveragePrice = new System.Windows.Forms.TextBox();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtAsk = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cbShares = new System.Windows.Forms.CheckBox();
            this.txtHeartBeat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.txtLimitOffset = new System.Windows.Forms.TextBox();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.txtPnL = new System.Windows.Forms.TextBox();
            this.timerGetSecuritiesAccount = new System.Windows.Forms.Timer(this.components);
            this.txtOneToOne = new System.Windows.Forms.TextBox();
            this.chkDisableFirstTarget = new System.Windows.Forms.CheckBox();
            this.rpbTickerLogo = new TdInterface.CustomControls.RoundedPictureBox();
            this.roundedPanel1 = new TdInterface.CustomControls.RoundedPanel();
            this.roundedPanel2 = new TdInterface.CustomControls.RoundedPanel();
            this.pbStopLoss = new System.Windows.Forms.PictureBox();
            this.lblStopPrefix = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new TdInterface.CustomControls.RoundedPanel();
            this.pbRisk = new System.Windows.Forms.PictureBox();
            this.lblRiskPrefix = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.roundedPanel4 = new TdInterface.CustomControls.RoundedPanel();
            this.lblPnL = new System.Windows.Forms.Label();
            this.lblShares = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.roundedPanel5 = new TdInterface.CustomControls.RoundedPanel();
            this.pbOneToOne = new System.Windows.Forms.PictureBox();
            this.lblOneToOnePrefix = new System.Windows.Forms.Label();
            this.lblOneToOne = new System.Windows.Forms.Label();
            this.roundedPanel6 = new TdInterface.CustomControls.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRValue = new System.Windows.Forms.PictureBox();
            this.lblR = new System.Windows.Forms.Label();
            this.btnBuyMrkTriggerOco = new TdInterface.CustomControls.RoundedButton();
            this.btnSellMrkTriggerOco = new TdInterface.CustomControls.RoundedButton();
            this.btnBuyLmtTriggerOco = new TdInterface.CustomControls.RoundedButton();
            this.btnSellLmtTriggerOco = new TdInterface.CustomControls.RoundedButton();
            this.roundedPanel7 = new TdInterface.CustomControls.RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLimitOffset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.lblOpenPosition = new System.Windows.Forms.Label();
            this.roundedPanel8 = new TdInterface.CustomControls.RoundedPanel();
            this.lblStopTo = new System.Windows.Forms.Label();
            this.btnBreakEven = new TdInterface.CustomControls.RoundedButton();
            this.btnCancelAll = new TdInterface.CustomControls.RoundedButton();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStopLoss)).BeginInit();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRisk)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOneToOne)).BeginInit();
            this.roundedPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRValue)).BeginInit();
            this.roundedPanel7.SuspendLayout();
            this.roundedPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSymbol.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtSymbol.Location = new System.Drawing.Point(66, 19);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.PlaceholderText = "SYMBOL";
            this.txtSymbol.Size = new System.Drawing.Size(87, 27);
            this.txtSymbol.TabIndex = 0;
            this.txtSymbol.Enter += new System.EventHandler(this.txtSymbol_Enter);
            this.txtSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSymbol_KeyPress);
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            this.txtSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_Enter);
            // 
            // lblRisk
            // 
            this.lblRisk.AutoSize = true;
            this.lblRisk.BackColor = System.Drawing.SystemColors.Window;
            this.lblRisk.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRisk.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRisk.Location = new System.Drawing.Point(12, 12);
            this.lblRisk.Name = "lblRisk";
            this.lblRisk.Size = new System.Drawing.Size(32, 15);
            this.lblRisk.TabIndex = 24;
            this.lblRisk.Text = "RISK";
            this.lblRisk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRisk
            // 
            this.txtRisk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRisk.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtRisk.Location = new System.Drawing.Point(28, 29);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.PlaceholderText = "RISK";
            this.txtRisk.Size = new System.Drawing.Size(73, 27);
            this.txtRisk.TabIndex = 4;
            this.txtRisk.TabStop = false;
            this.txtRisk.Text = "5";
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtLastPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtLastPrice.Location = new System.Drawing.Point(188, 19);
            this.txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.PlaceholderText = "LAST";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(68, 27);
            this.txtLastPrice.TabIndex = 10;
            this.txtLastPrice.TabStop = false;
            // 
            // txtStop
            // 
            this.txtStop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStop.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtStop.Location = new System.Drawing.Point(28, 29);
            this.txtStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStop.Name = "txtStop";
            this.txtStop.PlaceholderText = "STOP";
            this.txtStop.Size = new System.Drawing.Size(85, 27);
            this.txtStop.TabIndex = 1;
            this.txtStop.Leave += new System.EventHandler(this.txtStop_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLastError
            // 
            this.txtLastError.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastError.Location = new System.Drawing.Point(343, 819);
            this.txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.Size = new System.Drawing.Size(24, 26);
            this.txtLastError.TabIndex = 34;
            this.txtLastError.TabStop = false;
            this.txtLastError.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLastError_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(373, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 208);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Close";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExitAsk10);
            this.groupBox4.Controls.Add(this.btnExitAsk100);
            this.groupBox4.Controls.Add(this.btnExitAsk25);
            this.groupBox4.Controls.Add(this.btnExitAsk50);
            this.groupBox4.Controls.Add(this.btnExitAsk33);
            this.groupBox4.Location = new System.Drawing.Point(8, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 83);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bid/Ask";
            // 
            // btnExitAsk10
            // 
            this.btnExitAsk10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExitAsk10.Location = new System.Drawing.Point(9, 26);
            this.btnExitAsk10.Name = "btnExitAsk10";
            this.btnExitAsk10.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk10.TabIndex = 0;
            this.btnExitAsk10.TabStop = false;
            this.btnExitAsk10.Text = "10%";
            this.btnExitAsk10.UseVisualStyleBackColor = false;
            this.btnExitAsk10.Click += new System.EventHandler(this.btnExitAsk10_Click);
            // 
            // btnExitAsk100
            // 
            this.btnExitAsk100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExitAsk100.Location = new System.Drawing.Point(217, 26);
            this.btnExitAsk100.Name = "btnExitAsk100";
            this.btnExitAsk100.Size = new System.Drawing.Size(52, 39);
            this.btnExitAsk100.TabIndex = 4;
            this.btnExitAsk100.TabStop = false;
            this.btnExitAsk100.Text = "100%";
            this.btnExitAsk100.UseVisualStyleBackColor = false;
            this.btnExitAsk100.Click += new System.EventHandler(this.btnExitAsk100_Click);
            // 
            // btnExitAsk25
            // 
            this.btnExitAsk25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExitAsk25.Location = new System.Drawing.Point(61, 26);
            this.btnExitAsk25.Name = "btnExitAsk25";
            this.btnExitAsk25.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk25.TabIndex = 1;
            this.btnExitAsk25.TabStop = false;
            this.btnExitAsk25.Text = "25%";
            this.btnExitAsk25.UseVisualStyleBackColor = false;
            this.btnExitAsk25.Click += new System.EventHandler(this.btnExitAsk25_Click);
            // 
            // btnExitAsk50
            // 
            this.btnExitAsk50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExitAsk50.Location = new System.Drawing.Point(165, 26);
            this.btnExitAsk50.Name = "btnExitAsk50";
            this.btnExitAsk50.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk50.TabIndex = 3;
            this.btnExitAsk50.TabStop = false;
            this.btnExitAsk50.Text = "50%";
            this.btnExitAsk50.UseVisualStyleBackColor = false;
            this.btnExitAsk50.Click += new System.EventHandler(this.btnExitAsk50_Click);
            // 
            // btnExitAsk33
            // 
            this.btnExitAsk33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnExitAsk33.Location = new System.Drawing.Point(113, 26);
            this.btnExitAsk33.Name = "btnExitAsk33";
            this.btnExitAsk33.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk33.TabIndex = 2;
            this.btnExitAsk33.TabStop = false;
            this.btnExitAsk33.Text = "33%";
            this.btnExitAsk33.UseVisualStyleBackColor = false;
            this.btnExitAsk33.Click += new System.EventHandler(this.btnExitAsk33_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExitMark10);
            this.groupBox3.Controls.Add(this.btnExitMark25);
            this.groupBox3.Controls.Add(this.btnExitMark33);
            this.groupBox3.Controls.Add(this.btnExitMark50);
            this.groupBox3.Controls.Add(this.btnExitMark100);
            this.groupBox3.Location = new System.Drawing.Point(11, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 79);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Market";
            // 
            // btnExitMark10
            // 
            this.btnExitMark10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnExitMark10.Location = new System.Drawing.Point(6, 27);
            this.btnExitMark10.Name = "btnExitMark10";
            this.btnExitMark10.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark10.TabIndex = 0;
            this.btnExitMark10.TabStop = false;
            this.btnExitMark10.Text = "10%";
            this.btnExitMark10.UseVisualStyleBackColor = false;
            this.btnExitMark10.Click += new System.EventHandler(this.btnExitMark10_Click);
            // 
            // btnExitMark25
            // 
            this.btnExitMark25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnExitMark25.Location = new System.Drawing.Point(58, 27);
            this.btnExitMark25.Name = "btnExitMark25";
            this.btnExitMark25.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark25.TabIndex = 1;
            this.btnExitMark25.TabStop = false;
            this.btnExitMark25.Text = "25%";
            this.btnExitMark25.UseVisualStyleBackColor = false;
            this.btnExitMark25.Click += new System.EventHandler(this.btnExitMark25_Click);
            // 
            // btnExitMark33
            // 
            this.btnExitMark33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnExitMark33.Location = new System.Drawing.Point(110, 27);
            this.btnExitMark33.Name = "btnExitMark33";
            this.btnExitMark33.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark33.TabIndex = 2;
            this.btnExitMark33.TabStop = false;
            this.btnExitMark33.Text = "33%";
            this.btnExitMark33.UseVisualStyleBackColor = false;
            this.btnExitMark33.Click += new System.EventHandler(this.btnExitMark33_Click);
            // 
            // btnExitMark50
            // 
            this.btnExitMark50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnExitMark50.Location = new System.Drawing.Point(162, 27);
            this.btnExitMark50.Name = "btnExitMark50";
            this.btnExitMark50.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark50.TabIndex = 3;
            this.btnExitMark50.TabStop = false;
            this.btnExitMark50.Text = "50%";
            this.btnExitMark50.UseVisualStyleBackColor = false;
            this.btnExitMark50.Click += new System.EventHandler(this.btnExitMark50_Click);
            // 
            // btnExitMark100
            // 
            this.btnExitMark100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnExitMark100.Location = new System.Drawing.Point(214, 27);
            this.btnExitMark100.Name = "btnExitMark100";
            this.btnExitMark100.Size = new System.Drawing.Size(55, 39);
            this.btnExitMark100.TabIndex = 4;
            this.btnExitMark100.TabStop = false;
            this.btnExitMark100.Text = "100%";
            this.btnExitMark100.UseVisualStyleBackColor = false;
            this.btnExitMark100.Click += new System.EventHandler(this.btnExitMark100_Click);
            // 
            // txtStopToClose
            // 
            this.txtStopToClose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStopToClose.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStopToClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtStopToClose.Location = new System.Drawing.Point(178, 30);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.PlaceholderText = "BREAKEVEN";
            this.txtStopToClose.Size = new System.Drawing.Size(155, 27);
            this.txtStopToClose.TabIndex = 6;
            // 
            // txtAveragePrice
            // 
            this.txtAveragePrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtAveragePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAveragePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtAveragePrice.Location = new System.Drawing.Point(125, 32);
            this.txtAveragePrice.Name = "txtAveragePrice";
            this.txtAveragePrice.PlaceholderText = "-";
            this.txtAveragePrice.ReadOnly = true;
            this.txtAveragePrice.Size = new System.Drawing.Size(85, 19);
            this.txtAveragePrice.TabIndex = 16;
            this.txtAveragePrice.TabStop = false;
            // 
            // txtShares
            // 
            this.txtShares.BackColor = System.Drawing.SystemColors.Window;
            this.txtShares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtShares.Location = new System.Drawing.Point(19, 32);
            this.txtShares.Name = "txtShares";
            this.txtShares.PlaceholderText = "-";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(85, 19);
            this.txtShares.TabIndex = 18;
            this.txtShares.TabStop = false;
            this.txtShares.TextChanged += new System.EventHandler(this.txtShares_TextChanged);
            // 
            // txtBid
            // 
            this.txtBid.BackColor = System.Drawing.SystemColors.Window;
            this.txtBid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(197)))), ((int)(((byte)(210)))));
            this.txtBid.Location = new System.Drawing.Point(273, 12);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.PlaceholderText = "BID";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(60, 19);
            this.txtBid.TabIndex = 12;
            this.txtBid.TabStop = false;
            this.txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAsk
            // 
            this.txtAsk.BackColor = System.Drawing.SystemColors.Window;
            this.txtAsk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(197)))), ((int)(((byte)(210)))));
            this.txtAsk.Location = new System.Drawing.Point(273, 37);
            this.txtAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.PlaceholderText = "ASK";
            this.txtAsk.ReadOnly = true;
            this.txtAsk.Size = new System.Drawing.Size(60, 19);
            this.txtAsk.TabIndex = 14;
            this.txtAsk.TabStop = false;
            this.txtAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLimit
            // 
            this.txtLimit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLimit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimit.Location = new System.Drawing.Point(28, 193);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.PlaceholderText = "LIMIT";
            this.txtLimit.Size = new System.Drawing.Size(96, 27);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.Leave += new System.EventHandler(this.txtLimit_Leave);
            // 
            // cbShares
            // 
            this.cbShares.AutoSize = true;
            this.cbShares.Location = new System.Drawing.Point(546, 506);
            this.cbShares.Name = "cbShares";
            this.cbShares.Size = new System.Drawing.Size(68, 23);
            this.cbShares.TabIndex = 5;
            this.cbShares.Text = "Shares";
            this.cbShares.UseVisualStyleBackColor = true;
            this.cbShares.CheckedChanged += new System.EventHandler(this.cbShares_CheckedChanged);
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.Location = new System.Drawing.Point(373, 819);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.ReadOnly = true;
            this.txtHeartBeat.Size = new System.Drawing.Size(318, 26);
            this.txtHeartBeat.TabIndex = 36;
            this.txtHeartBeat.TabStop = false;
            this.txtHeartBeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(373, 797);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "HeartBeat";
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(19, 819);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.Size = new System.Drawing.Size(318, 26);
            this.txtConnectionStatus.TabIndex = 38;
            this.txtConnectionStatus.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(19, 797);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(121, 19);
            this.lblConnectionStatus.TabIndex = 37;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLimitOffset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimitOffset.Location = new System.Drawing.Point(194, 193);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.PlaceholderText = "OFFSET";
            this.txtLimitOffset.Size = new System.Drawing.Size(87, 27);
            this.txtLimitOffset.TabIndex = 3;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtLimitOffset_Leave);
            // 
            // txtRValue
            // 
            this.txtRValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtRValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtRValue.Location = new System.Drawing.Point(28, 29);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.ReadOnly = true;
            this.txtRValue.Size = new System.Drawing.Size(87, 27);
            this.txtRValue.TabIndex = 28;
            this.txtRValue.TabStop = false;
            this.txtRValue.TextChanged += new System.EventHandler(this.txtRValue_TextChanged);
            // 
            // txtPnL
            // 
            this.txtPnL.BackColor = System.Drawing.SystemColors.Window;
            this.txtPnL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPnL.Enabled = false;
            this.txtPnL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtPnL.Location = new System.Drawing.Point(253, 32);
            this.txtPnL.Name = "txtPnL";
            this.txtPnL.PlaceholderText = "-";
            this.txtPnL.ReadOnly = true;
            this.txtPnL.Size = new System.Drawing.Size(85, 19);
            this.txtPnL.TabIndex = 20;
            // 
            // timerGetSecuritiesAccount
            // 
            this.timerGetSecuritiesAccount.Enabled = true;
            this.timerGetSecuritiesAccount.Interval = 10000;
            this.timerGetSecuritiesAccount.Tick += new System.EventHandler(this.timerGetSecuritiesAccount_Tick);
            // 
            // txtOneToOne
            // 
            this.txtOneToOne.BackColor = System.Drawing.SystemColors.Window;
            this.txtOneToOne.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOneToOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOneToOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtOneToOne.Location = new System.Drawing.Point(28, 29);
            this.txtOneToOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOneToOne.Name = "txtOneToOne";
            this.txtOneToOne.ReadOnly = true;
            this.txtOneToOne.Size = new System.Drawing.Size(83, 27);
            this.txtOneToOne.TabIndex = 26;
            this.txtOneToOne.TabStop = false;
            // 
            // chkDisableFirstTarget
            // 
            this.chkDisableFirstTarget.AutoSize = true;
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(546, 484);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(143, 23);
            this.chkDisableFirstTarget.TabIndex = 7;
            this.chkDisableFirstTarget.Text = "Disable First Target";
            this.chkDisableFirstTarget.UseVisualStyleBackColor = true;
            // 
            // rpbTickerLogo
            // 
            this.rpbTickerLogo.Location = new System.Drawing.Point(12, 10);
            this.rpbTickerLogo.Name = "rpbTickerLogo";
            this.rpbTickerLogo.Size = new System.Drawing.Size(48, 48);
            this.rpbTickerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpbTickerLogo.TabIndex = 41;
            this.rpbTickerLogo.TabStop = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Controls.Add(this.txtLastPrice);
            this.roundedPanel1.Controls.Add(this.txtSymbol);
            this.roundedPanel1.Controls.Add(this.rpbTickerLogo);
            this.roundedPanel1.Controls.Add(this.txtBid);
            this.roundedPanel1.Controls.Add(this.txtAsk);
            this.roundedPanel1.Location = new System.Drawing.Point(12, 36);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(346, 68);
            this.roundedPanel1.TabIndex = 41;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Controls.Add(this.pbStopLoss);
            this.roundedPanel2.Controls.Add(this.lblStopPrefix);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Controls.Add(this.txtStop);
            this.roundedPanel2.Location = new System.Drawing.Point(12, 110);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(170, 68);
            this.roundedPanel2.TabIndex = 42;
            // 
            // pbStopLoss
            // 
            this.pbStopLoss.Image = ((System.Drawing.Image)(resources.GetObject("pbStopLoss.Image")));
            this.pbStopLoss.Location = new System.Drawing.Point(126, 16);
            this.pbStopLoss.Name = "pbStopLoss";
            this.pbStopLoss.Size = new System.Drawing.Size(36, 36);
            this.pbStopLoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStopLoss.TabIndex = 48;
            this.pbStopLoss.TabStop = false;
            // 
            // lblStopPrefix
            // 
            this.lblStopPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.lblStopPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStopPrefix.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStopPrefix.Location = new System.Drawing.Point(12, 29);
            this.lblStopPrefix.Name = "lblStopPrefix";
            this.lblStopPrefix.Size = new System.Drawing.Size(13, 27);
            this.lblStopPrefix.TabIndex = 26;
            this.lblStopPrefix.Text = "$";
            this.lblStopPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "STOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.Controls.Add(this.pbRisk);
            this.roundedPanel3.Controls.Add(this.txtRisk);
            this.roundedPanel3.Controls.Add(this.lblRiskPrefix);
            this.roundedPanel3.Controls.Add(this.lblRisk);
            this.roundedPanel3.Location = new System.Drawing.Point(188, 110);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(170, 68);
            this.roundedPanel3.TabIndex = 43;
            // 
            // pbRisk
            // 
            this.pbRisk.Image = ((System.Drawing.Image)(resources.GetObject("pbRisk.Image")));
            this.pbRisk.Location = new System.Drawing.Point(126, 16);
            this.pbRisk.Name = "pbRisk";
            this.pbRisk.Size = new System.Drawing.Size(36, 36);
            this.pbRisk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRisk.TabIndex = 49;
            this.pbRisk.TabStop = false;
            // 
            // lblRiskPrefix
            // 
            this.lblRiskPrefix.BackColor = System.Drawing.SystemColors.Window;
            this.lblRiskPrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblRiskPrefix.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRiskPrefix.Location = new System.Drawing.Point(12, 29);
            this.lblRiskPrefix.Name = "lblRiskPrefix";
            this.lblRiskPrefix.Size = new System.Drawing.Size(13, 27);
            this.lblRiskPrefix.TabIndex = 25;
            this.lblRiskPrefix.Text = "$";
            this.lblRiskPrefix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.pnlTop.Controls.Add(this.btnExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1046, 30);
            this.pnlTop.TabIndex = 44;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnExit.Location = new System.Drawing.Point(1008, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 30);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "✖️";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.Controls.Add(this.lblPnL);
            this.roundedPanel4.Controls.Add(this.lblShares);
            this.roundedPanel4.Controls.Add(this.lblAvgPrice);
            this.roundedPanel4.Controls.Add(this.txtShares);
            this.roundedPanel4.Controls.Add(this.txtAveragePrice);
            this.roundedPanel4.Controls.Add(this.txtPnL);
            this.roundedPanel4.Location = new System.Drawing.Point(370, 36);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(346, 68);
            this.roundedPanel4.TabIndex = 45;
            // 
            // lblPnL
            // 
            this.lblPnL.AutoSize = true;
            this.lblPnL.BackColor = System.Drawing.SystemColors.Window;
            this.lblPnL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblPnL.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPnL.Location = new System.Drawing.Point(251, 14);
            this.lblPnL.Name = "lblPnL";
            this.lblPnL.Size = new System.Drawing.Size(29, 15);
            this.lblPnL.TabIndex = 47;
            this.lblPnL.Text = "P&&L";
            this.lblPnL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.BackColor = System.Drawing.SystemColors.Window;
            this.lblShares.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblShares.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblShares.Location = new System.Drawing.Point(16, 14);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(51, 15);
            this.lblShares.TabIndex = 46;
            this.lblShares.Text = "SHARES";
            this.lblShares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.BackColor = System.Drawing.SystemColors.Window;
            this.lblAvgPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAvgPrice.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblAvgPrice.Location = new System.Drawing.Point(122, 14);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(64, 15);
            this.lblAvgPrice.TabIndex = 45;
            this.lblAvgPrice.Text = "AVG PRICE";
            this.lblAvgPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.Controls.Add(this.pbOneToOne);
            this.roundedPanel5.Controls.Add(this.lblOneToOnePrefix);
            this.roundedPanel5.Controls.Add(this.lblOneToOne);
            this.roundedPanel5.Controls.Add(this.txtOneToOne);
            this.roundedPanel5.Location = new System.Drawing.Point(370, 110);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(170, 68);
            this.roundedPanel5.TabIndex = 46;
            // 
            // pbOneToOne
            // 
            this.pbOneToOne.Image = ((System.Drawing.Image)(resources.GetObject("pbOneToOne.Image")));
            this.pbOneToOne.Location = new System.Drawing.Point(126, 16);
            this.pbOneToOne.Name = "pbOneToOne";
            this.pbOneToOne.Size = new System.Drawing.Size(36, 36);
            this.pbOneToOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOneToOne.TabIndex = 50;
            this.pbOneToOne.TabStop = false;
            // 
            // lblOneToOnePrefix
            // 
            this.lblOneToOnePrefix.BackColor = System.Drawing.SystemColors.Window;
            this.lblOneToOnePrefix.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOneToOnePrefix.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOneToOnePrefix.Location = new System.Drawing.Point(12, 29);
            this.lblOneToOnePrefix.Name = "lblOneToOnePrefix";
            this.lblOneToOnePrefix.Size = new System.Drawing.Size(13, 27);
            this.lblOneToOnePrefix.TabIndex = 45;
            this.lblOneToOnePrefix.Text = "$";
            this.lblOneToOnePrefix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOneToOne
            // 
            this.lblOneToOne.AutoSize = true;
            this.lblOneToOne.BackColor = System.Drawing.SystemColors.Window;
            this.lblOneToOne.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblOneToOne.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOneToOne.Location = new System.Drawing.Point(12, 12);
            this.lblOneToOne.Name = "lblOneToOne";
            this.lblOneToOne.Size = new System.Drawing.Size(20, 15);
            this.lblOneToOne.TabIndex = 45;
            this.lblOneToOne.Text = "1:1";
            this.lblOneToOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.Controls.Add(this.label2);
            this.roundedPanel6.Controls.Add(this.pbRValue);
            this.roundedPanel6.Controls.Add(this.lblR);
            this.roundedPanel6.Controls.Add(this.txtRValue);
            this.roundedPanel6.Location = new System.Drawing.Point(546, 110);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(170, 68);
            this.roundedPanel6.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Δ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbRValue
            // 
            this.pbRValue.Image = ((System.Drawing.Image)(resources.GetObject("pbRValue.Image")));
            this.pbRValue.Location = new System.Drawing.Point(126, 16);
            this.pbRValue.Name = "pbRValue";
            this.pbRValue.Size = new System.Drawing.Size(36, 36);
            this.pbRValue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRValue.TabIndex = 51;
            this.pbRValue.TabStop = false;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.BackColor = System.Drawing.SystemColors.Window;
            this.lblR.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblR.Location = new System.Drawing.Point(12, 12);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(14, 15);
            this.lblR.TabIndex = 46;
            this.lblR.Text = "R";
            this.lblR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBuyMrkTriggerOco
            // 
            this.btnBuyMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnBuyMrkTriggerOco.FlatAppearance.BorderSize = 0;
            this.btnBuyMrkTriggerOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyMrkTriggerOco.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuyMrkTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnBuyMrkTriggerOco.Location = new System.Drawing.Point(12, 40);
            this.btnBuyMrkTriggerOco.Name = "btnBuyMrkTriggerOco";
            this.btnBuyMrkTriggerOco.Size = new System.Drawing.Size(155, 58);
            this.btnBuyMrkTriggerOco.TabIndex = 48;
            this.btnBuyMrkTriggerOco.Text = "BUY MARKET";
            this.btnBuyMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyMrkTriggerOco.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnBuyMrkTriggerOco.Click += new System.EventHandler(this.btnBuyMrkTriggerOco_Click);
            // 
            // btnSellMrkTriggerOco
            // 
            this.btnSellMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSellMrkTriggerOco.FlatAppearance.BorderSize = 0;
            this.btnSellMrkTriggerOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellMrkTriggerOco.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSellMrkTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSellMrkTriggerOco.Location = new System.Drawing.Point(178, 40);
            this.btnSellMrkTriggerOco.Name = "btnSellMrkTriggerOco";
            this.btnSellMrkTriggerOco.Size = new System.Drawing.Size(155, 58);
            this.btnSellMrkTriggerOco.TabIndex = 49;
            this.btnSellMrkTriggerOco.Text = "SELL MARKET";
            this.btnSellMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellMrkTriggerOco.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnSellMrkTriggerOco.Click += new System.EventHandler(this.btnSellMrkTriggerOco_Click);
            // 
            // btnBuyLmtTriggerOco
            // 
            this.btnBuyLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnBuyLmtTriggerOco.FlatAppearance.BorderSize = 0;
            this.btnBuyLmtTriggerOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyLmtTriggerOco.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuyLmtTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnBuyLmtTriggerOco.Location = new System.Drawing.Point(12, 107);
            this.btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            this.btnBuyLmtTriggerOco.Size = new System.Drawing.Size(155, 58);
            this.btnBuyLmtTriggerOco.TabIndex = 50;
            this.btnBuyLmtTriggerOco.Text = "BUY LIMIT";
            this.btnBuyLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyLmtTriggerOco.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnBuyLmtTriggerOco.Click += new System.EventHandler(this.btnBuyLmtTriggerOco_Click);
            // 
            // btnSellLmtTriggerOco
            // 
            this.btnSellLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnSellLmtTriggerOco.FlatAppearance.BorderSize = 0;
            this.btnSellLmtTriggerOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellLmtTriggerOco.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSellLmtTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(178, 107);
            this.btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            this.btnSellLmtTriggerOco.Size = new System.Drawing.Size(155, 58);
            this.btnSellLmtTriggerOco.TabIndex = 51;
            this.btnSellLmtTriggerOco.Text = "SELL LIMIT";
            this.btnSellLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellLmtTriggerOco.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnSellLmtTriggerOco.Click += new System.EventHandler(this.btnSellLmtTriggerOco_Click);
            // 
            // roundedPanel7
            // 
            this.roundedPanel7.Controls.Add(this.label4);
            this.roundedPanel7.Controls.Add(this.lblLimitOffset);
            this.roundedPanel7.Controls.Add(this.label3);
            this.roundedPanel7.Controls.Add(this.lblLimit);
            this.roundedPanel7.Controls.Add(this.lblOpenPosition);
            this.roundedPanel7.Controls.Add(this.btnSellLmtTriggerOco);
            this.roundedPanel7.Controls.Add(this.btnBuyMrkTriggerOco);
            this.roundedPanel7.Controls.Add(this.btnBuyLmtTriggerOco);
            this.roundedPanel7.Controls.Add(this.btnSellMrkTriggerOco);
            this.roundedPanel7.Controls.Add(this.txtLimit);
            this.roundedPanel7.Controls.Add(this.txtLimitOffset);
            this.roundedPanel7.Location = new System.Drawing.Point(12, 185);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(346, 233);
            this.roundedPanel7.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(178, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 27);
            this.label4.TabIndex = 55;
            this.label4.Text = "$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLimitOffset
            // 
            this.lblLimitOffset.AutoSize = true;
            this.lblLimitOffset.BackColor = System.Drawing.SystemColors.Window;
            this.lblLimitOffset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLimitOffset.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLimitOffset.Location = new System.Drawing.Point(178, 178);
            this.lblLimitOffset.Name = "lblLimitOffset";
            this.lblLimitOffset.Size = new System.Drawing.Size(83, 15);
            this.lblLimitOffset.TabIndex = 54;
            this.lblLimitOffset.Text = "LIMIT OFFSET";
            this.lblLimitOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 27);
            this.label3.TabIndex = 53;
            this.label3.Text = "$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.BackColor = System.Drawing.SystemColors.Window;
            this.lblLimit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLimit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblLimit.Location = new System.Drawing.Point(12, 178);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(39, 15);
            this.lblLimit.TabIndex = 49;
            this.lblLimit.Text = "LIMIT";
            this.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpenPosition
            // 
            this.lblOpenPosition.AutoSize = true;
            this.lblOpenPosition.BackColor = System.Drawing.SystemColors.Window;
            this.lblOpenPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpenPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.lblOpenPosition.Location = new System.Drawing.Point(12, 12);
            this.lblOpenPosition.Name = "lblOpenPosition";
            this.lblOpenPosition.Size = new System.Drawing.Size(120, 20);
            this.lblOpenPosition.TabIndex = 53;
            this.lblOpenPosition.Text = "OPEN POSITION";
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.Controls.Add(this.lblStopTo);
            this.roundedPanel8.Controls.Add(this.btnBreakEven);
            this.roundedPanel8.Controls.Add(this.txtStopToClose);
            this.roundedPanel8.Location = new System.Drawing.Point(12, 424);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(346, 80);
            this.roundedPanel8.TabIndex = 53;
            // 
            // lblStopTo
            // 
            this.lblStopTo.AutoSize = true;
            this.lblStopTo.BackColor = System.Drawing.SystemColors.Window;
            this.lblStopTo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStopTo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStopTo.Location = new System.Drawing.Point(178, 12);
            this.lblStopTo.Name = "lblStopTo";
            this.lblStopTo.Size = new System.Drawing.Size(23, 15);
            this.lblStopTo.TabIndex = 54;
            this.lblStopTo.Text = "TO";
            this.lblStopTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(238)))));
            this.btnBreakEven.FlatAppearance.BorderSize = 0;
            this.btnBreakEven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBreakEven.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBreakEven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBreakEven.Location = new System.Drawing.Point(12, 12);
            this.btnBreakEven.Name = "btnBreakEven";
            this.btnBreakEven.Size = new System.Drawing.Size(155, 58);
            this.btnBreakEven.TabIndex = 56;
            this.btnBreakEven.Text = "MOVE STOP";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnCancelAll.FlatAppearance.BorderSize = 0;
            this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAll.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelAll.Location = new System.Drawing.Point(19, 510);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(331, 58);
            this.btnCancelAll.TabIndex = 57;
            this.btnCancelAll.Text = "CANCEL ALL";
            this.btnCancelAll.UseVisualStyleBackColor = false;
            this.btnCancelAll.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1046, 883);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.roundedPanel8);
            this.Controls.Add(this.roundedPanel7);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.chkDisableFirstTarget);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHeartBeat);
            this.Controls.Add(this.cbShares);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLastError);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "JrHurley\'s TDInterface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStopLoss)).EndInit();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRisk)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOneToOne)).EndInit();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRValue)).EndInit();
            this.roundedPanel7.ResumeLayout(false);
            this.roundedPanel7.PerformLayout();
            this.roundedPanel8.ResumeLayout(false);
            this.roundedPanel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblRisk;
        private System.Windows.Forms.TextBox txtRisk;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLastError;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAveragePrice;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.TextBox txtAsk;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnExitMark10;
        private System.Windows.Forms.Button btnExitMark50;
        private System.Windows.Forms.Button btnExitMark33;
        private System.Windows.Forms.Button btnExitMark25;
        private System.Windows.Forms.Button btnExitMark100;
        private System.Windows.Forms.CheckBox cbShares;
        private System.Windows.Forms.TextBox txtHeartBeat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TextBox txtStopToClose;
        private System.Windows.Forms.Button btnExitAsk10;
        private System.Windows.Forms.Button btnExitAsk25;
        private System.Windows.Forms.Button btnExitAsk33;
        private System.Windows.Forms.Button btnExitAsk50;
        private System.Windows.Forms.Button btnExitAsk100;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLimitOffset;
        private System.Windows.Forms.TextBox txtRValue;
        private System.Windows.Forms.TextBox txtPnL;
        private System.Windows.Forms.Timer timerGetSecuritiesAccount;
        private System.Windows.Forms.TextBox txtOneToOne;
        private System.Windows.Forms.CheckBox chkDisableFirstTarget;
        private CustomControls.RoundedPictureBox rpbTickerLogo;
        private CustomControls.RoundedPanel roundedPanel1;
        private CustomControls.RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RoundedPanel roundedPanel3;
        private System.Windows.Forms.Label lblStopPrefix;
        private System.Windows.Forms.Label lblRiskPrefix;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnExit;
        private CustomControls.RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Label lblPnL;
        private CustomControls.RoundedPanel roundedPanel5;
        private System.Windows.Forms.Label lblOneToOne;
        private CustomControls.RoundedPanel roundedPanel6;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblOneToOnePrefix;
        private System.Windows.Forms.PictureBox pbStopLoss;
        private System.Windows.Forms.PictureBox pbRisk;
        private System.Windows.Forms.PictureBox pbOneToOne;
        private System.Windows.Forms.PictureBox pbRValue;
        private System.Windows.Forms.Label label2;
        private CustomControls.RoundedButton btnBuyMrkTriggerOco;
        private CustomControls.RoundedButton btnSellMrkTriggerOco;
        private CustomControls.RoundedButton btnBuyLmtTriggerOco;
        private CustomControls.RoundedButton btnSellLmtTriggerOco;
        private CustomControls.RoundedPanel roundedPanel7;
        private System.Windows.Forms.Label lblOpenPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLimitOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLimit;
        private CustomControls.RoundedPanel roundedPanel8;
        private System.Windows.Forms.Label lblStopTo;
        private CustomControls.RoundedButton btnBreakEven;
        private CustomControls.RoundedButton btnCancelAll;
    }
}

