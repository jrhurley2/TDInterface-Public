
namespace TdInterface
{
    partial class UserOptionsForm
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
            this.lblTradeShares = new System.Windows.Forms.Label();
            this.chkTradeShares = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxShares = new System.Windows.Forms.TextBox();
            this.lblMaxRisk = new System.Windows.Forms.Label();
            this.txtMaxRisk = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkUseBidAskOcoCalc = new System.Windows.Forms.CheckBox();
            this.txtOneRSharePct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMoveLimitOnFill = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkReduceStopOnClose = new System.Windows.Forms.CheckBox();
            this.txtDefaultLimitOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkMaxLossLimit = new System.Windows.Forms.CheckBox();
            this.txtMaxLossLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinRisk = new System.Windows.Forms.TextBox();
            this.chkSendPrtScrOnOpen = new System.Windows.Forms.CheckBox();
            this.chkShowPnL = new System.Windows.Forms.CheckBox();
            this.chkPreventExceedMaxLoss = new System.Windows.Forms.CheckBox();
            this.chkAdjustRiskForMaxLoss = new System.Windows.Forms.CheckBox();
            this.chkDisableFirstTarget = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.chkCaptureSSOnOpen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTradeShares
            // 
            this.lblTradeShares.AutoSize = true;
            this.lblTradeShares.Location = new System.Drawing.Point(53, 48);
            this.lblTradeShares.Name = "lblTradeShares";
            this.lblTradeShares.Size = new System.Drawing.Size(86, 19);
            this.lblTradeShares.TabIndex = 1;
            this.lblTradeShares.Text = "Trade Shares";
            // 
            // chkTradeShares
            // 
            this.chkTradeShares.AutoSize = true;
            this.chkTradeShares.Location = new System.Drawing.Point(269, 51);
            this.chkTradeShares.Name = "chkTradeShares";
            this.chkTradeShares.Size = new System.Drawing.Size(15, 14);
            this.chkTradeShares.TabIndex = 2;
            this.chkTradeShares.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Shares (Trade Shares)";
            // 
            // txtMaxShares
            // 
            this.txtMaxShares.Location = new System.Drawing.Point(269, 73);
            this.txtMaxShares.Name = "txtMaxShares";
            this.txtMaxShares.Size = new System.Drawing.Size(125, 26);
            this.txtMaxShares.TabIndex = 4;
            // 
            // lblMaxRisk
            // 
            this.lblMaxRisk.AutoSize = true;
            this.lblMaxRisk.Location = new System.Drawing.Point(53, 109);
            this.lblMaxRisk.Name = "lblMaxRisk";
            this.lblMaxRisk.Size = new System.Drawing.Size(63, 19);
            this.lblMaxRisk.TabIndex = 5;
            this.lblMaxRisk.Text = "Max Risk";
            // 
            // txtMaxRisk
            // 
            this.txtMaxRisk.Location = new System.Drawing.Point(269, 105);
            this.txtMaxRisk.Name = "txtMaxRisk";
            this.txtMaxRisk.Size = new System.Drawing.Size(125, 26);
            this.txtMaxRisk.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(862, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(758, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use Bid/Ask Oco Calc";
            // 
            // chkUseBidAskOcoCalc
            // 
            this.chkUseBidAskOcoCalc.AccessibleName = "chkUseBidAskOcoCalc";
            this.chkUseBidAskOcoCalc.AutoSize = true;
            this.chkUseBidAskOcoCalc.Location = new System.Drawing.Point(271, 147);
            this.chkUseBidAskOcoCalc.Name = "chkUseBidAskOcoCalc";
            this.chkUseBidAskOcoCalc.Size = new System.Drawing.Size(15, 14);
            this.chkUseBidAskOcoCalc.TabIndex = 10;
            this.chkUseBidAskOcoCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseBidAskOcoCalc.UseVisualStyleBackColor = true;
            // 
            // txtOneRSharePct
            // 
            this.txtOneRSharePct.Location = new System.Drawing.Point(269, 219);
            this.txtOneRSharePct.Name = "txtOneRSharePct";
            this.txtOneRSharePct.Size = new System.Drawing.Size(125, 26);
            this.txtOneRSharePct.TabIndex = 11;
            this.txtOneRSharePct.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "1st Target Share Percentage";
            // 
            // chkMoveLimitOnFill
            // 
            this.chkMoveLimitOnFill.AutoSize = true;
            this.chkMoveLimitOnFill.Location = new System.Drawing.Point(271, 266);
            this.chkMoveLimitOnFill.Name = "chkMoveLimitOnFill";
            this.chkMoveLimitOnFill.Size = new System.Drawing.Size(15, 14);
            this.chkMoveLimitOnFill.TabIndex = 13;
            this.chkMoveLimitOnFill.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Move Limit On Fill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reduce Stop On Close";
            // 
            // chkReduceStopOnClose
            // 
            this.chkReduceStopOnClose.AutoSize = true;
            this.chkReduceStopOnClose.Location = new System.Drawing.Point(271, 307);
            this.chkReduceStopOnClose.Name = "chkReduceStopOnClose";
            this.chkReduceStopOnClose.Size = new System.Drawing.Size(15, 14);
            this.chkReduceStopOnClose.TabIndex = 15;
            this.chkReduceStopOnClose.UseVisualStyleBackColor = true;
            // 
            // txtDefaultLimitOffset
            // 
            this.txtDefaultLimitOffset.Location = new System.Drawing.Point(269, 342);
            this.txtDefaultLimitOffset.Name = "txtDefaultLimitOffset";
            this.txtDefaultLimitOffset.Size = new System.Drawing.Size(125, 26);
            this.txtDefaultLimitOffset.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Default Limit Offset";
            // 
            // chkMaxLossLimit
            // 
            this.chkMaxLossLimit.AutoSize = true;
            this.chkMaxLossLimit.Location = new System.Drawing.Point(574, 51);
            this.chkMaxLossLimit.Name = "chkMaxLossLimit";
            this.chkMaxLossLimit.Size = new System.Drawing.Size(220, 23);
            this.chkMaxLossLimit.TabIndex = 19;
            this.chkMaxLossLimit.Text = "Enable Max Loss Limit (R) Value";
            this.chkMaxLossLimit.UseVisualStyleBackColor = true;
            // 
            // txtMaxLossLimit
            // 
            this.txtMaxLossLimit.Location = new System.Drawing.Point(831, 48);
            this.txtMaxLossLimit.Name = "txtMaxLossLimit";
            this.txtMaxLossLimit.Size = new System.Drawing.Size(125, 26);
            this.txtMaxLossLimit.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Min Risk (ex:  .15)";
            // 
            // txtMinRisk
            // 
            this.txtMinRisk.Location = new System.Drawing.Point(831, 146);
            this.txtMinRisk.Name = "txtMinRisk";
            this.txtMinRisk.Size = new System.Drawing.Size(125, 26);
            this.txtMinRisk.TabIndex = 22;
            // 
            // chkSendPrtScrOnOpen
            // 
            this.chkSendPrtScrOnOpen.AutoSize = true;
            this.chkSendPrtScrOnOpen.Location = new System.Drawing.Point(574, 191);
            this.chkSendPrtScrOnOpen.Name = "chkSendPrtScrOnOpen";
            this.chkSendPrtScrOnOpen.Size = new System.Drawing.Size(172, 23);
            this.chkSendPrtScrOnOpen.TabIndex = 23;
            this.chkSendPrtScrOnOpen.Text = "Send Al-PrtSc On Open";
            this.chkSendPrtScrOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkShowPnL
            // 
            this.chkShowPnL.AutoSize = true;
            this.chkShowPnL.Location = new System.Drawing.Point(574, 347);
            this.chkShowPnL.Name = "chkShowPnL";
            this.chkShowPnL.Size = new System.Drawing.Size(88, 23);
            this.chkShowPnL.TabIndex = 24;
            this.chkShowPnL.Text = "Show PnL";
            this.chkShowPnL.UseVisualStyleBackColor = true;
            // 
            // chkPreventExceedMaxLoss
            // 
            this.chkPreventExceedMaxLoss.AutoSize = true;
            this.chkPreventExceedMaxLoss.Location = new System.Drawing.Point(574, 79);
            this.chkPreventExceedMaxLoss.Name = "chkPreventExceedMaxLoss";
            this.chkPreventExceedMaxLoss.Size = new System.Drawing.Size(228, 23);
            this.chkPreventExceedMaxLoss.TabIndex = 25;
            this.chkPreventExceedMaxLoss.Text = "Prevent Risk Exceeding Max Loss";
            this.chkPreventExceedMaxLoss.UseVisualStyleBackColor = true;
            // 
            // chkAdjustRiskForMaxLoss
            // 
            this.chkAdjustRiskForMaxLoss.AutoSize = true;
            this.chkAdjustRiskForMaxLoss.Location = new System.Drawing.Point(574, 108);
            this.chkAdjustRiskForMaxLoss.Name = "chkAdjustRiskForMaxLoss";
            this.chkAdjustRiskForMaxLoss.Size = new System.Drawing.Size(245, 23);
            this.chkAdjustRiskForMaxLoss.TabIndex = 26;
            this.chkAdjustRiskForMaxLoss.Text = "Adjust Risk to Not Exceed Max Loss";
            this.chkAdjustRiskForMaxLoss.UseVisualStyleBackColor = true;
            // 
            // chkDisableFirstTarget
            // 
            this.chkDisableFirstTarget.AutoSize = true;
            this.chkDisableFirstTarget.Location = new System.Drawing.Point(271, 191);
            this.chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            this.chkDisableFirstTarget.Size = new System.Drawing.Size(15, 14);
            this.chkDisableFirstTarget.TabIndex = 27;
            this.chkDisableFirstTarget.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Disable 1st Target Profit";
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(574, 267);
            this.chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(119, 23);
            this.chkAlwaysOnTop.TabIndex = 29;
            this.chkAlwaysOnTop.Text = "Always On Top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // chkCaptureSSOnOpen
            // 
            this.chkCaptureSSOnOpen.AutoSize = true;
            this.chkCaptureSSOnOpen.Location = new System.Drawing.Point(574, 224);
            this.chkCaptureSSOnOpen.Name = "chkCaptureSSOnOpen";
            this.chkCaptureSSOnOpen.Size = new System.Drawing.Size(206, 23);
            this.chkCaptureSSOnOpen.TabIndex = 30;
            this.chkCaptureSSOnOpen.Text = "Capture Screenshot on Open";
            this.chkCaptureSSOnOpen.UseVisualStyleBackColor = true;
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 457);
            this.Controls.Add(this.chkCaptureSSOnOpen);
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkDisableFirstTarget);
            this.Controls.Add(this.chkAdjustRiskForMaxLoss);
            this.Controls.Add(this.chkPreventExceedMaxLoss);
            this.Controls.Add(this.chkShowPnL);
            this.Controls.Add(this.chkSendPrtScrOnOpen);
            this.Controls.Add(this.txtMinRisk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxLossLimit);
            this.Controls.Add(this.chkMaxLossLimit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDefaultLimitOffset);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkReduceStopOnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkMoveLimitOnFill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOneRSharePct);
            this.Controls.Add(this.chkUseBidAskOcoCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMaxRisk);
            this.Controls.Add(this.lblMaxRisk);
            this.Controls.Add(this.txtMaxShares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTradeShares);
            this.Controls.Add(this.lblTradeShares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MaximizeBox = false;
            this.Name = "UserOptionsForm";
            this.Text = "EZTM Settings";
            this.Load += new System.EventHandler(this.UserOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTradeShares;
        private System.Windows.Forms.CheckBox chkTradeShares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxShares;
        private System.Windows.Forms.Label lblMaxRisk;
        private System.Windows.Forms.TextBox txtMaxRisk;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkUseBidAskOcoCalc;
        private System.Windows.Forms.TextBox txtOneRSharePct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMoveLimitOnFill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkReduceStopOnClose;
        private System.Windows.Forms.TextBox txtDefaultLimitOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkMaxLossLimit;
        private System.Windows.Forms.TextBox txtMaxLossLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinRisk;
        private System.Windows.Forms.CheckBox chkSendPrtScrOnOpen;
        private System.Windows.Forms.CheckBox chkShowPnL;
        private System.Windows.Forms.CheckBox chkPreventExceedMaxLoss;
        private System.Windows.Forms.CheckBox chkAdjustRiskForMaxLoss;
        private System.Windows.Forms.CheckBox chkDisableFirstTarget;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;
        private System.Windows.Forms.CheckBox chkCaptureSSOnOpen;
    }
}