
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
            this.txtStopToClose = new System.Windows.Forms.TextBox();
            this.txtAveragePrice = new System.Windows.Forms.TextBox();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtAsk = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.cbShares = new System.Windows.Forms.CheckBox();
            this.txtConnectionStatus = new System.Windows.Forms.TextBox();
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
            this.btnExitForm = new System.Windows.Forms.Button();
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
            this.lblStartPosition = new System.Windows.Forms.Label();
            this.roundedPanel8 = new TdInterface.CustomControls.RoundedPanel();
            this.btnBreakEven = new TdInterface.CustomControls.RoundedButton();
            this.btnCancelAll = new TdInterface.CustomControls.RoundedButton();
            this.roundedPanel9 = new TdInterface.CustomControls.RoundedPanel();
            this.rbExitBidAsk = new System.Windows.Forms.RadioButton();
            this.rbExitMarket = new System.Windows.Forms.RadioButton();
            this.btnExitPos100 = new TdInterface.CustomControls.RoundedButton();
            this.btnExitPos50 = new TdInterface.CustomControls.RoundedButton();
            this.btnExitPos33 = new TdInterface.CustomControls.RoundedButton();
            this.btnExitPos25 = new TdInterface.CustomControls.RoundedButton();
            this.lblClosePosition = new System.Windows.Forms.Label();
            this.btnExitPos10 = new TdInterface.CustomControls.RoundedButton();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblHeartbeat = new System.Windows.Forms.Label();
            this.toolTipStatus = new System.Windows.Forms.ToolTip(this.components);
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
            this.roundedPanel9.SuspendLayout();
            this.pnlBottom.SuspendLayout();
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
            this.txtStop.Leave += new System.EventHandler(this.txtWithDecimalValidation_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtStopToClose
            // 
            this.txtStopToClose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStopToClose.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStopToClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtStopToClose.Location = new System.Drawing.Point(176, 13);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.PlaceholderText = "BREAKEVEN";
            this.txtStopToClose.Size = new System.Drawing.Size(155, 27);
            this.txtStopToClose.TabIndex = 6;
            this.txtStopToClose.Leave += new System.EventHandler(this.txtWithDecimalValidation_Leave);
            // 
            // txtAveragePrice
            // 
            this.txtAveragePrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtAveragePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAveragePrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAveragePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtAveragePrice.Location = new System.Drawing.Point(125, 32);
            this.txtAveragePrice.Name = "txtAveragePrice";
            this.txtAveragePrice.PlaceholderText = "-";
            this.txtAveragePrice.ReadOnly = true;
            this.txtAveragePrice.Size = new System.Drawing.Size(85, 27);
            this.txtAveragePrice.TabIndex = 16;
            this.txtAveragePrice.TabStop = false;
            // 
            // txtShares
            // 
            this.txtShares.BackColor = System.Drawing.SystemColors.Window;
            this.txtShares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtShares.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtShares.Location = new System.Drawing.Point(19, 32);
            this.txtShares.Name = "txtShares";
            this.txtShares.PlaceholderText = "-";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(85, 27);
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
            this.txtLimit.Location = new System.Drawing.Point(28, 166);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.PlaceholderText = "LIMIT";
            this.txtLimit.Size = new System.Drawing.Size(96, 27);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.Leave += new System.EventHandler(this.txtWithDecimalValidation_Leave);
            // 
            // cbShares
            // 
            this.cbShares.AutoSize = true;
            this.cbShares.BackColor = System.Drawing.SystemColors.Window;
            this.cbShares.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cbShares.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbShares.Location = new System.Drawing.Point(50, 11);
            this.cbShares.Name = "cbShares";
            this.cbShares.Size = new System.Drawing.Size(68, 19);
            this.cbShares.TabIndex = 5;
            this.cbShares.Text = "SHARES";
            this.cbShares.UseVisualStyleBackColor = false;
            this.cbShares.CheckedChanged += new System.EventHandler(this.cbShares_CheckedChanged);
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtConnectionStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtConnectionStatus.Location = new System.Drawing.Point(6, 6);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.Size = new System.Drawing.Size(300, 19);
            this.txtConnectionStatus.TabIndex = 38;
            this.txtConnectionStatus.TabStop = false;
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLimitOffset.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimitOffset.Location = new System.Drawing.Point(194, 166);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.PlaceholderText = "OFFSET";
            this.txtLimitOffset.Size = new System.Drawing.Size(87, 27);
            this.txtLimitOffset.TabIndex = 3;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtWithDecimalValidation_Leave);
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
            this.txtPnL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPnL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.txtPnL.Location = new System.Drawing.Point(253, 32);
            this.txtPnL.Name = "txtPnL";
            this.txtPnL.PlaceholderText = "-";
            this.txtPnL.ReadOnly = true;
            this.txtPnL.Size = new System.Drawing.Size(85, 27);
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
            this.chkDisableFirstTarget.BackColor = System.Drawing.SystemColors.Window;
            this.chkDisableFirstTarget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkDisableFirstTarget.ForeColor = System.Drawing.SystemColors.GrayText;
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(199, 14);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(134, 19);
            this.chkDisableFirstTarget.TabIndex = 7;
            this.chkDisableFirstTarget.Text = "DISABLE 1ST TARGET";
            this.chkDisableFirstTarget.UseVisualStyleBackColor = false;
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
            this.roundedPanel3.Controls.Add(this.cbShares);
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
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTop.Controls.Add(this.btnExitForm);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(369, 30);
            this.pnlTop.TabIndex = 44;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnExitForm
            // 
            this.btnExitForm.AutoSize = true;
            this.btnExitForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitForm.FlatAppearance.BorderSize = 0;
            this.btnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitForm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExitForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnExitForm.Location = new System.Drawing.Point(331, 0);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(38, 30);
            this.btnExitForm.TabIndex = 46;
            this.btnExitForm.Text = "✖️";
            this.btnExitForm.UseVisualStyleBackColor = true;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.Controls.Add(this.lblPnL);
            this.roundedPanel4.Controls.Add(this.lblShares);
            this.roundedPanel4.Controls.Add(this.lblAvgPrice);
            this.roundedPanel4.Controls.Add(this.txtShares);
            this.roundedPanel4.Controls.Add(this.txtAveragePrice);
            this.roundedPanel4.Controls.Add(this.txtPnL);
            this.roundedPanel4.Location = new System.Drawing.Point(12, 403);
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
            this.roundedPanel5.Location = new System.Drawing.Point(12, 477);
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
            this.roundedPanel6.Location = new System.Drawing.Point(188, 477);
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
            this.btnBuyMrkTriggerOco.Size = new System.Drawing.Size(155, 36);
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
            this.btnSellMrkTriggerOco.Size = new System.Drawing.Size(155, 36);
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
            this.btnBuyLmtTriggerOco.Location = new System.Drawing.Point(12, 94);
            this.btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            this.btnBuyLmtTriggerOco.Size = new System.Drawing.Size(155, 36);
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
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(178, 94);
            this.btnSellLmtTriggerOco.Name = "btnSellLmtTriggerOco";
            this.btnSellLmtTriggerOco.Size = new System.Drawing.Size(155, 36);
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
            this.roundedPanel7.Controls.Add(this.lblStartPosition);
            this.roundedPanel7.Controls.Add(this.btnSellLmtTriggerOco);
            this.roundedPanel7.Controls.Add(this.btnBuyMrkTriggerOco);
            this.roundedPanel7.Controls.Add(this.btnBuyLmtTriggerOco);
            this.roundedPanel7.Controls.Add(this.btnSellMrkTriggerOco);
            this.roundedPanel7.Controls.Add(this.txtLimit);
            this.roundedPanel7.Controls.Add(this.txtLimitOffset);
            this.roundedPanel7.Controls.Add(this.chkDisableFirstTarget);
            this.roundedPanel7.Location = new System.Drawing.Point(12, 185);
            this.roundedPanel7.Name = "roundedPanel7";
            this.roundedPanel7.Size = new System.Drawing.Size(346, 212);
            this.roundedPanel7.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(178, 166);
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
            this.lblLimitOffset.Location = new System.Drawing.Point(178, 151);
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
            this.label3.Location = new System.Drawing.Point(12, 166);
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
            this.lblLimit.Location = new System.Drawing.Point(12, 151);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(39, 15);
            this.lblLimit.TabIndex = 49;
            this.lblLimit.Text = "LIMIT";
            this.lblLimit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStartPosition
            // 
            this.lblStartPosition.AutoSize = true;
            this.lblStartPosition.BackColor = System.Drawing.SystemColors.Window;
            this.lblStartPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblStartPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.lblStartPosition.Location = new System.Drawing.Point(12, 12);
            this.lblStartPosition.Name = "lblStartPosition";
            this.lblStartPosition.Size = new System.Drawing.Size(134, 21);
            this.lblStartPosition.TabIndex = 53;
            this.lblStartPosition.Text = "START POSITION";
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.Controls.Add(this.btnBreakEven);
            this.roundedPanel8.Controls.Add(this.txtStopToClose);
            this.roundedPanel8.Location = new System.Drawing.Point(12, 551);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(346, 60);
            this.roundedPanel8.TabIndex = 53;
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
            this.btnBreakEven.Size = new System.Drawing.Size(155, 36);
            this.btnBreakEven.TabIndex = 56;
            this.btnBreakEven.Text = "MOVE STOP TO";
            this.btnBreakEven.UseVisualStyleBackColor = false;
            this.btnBreakEven.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnBreakEven.Click += new System.EventHandler(this.btnBreakEven_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btnCancelAll.FlatAppearance.BorderSize = 0;
            this.btnCancelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAll.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCancelAll.Location = new System.Drawing.Point(12, 715);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(346, 36);
            this.btnCancelAll.TabIndex = 57;
            this.btnCancelAll.Text = "CANCEL ALL ORDERS";
            this.btnCancelAll.UseVisualStyleBackColor = false;
            this.btnCancelAll.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
            // 
            // roundedPanel9
            // 
            this.roundedPanel9.Controls.Add(this.rbExitBidAsk);
            this.roundedPanel9.Controls.Add(this.rbExitMarket);
            this.roundedPanel9.Controls.Add(this.btnExitPos100);
            this.roundedPanel9.Controls.Add(this.btnExitPos50);
            this.roundedPanel9.Controls.Add(this.btnExitPos33);
            this.roundedPanel9.Controls.Add(this.btnExitPos25);
            this.roundedPanel9.Controls.Add(this.lblClosePosition);
            this.roundedPanel9.Controls.Add(this.btnExitPos10);
            this.roundedPanel9.Location = new System.Drawing.Point(12, 617);
            this.roundedPanel9.Name = "roundedPanel9";
            this.roundedPanel9.Padding = new System.Windows.Forms.Padding(12);
            this.roundedPanel9.Size = new System.Drawing.Size(346, 92);
            this.roundedPanel9.TabIndex = 58;
            // 
            // rbExitBidAsk
            // 
            this.rbExitBidAsk.AutoSize = true;
            this.rbExitBidAsk.BackColor = System.Drawing.SystemColors.Window;
            this.rbExitBidAsk.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbExitBidAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.rbExitBidAsk.Location = new System.Drawing.Point(243, 11);
            this.rbExitBidAsk.Name = "rbExitBidAsk";
            this.rbExitBidAsk.Size = new System.Drawing.Size(84, 24);
            this.rbExitBidAsk.TabIndex = 64;
            this.rbExitBidAsk.Text = "BID/ASK";
            this.rbExitBidAsk.UseVisualStyleBackColor = false;
            // 
            // rbExitMarket
            // 
            this.rbExitMarket.AutoSize = true;
            this.rbExitMarket.BackColor = System.Drawing.SystemColors.Window;
            this.rbExitMarket.Checked = true;
            this.rbExitMarket.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbExitMarket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.rbExitMarket.Location = new System.Drawing.Point(152, 11);
            this.rbExitMarket.Name = "rbExitMarket";
            this.rbExitMarket.Size = new System.Drawing.Size(85, 24);
            this.rbExitMarket.TabIndex = 59;
            this.rbExitMarket.TabStop = true;
            this.rbExitMarket.Text = "MARKET";
            this.rbExitMarket.UseVisualStyleBackColor = false;
            // 
            // btnExitPos100
            // 
            this.btnExitPos100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnExitPos100.FlatAppearance.BorderSize = 0;
            this.btnExitPos100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPos100.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitPos100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExitPos100.Location = new System.Drawing.Point(275, 40);
            this.btnExitPos100.Name = "btnExitPos100";
            this.btnExitPos100.Size = new System.Drawing.Size(58, 36);
            this.btnExitPos100.TabIndex = 63;
            this.btnExitPos100.Tag = "1";
            this.btnExitPos100.Text = "100%";
            this.btnExitPos100.UseVisualStyleBackColor = false;
            this.btnExitPos100.Click += new System.EventHandler(this.btnExitPosition_Click);
            // 
            // btnExitPos50
            // 
            this.btnExitPos50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnExitPos50.FlatAppearance.BorderSize = 0;
            this.btnExitPos50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPos50.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitPos50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExitPos50.Location = new System.Drawing.Point(209, 40);
            this.btnExitPos50.Name = "btnExitPos50";
            this.btnExitPos50.Size = new System.Drawing.Size(58, 36);
            this.btnExitPos50.TabIndex = 62;
            this.btnExitPos50.Tag = ".5";
            this.btnExitPos50.Text = "50%";
            this.btnExitPos50.UseVisualStyleBackColor = false;
            this.btnExitPos50.Click += new System.EventHandler(this.btnExitPosition_Click);
            // 
            // btnExitPos33
            // 
            this.btnExitPos33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnExitPos33.FlatAppearance.BorderSize = 0;
            this.btnExitPos33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPos33.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitPos33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExitPos33.Location = new System.Drawing.Point(143, 40);
            this.btnExitPos33.Name = "btnExitPos33";
            this.btnExitPos33.Size = new System.Drawing.Size(58, 36);
            this.btnExitPos33.TabIndex = 61;
            this.btnExitPos33.Tag = ".33";
            this.btnExitPos33.Text = "33%";
            this.btnExitPos33.UseVisualStyleBackColor = false;
            this.btnExitPos33.Click += new System.EventHandler(this.btnExitPosition_Click);
            // 
            // btnExitPos25
            // 
            this.btnExitPos25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnExitPos25.FlatAppearance.BorderSize = 0;
            this.btnExitPos25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPos25.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitPos25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExitPos25.Location = new System.Drawing.Point(77, 40);
            this.btnExitPos25.Name = "btnExitPos25";
            this.btnExitPos25.Size = new System.Drawing.Size(58, 36);
            this.btnExitPos25.TabIndex = 60;
            this.btnExitPos25.Tag = ".25";
            this.btnExitPos25.Text = "25%";
            this.btnExitPos25.UseVisualStyleBackColor = false;
            this.btnExitPos25.Click += new System.EventHandler(this.btnExitPosition_Click);
            // 
            // lblClosePosition
            // 
            this.lblClosePosition.AutoSize = true;
            this.lblClosePosition.BackColor = System.Drawing.SystemColors.Window;
            this.lblClosePosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClosePosition.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblClosePosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(49)))), ((int)(((byte)(75)))));
            this.lblClosePosition.Location = new System.Drawing.Point(12, 12);
            this.lblClosePosition.Name = "lblClosePosition";
            this.lblClosePosition.Size = new System.Drawing.Size(134, 21);
            this.lblClosePosition.TabIndex = 56;
            this.lblClosePosition.Text = "CLOSE POSITION";
            // 
            // btnExitPos10
            // 
            this.btnExitPos10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.btnExitPos10.FlatAppearance.BorderSize = 0;
            this.btnExitPos10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitPos10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitPos10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.btnExitPos10.Location = new System.Drawing.Point(11, 40);
            this.btnExitPos10.Name = "btnExitPos10";
            this.btnExitPos10.Size = new System.Drawing.Size(58, 36);
            this.btnExitPos10.TabIndex = 56;
            this.btnExitPos10.Tag = ".1";
            this.btnExitPos10.Text = "10%";
            this.btnExitPos10.UseVisualStyleBackColor = false;
            this.btnExitPos10.Click += new System.EventHandler(this.btnExitPosition_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBottom.Controls.Add(this.lblLastError);
            this.pnlBottom.Controls.Add(this.lblHeartbeat);
            this.pnlBottom.Controls.Add(this.txtConnectionStatus);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 759);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(369, 30);
            this.pnlBottom.TabIndex = 47;
            // 
            // lblLastError
            // 
            this.lblLastError.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastError.Location = new System.Drawing.Point(313, 0);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(28, 30);
            this.lblLastError.TabIndex = 60;
            this.lblLastError.Text = "📄";
            this.lblLastError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLastError.DoubleClick += new System.EventHandler(this.lblLastError_DoubleClick);
            // 
            // lblHeartbeat
            // 
            this.lblHeartbeat.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHeartbeat.Location = new System.Drawing.Point(341, 0);
            this.lblHeartbeat.Name = "lblHeartbeat";
            this.lblHeartbeat.Size = new System.Drawing.Size(28, 30);
            this.lblHeartbeat.TabIndex = 59;
            this.lblHeartbeat.Text = "💓";
            this.lblHeartbeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeartbeat.MouseHover += new System.EventHandler(this.lblHeartbeat_MouseHover);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(369, 789);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.roundedPanel9);
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
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 535);
            this.Name = "MainForm";
            this.Text = "JrHurley\'s TDInterface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
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
            this.roundedPanel9.ResumeLayout(false);
            this.roundedPanel9.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblRisk;
        private System.Windows.Forms.TextBox txtRisk;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAveragePrice;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.TextBox txtAsk;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.CheckBox cbShares;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.TextBox txtStopToClose;
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
        private System.Windows.Forms.Button btnExitForm;
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
        private System.Windows.Forms.Label lblStartPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLimitOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLimit;
        private CustomControls.RoundedPanel roundedPanel8;
        private CustomControls.RoundedButton btnBreakEven;
        private CustomControls.RoundedButton btnCancelAll;
        private CustomControls.RoundedPanel roundedPanel9;
        private CustomControls.RoundedButton btnExitPos10;
        private System.Windows.Forms.Label lblClosePosition;
        private CustomControls.RoundedButton btnExitPos100;
        private CustomControls.RoundedButton btnExitPos50;
        private CustomControls.RoundedButton btnExitPos33;
        private CustomControls.RoundedButton btnExitPos25;
        private System.Windows.Forms.RadioButton rbExitBidAsk;
        private System.Windows.Forms.RadioButton rbExitMarket;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblHeartbeat;
        private System.Windows.Forms.ToolTip toolTipStatus;
        private System.Windows.Forms.Label lblLastError;
    }
}

