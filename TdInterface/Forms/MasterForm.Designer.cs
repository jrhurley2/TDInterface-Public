namespace TdInterface
{
    partial class MasterForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuturesCalc = new System.Windows.Forms.Button();
            this.btnAMZN = new System.Windows.Forms.Button();
            this.btnMSFT = new System.Windows.Forms.Button();
            this.btnAMD = new System.Windows.Forms.Button();
            this.btnAAPL = new System.Windows.Forms.Button();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.btnNewTrade = new System.Windows.Forms.Button();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnNVDA = new System.Windows.Forms.Button();
            this.btnMETA = new System.Windows.Forms.Button();
            this.btnTSLA = new System.Windows.Forms.Button();
            this.btnSPY = new System.Windows.Forms.Button();
            this.btnQQQ = new System.Windows.Forms.Button();
            this.lblQuickTrade = new System.Windows.Forms.Label();
            this.lblQuickTradeLine = new System.Windows.Forms.Label();
            this.lblToolsLine = new System.Windows.Forms.Label();
            this.lblTools = new System.Windows.Forms.Label();
            this.lblTradeLine = new System.Windows.Forms.Label();
            this.lblTrade = new System.Windows.Forms.Label();
            this.btnScreenshots = new System.Windows.Forms.Button();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(301, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.accountSettingsToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnFuturesCalc
            // 
            this.btnFuturesCalc.Location = new System.Drawing.Point(13, 260);
            this.btnFuturesCalc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFuturesCalc.Name = "btnFuturesCalc";
            this.btnFuturesCalc.Size = new System.Drawing.Size(130, 28);
            this.btnFuturesCalc.TabIndex = 3;
            this.btnFuturesCalc.Text = "Futures Calculator";
            this.btnFuturesCalc.UseVisualStyleBackColor = true;
            this.btnFuturesCalc.Click += new System.EventHandler(this.btnFuturesCalc_Click);
            // 
            // btnAMZN
            // 
            this.btnAMZN.Location = new System.Drawing.Point(199, 131);
            this.btnAMZN.Margin = new System.Windows.Forms.Padding(4);
            this.btnAMZN.Name = "btnAMZN";
            this.btnAMZN.Size = new System.Drawing.Size(86, 26);
            this.btnAMZN.TabIndex = 8;
            this.btnAMZN.Tag = "AMZN";
            this.btnAMZN.Text = "AMZN";
            this.btnAMZN.UseVisualStyleBackColor = true;
            this.btnAMZN.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnMSFT
            // 
            this.btnMSFT.Location = new System.Drawing.Point(107, 165);
            this.btnMSFT.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSFT.Name = "btnMSFT";
            this.btnMSFT.Size = new System.Drawing.Size(86, 26);
            this.btnMSFT.TabIndex = 9;
            this.btnMSFT.Tag = "MSFT";
            this.btnMSFT.Text = "MSFT";
            this.btnMSFT.UseVisualStyleBackColor = true;
            this.btnMSFT.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnAMD
            // 
            this.btnAMD.Location = new System.Drawing.Point(107, 131);
            this.btnAMD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAMD.Name = "btnAMD";
            this.btnAMD.Size = new System.Drawing.Size(86, 26);
            this.btnAMD.TabIndex = 5;
            this.btnAMD.Tag = "AMD";
            this.btnAMD.Text = "AMD";
            this.btnAMD.UseVisualStyleBackColor = true;
            this.btnAMD.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnAAPL
            // 
            this.btnAAPL.Location = new System.Drawing.Point(13, 131);
            this.btnAAPL.Margin = new System.Windows.Forms.Padding(4);
            this.btnAAPL.Name = "btnAAPL";
            this.btnAAPL.Size = new System.Drawing.Size(86, 26);
            this.btnAAPL.TabIndex = 4;
            this.btnAAPL.Tag = "AAPL";
            this.btnAAPL.Text = "AAPL";
            this.btnAAPL.UseVisualStyleBackColor = true;
            this.btnAAPL.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(42, 70);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(54, 19);
            this.lblSymbol.TabIndex = 6;
            this.lblSymbol.Text = "Symbol";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewTrade
            // 
            this.btnNewTrade.Location = new System.Drawing.Point(201, 67);
            this.btnNewTrade.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNewTrade.Name = "btnNewTrade";
            this.btnNewTrade.Size = new System.Drawing.Size(86, 26);
            this.btnNewTrade.TabIndex = 1;
            this.btnNewTrade.Text = "Trade";
            this.btnNewTrade.UseVisualStyleBackColor = true;
            this.btnNewTrade.Click += new System.EventHandler(this.btnNewTrade_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(107, 67);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(86, 26);
            this.txtSymbol.TabIndex = 2;
            // 
            // btnNVDA
            // 
            this.btnNVDA.Location = new System.Drawing.Point(201, 165);
            this.btnNVDA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNVDA.Name = "btnNVDA";
            this.btnNVDA.Size = new System.Drawing.Size(86, 26);
            this.btnNVDA.TabIndex = 10;
            this.btnNVDA.Tag = "NVDA";
            this.btnNVDA.Text = "NVDA";
            this.btnNVDA.UseVisualStyleBackColor = true;
            this.btnNVDA.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnMETA
            // 
            this.btnMETA.Location = new System.Drawing.Point(13, 165);
            this.btnMETA.Margin = new System.Windows.Forms.Padding(4);
            this.btnMETA.Name = "btnMETA";
            this.btnMETA.Size = new System.Drawing.Size(86, 26);
            this.btnMETA.TabIndex = 11;
            this.btnMETA.Tag = "META";
            this.btnMETA.Text = "META";
            this.btnMETA.UseVisualStyleBackColor = true;
            this.btnMETA.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnTSLA
            // 
            this.btnTSLA.Location = new System.Drawing.Point(13, 199);
            this.btnTSLA.Margin = new System.Windows.Forms.Padding(4);
            this.btnTSLA.Name = "btnTSLA";
            this.btnTSLA.Size = new System.Drawing.Size(86, 26);
            this.btnTSLA.TabIndex = 12;
            this.btnTSLA.Tag = "TSLA";
            this.btnTSLA.Text = "TSLA";
            this.btnTSLA.UseVisualStyleBackColor = true;
            this.btnTSLA.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnSPY
            // 
            this.btnSPY.Location = new System.Drawing.Point(107, 199);
            this.btnSPY.Margin = new System.Windows.Forms.Padding(4);
            this.btnSPY.Name = "btnSPY";
            this.btnSPY.Size = new System.Drawing.Size(86, 26);
            this.btnSPY.TabIndex = 13;
            this.btnSPY.Tag = "SPY";
            this.btnSPY.Text = "SPY";
            this.btnSPY.UseVisualStyleBackColor = true;
            this.btnSPY.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnQQQ
            // 
            this.btnQQQ.Location = new System.Drawing.Point(201, 199);
            this.btnQQQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnQQQ.Name = "btnQQQ";
            this.btnQQQ.Size = new System.Drawing.Size(86, 26);
            this.btnQQQ.TabIndex = 14;
            this.btnQQQ.Tag = "QQQ";
            this.btnQQQ.Text = "QQQ";
            this.btnQQQ.UseVisualStyleBackColor = true;
            this.btnQQQ.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // lblQuickTrade
            // 
            this.lblQuickTrade.AutoSize = true;
            this.lblQuickTrade.Location = new System.Drawing.Point(15, 102);
            this.lblQuickTrade.Name = "lblQuickTrade";
            this.lblQuickTrade.Size = new System.Drawing.Size(81, 19);
            this.lblQuickTrade.TabIndex = 15;
            this.lblQuickTrade.Text = "Quick Trade";
            // 
            // lblQuickTradeLine
            // 
            this.lblQuickTradeLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuickTradeLine.Location = new System.Drawing.Point(107, 113);
            this.lblQuickTradeLine.Name = "lblQuickTradeLine";
            this.lblQuickTradeLine.Size = new System.Drawing.Size(180, 2);
            this.lblQuickTradeLine.TabIndex = 16;
            // 
            // lblToolsLine
            // 
            this.lblToolsLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToolsLine.Location = new System.Drawing.Point(64, 247);
            this.lblToolsLine.Name = "lblToolsLine";
            this.lblToolsLine.Size = new System.Drawing.Size(221, 2);
            this.lblToolsLine.TabIndex = 18;
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.Location = new System.Drawing.Point(13, 236);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(40, 19);
            this.lblTools.TabIndex = 17;
            this.lblTools.Text = "Tools";
            // 
            // lblTradeLine
            // 
            this.lblTradeLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTradeLine.Location = new System.Drawing.Point(61, 51);
            this.lblTradeLine.Name = "lblTradeLine";
            this.lblTradeLine.Size = new System.Drawing.Size(224, 2);
            this.lblTradeLine.TabIndex = 20;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(13, 40);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(42, 19);
            this.lblTrade.TabIndex = 19;
            this.lblTrade.Text = "Trade";
            // 
            // btnScreenshots
            // 
            this.btnScreenshots.Location = new System.Drawing.Point(155, 260);
            this.btnScreenshots.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnScreenshots.Name = "btnScreenshots";
            this.btnScreenshots.Size = new System.Drawing.Size(130, 28);
            this.btnScreenshots.TabIndex = 21;
            this.btnScreenshots.Text = "View Screenshots";
            this.btnScreenshots.UseVisualStyleBackColor = true;
            this.btnScreenshots.Click += new System.EventHandler(this.btnScreenshots_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 299);
            this.Controls.Add(this.btnScreenshots);
            this.Controls.Add(this.lblTradeLine);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.lblToolsLine);
            this.Controls.Add(this.lblTools);
            this.Controls.Add(this.lblQuickTradeLine);
            this.Controls.Add(this.lblQuickTrade);
            this.Controls.Add(this.btnQQQ);
            this.Controls.Add(this.btnSPY);
            this.Controls.Add(this.btnTSLA);
            this.Controls.Add(this.btnMETA);
            this.Controls.Add(this.btnNVDA);
            this.Controls.Add(this.btnAMD);
            this.Controls.Add(this.btnAAPL);
            this.Controls.Add(this.btnNewTrade);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.btnMSFT);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.btnAMZN);
            this.Controls.Add(this.btnFuturesCalc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MasterForm";
            this.Text = "EZTM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btnFuturesCalc;
        private System.Windows.Forms.Button btnAMZN;
        private System.Windows.Forms.Button btnMSFT;
        private System.Windows.Forms.Button btnAMD;
        private System.Windows.Forms.Button btnAAPL;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnNewTrade;
        private System.Windows.Forms.Button btnNVDA;
        private System.Windows.Forms.Button btnMETA;
        private System.Windows.Forms.Button btnTSLA;
        private System.Windows.Forms.Button btnSPY;
        private System.Windows.Forms.Button btnQQQ;
        private System.Windows.Forms.Label lblQuickTrade;
        private System.Windows.Forms.Label lblQuickTradeLine;
        private System.Windows.Forms.Label lblToolsLine;
        private System.Windows.Forms.Label lblTools;
        private System.Windows.Forms.Label lblTradeLine;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.Button btnScreenshots;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
    }
}