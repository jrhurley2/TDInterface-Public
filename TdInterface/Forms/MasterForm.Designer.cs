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
            btnStock3 = new System.Windows.Forms.Button();
            btnStock5 = new System.Windows.Forms.Button();
            btnStock2 = new System.Windows.Forms.Button();
            btnStock1 = new System.Windows.Forms.Button();
            lblSymbol = new System.Windows.Forms.Label();
            btnNewTrade = new System.Windows.Forms.Button();
            txtSymbol = new System.Windows.Forms.TextBox();
            btnStock6 = new System.Windows.Forms.Button();
            btnStock4 = new System.Windows.Forms.Button();
            btnStock7 = new System.Windows.Forms.Button();
            btnStock8 = new System.Windows.Forms.Button();
            btnStock9 = new System.Windows.Forms.Button();
            lblQuickTrade = new System.Windows.Forms.Label();
            lblQuickTradeLine = new System.Windows.Forms.Label();
            lblToolsLine = new System.Windows.Forms.Label();
            lblTools = new System.Windows.Forms.Label();
            lblTradeLine = new System.Windows.Forms.Label();
            lblTrade = new System.Windows.Forms.Label();
            btnScreenshots = new System.Windows.Forms.Button();
            btnThetaForm = new System.Windows.Forms.Button();
            stockPreferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem, accountSettingsToolStripMenuItem, stockPreferenceToolStripMenuItem, checkForUpdateToolStripMenuItem, aboutToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // accountSettingsToolStripMenuItem
            // 
            accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            accountSettingsToolStripMenuItem.Text = "Account Settings";
            accountSettingsToolStripMenuItem.Click += accountSettingsToolStripMenuItem_Click;
            // 
            // checkForUpdateToolStripMenuItem
            // 
            checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            checkForUpdateToolStripMenuItem.Text = "Check For Update";
            checkForUpdateToolStripMenuItem.Click += checkForUpdateToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // btnStock3
            // 
            btnStock3.Location = new System.Drawing.Point(199, 131);
            btnStock3.Margin = new System.Windows.Forms.Padding(4);
            btnStock3.Name = "btnStock3";
            btnStock3.Size = new System.Drawing.Size(86, 26);
            btnStock3.TabIndex = 8;
            btnStock3.Tag = "AMZN";
            btnStock3.Text = "AMZN";
            btnStock3.UseVisualStyleBackColor = true;
            btnStock3.Click += btnTicker_Click;
            // 
            // btnStock5
            // 
            btnStock5.Location = new System.Drawing.Point(107, 165);
            btnStock5.Margin = new System.Windows.Forms.Padding(4);
            btnStock5.Name = "btnStock5";
            btnStock5.Size = new System.Drawing.Size(86, 26);
            btnStock5.TabIndex = 9;
            btnStock5.Tag = "MSFT";
            btnStock5.Text = "MSFT";
            btnStock5.UseVisualStyleBackColor = true;
            btnStock5.Click += btnTicker_Click;
            // 
            // btnStock2
            // 
            btnStock2.Location = new System.Drawing.Point(107, 131);
            btnStock2.Margin = new System.Windows.Forms.Padding(4);
            btnStock2.Name = "btnStock2";
            btnStock2.Size = new System.Drawing.Size(86, 26);
            btnStock2.TabIndex = 5;
            btnStock2.Tag = "AMD";
            btnStock2.Text = "AMD";
            btnStock2.UseVisualStyleBackColor = true;
            btnStock2.Click += btnTicker_Click;
            // 
            // btnStock1
            // 
            btnStock1.Location = new System.Drawing.Point(13, 131);
            btnStock1.Margin = new System.Windows.Forms.Padding(4);
            btnStock1.Name = "btnStock1";
            btnStock1.Size = new System.Drawing.Size(86, 26);
            btnStock1.TabIndex = 4;
            btnStock1.Tag = "AAPL";
            btnStock1.Text = "AAPL";
            btnStock1.UseVisualStyleBackColor = true;
            btnStock1.Click += btnTicker_Click;
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
            // btnStock6
            // 
            btnStock6.Location = new System.Drawing.Point(201, 165);
            btnStock6.Margin = new System.Windows.Forms.Padding(4);
            btnStock6.Name = "btnStock6";
            btnStock6.Size = new System.Drawing.Size(86, 26);
            btnStock6.TabIndex = 10;
            btnStock6.Tag = "NVDA";
            btnStock6.Text = "NVDA";
            btnStock6.UseVisualStyleBackColor = true;
            btnStock6.Click += btnTicker_Click;
            // 
            // btnStock4
            // 
            btnStock4.Location = new System.Drawing.Point(13, 165);
            btnStock4.Margin = new System.Windows.Forms.Padding(4);
            btnStock4.Name = "btnStock4";
            btnStock4.Size = new System.Drawing.Size(86, 26);
            btnStock4.TabIndex = 11;
            btnStock4.Tag = "META";
            btnStock4.Text = "META";
            btnStock4.UseVisualStyleBackColor = true;
            btnStock4.Click += btnTicker_Click;
            // 
            // btnStock7
            // 
            btnStock7.Location = new System.Drawing.Point(13, 199);
            btnStock7.Margin = new System.Windows.Forms.Padding(4);
            btnStock7.Name = "btnStock7";
            btnStock7.Size = new System.Drawing.Size(86, 26);
            btnStock7.TabIndex = 12;
            btnStock7.Tag = "TSLA";
            btnStock7.Text = "TSLA";
            btnStock7.UseVisualStyleBackColor = true;
            btnStock7.Click += btnTicker_Click;
            // 
            // btnStock8
            // 
            btnStock8.Location = new System.Drawing.Point(107, 199);
            btnStock8.Margin = new System.Windows.Forms.Padding(4);
            btnStock8.Name = "btnStock8";
            btnStock8.Size = new System.Drawing.Size(86, 26);
            btnStock8.TabIndex = 13;
            btnStock8.Tag = "SPY";
            btnStock8.Text = "SPY";
            btnStock8.UseVisualStyleBackColor = true;
            btnStock8.Click += btnTicker_Click;
            // 
            // btnStock9
            // 
            btnStock9.Location = new System.Drawing.Point(201, 199);
            btnStock9.Margin = new System.Windows.Forms.Padding(4);
            btnStock9.Name = "btnStock9";
            btnStock9.Size = new System.Drawing.Size(86, 26);
            btnStock9.TabIndex = 14;
            btnStock9.Tag = "QQQ";
            btnStock9.Text = "QQQ";
            btnStock9.UseVisualStyleBackColor = true;
            btnStock9.Click += btnTicker_Click;
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
            // stockPreferenceToolStripMenuItem
            // 
            stockPreferenceToolStripMenuItem.Name = "stockPreferenceToolStripMenuItem";
            stockPreferenceToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            stockPreferenceToolStripMenuItem.Text = "Stock Preference";
            stockPreferenceToolStripMenuItem.Click += stockPreferenceToolStripMenuItem_Click;
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
            Controls.Add(btnStock9);
            Controls.Add(btnStock8);
            Controls.Add(btnStock7);
            Controls.Add(btnStock4);
            Controls.Add(btnStock6);
            Controls.Add(btnStock2);
            Controls.Add(btnStock1);
            Controls.Add(btnNewTrade);
            Controls.Add(txtSymbol);
            Controls.Add(btnStock5);
            Controls.Add(lblSymbol);
            Controls.Add(btnStock3);
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
        private System.Windows.Forms.Button btnStock3;
        private System.Windows.Forms.Button btnStock5;
        private System.Windows.Forms.Button btnStock2;
        private System.Windows.Forms.Button btnStock1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnNewTrade;
        private System.Windows.Forms.Button btnStock6;
        private System.Windows.Forms.Button btnStock4;
        private System.Windows.Forms.Button btnStock7;
        private System.Windows.Forms.Button btnStock8;
        private System.Windows.Forms.Button btnStock9;
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
        private System.Windows.Forms.ToolStripMenuItem stockPreferenceToolStripMenuItem;
    }
}