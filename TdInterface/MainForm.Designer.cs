
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
            this.btnExitMark100 = new System.Windows.Forms.Button();
            this.btnExitMark50 = new System.Windows.Forms.Button();
            this.btnExitMark33 = new System.Windows.Forms.Button();
            this.btnExitMark25 = new System.Windows.Forms.Button();
            this.btnExitMark10 = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.txtSymbol.Size = new System.Drawing.Size(100, 31);
            this.txtSymbol.TabIndex = 1;
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(42, 93);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(72, 25);
            this.lblSymbol.TabIndex = 4;
            this.lblSymbol.Text = "Symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Risk";
            // 
            // txtRisk
            // 
            this.txtRisk.Location = new System.Drawing.Point(104, 43);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(100, 31);
            this.txtRisk.TabIndex = 7;
            this.txtRisk.TabStop = false;
            this.txtRisk.Text = "5";
            // 
            // btnSellMrkTriggerOco
            // 
            this.btnSellMrkTriggerOco.AutoSize = true;
            this.btnSellMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSellMrkTriggerOco.Location = new System.Drawing.Point(6, 101);
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
            this.txtLastPrice.Location = new System.Drawing.Point(181, 117);
            this.txtLastPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(100, 31);
            this.txtLastPrice.TabIndex = 9;
            this.txtLastPrice.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stop";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(116, 228);
            this.txtStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(100, 31);
            this.txtStop.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLastError
            // 
            this.txtLastError.Location = new System.Drawing.Point(42, 434);
            this.txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.Size = new System.Drawing.Size(676, 104);
            this.txtLastError.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSellLmtTriggerOco);
            this.groupBox1.Controls.Add(this.btnBuyLmtTriggerOco);
            this.groupBox1.Controls.Add(this.btnSellMrkTriggerOco);
            this.groupBox1.Controls.Add(this.btnBuyMrkTriggerOco);
            this.groupBox1.Location = new System.Drawing.Point(643, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 172);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " To Open";
            // 
            // btnSellLmtTriggerOco
            // 
            this.btnSellLmtTriggerOco.AutoSize = true;
            this.btnSellLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(149, 101);
            this.btnSellLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            this.btnSellLmtTriggerOco.Size = new System.Drawing.Size(139, 51);
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
            this.groupBox2.Controls.Add(this.btnExitMark100);
            this.groupBox2.Controls.Add(this.btnExitMark50);
            this.groupBox2.Controls.Add(this.btnExitMark33);
            this.groupBox2.Controls.Add(this.btnExitMark25);
            this.groupBox2.Controls.Add(this.btnExitMark10);
            this.groupBox2.Controls.Add(this.btnBreakEven);
            this.groupBox2.Location = new System.Drawing.Point(643, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 169);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Close";
            // 
            // btnExitMark100
            // 
            this.btnExitMark100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark100.Location = new System.Drawing.Point(227, 93);
            this.btnExitMark100.Name = "btnExitMark100";
            this.btnExitMark100.Size = new System.Drawing.Size(55, 39);
            this.btnExitMark100.TabIndex = 5;
            this.btnExitMark100.Text = "100%";
            this.btnExitMark100.UseVisualStyleBackColor = false;
            this.btnExitMark100.Click += new System.EventHandler(this.btnExitMark100_Click);
            // 
            // btnExitMark50
            // 
            this.btnExitMark50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark50.Location = new System.Drawing.Point(175, 93);
            this.btnExitMark50.Name = "btnExitMark50";
            this.btnExitMark50.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark50.TabIndex = 4;
            this.btnExitMark50.Text = "50%";
            this.btnExitMark50.UseVisualStyleBackColor = false;
            this.btnExitMark50.Click += new System.EventHandler(this.btnExitMark50_Click);
            // 
            // btnExitMark33
            // 
            this.btnExitMark33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark33.Location = new System.Drawing.Point(124, 93);
            this.btnExitMark33.Name = "btnExitMark33";
            this.btnExitMark33.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark33.TabIndex = 3;
            this.btnExitMark33.Text = "33%";
            this.btnExitMark33.UseVisualStyleBackColor = false;
            this.btnExitMark33.Click += new System.EventHandler(this.btnExitMark33_Click);
            // 
            // btnExitMark25
            // 
            this.btnExitMark25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark25.Location = new System.Drawing.Point(72, 93);
            this.btnExitMark25.Name = "btnExitMark25";
            this.btnExitMark25.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark25.TabIndex = 2;
            this.btnExitMark25.Text = "25%";
            this.btnExitMark25.UseVisualStyleBackColor = false;
            this.btnExitMark25.Click += new System.EventHandler(this.btnExitMark25_Click);
            // 
            // btnExitMark10
            // 
            this.btnExitMark10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExitMark10.Location = new System.Drawing.Point(20, 93);
            this.btnExitMark10.Name = "btnExitMark10";
            this.btnExitMark10.Size = new System.Drawing.Size(46, 39);
            this.btnExitMark10.TabIndex = 1;
            this.btnExitMark10.Text = "10%";
            this.btnExitMark10.UseVisualStyleBackColor = false;
            this.btnExitMark10.Click += new System.EventHandler(this.btnExitMark10_Click);
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBreakEven.Location = new System.Drawing.Point(20, 29);
            this.btnBreakEven.Name = "btnBreakEven";
            this.btnBreakEven.Size = new System.Drawing.Size(224, 58);
            this.btnBreakEven.TabIndex = 0;
            this.btnBreakEven.Text = "Stop\r\nBreak Even";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // txtAveragePrice
            // 
            this.txtAveragePrice.Location = new System.Drawing.Point(153, 311);
            this.txtAveragePrice.Name = "txtAveragePrice";
            this.txtAveragePrice.ReadOnly = true;
            this.txtAveragePrice.Size = new System.Drawing.Size(125, 31);
            this.txtAveragePrice.TabIndex = 15;
            this.txtAveragePrice.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Avg Price";
            // 
            // txtShares
            // 
            this.txtShares.Location = new System.Drawing.Point(153, 353);
            this.txtShares.Name = "txtShares";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(125, 31);
            this.txtShares.TabIndex = 17;
            this.txtShares.TabStop = false;
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Location = new System.Drawing.Point(40, 360);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(64, 25);
            this.lblShares.TabIndex = 18;
            this.lblShares.Text = "Shares";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Last";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(317, 118);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(100, 31);
            this.txtBid.TabIndex = 22;
            this.txtBid.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ask";
            // 
            // txtAsk
            // 
            this.txtAsk.Location = new System.Drawing.Point(461, 117);
            this.txtAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.ReadOnly = true;
            this.txtAsk.Size = new System.Drawing.Size(100, 31);
            this.txtAsk.TabIndex = 24;
            this.txtAsk.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(116, 175);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(104, 31);
            this.txtLimit.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 33);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCredentialsToolStripMenuItem,
            this.saveCredentialsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearCredentialsToolStripMenuItem
            // 
            this.clearCredentialsToolStripMenuItem.Name = "clearCredentialsToolStripMenuItem";
            this.clearCredentialsToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.clearCredentialsToolStripMenuItem.Text = "Clear Credentials";
            this.clearCredentialsToolStripMenuItem.Click += new System.EventHandler(this.clearCredentialsToolStripMenuItem_Click);
            // 
            // saveCredentialsToolStripMenuItem
            // 
            this.saveCredentialsToolStripMenuItem.Name = "saveCredentialsToolStripMenuItem";
            this.saveCredentialsToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.saveCredentialsToolStripMenuItem.Text = "Save Credentials";
            this.saveCredentialsToolStripMenuItem.Click += new System.EventHandler(this.saveCredentialsToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(229, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 29);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "Training Wheels";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1001, 566);
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
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(818, 613);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCredentialsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

