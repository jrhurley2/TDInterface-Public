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
            this.tpAccountSettings = new System.Windows.Forms.TabPage();
            this.btnClearCreds = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.chkUseSimAccount = new MaterialSkin.Controls.MaterialSwitch();
            this.txtClientSecret = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtClientId = new MaterialSkin.Controls.MaterialTextBox2();
            this.chkTsEnableEquity = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.chkTdaEnableEquity = new MaterialSkin.Controls.MaterialSwitch();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtConsumerKey = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblAccountSettings = new MaterialSkin.Controls.MaterialLabel();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.btnCheckForUpdates = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnGitHub = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblVersion = new MaterialSkin.Controls.MaterialLabel();
            this.pbAppLogo = new System.Windows.Forms.PictureBox();
            this.mtcMasterForm.SuspendLayout();
            this.tpHome.SuspendLayout();
            this.tpAccountSettings.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnFuturesCalc
            // 
            this.btnFuturesCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnFuturesCalc.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnFuturesCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFuturesCalc.Location = new System.Drawing.Point(17, 235);
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
            this.mtcMasterForm.Controls.Add(this.tpAccountSettings);
            this.mtcMasterForm.Controls.Add(this.tpAbout);
            this.mtcMasterForm.Depth = 0;
            this.mtcMasterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMasterForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mtcMasterForm.Location = new System.Drawing.Point(3, 64);
            this.mtcMasterForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.mtcMasterForm.Multiline = true;
            this.mtcMasterForm.Name = "mtcMasterForm";
            this.mtcMasterForm.SelectedIndex = 0;
            this.mtcMasterForm.Size = new System.Drawing.Size(954, 893);
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
            this.tpHome.Size = new System.Drawing.Size(946, 836);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tpSettings.Location = new System.Drawing.Point(4, 28);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(946, 836);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.Enter += new System.EventHandler(this.tpSettings_Enter);
            // 
            // tpAccountSettings
            // 
            this.tpAccountSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tpAccountSettings.Controls.Add(this.btnClearCreds);
            this.tpAccountSettings.Controls.Add(this.btnSave);
            this.tpAccountSettings.Controls.Add(this.materialCard2);
            this.tpAccountSettings.Controls.Add(this.materialLabel5);
            this.tpAccountSettings.Controls.Add(this.materialLabel3);
            this.tpAccountSettings.Controls.Add(this.materialCard1);
            this.tpAccountSettings.Controls.Add(this.lblAccountSettings);
            this.tpAccountSettings.Location = new System.Drawing.Point(4, 28);
            this.tpAccountSettings.Name = "tpAccountSettings";
            this.tpAccountSettings.Size = new System.Drawing.Size(946, 861);
            this.tpAccountSettings.TabIndex = 3;
            this.tpAccountSettings.Text = "Account Settings";
            this.tpAccountSettings.Enter += new System.EventHandler(this.tpAccountSettings_Enter);
            // 
            // btnClearCreds
            // 
            this.btnClearCreds.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearCreds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnClearCreds.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearCreds.Depth = 0;
            this.btnClearCreds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClearCreds.HighEmphasis = true;
            this.btnClearCreds.Icon = null;
            this.btnClearCreds.Location = new System.Drawing.Point(20, 784);
            this.btnClearCreds.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearCreds.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearCreds.Name = "btnClearCreds";
            this.btnClearCreds.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearCreds.Size = new System.Drawing.Size(166, 36);
            this.btnClearCreds.TabIndex = 27;
            this.btnClearCreds.Text = "Clear Credentials";
            this.btnClearCreds.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearCreds.UseAccentColor = true;
            this.btnClearCreds.UseVisualStyleBackColor = false;
            this.btnClearCreds.Click += new System.EventHandler(this.btnClearCreds_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(868, 784);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel9);
            this.materialCard2.Controls.Add(this.chkUseSimAccount);
            this.materialCard2.Controls.Add(this.txtClientSecret);
            this.materialCard2.Controls.Add(this.materialLabel8);
            this.materialCard2.Controls.Add(this.txtClientId);
            this.materialCard2.Controls.Add(this.chkTsEnableEquity);
            this.materialCard2.Controls.Add(this.materialLabel7);
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(21, 342);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(911, 275);
            this.materialCard2.TabIndex = 22;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.HighEmphasis = true;
            this.materialLabel9.Location = new System.Drawing.Point(344, 240);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(545, 14);
            this.materialLabel9.TabIndex = 23;
            this.materialLabel9.Text = "TradeStation API only supports equities at this time. Futures support is on the r" +
    "equested features list.";
            this.materialLabel9.UseAccent = true;
            // 
            // chkUseSimAccount
            // 
            this.chkUseSimAccount.AutoSize = true;
            this.chkUseSimAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkUseSimAccount.Depth = 0;
            this.chkUseSimAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkUseSimAccount.Location = new System.Drawing.Point(12, 228);
            this.chkUseSimAccount.Margin = new System.Windows.Forms.Padding(0);
            this.chkUseSimAccount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkUseSimAccount.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkUseSimAccount.Name = "chkUseSimAccount";
            this.chkUseSimAccount.Ripple = true;
            this.chkUseSimAccount.Size = new System.Drawing.Size(183, 37);
            this.chkUseSimAccount.TabIndex = 23;
            this.chkUseSimAccount.Text = "Use sim account?";
            this.chkUseSimAccount.UseVisualStyleBackColor = false;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.AnimateReadOnly = false;
            this.txtClientSecret.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClientSecret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClientSecret.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClientSecret.Depth = 0;
            this.txtClientSecret.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientSecret.HideSelection = true;
            this.txtClientSecret.LeadingIcon = null;
            this.txtClientSecret.Location = new System.Drawing.Point(24, 163);
            this.txtClientSecret.MaxLength = 32767;
            this.txtClientSecret.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.PasswordChar = '*';
            this.txtClientSecret.PrefixSuffixText = null;
            this.txtClientSecret.ReadOnly = false;
            this.txtClientSecret.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientSecret.SelectedText = "";
            this.txtClientSecret.SelectionLength = 0;
            this.txtClientSecret.SelectionStart = 0;
            this.txtClientSecret.ShortcutsEnabled = true;
            this.txtClientSecret.Size = new System.Drawing.Size(865, 48);
            this.txtClientSecret.TabIndex = 23;
            this.txtClientSecret.TabStop = false;
            this.txtClientSecret.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClientSecret.TrailingIcon = null;
            this.txtClientSecret.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(24, 141);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(89, 19);
            this.materialLabel8.TabIndex = 24;
            this.materialLabel8.Text = "Client Secret";
            // 
            // txtClientId
            // 
            this.txtClientId.AnimateReadOnly = false;
            this.txtClientId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtClientId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtClientId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtClientId.Depth = 0;
            this.txtClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtClientId.HideSelection = true;
            this.txtClientId.LeadingIcon = null;
            this.txtClientId.Location = new System.Drawing.Point(24, 81);
            this.txtClientId.MaxLength = 32767;
            this.txtClientId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.PasswordChar = '*';
            this.txtClientId.PrefixSuffixText = null;
            this.txtClientId.ReadOnly = false;
            this.txtClientId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtClientId.SelectedText = "";
            this.txtClientId.SelectionLength = 0;
            this.txtClientId.SelectionStart = 0;
            this.txtClientId.ShortcutsEnabled = true;
            this.txtClientId.Size = new System.Drawing.Size(865, 48);
            this.txtClientId.TabIndex = 25;
            this.txtClientId.TabStop = false;
            this.txtClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtClientId.TrailingIcon = null;
            this.txtClientId.UseSystemPasswordChar = false;
            // 
            // chkTsEnableEquity
            // 
            this.chkTsEnableEquity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTsEnableEquity.AutoSize = true;
            this.chkTsEnableEquity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkTsEnableEquity.Depth = 0;
            this.chkTsEnableEquity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTsEnableEquity.Location = new System.Drawing.Point(831, 14);
            this.chkTsEnableEquity.Margin = new System.Windows.Forms.Padding(0);
            this.chkTsEnableEquity.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTsEnableEquity.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTsEnableEquity.Name = "chkTsEnableEquity";
            this.chkTsEnableEquity.Ripple = true;
            this.chkTsEnableEquity.Size = new System.Drawing.Size(58, 37);
            this.chkTsEnableEquity.TabIndex = 23;
            this.chkTsEnableEquity.UseVisualStyleBackColor = false;
            this.chkTsEnableEquity.CheckedChanged += new System.EventHandler(this.chkTsEnableEquity_CheckedChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(24, 59);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(60, 19);
            this.materialLabel7.TabIndex = 23;
            this.materialLabel7.Text = "Client ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = global::TdInterface.Properties.Resources.Logo_TS;
            this.pictureBox2.Location = new System.Drawing.Point(0, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(20, 124);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(1, 0);
            this.materialLabel5.TabIndex = 21;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(20, 90);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(660, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "Please choose an account to use with the EZTM tool. You may only have one active " +
    "at a time.";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel6);
            this.materialCard1.Controls.Add(this.chkTdaEnableEquity);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.txtConsumerKey);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(21, 124);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(911, 180);
            this.materialCard1.TabIndex = 18;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.SubtleEmphasis;
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.HighEmphasis = true;
            this.materialLabel6.Location = new System.Drawing.Point(305, 151);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(569, 14);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "TD Ameritrade api only supports trading equities at this time. Their API does NOT" +
    " support futures trading.";
            this.materialLabel6.UseAccent = true;
            // 
            // chkTdaEnableEquity
            // 
            this.chkTdaEnableEquity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkTdaEnableEquity.AutoSize = true;
            this.chkTdaEnableEquity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkTdaEnableEquity.Depth = 0;
            this.chkTdaEnableEquity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTdaEnableEquity.Location = new System.Drawing.Point(831, 14);
            this.chkTdaEnableEquity.Margin = new System.Windows.Forms.Padding(0);
            this.chkTdaEnableEquity.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTdaEnableEquity.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkTdaEnableEquity.Name = "chkTdaEnableEquity";
            this.chkTdaEnableEquity.Ripple = true;
            this.chkTdaEnableEquity.Size = new System.Drawing.Size(58, 37);
            this.chkTdaEnableEquity.TabIndex = 20;
            this.chkTdaEnableEquity.UseVisualStyleBackColor = false;
            this.chkTdaEnableEquity.CheckedChanged += new System.EventHandler(this.chkTdaEnableEquity_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::TdInterface.Properties.Resources.Logo_TDA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(20, 64);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(103, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "Consumer Key";
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.AnimateReadOnly = false;
            this.txtConsumerKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtConsumerKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtConsumerKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtConsumerKey.Depth = 0;
            this.txtConsumerKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConsumerKey.HideSelection = true;
            this.txtConsumerKey.Hint = "Consumer Key";
            this.txtConsumerKey.LeadingIcon = null;
            this.txtConsumerKey.Location = new System.Drawing.Point(20, 86);
            this.txtConsumerKey.MaxLength = 32767;
            this.txtConsumerKey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.PasswordChar = '*';
            this.txtConsumerKey.PrefixSuffixText = null;
            this.txtConsumerKey.ReadOnly = false;
            this.txtConsumerKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtConsumerKey.SelectedText = "";
            this.txtConsumerKey.SelectionLength = 0;
            this.txtConsumerKey.SelectionStart = 0;
            this.txtConsumerKey.ShortcutsEnabled = true;
            this.txtConsumerKey.Size = new System.Drawing.Size(869, 48);
            this.txtConsumerKey.TabIndex = 17;
            this.txtConsumerKey.TabStop = false;
            this.txtConsumerKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConsumerKey.TrailingIcon = null;
            this.txtConsumerKey.UseSystemPasswordChar = false;
            // 
            // lblAccountSettings
            // 
            this.lblAccountSettings.AutoSize = true;
            this.lblAccountSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblAccountSettings.Depth = 0;
            this.lblAccountSettings.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAccountSettings.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblAccountSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccountSettings.Location = new System.Drawing.Point(21, 21);
            this.lblAccountSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAccountSettings.Name = "lblAccountSettings";
            this.lblAccountSettings.Size = new System.Drawing.Size(364, 58);
            this.lblAccountSettings.TabIndex = 13;
            this.lblAccountSettings.Text = "Account Settings";
            // 
            // tpAbout
            // 
            this.tpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tpAbout.Controls.Add(this.btnCheckForUpdates);
            this.tpAbout.Controls.Add(this.materialLabel2);
            this.tpAbout.Controls.Add(this.mbtnGitHub);
            this.tpAbout.Controls.Add(this.materialLabel1);
            this.tpAbout.Controls.Add(this.lblVersion);
            this.tpAbout.Controls.Add(this.pbAppLogo);
            this.tpAbout.Location = new System.Drawing.Point(4, 28);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(946, 836);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            // 
            // btnCheckForUpdates
            // 
            this.btnCheckForUpdates.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckForUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCheckForUpdates.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckForUpdates.Depth = 0;
            this.btnCheckForUpdates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheckForUpdates.HighEmphasis = true;
            this.btnCheckForUpdates.Icon = null;
            this.btnCheckForUpdates.Location = new System.Drawing.Point(394, 313);
            this.btnCheckForUpdates.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckForUpdates.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckForUpdates.Name = "btnCheckForUpdates";
            this.btnCheckForUpdates.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckForUpdates.Size = new System.Drawing.Size(168, 36);
            this.btnCheckForUpdates.TabIndex = 15;
            this.btnCheckForUpdates.Text = "Check For Updates";
            this.btnCheckForUpdates.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckForUpdates.UseAccentColor = false;
            this.btnCheckForUpdates.UseVisualStyleBackColor = false;
            this.btnCheckForUpdates.Click += new System.EventHandler(this.btnCheckForUpdates_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(358, 262);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(231, 45);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Copyright 2022 - 2023, EZTM\r\nAll Rights Reserved.";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mbtnGitHub
            // 
            this.mbtnGitHub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mbtnGitHub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mbtnGitHub.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnGitHub.Depth = 0;
            this.mbtnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mbtnGitHub.HighEmphasis = false;
            this.mbtnGitHub.Icon = global::TdInterface.Properties.Resources.github_24;
            this.mbtnGitHub.Location = new System.Drawing.Point(429, 195);
            this.mbtnGitHub.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnGitHub.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnGitHub.Name = "mbtnGitHub";
            this.mbtnGitHub.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnGitHub.Size = new System.Drawing.Size(88, 36);
            this.mbtnGitHub.TabIndex = 13;
            this.mbtnGitHub.Text = "EZTM";
            this.mbtnGitHub.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.mbtnGitHub.UseAccentColor = false;
            this.mbtnGitHub.UseVisualStyleBackColor = false;
            this.mbtnGitHub.Click += new System.EventHandler(this.mbtnGitHub_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(333, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(280, 41);
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
            this.lblVersion.Location = new System.Drawing.Point(422, 150);
            this.lblVersion.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 19);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Version: #.#.#";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbAppLogo
            // 
            this.pbAppLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pbAppLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbAppLogo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pbAppLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pbAppLogo.Image = global::TdInterface.Properties.Resources.logo_96;
            this.pbAppLogo.Location = new System.Drawing.Point(0, 0);
            this.pbAppLogo.Name = "pbAppLogo";
            this.pbAppLogo.Size = new System.Drawing.Size(946, 96);
            this.pbAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAppLogo.TabIndex = 5;
            this.pbAppLogo.TabStop = false;
            // 
            // MasterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(960, 960);
            this.Controls.Add(this.mtcMasterForm);
            this.DrawerTabControl = this.mtcMasterForm;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(960, 960);
            this.Name = "MasterForm";
            this.Sizable = false;
            this.Text = "EZTM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.mtcMasterForm.ResumeLayout(false);
            this.tpHome.ResumeLayout(false);
            this.tpHome.PerformLayout();
            this.tpAccountSettings.ResumeLayout(false);
            this.tpAccountSettings.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
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
        private System.Windows.Forms.Button btnScreenshots;
        private MaterialSkin.Controls.MaterialTabControl mtcMasterForm;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpAbout;
        private MaterialSkin.Controls.MaterialLabel lblVersion;
        private System.Windows.Forms.PictureBox pbAppLogo;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton mbtnGitHub;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.TabPage tpAccountSettings;
        private MaterialSkin.Controls.MaterialLabel lblAccountSettings;
        private MaterialSkin.Controls.MaterialTextBox2 txtConsumerKey;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSwitch chkTdaEnableEquity;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSwitch chkTsEnableEquity;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientId;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSwitch chkUseSimAccount;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientSecret;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialButton btnClearCreds;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnCheckForUpdates;
    }
}