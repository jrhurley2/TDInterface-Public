
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
            this.txtLastError = new System.Windows.Forms.TextBox();
            this.btnSellLmtTriggerOco = new System.Windows.Forms.Button();
            this.btnBuyLmtTriggerOco = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.txtStopToClose = new System.Windows.Forms.TextBox();
            this.btnBreakEven = new System.Windows.Forms.Button();
            this.txtAveragePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShares = new System.Windows.Forms.TextBox();
            this.lblShares = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAsk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.chkTradeShares = new System.Windows.Forms.CheckBox();
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
            this.rbExitMarket = new System.Windows.Forms.RadioButton();
            this.rbExitBidAsk = new System.Windows.Forms.RadioButton();
            this.btnExit33 = new System.Windows.Forms.Button();
            this.btnExit50 = new System.Windows.Forms.Button();
            this.btnExit25 = new System.Windows.Forms.Button();
            this.btnExit100 = new System.Windows.Forms.Button();
            this.btnExit10 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblLastPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblSymbol = new MaterialSkin.Controls.MaterialLabel();
            this.lblDescription = new MaterialSkin.Controls.MaterialLabel();
            this.rpbTickerLogo = new TdInterface.CustomControls.RoundedPictureBox();
            this.txtSymbol = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtStop = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRisk = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnBuyMrkTriggerOco = new MaterialSkin.Controls.MaterialButton();
            this.btnSellMrkTriggerOco = new MaterialSkin.Controls.MaterialButton();
            this.txtMoveStop = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLastError
            // 
            this.txtLastError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtLastError.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLastError.Location = new System.Drawing.Point(810, 292);
            this.txtLastError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastError.Multiline = true;
            this.txtLastError.Name = "txtLastError";
            this.txtLastError.ReadOnly = true;
            this.txtLastError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLastError.Size = new System.Drawing.Size(291, 108);
            this.txtLastError.TabIndex = 34;
            this.txtLastError.TabStop = false;
            this.txtLastError.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtLastError_MouseDoubleClick);
            // 
            // btnSellLmtTriggerOco
            // 
            this.btnSellLmtTriggerOco.AutoSize = true;
            this.btnSellLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSellLmtTriggerOco.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSellLmtTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSellLmtTriggerOco.Location = new System.Drawing.Point(201, 278);
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
            this.btnBuyLmtTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuyLmtTriggerOco.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBuyLmtTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuyLmtTriggerOco.Location = new System.Drawing.Point(17, 277);
            this.btnBuyLmtTriggerOco.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuyLmtTriggerOco.Name = "btnBuyLmtTriggerOco";
            this.btnBuyLmtTriggerOco.Size = new System.Drawing.Size(170, 52);
            this.btnBuyLmtTriggerOco.TabIndex = 1;
            this.btnBuyLmtTriggerOco.TabStop = false;
            this.btnBuyLmtTriggerOco.Text = "Buy Limit";
            this.btnBuyLmtTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyLmtTriggerOco.Click += new System.EventHandler(this.btnBuyLmtTriggerOco_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCancelAll.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancelAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelAll.Location = new System.Drawing.Point(88, 727);
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
            this.txtStopToClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtStopToClose.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStopToClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtStopToClose.Location = new System.Drawing.Point(206, 547);
            this.txtStopToClose.Name = "txtStopToClose";
            this.txtStopToClose.Size = new System.Drawing.Size(172, 24);
            this.txtStopToClose.TabIndex = 6;
            this.txtStopToClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStopToClose.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // btnBreakEven
            // 
            this.btnBreakEven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBreakEven.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnBreakEven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBreakEven.Location = new System.Drawing.Point(26, 513);
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
            this.txtAveragePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtAveragePrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAveragePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAveragePrice.Location = new System.Drawing.Point(29, 366);
            this.txtAveragePrice.Name = "txtAveragePrice";
            this.txtAveragePrice.ReadOnly = true;
            this.txtAveragePrice.Size = new System.Drawing.Size(104, 24);
            this.txtAveragePrice.TabIndex = 16;
            this.txtAveragePrice.TabStop = false;
            this.txtAveragePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(29, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Avg Price";
            // 
            // txtShares
            // 
            this.txtShares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtShares.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtShares.Location = new System.Drawing.Point(139, 366);
            this.txtShares.Name = "txtShares";
            this.txtShares.ReadOnly = true;
            this.txtShares.Size = new System.Drawing.Size(87, 24);
            this.txtShares.TabIndex = 18;
            this.txtShares.TabStop = false;
            this.txtShares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtShares.TextChanged += new System.EventHandler(this.txtShares_TextChanged);
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblShares.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblShares.Location = new System.Drawing.Point(144, 345);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(51, 17);
            this.lblShares.TabIndex = 17;
            this.lblShares.Text = "Shares";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(475, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bid";
            // 
            // txtBid
            // 
            this.txtBid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBid.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBid.Location = new System.Drawing.Point(475, 403);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.ReadOnly = true;
            this.txtBid.Size = new System.Drawing.Size(87, 24);
            this.txtBid.TabIndex = 12;
            this.txtBid.TabStop = false;
            this.txtBid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(568, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ask";
            // 
            // txtAsk
            // 
            this.txtAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtAsk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtAsk.Location = new System.Drawing.Point(568, 403);
            this.txtAsk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.ReadOnly = true;
            this.txtAsk.Size = new System.Drawing.Size(87, 24);
            this.txtAsk.TabIndex = 14;
            this.txtAsk.TabStop = false;
            this.txtAsk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(380, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Limit";
            // 
            // txtLimit
            // 
            this.txtLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtLimit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLimit.Location = new System.Drawing.Point(380, 467);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(89, 24);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLimit.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // chkTradeShares
            // 
            this.chkTradeShares.AutoSize = true;
            this.chkTradeShares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkTradeShares.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkTradeShares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkTradeShares.Location = new System.Drawing.Point(410, 201);
            this.chkTradeShares.Name = "chkTradeShares";
            this.chkTradeShares.Size = new System.Drawing.Size(70, 21);
            this.chkTradeShares.TabIndex = 5;
            this.chkTradeShares.Text = "Shares";
            this.chkTradeShares.UseVisualStyleBackColor = false;
            this.chkTradeShares.CheckedChanged += new System.EventHandler(this.chkTradeShares_CheckedChanged);
            // 
            // txtHeartBeat
            // 
            this.txtHeartBeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtHeartBeat.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtHeartBeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtHeartBeat.Location = new System.Drawing.Point(673, 866);
            this.txtHeartBeat.Name = "txtHeartBeat";
            this.txtHeartBeat.ReadOnly = true;
            this.txtHeartBeat.Size = new System.Drawing.Size(285, 24);
            this.txtHeartBeat.TabIndex = 36;
            this.txtHeartBeat.TabStop = false;
            this.txtHeartBeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(673, 846);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "HeartBeat";
            // 
            // txtConnectionStatus
            // 
            this.txtConnectionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtConnectionStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtConnectionStatus.Location = new System.Drawing.Point(297, 866);
            this.txtConnectionStatus.Name = "txtConnectionStatus";
            this.txtConnectionStatus.ReadOnly = true;
            this.txtConnectionStatus.Size = new System.Drawing.Size(318, 24);
            this.txtConnectionStatus.TabIndex = 38;
            this.txtConnectionStatus.TabStop = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblConnectionStatus.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConnectionStatus.Location = new System.Drawing.Point(297, 846);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(123, 17);
            this.lblConnectionStatus.TabIndex = 37;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // txtLimitOffset
            // 
            this.txtLimitOffset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtLimitOffset.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLimitOffset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtLimitOffset.Location = new System.Drawing.Point(475, 467);
            this.txtLimitOffset.Name = "txtLimitOffset";
            this.txtLimitOffset.Size = new System.Drawing.Size(87, 24);
            this.txtLimitOffset.TabIndex = 3;
            this.txtLimitOffset.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(238, 405);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "R";
            // 
            // txtRValue
            // 
            this.txtRValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRValue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRValue.Location = new System.Drawing.Point(238, 425);
            this.txtRValue.Name = "txtRValue";
            this.txtRValue.ReadOnly = true;
            this.txtRValue.Size = new System.Drawing.Size(87, 24);
            this.txtRValue.TabIndex = 28;
            this.txtRValue.TabStop = false;
            this.txtRValue.TextChanged += new System.EventHandler(this.txtRValue_TextChanged);
            // 
            // txtPnL
            // 
            this.txtPnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtPnL.Enabled = false;
            this.txtPnL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPnL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPnL.Location = new System.Drawing.Point(233, 365);
            this.txtPnL.Name = "txtPnL";
            this.txtPnL.ReadOnly = true;
            this.txtPnL.Size = new System.Drawing.Size(87, 24);
            this.txtPnL.TabIndex = 20;
            this.txtPnL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPnL
            // 
            this.lblPnL.AutoSize = true;
            this.lblPnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblPnL.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPnL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPnL.Location = new System.Drawing.Point(233, 345);
            this.lblPnL.Name = "lblPnL";
            this.lblPnL.Size = new System.Drawing.Size(33, 17);
            this.lblPnL.TabIndex = 19;
            this.lblPnL.Text = "PnL";
            // 
            // timerGetSecuritiesAccount
            // 
            this.timerGetSecuritiesAccount.Enabled = true;
            this.timerGetSecuritiesAccount.Interval = 20000;
            this.timerGetSecuritiesAccount.Tick += new System.EventHandler(this.timerGetSecuritiesAccount_Tick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(50, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "1:1";
            // 
            // txtOneToOne
            // 
            this.txtOneToOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtOneToOne.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOneToOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtOneToOne.Location = new System.Drawing.Point(34, 425);
            this.txtOneToOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOneToOne.Name = "txtOneToOne";
            this.txtOneToOne.ReadOnly = true;
            this.txtOneToOne.Size = new System.Drawing.Size(197, 24);
            this.txtOneToOne.TabIndex = 26;
            this.txtOneToOne.TabStop = false;
            // 
            // chkDisableFirstTarget
            // 
            this.chkDisableFirstTarget.AutoSize = true;
            this.chkDisableFirstTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.chkDisableFirstTarget.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.chkDisableFirstTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(394, 246);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(146, 21);
            this.chkDisableFirstTarget.TabIndex = 7;
            this.chkDisableFirstTarget.Text = "Disable First Target";
            this.chkDisableFirstTarget.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(475, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Limit Offset";
            // 
            // rbExitMarket
            // 
            this.rbExitMarket.AutoSize = true;
            this.rbExitMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbExitMarket.Checked = true;
            this.rbExitMarket.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rbExitMarket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbExitMarket.Location = new System.Drawing.Point(114, 23);
            this.rbExitMarket.Name = "rbExitMarket";
            this.rbExitMarket.Size = new System.Drawing.Size(81, 21);
            this.rbExitMarket.TabIndex = 39;
            this.rbExitMarket.TabStop = true;
            this.rbExitMarket.Text = "MARKET";
            this.rbExitMarket.UseVisualStyleBackColor = false;
            // 
            // rbExitBidAsk
            // 
            this.rbExitBidAsk.AutoSize = true;
            this.rbExitBidAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.rbExitBidAsk.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rbExitBidAsk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbExitBidAsk.Location = new System.Drawing.Point(199, 23);
            this.rbExitBidAsk.Name = "rbExitBidAsk";
            this.rbExitBidAsk.Size = new System.Drawing.Size(86, 21);
            this.rbExitBidAsk.TabIndex = 40;
            this.rbExitBidAsk.Text = "BID / ASK";
            this.rbExitBidAsk.UseVisualStyleBackColor = false;
            // 
            // btnExit33
            // 
            this.btnExit33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExit33.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit33.Location = new System.Drawing.Point(120, 85);
            this.btnExit33.Name = "btnExit33";
            this.btnExit33.Size = new System.Drawing.Size(46, 39);
            this.btnExit33.TabIndex = 2;
            this.btnExit33.TabStop = false;
            this.btnExit33.Tag = ".33";
            this.btnExit33.Text = "33%";
            this.btnExit33.UseVisualStyleBackColor = false;
            this.btnExit33.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit50
            // 
            this.btnExit50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExit50.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit50.Location = new System.Drawing.Point(172, 85);
            this.btnExit50.Name = "btnExit50";
            this.btnExit50.Size = new System.Drawing.Size(46, 39);
            this.btnExit50.TabIndex = 3;
            this.btnExit50.TabStop = false;
            this.btnExit50.Tag = ".5";
            this.btnExit50.Text = "50%";
            this.btnExit50.UseVisualStyleBackColor = false;
            this.btnExit50.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit25
            // 
            this.btnExit25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExit25.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit25.Location = new System.Drawing.Point(68, 85);
            this.btnExit25.Name = "btnExit25";
            this.btnExit25.Size = new System.Drawing.Size(46, 39);
            this.btnExit25.TabIndex = 1;
            this.btnExit25.TabStop = false;
            this.btnExit25.Tag = ".25";
            this.btnExit25.Text = "25%";
            this.btnExit25.UseVisualStyleBackColor = false;
            this.btnExit25.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit100
            // 
            this.btnExit100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExit100.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit100.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit100.Location = new System.Drawing.Point(224, 85);
            this.btnExit100.Name = "btnExit100";
            this.btnExit100.Size = new System.Drawing.Size(52, 39);
            this.btnExit100.TabIndex = 4;
            this.btnExit100.TabStop = false;
            this.btnExit100.Tag = "1";
            this.btnExit100.Text = "100%";
            this.btnExit100.UseVisualStyleBackColor = false;
            this.btnExit100.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // btnExit10
            // 
            this.btnExit10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnExit10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnExit10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit10.Location = new System.Drawing.Point(16, 85);
            this.btnExit10.Name = "btnExit10";
            this.btnExit10.Size = new System.Drawing.Size(46, 39);
            this.btnExit10.TabIndex = 0;
            this.btnExit10.TabStop = false;
            this.btnExit10.Tag = ".1";
            this.btnExit10.Text = "10%";
            this.btnExit10.UseVisualStyleBackColor = false;
            this.btnExit10.Click += new System.EventHandler(this.btnExitPercentage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.rbExitBidAsk);
            this.groupBox2.Controls.Add(this.btnExit10);
            this.groupBox2.Controls.Add(this.rbExitMarket);
            this.groupBox2.Controls.Add(this.btnExit100);
            this.groupBox2.Controls.Add(this.btnExit50);
            this.groupBox2.Controls.Add(this.btnExit25);
            this.groupBox2.Controls.Add(this.btnExit33);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(34, 577);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 144);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Close";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblVersion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVersion.Location = new System.Drawing.Point(988, 788);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(55, 17);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblLastPrice);
            this.materialCard1.Controls.Add(this.lblSymbol);
            this.materialCard1.Controls.Add(this.lblDescription);
            this.materialCard1.Controls.Add(this.rpbTickerLogo);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 38);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(354, 75);
            this.materialCard1.TabIndex = 41;
            // 
            // lblLastPrice
            // 
            this.lblLastPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblLastPrice.Depth = 0;
            this.lblLastPrice.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblLastPrice.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblLastPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastPrice.Location = new System.Drawing.Point(237, 13);
            this.lblLastPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLastPrice.Name = "lblLastPrice";
            this.lblLastPrice.Size = new System.Drawing.Size(100, 23);
            this.lblLastPrice.TabIndex = 42;
            this.lblLastPrice.Text = "$$$$";
            this.lblLastPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblSymbol.Depth = 0;
            this.lblSymbol.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblSymbol.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSymbol.Location = new System.Drawing.Point(68, 12);
            this.lblSymbol.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(67, 24);
            this.lblSymbol.TabIndex = 42;
            this.lblSymbol.Text = "Symbol";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDescription.Depth = 0;
            this.lblDescription.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDescription.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.Location = new System.Drawing.Point(68, 43);
            this.lblDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(269, 18);
            this.lblDescription.TabIndex = 42;
            this.lblDescription.Text = "Description";
            // 
            // rpbTickerLogo
            // 
            this.rpbTickerLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rpbTickerLogo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.rpbTickerLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rpbTickerLogo.Image = global::TdInterface.Properties.Resources.abc_24;
            this.rpbTickerLogo.Location = new System.Drawing.Point(12, 13);
            this.rpbTickerLogo.Name = "rpbTickerLogo";
            this.rpbTickerLogo.Size = new System.Drawing.Size(48, 48);
            this.rpbTickerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rpbTickerLogo.TabIndex = 42;
            this.rpbTickerLogo.TabStop = false;
            this.rpbTickerLogo.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.rpbTickerLogo_LoadCompleted);
            // 
            // txtSymbol
            // 
            this.txtSymbol.AnimateReadOnly = false;
            this.txtSymbol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtSymbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSymbol.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSymbol.Depth = 0;
            this.txtSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSymbol.HideSelection = true;
            this.txtSymbol.Hint = "Symbol";
            this.txtSymbol.LeadingIcon = null;
            this.txtSymbol.LeaveOnEnterKey = true;
            this.txtSymbol.Location = new System.Drawing.Point(17, 120);
            this.txtSymbol.MaxLength = 32767;
            this.txtSymbol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.PasswordChar = '\0';
            this.txtSymbol.PrefixSuffixText = null;
            this.txtSymbol.ReadOnly = false;
            this.txtSymbol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSymbol.SelectedText = "";
            this.txtSymbol.SelectionLength = 0;
            this.txtSymbol.SelectionStart = 0;
            this.txtSymbol.ShortcutsEnabled = true;
            this.txtSymbol.Size = new System.Drawing.Size(354, 48);
            this.txtSymbol.TabIndex = 0;
            this.txtSymbol.TabStop = false;
            this.txtSymbol.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSymbol.TrailingIcon = null;
            this.txtSymbol.UseAccent = false;
            this.txtSymbol.UseSystemPasswordChar = false;
            this.txtSymbol.Enter += new System.EventHandler(this.txtSymbol_Enter);
            this.txtSymbol.Leave += new System.EventHandler(this.txtSymbol_Leave);
            this.txtSymbol.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txtSymbol_Enter);
            // 
            // txtStop
            // 
            this.txtStop.AnimateReadOnly = false;
            this.txtStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtStop.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtStop.Depth = 0;
            this.txtStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtStop.HideSelection = true;
            this.txtStop.Hint = "Stop";
            this.txtStop.LeadingIcon = null;
            this.txtStop.Location = new System.Drawing.Point(17, 174);
            this.txtStop.MaxLength = 32767;
            this.txtStop.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStop.Name = "txtStop";
            this.txtStop.PasswordChar = '\0';
            this.txtStop.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtStop.PrefixSuffixText = "$";
            this.txtStop.ReadOnly = false;
            this.txtStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStop.SelectedText = "";
            this.txtStop.SelectionLength = 0;
            this.txtStop.SelectionStart = 0;
            this.txtStop.ShortcutsEnabled = true;
            this.txtStop.Size = new System.Drawing.Size(172, 48);
            this.txtStop.TabIndex = 1;
            this.txtStop.TabStop = false;
            this.txtStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStop.TrailingIcon = null;
            this.txtStop.UseAccent = false;
            this.txtStop.UseSystemPasswordChar = false;
            this.txtStop.Leave += new System.EventHandler(this.txtWithValidation_Leave);
            // 
            // txtRisk
            // 
            this.txtRisk.AnimateReadOnly = false;
            this.txtRisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtRisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRisk.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRisk.Depth = 0;
            this.txtRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRisk.HideSelection = true;
            this.txtRisk.Hint = "Risk";
            this.txtRisk.LeadingIcon = null;
            this.txtRisk.Location = new System.Drawing.Point(199, 174);
            this.txtRisk.MaxLength = 32767;
            this.txtRisk.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.PasswordChar = '\0';
            this.txtRisk.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.txtRisk.PrefixSuffixText = "$";
            this.txtRisk.ReadOnly = false;
            this.txtRisk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRisk.SelectedText = "";
            this.txtRisk.SelectionLength = 0;
            this.txtRisk.SelectionStart = 0;
            this.txtRisk.ShortcutsEnabled = true;
            this.txtRisk.Size = new System.Drawing.Size(172, 48);
            this.txtRisk.TabIndex = 5;
            this.txtRisk.TabStop = false;
            this.txtRisk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRisk.TrailingIcon = null;
            this.txtRisk.UseAccent = false;
            this.txtRisk.UseSystemPasswordChar = false;
            // 
            // btnBuyMrkTriggerOco
            // 
            this.btnBuyMrkTriggerOco.AutoSize = false;
            this.btnBuyMrkTriggerOco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuyMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnBuyMrkTriggerOco.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuyMrkTriggerOco.Depth = 0;
            this.btnBuyMrkTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnBuyMrkTriggerOco.HighEmphasis = true;
            this.btnBuyMrkTriggerOco.Icon = null;
            this.btnBuyMrkTriggerOco.Location = new System.Drawing.Point(17, 231);
            this.btnBuyMrkTriggerOco.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuyMrkTriggerOco.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuyMrkTriggerOco.Name = "btnBuyMrkTriggerOco";
            this.btnBuyMrkTriggerOco.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuyMrkTriggerOco.Size = new System.Drawing.Size(172, 36);
            this.btnBuyMrkTriggerOco.TabIndex = 42;
            this.btnBuyMrkTriggerOco.Text = "Buy Market";
            this.btnBuyMrkTriggerOco.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuyMrkTriggerOco.UseAccentColor = false;
            this.btnBuyMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnBuyMrkTriggerOco.Click += new System.EventHandler(this.btnBuyMrkTriggerOco_Click);
            // 
            // btnSellMrkTriggerOco
            // 
            this.btnSellMrkTriggerOco.AutoSize = false;
            this.btnSellMrkTriggerOco.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSellMrkTriggerOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSellMrkTriggerOco.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSellMrkTriggerOco.Depth = 0;
            this.btnSellMrkTriggerOco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSellMrkTriggerOco.HighEmphasis = true;
            this.btnSellMrkTriggerOco.Icon = null;
            this.btnSellMrkTriggerOco.Location = new System.Drawing.Point(199, 231);
            this.btnSellMrkTriggerOco.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSellMrkTriggerOco.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSellMrkTriggerOco.Name = "btnSellMrkTriggerOco";
            this.btnSellMrkTriggerOco.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSellMrkTriggerOco.Size = new System.Drawing.Size(172, 36);
            this.btnSellMrkTriggerOco.TabIndex = 43;
            this.btnSellMrkTriggerOco.Text = "Sell Market";
            this.btnSellMrkTriggerOco.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSellMrkTriggerOco.UseAccentColor = true;
            this.btnSellMrkTriggerOco.UseVisualStyleBackColor = false;
            this.btnSellMrkTriggerOco.Click += new System.EventHandler(this.btnSellMrkTriggerOco_Click);
            // 
            // txtMoveStop
            // 
            this.txtMoveStop.AutoSize = true;
            this.txtMoveStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtMoveStop.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMoveStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtMoveStop.Location = new System.Drawing.Point(206, 513);
            this.txtMoveStop.Name = "txtMoveStop";
            this.txtMoveStop.Size = new System.Drawing.Size(92, 17);
            this.txtMoveStop.TabIndex = 32;
            this.txtMoveStop.Text = "Move Stop To";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.ClientSize = new System.Drawing.Size(1166, 980);
            this.Controls.Add(this.btnSellLmtTriggerOco);
            this.Controls.Add(this.btnSellMrkTriggerOco);
            this.Controls.Add(this.btnBuyLmtTriggerOco);
            this.Controls.Add(this.btnBuyMrkTriggerOco);
            this.Controls.Add(this.txtRisk);
            this.Controls.Add(this.txtStop);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.lblVersion);
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
            this.Controls.Add(this.chkTradeShares);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAsk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblShares);
            this.Controls.Add(this.txtShares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAveragePrice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtLastError);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(700, 570);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Text = "EZTM - EZ Trade Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rpbTickerLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLastError;
        private System.Windows.Forms.Button btnBreakEven;
        private System.Windows.Forms.TextBox txtAveragePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShares;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Button btnSellLmtTriggerOco;
        private System.Windows.Forms.Button btnBuyLmtTriggerOco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAsk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.CheckBox chkTradeShares;
        private System.Windows.Forms.TextBox txtHeartBeat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectionStatus;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TextBox txtStopToClose;
        private System.Windows.Forms.Button btnCancelAll;
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
        private System.Windows.Forms.RadioButton rbExitMarket;
        private System.Windows.Forms.RadioButton rbExitBidAsk;
        private System.Windows.Forms.Button btnExit33;
        private System.Windows.Forms.Button btnExit50;
        private System.Windows.Forms.Button btnExit25;
        private System.Windows.Forms.Button btnExit100;
        private System.Windows.Forms.Button btnExit10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVersion;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblSymbol;
        private MaterialSkin.Controls.MaterialLabel lblDescription;
        private CustomControls.RoundedPictureBox rpbTickerLogo;
        private MaterialSkin.Controls.MaterialLabel lblLastPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtSymbol;
        private MaterialSkin.Controls.MaterialTextBox2 txtStop;
        private MaterialSkin.Controls.MaterialTextBox2 txtRisk;
        private MaterialSkin.Controls.MaterialButton btnBuyMrkTriggerOco;
        private MaterialSkin.Controls.MaterialButton btnSellMrkTriggerOco;
        private System.Windows.Forms.Label txtMoveStop;
    }
}

