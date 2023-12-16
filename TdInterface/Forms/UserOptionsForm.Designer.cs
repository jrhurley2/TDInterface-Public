
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
            lblTradeShares = new System.Windows.Forms.Label();
            chkTradeShares = new System.Windows.Forms.CheckBox();
            label1 = new System.Windows.Forms.Label();
            txtMaxShares = new System.Windows.Forms.TextBox();
            lblMaxRisk = new System.Windows.Forms.Label();
            txtMaxRisk = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            chkUseBidAskOcoCalc = new System.Windows.Forms.CheckBox();
            txtOneRSharePct = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            chkMoveLimitOnFill = new System.Windows.Forms.CheckBox();
            label4 = new System.Windows.Forms.Label();
            txtDefaultLimitOffset = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            chkMaxLossLimit = new System.Windows.Forms.CheckBox();
            txtMaxLossLimit = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            txtMinRisk = new System.Windows.Forms.TextBox();
            chkSendPrtScrOnOpen = new System.Windows.Forms.CheckBox();
            chkShowPnL = new System.Windows.Forms.CheckBox();
            chkPreventExceedMaxLoss = new System.Windows.Forms.CheckBox();
            chkAdjustRiskForMaxLoss = new System.Windows.Forms.CheckBox();
            chkDisableFirstTarget = new System.Windows.Forms.CheckBox();
            label8 = new System.Windows.Forms.Label();
            chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            chkCaptureSSOnOpen = new System.Windows.Forms.CheckBox();
            label5 = new System.Windows.Forms.Label();
            chkTimeRestrict = new System.Windows.Forms.CheckBox();
            dtPickerTimeRestrict = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            chkTriggerOrderLimit = new System.Windows.Forms.CheckBox();
            txtTriggerOrderLimit = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblTradeShares
            // 
            lblTradeShares.AutoSize = true;
            lblTradeShares.Location = new System.Drawing.Point(53, 48);
            lblTradeShares.Name = "lblTradeShares";
            lblTradeShares.Size = new System.Drawing.Size(93, 20);
            lblTradeShares.TabIndex = 1;
            lblTradeShares.Text = "Trade Shares";
            // 
            // chkTradeShares
            // 
            chkTradeShares.AutoSize = true;
            chkTradeShares.Location = new System.Drawing.Point(269, 51);
            chkTradeShares.Name = "chkTradeShares";
            chkTradeShares.Size = new System.Drawing.Size(18, 17);
            chkTradeShares.TabIndex = 2;
            chkTradeShares.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(53, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(182, 20);
            label1.TabIndex = 3;
            label1.Text = "Max Shares (Trade Shares)";
            // 
            // txtMaxShares
            // 
            txtMaxShares.Location = new System.Drawing.Point(269, 73);
            txtMaxShares.Name = "txtMaxShares";
            txtMaxShares.Size = new System.Drawing.Size(125, 26);
            txtMaxShares.TabIndex = 4;
            // 
            // lblMaxRisk
            // 
            lblMaxRisk.AutoSize = true;
            lblMaxRisk.Location = new System.Drawing.Point(53, 109);
            lblMaxRisk.Name = "lblMaxRisk";
            lblMaxRisk.Size = new System.Drawing.Size(67, 20);
            lblMaxRisk.TabIndex = 5;
            lblMaxRisk.Text = "Max Risk";
            // 
            // txtMaxRisk
            // 
            txtMaxRisk.Location = new System.Drawing.Point(269, 105);
            txtMaxRisk.Name = "txtMaxRisk";
            txtMaxRisk.Size = new System.Drawing.Size(125, 26);
            txtMaxRisk.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(862, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 28);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(758, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 28);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(53, 149);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(151, 20);
            label2.TabIndex = 9;
            label2.Text = "Use Bid/Ask Oco Calc";
            // 
            // chkUseBidAskOcoCalc
            // 
            chkUseBidAskOcoCalc.AccessibleName = "chkUseBidAskOcoCalc";
            chkUseBidAskOcoCalc.AutoSize = true;
            chkUseBidAskOcoCalc.Location = new System.Drawing.Point(271, 147);
            chkUseBidAskOcoCalc.Name = "chkUseBidAskOcoCalc";
            chkUseBidAskOcoCalc.Size = new System.Drawing.Size(18, 17);
            chkUseBidAskOcoCalc.TabIndex = 10;
            chkUseBidAskOcoCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkUseBidAskOcoCalc.UseVisualStyleBackColor = true;
            // 
            // txtOneRSharePct
            // 
            txtOneRSharePct.Location = new System.Drawing.Point(269, 219);
            txtOneRSharePct.Name = "txtOneRSharePct";
            txtOneRSharePct.Size = new System.Drawing.Size(125, 26);
            txtOneRSharePct.TabIndex = 11;
            txtOneRSharePct.Text = "25";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(53, 223);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(191, 20);
            label3.TabIndex = 12;
            label3.Text = "1st Target Share Percentage";
            // 
            // chkMoveLimitOnFill
            // 
            chkMoveLimitOnFill.AutoSize = true;
            chkMoveLimitOnFill.Location = new System.Drawing.Point(271, 266);
            chkMoveLimitOnFill.Name = "chkMoveLimitOnFill";
            chkMoveLimitOnFill.Size = new System.Drawing.Size(18, 17);
            chkMoveLimitOnFill.TabIndex = 13;
            chkMoveLimitOnFill.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 267);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(129, 20);
            label4.TabIndex = 14;
            label4.Text = "Move Limit On Fill";
            // 
            // txtDefaultLimitOffset
            // 
            txtDefaultLimitOffset.Location = new System.Drawing.Point(269, 297);
            txtDefaultLimitOffset.Name = "txtDefaultLimitOffset";
            txtDefaultLimitOffset.Size = new System.Drawing.Size(125, 26);
            txtDefaultLimitOffset.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(53, 301);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(139, 20);
            label6.TabIndex = 18;
            label6.Text = "Default Limit Offset";
            // 
            // chkMaxLossLimit
            // 
            chkMaxLossLimit.AutoSize = true;
            chkMaxLossLimit.Location = new System.Drawing.Point(574, 51);
            chkMaxLossLimit.Name = "chkMaxLossLimit";
            chkMaxLossLimit.Size = new System.Drawing.Size(240, 24);
            chkMaxLossLimit.TabIndex = 19;
            chkMaxLossLimit.Text = "Enable Max Loss Limit (R) Value";
            chkMaxLossLimit.UseVisualStyleBackColor = true;
            // 
            // txtMaxLossLimit
            // 
            txtMaxLossLimit.Location = new System.Drawing.Point(831, 48);
            txtMaxLossLimit.Name = "txtMaxLossLimit";
            txtMaxLossLimit.Size = new System.Drawing.Size(125, 26);
            txtMaxLossLimit.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(574, 147);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 20);
            label7.TabIndex = 21;
            label7.Text = "Min Risk (ex:  .15)";
            // 
            // txtMinRisk
            // 
            txtMinRisk.Location = new System.Drawing.Point(831, 146);
            txtMinRisk.Name = "txtMinRisk";
            txtMinRisk.Size = new System.Drawing.Size(125, 26);
            txtMinRisk.TabIndex = 22;
            // 
            // chkSendPrtScrOnOpen
            // 
            chkSendPrtScrOnOpen.AutoSize = true;
            chkSendPrtScrOnOpen.Location = new System.Drawing.Point(574, 191);
            chkSendPrtScrOnOpen.Name = "chkSendPrtScrOnOpen";
            chkSendPrtScrOnOpen.Size = new System.Drawing.Size(184, 24);
            chkSendPrtScrOnOpen.TabIndex = 23;
            chkSendPrtScrOnOpen.Text = "Send Al-PrtSc On Open";
            chkSendPrtScrOnOpen.UseVisualStyleBackColor = true;
            // 
            // chkShowPnL
            // 
            chkShowPnL.AutoSize = true;
            chkShowPnL.Location = new System.Drawing.Point(574, 347);
            chkShowPnL.Name = "chkShowPnL";
            chkShowPnL.Size = new System.Drawing.Size(94, 24);
            chkShowPnL.TabIndex = 24;
            chkShowPnL.Text = "Show PnL";
            chkShowPnL.UseVisualStyleBackColor = true;
            // 
            // chkPreventExceedMaxLoss
            // 
            chkPreventExceedMaxLoss.AutoSize = true;
            chkPreventExceedMaxLoss.Location = new System.Drawing.Point(574, 79);
            chkPreventExceedMaxLoss.Name = "chkPreventExceedMaxLoss";
            chkPreventExceedMaxLoss.Size = new System.Drawing.Size(246, 24);
            chkPreventExceedMaxLoss.TabIndex = 25;
            chkPreventExceedMaxLoss.Text = "Prevent Risk Exceeding Max Loss";
            chkPreventExceedMaxLoss.UseVisualStyleBackColor = true;
            // 
            // chkAdjustRiskForMaxLoss
            // 
            chkAdjustRiskForMaxLoss.AutoSize = true;
            chkAdjustRiskForMaxLoss.Location = new System.Drawing.Point(574, 108);
            chkAdjustRiskForMaxLoss.Name = "chkAdjustRiskForMaxLoss";
            chkAdjustRiskForMaxLoss.Size = new System.Drawing.Size(265, 24);
            chkAdjustRiskForMaxLoss.TabIndex = 26;
            chkAdjustRiskForMaxLoss.Text = "Adjust Risk to Not Exceed Max Loss";
            chkAdjustRiskForMaxLoss.UseVisualStyleBackColor = true;
            // 
            // chkDisableFirstTarget
            // 
            chkDisableFirstTarget.AutoSize = true;
            chkDisableFirstTarget.Location = new System.Drawing.Point(271, 191);
            chkDisableFirstTarget.Name = "chkDisableFirstTarget";
            chkDisableFirstTarget.Size = new System.Drawing.Size(18, 17);
            chkDisableFirstTarget.TabIndex = 27;
            chkDisableFirstTarget.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(53, 193);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(167, 20);
            label8.TabIndex = 28;
            label8.Text = "Disable 1st Target Profit";
            // 
            // chkAlwaysOnTop
            // 
            chkAlwaysOnTop.AutoSize = true;
            chkAlwaysOnTop.Location = new System.Drawing.Point(574, 267);
            chkAlwaysOnTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            chkAlwaysOnTop.Size = new System.Drawing.Size(129, 24);
            chkAlwaysOnTop.TabIndex = 29;
            chkAlwaysOnTop.Text = "Always On Top";
            chkAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // chkCaptureSSOnOpen
            // 
            chkCaptureSSOnOpen.AutoSize = true;
            chkCaptureSSOnOpen.Location = new System.Drawing.Point(574, 224);
            chkCaptureSSOnOpen.Name = "chkCaptureSSOnOpen";
            chkCaptureSSOnOpen.Size = new System.Drawing.Size(220, 24);
            chkCaptureSSOnOpen.TabIndex = 30;
            chkCaptureSSOnOpen.Text = "Capture Screenshot on Open";
            chkCaptureSSOnOpen.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(56, 356);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(131, 20);
            label5.TabIndex = 31;
            label5.Text = "No Trading Before";
            // 
            // chkTimeRestrict
            // 
            chkTimeRestrict.AutoSize = true;
            chkTimeRestrict.Location = new System.Drawing.Point(222, 353);
            chkTimeRestrict.Name = "chkTimeRestrict";
            chkTimeRestrict.Size = new System.Drawing.Size(18, 17);
            chkTimeRestrict.TabIndex = 32;
            chkTimeRestrict.UseVisualStyleBackColor = true;
            // 
            // dtPickerTimeRestrict
            // 
            dtPickerTimeRestrict.CustomFormat = "";
            dtPickerTimeRestrict.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtPickerTimeRestrict.Location = new System.Drawing.Point(265, 351);
            dtPickerTimeRestrict.Name = "dtPickerTimeRestrict";
            dtPickerTimeRestrict.Size = new System.Drawing.Size(250, 26);
            dtPickerTimeRestrict.TabIndex = 33;
            dtPickerTimeRestrict.Value = new System.DateTime(2023, 11, 3, 9, 30, 0, 0);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(53, 394);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(135, 20);
            label9.TabIndex = 34;
            label9.Text = "Trigger Order Limit";
            // 
            // chkTriggerOrderLimit
            // 
            chkTriggerOrderLimit.AutoSize = true;
            chkTriggerOrderLimit.Location = new System.Drawing.Point(222, 397);
            chkTriggerOrderLimit.Name = "chkTriggerOrderLimit";
            chkTriggerOrderLimit.Size = new System.Drawing.Size(18, 17);
            chkTriggerOrderLimit.TabIndex = 35;
            chkTriggerOrderLimit.UseVisualStyleBackColor = true;
            // 
            // txtTriggerOrderLimit
            // 
            txtTriggerOrderLimit.Location = new System.Drawing.Point(262, 393);
            txtTriggerOrderLimit.Name = "txtTriggerOrderLimit";
            txtTriggerOrderLimit.Size = new System.Drawing.Size(125, 26);
            txtTriggerOrderLimit.TabIndex = 36;
            // 
            // UserOptionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(994, 457);
            Controls.Add(txtTriggerOrderLimit);
            Controls.Add(chkTriggerOrderLimit);
            Controls.Add(label9);
            Controls.Add(dtPickerTimeRestrict);
            Controls.Add(chkTimeRestrict);
            Controls.Add(label5);
            Controls.Add(chkCaptureSSOnOpen);
            Controls.Add(chkAlwaysOnTop);
            Controls.Add(label8);
            Controls.Add(chkDisableFirstTarget);
            Controls.Add(chkAdjustRiskForMaxLoss);
            Controls.Add(chkPreventExceedMaxLoss);
            Controls.Add(chkShowPnL);
            Controls.Add(chkSendPrtScrOnOpen);
            Controls.Add(txtMinRisk);
            Controls.Add(label7);
            Controls.Add(txtMaxLossLimit);
            Controls.Add(chkMaxLossLimit);
            Controls.Add(label6);
            Controls.Add(txtDefaultLimitOffset);
            Controls.Add(label4);
            Controls.Add(chkMoveLimitOnFill);
            Controls.Add(label3);
            Controls.Add(txtOneRSharePct);
            Controls.Add(chkUseBidAskOcoCalc);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMaxRisk);
            Controls.Add(lblMaxRisk);
            Controls.Add(txtMaxShares);
            Controls.Add(label1);
            Controls.Add(chkTradeShares);
            Controls.Add(lblTradeShares);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3);
            MaximizeBox = false;
            Name = "UserOptionsForm";
            Text = "EZTM Settings";
            Load += UserOptionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkTimeRestrict;
        private System.Windows.Forms.DateTimePicker dtPickerTimeRestrict;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkTriggerOrderLimit;
        private System.Windows.Forms.TextBox txtTriggerOrderLimit;
    }
}