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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            btnFuturesCalc = new System.Windows.Forms.Button();
            btnAMZN = new System.Windows.Forms.Button();
            btnMSFT = new System.Windows.Forms.Button();
            btnAMD = new System.Windows.Forms.Button();
            btnAAPL = new System.Windows.Forms.Button();
            lblSymbol = new System.Windows.Forms.Label();
            btnNewTrade = new System.Windows.Forms.Button();
            txtSymbol = new System.Windows.Forms.TextBox();
            btnNVDA = new System.Windows.Forms.Button();
            btnMETA = new System.Windows.Forms.Button();
            btnTSLA = new System.Windows.Forms.Button();
            btnSPY = new System.Windows.Forms.Button();
            btnQQQ = new System.Windows.Forms.Button();
            lblQuickTrade = new System.Windows.Forms.Label();
            lblQuickTradeLine = new System.Windows.Forms.Label();
            lblToolsLine = new System.Windows.Forms.Label();
            lblTools = new System.Windows.Forms.Label();
            lblTradeLine = new System.Windows.Forms.Label();
            lblTrade = new System.Windows.Forms.Label();
            btnScreenshots = new System.Windows.Forms.Button();
            btnThetaForm = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 50000;
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(301, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem, accountSettingsToolStripMenuItem, checkForUpdateToolStripMenuItem, aboutToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            accountSettingsToolStripMenuItem.Click += accountSettingsToolStripMenuItem_Click;
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            checkForUpdateToolStripMenuItem.Text = "Check For Update";
            checkForUpdateToolStripMenuItem.Click += checkForUpdateToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // btnFuturesCalc
            // 
            btnFuturesCalc.Location = new System.Drawing.Point(13, 260);
            btnFuturesCalc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnFuturesCalc.Name = "btnFuturesCalc";
            btnFuturesCalc.Size = new System.Drawing.Size(130, 28);
            btnFuturesCalc.TabIndex = 3;
            btnFuturesCalc.Text = "Futures Calculator";
            btnFuturesCalc.UseVisualStyleBackColor = true;
            btnFuturesCalc.Click += btnFuturesCalc_Click;
            // 
            // btnAMZN
            // 
            btnAMZN.Location = new System.Drawing.Point(199, 131);
            btnAMZN.Margin = new System.Windows.Forms.Padding(4);
            btnAMZN.Name = "btnAMZN";
            btnAMZN.Size = new System.Drawing.Size(86, 26);
            btnAMZN.TabIndex = 8;
            btnAMZN.Tag = "AMZN";
            btnAMZN.Text = "AMZN";
            btnAMZN.UseVisualStyleBackColor = true;
            btnAMZN.Click += btnTicker_Click;
            // 
            // btnMSFT
            // 
            btnMSFT.Location = new System.Drawing.Point(107, 165);
            btnMSFT.Margin = new System.Windows.Forms.Padding(4);
            btnMSFT.Name = "btnMSFT";
            btnMSFT.Size = new System.Drawing.Size(86, 26);
            btnMSFT.TabIndex = 9;
            btnMSFT.Tag = "MSFT";
            btnMSFT.Text = "MSFT";
            btnMSFT.UseVisualStyleBackColor = true;
            btnMSFT.Click += btnTicker_Click;
            // 
            // btnAMD
            // 
            btnAMD.Location = new System.Drawing.Point(107, 131);
            btnAMD.Margin = new System.Windows.Forms.Padding(4);
            btnAMD.Name = "btnAMD";
            btnAMD.Size = new System.Drawing.Size(86, 26);
            btnAMD.TabIndex = 5;
            btnAMD.Tag = "AMD";
            btnAMD.Text = "AMD";
            btnAMD.UseVisualStyleBackColor = true;
            btnAMD.Click += btnTicker_Click;
            // 
            // btnAAPL
            // 
            btnAAPL.Location = new System.Drawing.Point(13, 131);
            btnAAPL.Margin = new System.Windows.Forms.Padding(4);
            btnAAPL.Name = "btnAAPL";
            btnAAPL.Size = new System.Drawing.Size(86, 26);
            btnAAPL.TabIndex = 4;
            btnAAPL.Tag = "AAPL";
            btnAAPL.Text = "AAPL";
            btnAAPL.UseVisualStyleBackColor = true;
            btnAAPL.Click += btnTicker_Click;
            // 
            // lblSymbol
            // 
            lblSymbol.AutoSize = true;
            lblSymbol.Location = new System.Drawing.Point(42, 70);
            lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSymbol.Name = "lblSymbol";
            lblSymbol.Size = new System.Drawing.Size(59, 20);
            lblSymbol.TabIndex = 6;
            lblSymbol.Text = "Symbol";
            lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewTrade
            // 
            btnNewTrade.Location = new System.Drawing.Point(201, 67);
            btnNewTrade.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnNewTrade.Name = "btnNewTrade";
            btnNewTrade.Size = new System.Drawing.Size(86, 26);
            btnNewTrade.TabIndex = 1;
            btnNewTrade.Text = "Trade";
            btnNewTrade.UseVisualStyleBackColor = true;
            btnNewTrade.Click += btnNewTrade_Click;
            // 
            // txtSymbol
            // 
            txtSymbol.Location = new System.Drawing.Point(107, 67);
            txtSymbol.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new System.Drawing.Size(86, 26);
            txtSymbol.TabIndex = 2;
            // 
            // btnNVDA
            // 
            btnNVDA.Location = new System.Drawing.Point(201, 165);
            btnNVDA.Margin = new System.Windows.Forms.Padding(4);
            btnNVDA.Name = "btnNVDA";
            btnNVDA.Size = new System.Drawing.Size(86, 26);
            btnNVDA.TabIndex = 10;
            btnNVDA.Tag = "NVDA";
            btnNVDA.Text = "NVDA";
            btnNVDA.UseVisualStyleBackColor = true;
            btnNVDA.Click += btnTicker_Click;
            // 
            // btnMETA
            // 
            btnMETA.Location = new System.Drawing.Point(13, 165);
            btnMETA.Margin = new System.Windows.Forms.Padding(4);
            btnMETA.Name = "btnMETA";
            btnMETA.Size = new System.Drawing.Size(86, 26);
            btnMETA.TabIndex = 11;
            btnMETA.Tag = "META";
            btnMETA.Text = "META";
            btnMETA.UseVisualStyleBackColor = true;
            btnMETA.Click += btnTicker_Click;
            // 
            // btnTSLA
            // 
            btnTSLA.Location = new System.Drawing.Point(13, 199);
            btnTSLA.Margin = new System.Windows.Forms.Padding(4);
            btnTSLA.Name = "btnTSLA";
            btnTSLA.Size = new System.Drawing.Size(86, 26);
            btnTSLA.TabIndex = 12;
            btnTSLA.Tag = "TSLA";
            btnTSLA.Text = "TSLA";
            btnTSLA.UseVisualStyleBackColor = true;
            btnTSLA.Click += btnTicker_Click;
            // 
            // btnSPY
            // 
            btnSPY.Location = new System.Drawing.Point(107, 199);
            btnSPY.Margin = new System.Windows.Forms.Padding(4);
            btnSPY.Name = "btnSPY";
            btnSPY.Size = new System.Drawing.Size(86, 26);
            btnSPY.TabIndex = 13;
            btnSPY.Tag = "SPY";
            btnSPY.Text = "SPY";
            btnSPY.UseVisualStyleBackColor = true;
            btnSPY.Click += btnTicker_Click;
            // 
            // btnQQQ
            // 
            btnQQQ.Location = new System.Drawing.Point(201, 199);
            btnQQQ.Margin = new System.Windows.Forms.Padding(4);
            btnQQQ.Name = "btnQQQ";
            btnQQQ.Size = new System.Drawing.Size(86, 26);
            btnQQQ.TabIndex = 14;
            btnQQQ.Tag = "QQQ";
            btnQQQ.Text = "QQQ";
            btnQQQ.UseVisualStyleBackColor = true;
            btnQQQ.Click += btnTicker_Click;
            // 
            // lblQuickTrade
            // 
            lblQuickTrade.AutoSize = true;
            lblQuickTrade.Location = new System.Drawing.Point(15, 102);
            lblQuickTrade.Name = "lblQuickTrade";
            lblQuickTrade.Size = new System.Drawing.Size(87, 20);
            lblQuickTrade.TabIndex = 15;
            lblQuickTrade.Text = "Quick Trade";
            // 
            // lblQuickTradeLine
            // 
            lblQuickTradeLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblQuickTradeLine.Location = new System.Drawing.Point(107, 113);
            lblQuickTradeLine.Name = "lblQuickTradeLine";
            lblQuickTradeLine.Size = new System.Drawing.Size(180, 2);
            lblQuickTradeLine.TabIndex = 16;
            // 
            // lblToolsLine
            // 
            lblToolsLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblToolsLine.Location = new System.Drawing.Point(64, 247);
            lblToolsLine.Name = "lblToolsLine";
            lblToolsLine.Size = new System.Drawing.Size(221, 2);
            lblToolsLine.TabIndex = 18;
            // 
            // lblTools
            // 
            lblTools.AutoSize = true;
            lblTools.Location = new System.Drawing.Point(13, 236);
            lblTools.Name = "lblTools";
            lblTools.Size = new System.Drawing.Size(44, 20);
            lblTools.TabIndex = 17;
            lblTools.Text = "Tools";
            // 
            // lblTradeLine
            // 
            lblTradeLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lblTradeLine.Location = new System.Drawing.Point(61, 51);
            lblTradeLine.Name = "lblTradeLine";
            lblTradeLine.Size = new System.Drawing.Size(224, 2);
            lblTradeLine.TabIndex = 20;
            // 
            // lblTrade
            // 
            lblTrade.AutoSize = true;
            lblTrade.Location = new System.Drawing.Point(13, 40);
            lblTrade.Name = "lblTrade";
            lblTrade.Size = new System.Drawing.Size(46, 20);
            lblTrade.TabIndex = 19;
            lblTrade.Text = "Trade";
            // 
            // btnScreenshots
            // 
            btnScreenshots.Location = new System.Drawing.Point(155, 260);
            btnScreenshots.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            btnScreenshots.Name = "btnScreenshots";
            btnScreenshots.Size = new System.Drawing.Size(130, 28);
            btnScreenshots.TabIndex = 21;
            btnScreenshots.Text = "View Screenshots";
            btnScreenshots.UseVisualStyleBackColor = true;
            btnScreenshots.Click += btnScreenshots_Click;
            // 
            // btnThetaForm
            // 
            btnThetaForm.Location = new System.Drawing.Point(16, 298);
            btnThetaForm.Name = "btnThetaForm";
            btnThetaForm.Size = new System.Drawing.Size(94, 29);
            btnThetaForm.TabIndex = 22;
            btnThetaForm.Text = "Theta";
            btnThetaForm.UseVisualStyleBackColor = true;
            btnThetaForm.Click += btnThetaForm_Click;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(301, 332);
            Controls.Add(btnThetaForm);
            Controls.Add(btnScreenshots);
            Controls.Add(lblTradeLine);
            Controls.Add(lblTrade);
            Controls.Add(lblToolsLine);
            Controls.Add(lblTools);
            Controls.Add(lblQuickTradeLine);
            Controls.Add(lblQuickTrade);
            Controls.Add(btnQQQ);
            Controls.Add(btnSPY);
            Controls.Add(btnTSLA);
            Controls.Add(btnMETA);
            Controls.Add(btnNVDA);
            Controls.Add(btnAMD);
            Controls.Add(btnAAPL);
            Controls.Add(btnNewTrade);
            Controls.Add(txtSymbol);
            Controls.Add(btnMSFT);
            Controls.Add(lblSymbol);
            Controls.Add(btnAMZN);
            Controls.Add(btnFuturesCalc);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "MasterForm";
            Text = "EZTM";
            FormClosing += MasterForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Button btnThetaForm;
    }
}