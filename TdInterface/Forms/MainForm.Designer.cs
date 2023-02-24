
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
            this.txtPnL = new System.Windows.Forms.TextBox();
            this.lblPnL = new System.Windows.Forms.Label();
            this.timerGetSecuritiesAccount = new System.Windows.Forms.Timer(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.txtOneToOne = new System.Windows.Forms.TextBox();
            this.chkDisableFirstTarget = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMoveStop = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSymbol.Location = new System.Drawing.Point(12, 28);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(87, 26);
            this.txtSymbol.TabIndex = 0;
            this.txtSymbol.Enter += new System.EventHandler(this.txtSymbol_Enter);
            this.txtSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSymbol_KeyPress);
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            this.txtSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_Enter);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(12, 9);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(54, 19);
            this.lblSymbol.TabIndex = 8;
            this.lblSymbol.Text = "Symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Risk";
            // 
            // txtRisk
            // 
            this.txtRisk.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRisk.Location = new System.Drawing.Point(291, 93);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(87, 34);
            this.txtRisk.TabIndex = 4;
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
            this.txtLastPrice.Location = new System.Drawing.Point(105, 28);
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
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Stop";
            // 
            // txtStop
            // 
            this.txtStop.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStop.Location = new System.Drawing.Point(12, 93);
            this.txtStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(85, 34);
            this.txtStop.TabIndex = 1;
            this.txtStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txtLastError.Location = new System.Drawing.Point(344, 453);
            this.txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.Size = new System.Drawing.Size(24, 26);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 164);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(390, 164);
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
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(237)))), ((int)(((byte)(220)))));
            this.btnCancelAll.Location = new System.Drawing.Point(201, 314);
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
            this.txtStopToClose.Location = new System.Drawing.Point(18, 397);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.Size = new System.Drawing.Size(172, 26);
            this.txtStopToClose.TabIndex = 6;
            this.txtStopToClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(212)))));
            this.btnBreakEven.Location = new System.Drawing.Point(18, 314);
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
            this.txtAveragePrice.Location = new System.Drawing.Point(390, 28);
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
            this.label3.Location = new System.Drawing.Point(390, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Avg Price";
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(500, 28);
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
            this.lblShares.Location = new System.Drawing.Point(505, 9);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(49, 19);
            this.lblShares.TabIndex = 17;
            this.lblShares.Text = "Shares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(198, 28);
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
            this.label6.Location = new System.Drawing.Point(291, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ask";
            // 
            // txtAsk
            // 
            this.txtAsk.Location = new System.Drawing.Point(291, 28);
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
            this.label7.Location = new System.Drawing.Point(103, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimit.Location = new System.Drawing.Point(103, 93);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(89, 34);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimit.Leave += new System.EventHandler(this.txtLimit_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(310, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Shares";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.Location = new System.Drawing.Point(396, 453);
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
            this.label8.Location = new System.Drawing.Point(396, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "HeartBeat";
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.Location = new System.Drawing.Point(20, 453);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.Size = new System.Drawing.Size(318, 26);
            this.txtConnectionStatus.TabIndex = 38;
            this.txtConnectionStatus.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(20, 430);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(121, 19);
            this.lblConnectionStatus.TabIndex = 37;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimitOffset.Location = new System.Drawing.Point(198, 93);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.Size = new System.Drawing.Size(87, 34);
            this.txtLimitOffset.TabIndex = 3;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtLimitOffset_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(594, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "R";
            // 
            // txtRValue
            // 
            this.txtRValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRValue.Location = new System.Drawing.Point(594, 93);
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
            this.txtPnL.Location = new System.Drawing.Point(594, 27);
            this.txtPnL.Name = "txtPnL";
            this.txtPnL.ReadOnly = true;
            this.txtPnL.Size = new System.Drawing.Size(87, 26);
            this.txtPnL.TabIndex = 20;
            this.txtPnL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPnL
            // 
            this.lblPnL.AutoSize = true;
            this.lblPnL.Location = new System.Drawing.Point(594, 9);
            this.lblPnL.Name = "lblPnL";
            this.lblPnL.Size = new System.Drawing.Size(32, 19);
            this.lblPnL.TabIndex = 19;
            this.lblPnL.Text = "PnL";
            // 
            // timerGetSecuritiesAccount
            // 
            this.timerGetSecuritiesAccount.Enabled = true;
            this.timerGetSecuritiesAccount.Interval = 10000;
            this.timerGetSecuritiesAccount.Tick += new System.EventHandler(this.timerGetSecuritiesAccount_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "1:1";
            // 
            // txtOneToOne
            // 
            this.txtOneToOne.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOneToOne.Location = new System.Drawing.Point(390, 93);
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
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(205, 374);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(143, 23);
            this.chkDisableFirstTarget.TabIndex = 7;
            this.chkDisableFirstTarget.Text = "Disable First Target";
            this.chkDisableFirstTarget.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Limit Offset";
            // 
            // txtMoveStop
            // 
            this.txtMoveStop.AutoSize = true;
            this.txtMoveStop.Location = new System.Drawing.Point(20, 375);
            this.txtMoveStop.Name = "txtMoveStop";
            this.txtMoveStop.Size = new System.Drawing.Size(94, 19);
            this.txtMoveStop.TabIndex = 32;
            this.txtMoveStop.Text = "Move Stop To";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(694, 496);
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
            this.Controls.Add(this.checkBox1);
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
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.txtSymbol);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 535);
            this.Name = "MainForm";
            this.Text = "JrHurley\'s TDInterface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
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
        private System.Windows.Forms.TextBox txtPnL;
        private System.Windows.Forms.Label lblPnL;
        private System.Windows.Forms.Timer timerGetSecuritiesAccount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOneToOne;
        private System.Windows.Forms.CheckBox chkDisableFirstTarget;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtMoveStop;
    }
}

