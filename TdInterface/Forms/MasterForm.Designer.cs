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
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mtcMasterForm = new MaterialSkin.Controls.MaterialTabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lnkAppGithub = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.mtcMasterForm.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.menuStrip1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 25);
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
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            this.accountSettingsToolStripMenuItem.Click += new System.EventHandler(this.accountSettingsToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check For Update";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnFuturesCalc
            // 
            this.btnFuturesCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFuturesCalc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFuturesCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFuturesCalc.Location = new System.Drawing.Point(13, 260);
            this.btnFuturesCalc.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFuturesCalc.Name = "btnFuturesCalc";
            this.btnFuturesCalc.Size = new System.Drawing.Size(130, 28);
            this.btnFuturesCalc.TabIndex = 3;
            this.btnFuturesCalc.Text = "Futures Calculator";
            this.btnFuturesCalc.UseVisualStyleBackColor = false;
            this.btnFuturesCalc.Click += new System.EventHandler(this.btnFuturesCalc_Click);
            // 
            // btnAMZN
            // 
            this.btnAMZN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAMZN.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAMZN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAMZN.Location = new System.Drawing.Point(203, 106);
            this.btnAMZN.Margin = new System.Windows.Forms.Padding(4);
            this.btnAMZN.Name = "btnAMZN";
            this.btnAMZN.Size = new System.Drawing.Size(86, 26);
            this.btnAMZN.TabIndex = 8;
            this.btnAMZN.Tag = "AMZN";
            this.btnAMZN.Text = "AMZN";
            this.btnAMZN.UseVisualStyleBackColor = false;
            this.btnAMZN.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnMSFT
            // 
            this.btnMSFT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMSFT.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMSFT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMSFT.Location = new System.Drawing.Point(111, 140);
            this.btnMSFT.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSFT.Name = "btnMSFT";
            this.btnMSFT.Size = new System.Drawing.Size(86, 26);
            this.btnMSFT.TabIndex = 9;
            this.btnMSFT.Tag = "MSFT";
            this.btnMSFT.Text = "MSFT";
            this.btnMSFT.UseVisualStyleBackColor = false;
            this.btnMSFT.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnAMD
            // 
            this.btnAMD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAMD.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAMD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAMD.Location = new System.Drawing.Point(111, 106);
            this.btnAMD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAMD.Name = "btnAMD";
            this.btnAMD.Size = new System.Drawing.Size(86, 26);
            this.btnAMD.TabIndex = 5;
            this.btnAMD.Tag = "AMD";
            this.btnAMD.Text = "AMD";
            this.btnAMD.UseVisualStyleBackColor = false;
            this.btnAMD.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnAAPL
            // 
            this.btnAAPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAAPL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAAPL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAAPL.Location = new System.Drawing.Point(17, 106);
            this.btnAAPL.Margin = new System.Windows.Forms.Padding(4);
            this.btnAAPL.Name = "btnAAPL";
            this.btnAAPL.Size = new System.Drawing.Size(86, 26);
            this.btnAAPL.TabIndex = 4;
            this.btnAAPL.Tag = "AAPL";
            this.btnAAPL.Text = "AAPL";
            this.btnAAPL.UseVisualStyleBackColor = false;
            this.btnAAPL.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSymbol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSymbol.Location = new System.Drawing.Point(46, 45);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(54, 17);
            this.lblSymbol.TabIndex = 6;
            this.lblSymbol.Text = "Symbol";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewTrade
            // 
            this.btnNewTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNewTrade.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNewTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNewTrade.Location = new System.Drawing.Point(205, 42);
            this.btnNewTrade.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnNewTrade.Name = "btnNewTrade";
            this.btnNewTrade.Size = new System.Drawing.Size(86, 26);
            this.btnNewTrade.TabIndex = 1;
            this.btnNewTrade.Text = "Trade";
            this.btnNewTrade.UseVisualStyleBackColor = false;
            this.btnNewTrade.Click += new System.EventHandler(this.btnNewTrade_Click);
            // 
            // txtSymbol
            // 
            this.txtSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSymbol.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSymbol.Location = new System.Drawing.Point(111, 42);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(86, 24);
            this.txtSymbol.TabIndex = 2;
            // 
            // btnNVDA
            // 
            this.btnNVDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNVDA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnNVDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNVDA.Location = new System.Drawing.Point(205, 140);
            this.btnNVDA.Margin = new System.Windows.Forms.Padding(4);
            this.btnNVDA.Name = "btnNVDA";
            this.btnNVDA.Size = new System.Drawing.Size(86, 26);
            this.btnNVDA.TabIndex = 10;
            this.btnNVDA.Tag = "NVDA";
            this.btnNVDA.Text = "NVDA";
            this.btnNVDA.UseVisualStyleBackColor = false;
            this.btnNVDA.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnMETA
            // 
            this.btnMETA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnMETA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnMETA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMETA.Location = new System.Drawing.Point(17, 140);
            this.btnMETA.Margin = new System.Windows.Forms.Padding(4);
            this.btnMETA.Name = "btnMETA";
            this.btnMETA.Size = new System.Drawing.Size(86, 26);
            this.btnMETA.TabIndex = 11;
            this.btnMETA.Tag = "META";
            this.btnMETA.Text = "META";
            this.btnMETA.UseVisualStyleBackColor = false;
            this.btnMETA.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnTSLA
            // 
            this.btnTSLA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTSLA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnTSLA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTSLA.Location = new System.Drawing.Point(17, 174);
            this.btnTSLA.Margin = new System.Windows.Forms.Padding(4);
            this.btnTSLA.Name = "btnTSLA";
            this.btnTSLA.Size = new System.Drawing.Size(86, 26);
            this.btnTSLA.TabIndex = 12;
            this.btnTSLA.Tag = "TSLA";
            this.btnTSLA.Text = "TSLA";
            this.btnTSLA.UseVisualStyleBackColor = false;
            this.btnTSLA.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnSPY
            // 
            this.btnSPY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSPY.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSPY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSPY.Location = new System.Drawing.Point(111, 174);
            this.btnSPY.Margin = new System.Windows.Forms.Padding(4);
            this.btnSPY.Name = "btnSPY";
            this.btnSPY.Size = new System.Drawing.Size(86, 26);
            this.btnSPY.TabIndex = 13;
            this.btnSPY.Tag = "SPY";
            this.btnSPY.Text = "SPY";
            this.btnSPY.UseVisualStyleBackColor = false;
            this.btnSPY.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // btnQQQ
            // 
            this.btnQQQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnQQQ.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnQQQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnQQQ.Location = new System.Drawing.Point(205, 174);
            this.btnQQQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnQQQ.Name = "btnQQQ";
            this.btnQQQ.Size = new System.Drawing.Size(86, 26);
            this.btnQQQ.TabIndex = 14;
            this.btnQQQ.Tag = "QQQ";
            this.btnQQQ.Text = "QQQ";
            this.btnQQQ.UseVisualStyleBackColor = false;
            this.btnQQQ.Click += new System.EventHandler(this.btnTicker_Click);
            // 
            // lblQuickTrade
            // 
            this.lblQuickTrade.AutoSize = true;
            this.lblQuickTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblQuickTrade.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuickTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuickTrade.Location = new System.Drawing.Point(19, 77);
            this.lblQuickTrade.Name = "lblQuickTrade";
            this.lblQuickTrade.Size = new System.Drawing.Size(81, 17);
            this.lblQuickTrade.TabIndex = 15;
            this.lblQuickTrade.Text = "Quick Trade";
            // 
            // lblQuickTradeLine
            // 
            this.lblQuickTradeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblQuickTradeLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuickTradeLine.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblQuickTradeLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuickTradeLine.Location = new System.Drawing.Point(111, 88);
            this.lblQuickTradeLine.Name = "lblQuickTradeLine";
            this.lblQuickTradeLine.Size = new System.Drawing.Size(180, 2);
            this.lblQuickTradeLine.TabIndex = 16;
            // 
            // lblToolsLine
            // 
            this.lblToolsLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblToolsLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblToolsLine.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblToolsLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblToolsLine.Location = new System.Drawing.Point(68, 222);
            this.lblToolsLine.Name = "lblToolsLine";
            this.lblToolsLine.Size = new System.Drawing.Size(221, 2);
            this.lblToolsLine.TabIndex = 18;
            // 
            // lblTools
            // 
            this.lblTools.AutoSize = true;
            this.lblTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTools.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTools.Location = new System.Drawing.Point(17, 211);
            this.lblTools.Name = "lblTools";
            this.lblTools.Size = new System.Drawing.Size(41, 17);
            this.lblTools.TabIndex = 17;
            this.lblTools.Text = "Tools";
            // 
            // lblTradeLine
            // 
            this.lblTradeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTradeLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTradeLine.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTradeLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTradeLine.Location = new System.Drawing.Point(65, 26);
            this.lblTradeLine.Name = "lblTradeLine";
            this.lblTradeLine.Size = new System.Drawing.Size(224, 2);
            this.lblTradeLine.TabIndex = 20;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblTrade.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTrade.Location = new System.Drawing.Point(17, 15);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(43, 17);
            this.lblTrade.TabIndex = 19;
            this.lblTrade.Text = "Trade";
            // 
            // btnScreenshots
            // 
            this.btnScreenshots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScreenshots.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnScreenshots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnScreenshots.Location = new System.Drawing.Point(159, 235);
            this.btnScreenshots.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnScreenshots.Name = "btnScreenshots";
            this.btnScreenshots.Size = new System.Drawing.Size(130, 28);
            this.btnScreenshots.TabIndex = 21;
            this.btnScreenshots.Text = "View Screenshots";
            this.btnScreenshots.UseVisualStyleBackColor = false;
            this.btnScreenshots.Click += new System.EventHandler(this.btnScreenshots_Click);
            // 
            // mtcMasterForm
            // 
            this.mtcMasterForm.Controls.Add(this.tpHome);
            this.mtcMasterForm.Controls.Add(this.tpSettings);
            this.mtcMasterForm.Controls.Add(this.tpAbout);
            this.mtcMasterForm.Depth = 0;
            this.mtcMasterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMasterForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtcMasterForm.Location = new System.Drawing.Point(3, 89);
            this.mtcMasterForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMasterForm.Multiline = true;
            this.mtcMasterForm.Name = "mtcMasterForm";
            this.mtcMasterForm.SelectedIndex = 0;
            this.mtcMasterForm.Size = new System.Drawing.Size(311, 731);
            this.mtcMasterForm.TabIndex = 22;
            // 
            // tpHome
            // 
            this.tpHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tpHome.Controls.Add(this.btnScreenshots);
            this.tpHome.Controls.Add(this.btnFuturesCalc);
            this.tpHome.Controls.Add(this.lblTradeLine);
            this.tpHome.Controls.Add(this.btnAMZN);
            this.tpHome.Controls.Add(this.lblTrade);
            this.tpHome.Controls.Add(this.lblSymbol);
            this.tpHome.Controls.Add(this.lblToolsLine);
            this.tpHome.Controls.Add(this.btnMSFT);
            this.tpHome.Controls.Add(this.lblTools);
            this.tpHome.Controls.Add(this.txtSymbol);
            this.tpHome.Controls.Add(this.lblQuickTradeLine);
            this.tpHome.Controls.Add(this.btnNewTrade);
            this.tpHome.Controls.Add(this.lblQuickTrade);
            this.tpHome.Controls.Add(this.btnAAPL);
            this.tpHome.Controls.Add(this.btnQQQ);
            this.tpHome.Controls.Add(this.btnAMD);
            this.tpHome.Controls.Add(this.btnSPY);
            this.tpHome.Controls.Add(this.btnNVDA);
            this.tpHome.Controls.Add(this.btnTSLA);
            this.tpHome.Controls.Add(this.btnMETA);
            this.tpHome.Location = new System.Drawing.Point(4, 28);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(303, 699);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tpSettings.Location = new System.Drawing.Point(4, 28);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(303, 699);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            // 
            // tpAbout
            // 
            this.tpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tpAbout.Controls.Add(this.materialLabel1);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.lblCopyright);
            this.tpAbout.Controls.Add(this.lnkAppGithub);
            this.tpAbout.Controls.Add(this.pictureBox1);
            this.tpAbout.Location = new System.Drawing.Point(4, 28);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(303, 699);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(68, 146);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(166, 24);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "EZ Trade Manager";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblVersion.Depth = 0;
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVersion.Location = new System.Drawing.Point(101, 191);
            this.lblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 19);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Version: #.#.#";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblCopyright.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCopyright.Location = new System.Drawing.Point(74, 263);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(188, 34);
            this.lblCopyright.TabIndex = 9;
            this.lblCopyright.Text = "Copyright 2022 - 2023, EZTM\r\nAll Rights Reserved.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkAppGithub
            // 
            this.lnkAppGithub.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.lnkAppGithub.AutoSize = true;
            this.lnkAppGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lnkAppGithub.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lnkAppGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lnkAppGithub.Location = new System.Drawing.Point(76, 234);
            this.lnkAppGithub.Name = "lnkAppGithub";
            this.lnkAppGithub.Size = new System.Drawing.Size(185, 17);
            this.lnkAppGithub.TabIndex = 8;
            this.lnkAppGithub.TabStop = true;
            this.lnkAppGithub.Text = "EZ Trade Manager on Github";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::TdInterface.Properties.Resources.logo_96;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MasterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(317, 823);
            this.Controls.Add(this.mtcMasterForm);
            this.Controls.Add(this.menuStrip1);
            this.DrawerTabControl = this.mtcMasterForm;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MasterForm";
            this.Text = "EZTM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mtcMasterForm.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private MaterialSkin.Controls.MaterialTabControl mtcMasterForm;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpAbout;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.LinkLabel lnkAppGithub;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}