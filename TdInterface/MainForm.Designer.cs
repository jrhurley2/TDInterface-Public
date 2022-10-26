
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
            this.lblSymbol = new System.Windows.Forms.Label();
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtHeartBeat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.txtLimitOffset = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRValue = new System.Windows.Forms.TextBox();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuyMrkTriggerOco
            // 
            this.btnBuyMrkTriggerOco.AutoSize = true;
            this.btnBuyMrkTriggerOco.BackColor = System.Drawing.Color.Lime;
            this.btnBuyMrkTriggerOco.Location = new System.Drawing.Point(6, 31);
            this.btnBuyMrkTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuyMrkTriggerOco.Name = "btnBuyMrkTriggerOco";
            this.btnBuyMrkTriggerOco.Size = new System.Drawing.Size(137, 52);
            this.btnBuyMrkTriggerOco.TabIndex = 1;
            this.btnBuyMrkTriggerOco.TabStop = false;
            this.btnBuyMrkTriggerOco.Text = "Buy Mrk";
            this.btnBuyMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyMrkTriggerOco.Click += new System.EventHandler(this.btnBuyMrkTriggerOco_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(42, 117);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(60, 27);
            this.txtSymbol.TabIndex = 1;
            this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(42, 93);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(59, 20);
            this.lblSymbol.TabIndex = 4;
            this.lblSymbol.Text = "Symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Risk";
            // 
            // txtRisk
            // 
            this.txtRisk.Location = new System.Drawing.Point(104, 43);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(100, 27);
            this.txtRisk.TabIndex = 7;
            this.txtRisk.TabStop = false;
            this.txtRisk.Text = "5";
            // 
            // btnSellMrkTriggerOco
            // 
            this.btnSellMrkTriggerOco.AutoSize = true;
            this.btnSellMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSellMrkTriggerOco.Location = new System.Drawing.Point(9, 85);
            this.btnSellMrkTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSellMrkTriggerOco.Name = "btnSellMrkTriggerOco";
            this.btnSellMrkTriggerOco.Size = new System.Drawing.Size(134, 51);
            this.btnSellMrkTriggerOco.TabIndex = 8;
            this.btnSellMrkTriggerOco.TabStop = false;
            this.btnSellMrkTriggerOco.Text = "Sell Mrk";
            this.btnSellMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellMrkTriggerOco.Click += new System.EventHandler(this.btnSellMrkTriggerOco_Click);
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.Location = new System.Drawing.Point(107, 117);
            this.txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(51, 27);
            this.txtLastPrice.TabIndex = 9;
            this.txtLastPrice.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stop";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(88, 193);
            this.txtStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(100, 27);
            this.txtStop.TabIndex = 2;
            this.txtStop.TextChanged += new System.EventHandler(this.txtStop_TextChanged);
            this.txtStop.Leave += new System.EventHandler(this.txtStop_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLastError
            // 
            this.txtLastError.Location = new System.Drawing.Point(18, 451);
            this.txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.Size = new System.Drawing.Size(571, 57);
            this.txtLastError.TabIndex = 11;
            this.txtLastError.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSellLmtTriggerOco);
            this.groupBox1.Controls.Add(this.btnBuyLmtTriggerOco);
            this.groupBox1.Controls.Add(this.btnSellMrkTriggerOco);
            this.groupBox1.Controls.Add(this.btnBuyMrkTriggerOco);
            this.groupBox1.Location = new System.Drawing.Point(622, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 145);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " To Open";
            // 
            // btnSellLmtTriggerOco
            // 
            this.btnSellLmtTriggerOco.AutoSize = true;
            this.btnSellLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(149, 85);
            this.btnSellLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            this.btnSellLmtTriggerOco.Size = new System.Drawing.Size(151, 51);
            this.btnSellLmtTriggerOco.TabIndex = 10;
            this.btnSellLmtTriggerOco.TabStop = false;
            this.btnSellLmtTriggerOco.Text = "Sell Lmit";
            this.btnSellLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellLmtTriggerOco.Click += new System.EventHandler(this.btnSellLmtTriggerOco_Click);
            // 
            // btnBuyLmtTriggerOco
            // 
            this.btnBuyLmtTriggerOco.AutoSize = true;
            this.btnBuyLmtTriggerOco.BackColor = System.Drawing.Color.Lime;
            this.btnBuyLmtTriggerOco.Location = new System.Drawing.Point(149, 31);
            this.btnBuyLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            this.btnBuyLmtTriggerOco.Size = new System.Drawing.Size(152, 52);
            this.btnBuyLmtTriggerOco.TabIndex = 9;
            this.btnBuyLmtTriggerOco.TabStop = false;
            this.btnBuyLmtTriggerOco.Text = "Buy Lmt";
            this.btnBuyLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyLmtTriggerOco.Click += new System.EventHandler(this.btnBuyLmtTriggerOco_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(622, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 225);
            this.groupBox2.TabIndex = 14;
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
            this.groupBox4.Location = new System.Drawing.Point(20, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 83);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bid/Ask";
            // 
            // btnExitAsk10
            // 
            this.btnExitAsk10.BackColor = System.Drawing.Color.Lime;
            this.btnExitAsk10.Location = new System.Drawing.Point(6, 26);
            this.btnExitAsk10.Name = "btnExitAsk10";
            this.btnExitAsk10.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk10.TabIndex = 6;
            this.btnExitAsk10.Text = "10%";
            this.btnExitAsk10.UseVisualStyleBackColor = false;
            this.btnExitAsk10.Click += new System.EventHandler(this.btnExitAsk10_Click);
            // 
            // btnExitAsk100
            // 
            this.btnExitAsk100.BackColor = System.Drawing.Color.Lime;
            this.btnExitAsk100.Location = new System.Drawing.Point(216, 26);
            this.btnExitAsk100.Name = "btnExitAsk100";
            this.btnExitAsk100.Size = new System.Drawing.Size(52, 39);
            this.btnExitAsk100.TabIndex = 7;
            this.btnExitAsk100.Text = "100%";
            this.btnExitAsk100.UseVisualStyleBackColor = false;
            this.btnExitAsk100.Click += new System.EventHandler(this.btnExitAsk100_Click);
            // 
            // btnExitAsk25
            // 
            this.btnExitAsk25.BackColor = System.Drawing.Color.Lime;
            this.btnExitAsk25.Location = new System.Drawing.Point(58, 26);
            this.btnExitAsk25.Name = "btnExitAsk25";
            this.btnExitAsk25.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk25.TabIndex = 10;
            this.btnExitAsk25.Text = "25%";
            this.btnExitAsk25.UseVisualStyleBackColor = false;
            this.btnExitAsk25.Click += new System.EventHandler(this.btnExitAsk25_Click);
            // 
            // btnExitAsk50
            // 
            this.btnExitAsk50.BackColor = System.Drawing.Color.Lime;
            this.btnExitAsk50.Location = new System.Drawing.Point(164, 26);
            this.btnExitAsk50.Name = "btnExitAsk50";
            this.btnExitAsk50.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk50.TabIndex = 8;
            this.btnExitAsk50.Text = "50%";
            this.btnExitAsk50.UseVisualStyleBackColor = false;
            this.btnExitAsk50.Click += new System.EventHandler(this.btnExitAsk50_Click);
            // 
            // btnExitAsk33
            // 
            this.btnExitAsk33.BackColor = System.Drawing.Color.Lime;
            this.btnExitAsk33.Location = new System.Drawing.Point(110, 26);
            this.btnExitAsk33.Name = "btnExitAsk33";
            this.btnExitAsk33.Size = new System.Drawing.Size(46, 39);
            this.btnExitAsk33.TabIndex = 9;
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
            this.groupBox3.Location = new System.Drawing.Point(20, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 83);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Market";
            // 
            // btnExitMark10
            // 
            this.btnExitMark10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark10.Location = new System.Drawing.Point(6, 28);
            this.btnExitMark10.Name = "btnExitMark10";
            this.btnExitMark10.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark10.TabIndex = 1;
            this.btnExitMark10.Text = "10%";
            this.btnExitMark10.UseVisualStyleBackColor = false;
            this.btnExitMark10.Click += new System.EventHandler(this.btnExitMark10_Click);
            // 
            // btnExitMark25
            // 
            this.btnExitMark25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark25.Location = new System.Drawing.Point(58, 28);
            this.btnExitMark25.Name = "btnExitMark25";
            this.btnExitMark25.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark25.TabIndex = 2;
            this.btnExitMark25.Text = "25%";
            this.btnExitMark25.UseVisualStyleBackColor = false;
            this.btnExitMark25.Click += new System.EventHandler(this.btnExitMark25_Click);
            // 
            // btnExitMark33
            // 
            this.btnExitMark33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark33.Location = new System.Drawing.Point(109, 28);
            this.btnExitMark33.Name = "btnExitMark33";
            this.btnExitMark33.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark33.TabIndex = 3;
            this.btnExitMark33.Text = "33%";
            this.btnExitMark33.UseVisualStyleBackColor = false;
            this.btnExitMark33.Click += new System.EventHandler(this.btnExitMark33_Click);
            // 
            // btnExitMark50
            // 
            this.btnExitMark50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark50.Location = new System.Drawing.Point(161, 28);
            this.btnExitMark50.Name = "btnExitMark50";
            this.btnExitMark50.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark50.TabIndex = 4;
            this.btnExitMark50.Text = "50%";
            this.btnExitMark50.UseVisualStyleBackColor = false;
            this.btnExitMark50.Click += new System.EventHandler(this.btnExitMark50_Click);
            // 
            // btnExitMark100
            // 
            this.btnExitMark100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark100.Location = new System.Drawing.Point(213, 28);
            this.btnExitMark100.Name = "btnExitMark100";
            this.btnExitMark100.Size = new System.Drawing.Size(55, 39);
            this.btnExitMark100.TabIndex = 5;
            this.btnExitMark100.Text = "100%";
            this.btnExitMark100.UseVisualStyleBackColor = false;
            this.btnExitMark100.Click += new System.EventHandler(this.btnExitMark100_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelAll.Location = new System.Drawing.Point(771, 200);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(151, 58);
            this.btnCancelAll.TabIndex = 7;
            this.btnCancelAll.Text = "Cancel All";
            this.btnCancelAll.UseVisualStyleBackColor = false;
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // txtStopToClose
            // 
            this.txtStopToClose.Location = new System.Drawing.Point(628, 265);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.Size = new System.Drawing.Size(125, 27);
            this.txtStopToClose.TabIndex = 5;
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBreakEven.Location = new System.Drawing.Point(628, 201);
            this.btnBreakEven.Name = "btnBreakEven";
            this.btnBreakEven.Size = new System.Drawing.Size(137, 58);
            this.btnBreakEven.TabIndex = 0;
            this.btnBreakEven.TabStop = false;
            this.btnBreakEven.Text = "Stop/BE";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // txtAveragePrice
            // 
            this.txtAveragePrice.Location = new System.Drawing.Point(125, 243);
            this.txtAveragePrice.Name = "txtAveragePrice";
            this.txtAveragePrice.ReadOnly = true;
            this.txtAveragePrice.Size = new System.Drawing.Size(125, 27);
            this.txtAveragePrice.TabIndex = 15;
            this.txtAveragePrice.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Avg Price";
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(125, 285);
            this.txtShares.Name = "txtShares";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(125, 27);
            this.txtShares.TabIndex = 17;
            this.txtShares.TabStop = false;
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Location = new System.Drawing.Point(12, 292);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(52, 20);
            this.lblShares.TabIndex = 18;
            this.lblShares.Text = "Shares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(174, 117);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(51, 27);
            this.txtBid.TabIndex = 22;
            this.txtBid.TabStop = false;
            this.txtBid.TextChanged += new System.EventHandler(this.txtBid_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ask";
            // 
            // txtAsk
            // 
            this.txtAsk.Location = new System.Drawing.Point(238, 117);
            this.txtAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.ReadOnly = true;
            this.txtAsk.Size = new System.Drawing.Size(51, 27);
            this.txtAsk.TabIndex = 24;
            this.txtAsk.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(86, 159);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(104, 27);
            this.txtLimit.TabIndex = 3;
            this.txtLimit.Leave += new System.EventHandler(this.txtLimit_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(229, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 24);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Trade Shares";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.Location = new System.Drawing.Point(176, 351);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.ReadOnly = true;
            this.txtHeartBeat.Size = new System.Drawing.Size(270, 27);
            this.txtHeartBeat.TabIndex = 29;
            this.txtHeartBeat.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "HeartBeat";
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(174, 384);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.Size = new System.Drawing.Size(278, 27);
            this.txtConnectionStatus.TabIndex = 31;
            this.txtConnectionStatus.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(14, 391);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(128, 20);
            this.lblConnectionStatus.TabIndex = 32;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.Location = new System.Drawing.Point(238, 161);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.Size = new System.Drawing.Size(125, 27);
            this.txtLimitOffset.TabIndex = 4;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtLimitOffset_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "R";
            // 
            // txtRValue
            // 
            this.txtRValue.Location = new System.Drawing.Point(474, 112);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.ReadOnly = true;
            this.txtRValue.Size = new System.Drawing.Size(43, 27);
            this.txtRValue.TabIndex = 34;
            this.txtRValue.TabStop = false;
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(365, 533);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(94, 29);
            this.btnReconnect.TabIndex = 35;
            this.btnReconnect.Text = "Reconnect";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(986, 574);
            this.Controls.Add(this.btnReconnect);
            this.Controls.Add(this.txtRValue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLimitOffset);
            this.Controls.Add(this.txtStopToClose);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.txtConnectionStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtHeartBeat);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBreakEven);
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
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.txtSymbol);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(818, 613);
            this.Name = "MainForm";
            this.Text = "JrHurley\'s TDInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Button btnExitMark10;
        private System.Windows.Forms.Button btnExitMark50;
        private System.Windows.Forms.Button btnExitMark33;
        private System.Windows.Forms.Button btnExitMark25;
        private System.Windows.Forms.Button btnExitMark100;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtHeartBeat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TextBox txtStopToClose;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.Button btnExitAsk10;
        private System.Windows.Forms.Button btnExitAsk25;
        private System.Windows.Forms.Button btnExitAsk33;
        private System.Windows.Forms.Button btnExitAsk50;
        private System.Windows.Forms.Button btnExitAsk100;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLimitOffset;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRValue;
        private System.Windows.Forms.Button btnReconnect;
    }
}

