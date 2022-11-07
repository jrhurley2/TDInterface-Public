
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
            this.lblTrainingWheels = new System.Windows.Forms.Label();
            this.chkTrainingWheels = new System.Windows.Forms.CheckBox();
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
            this.SuspendLayout();
            // 
            // lblTrainingWheels
            // 
            this.lblTrainingWheels.AutoSize = true;
            this.lblTrainingWheels.Location = new System.Drawing.Point(53, 53);
            this.lblTrainingWheels.Name = "lblTrainingWheels";
            this.lblTrainingWheels.Size = new System.Drawing.Size(93, 20);
            this.lblTrainingWheels.TabIndex = 1;
            this.lblTrainingWheels.Text = "Trade Shares";
            // 
            // chkTrainingWheels
            // 
            this.chkTrainingWheels.AutoSize = true;
            this.chkTrainingWheels.Location = new System.Drawing.Point(275, 53);
            this.chkTrainingWheels.Name = "chkTrainingWheels";
            this.chkTrainingWheels.Size = new System.Drawing.Size(18, 17);
            this.chkTrainingWheels.TabIndex = 2;
            this.chkTrainingWheels.UseVisualStyleBackColor = true;
            this.chkTrainingWheels.CheckedChanged += new System.EventHandler(this.chkTrainingWheels_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Shares (Trade Shares)";
            // 
            // txtMaxShares
            // 
            this.txtMaxShares.Location = new System.Drawing.Point(275, 77);
            this.txtMaxShares.Name = "txtMaxShares";
            this.txtMaxShares.Size = new System.Drawing.Size(125, 27);
            this.txtMaxShares.TabIndex = 4;
            // 
            // lblMaxRisk
            // 
            this.lblMaxRisk.AutoSize = true;
            this.lblMaxRisk.Location = new System.Drawing.Point(53, 101);
            this.lblMaxRisk.Name = "lblMaxRisk";
            this.lblMaxRisk.Size = new System.Drawing.Size(67, 20);
            this.lblMaxRisk.TabIndex = 5;
            this.lblMaxRisk.Text = "Max Risk";
            // 
            // txtMaxRisk
            // 
            this.txtMaxRisk.Location = new System.Drawing.Point(275, 112);
            this.txtMaxRisk.Name = "txtMaxRisk";
            this.txtMaxRisk.Size = new System.Drawing.Size(125, 27);
            this.txtMaxRisk.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(123, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use Bid/Ask Oco Calc";
            // 
            // chkUseBidAskOcoCalc
            // 
            this.chkUseBidAskOcoCalc.AccessibleName = "chkUseBidAskOcoCalc";
            this.chkUseBidAskOcoCalc.AutoSize = true;
            this.chkUseBidAskOcoCalc.Location = new System.Drawing.Point(277, 155);
            this.chkUseBidAskOcoCalc.Name = "chkUseBidAskOcoCalc";
            this.chkUseBidAskOcoCalc.Size = new System.Drawing.Size(18, 17);
            this.chkUseBidAskOcoCalc.TabIndex = 10;
            this.chkUseBidAskOcoCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseBidAskOcoCalc.UseVisualStyleBackColor = true;
            // 
            // txtOneRSharePct
            // 
            this.txtOneRSharePct.Location = new System.Drawing.Point(275, 183);
            this.txtOneRSharePct.Name = "txtOneRSharePct";
            this.txtOneRSharePct.Size = new System.Drawing.Size(125, 27);
            this.txtOneRSharePct.TabIndex = 11;
            this.txtOneRSharePct.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "1st Target Share Percentage";
            // 
            // chkMoveLimitOnFill
            // 
            this.chkMoveLimitOnFill.AutoSize = true;
            this.chkMoveLimitOnFill.Location = new System.Drawing.Point(277, 232);
            this.chkMoveLimitOnFill.Name = "chkMoveLimitOnFill";
            this.chkMoveLimitOnFill.Size = new System.Drawing.Size(18, 17);
            this.chkMoveLimitOnFill.TabIndex = 13;
            this.chkMoveLimitOnFill.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Move Limit On Fill";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Reduce Stop On Close";
            // 
            // chkReduceStopOnClose
            // 
            this.chkReduceStopOnClose.AutoSize = true;
            this.chkReduceStopOnClose.Location = new System.Drawing.Point(277, 274);
            this.chkReduceStopOnClose.Name = "chkReduceStopOnClose";
            this.chkReduceStopOnClose.Size = new System.Drawing.Size(18, 17);
            this.chkReduceStopOnClose.TabIndex = 15;
            this.chkReduceStopOnClose.UseVisualStyleBackColor = true;
            // 
            // txtDefaultLimitOffset
            // 
            this.txtDefaultLimitOffset.Location = new System.Drawing.Point(275, 312);
            this.txtDefaultLimitOffset.Name = "txtDefaultLimitOffset";
            this.txtDefaultLimitOffset.Size = new System.Drawing.Size(125, 27);
            this.txtDefaultLimitOffset.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Default Limit Offset";
            // 
            // chkMaxLossLimit
            // 
            this.chkMaxLossLimit.AutoSize = true;
            this.chkMaxLossLimit.Location = new System.Drawing.Point(574, 53);
            this.chkMaxLossLimit.Name = "chkMaxLossLimit";
            this.chkMaxLossLimit.Size = new System.Drawing.Size(177, 24);
            this.chkMaxLossLimit.TabIndex = 19;
            this.chkMaxLossLimit.Text = "Enable Max Loss Limit";
            this.chkMaxLossLimit.UseVisualStyleBackColor = true;
            // 
            // txtMaxLossLimit
            // 
            this.txtMaxLossLimit.Location = new System.Drawing.Point(780, 55);
            this.txtMaxLossLimit.Name = "txtMaxLossLimit";
            this.txtMaxLossLimit.Size = new System.Drawing.Size(125, 27);
            this.txtMaxLossLimit.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(577, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Min Risk (ex:  .15)";
            // 
            // txtMinRisk
            // 
            this.txtMinRisk.Location = new System.Drawing.Point(785, 100);
            this.txtMinRisk.Name = "txtMinRisk";
            this.txtMinRisk.Size = new System.Drawing.Size(125, 27);
            this.txtMinRisk.TabIndex = 22;
            // 
            // chkSendPrtScrOnOpen
            // 
            this.chkSendPrtScrOnOpen.AutoSize = true;
            this.chkSendPrtScrOnOpen.Location = new System.Drawing.Point(574, 148);
            this.chkSendPrtScrOnOpen.Name = "chkSendPrtScrOnOpen";
            this.chkSendPrtScrOnOpen.Size = new System.Drawing.Size(184, 24);
            this.chkSendPrtScrOnOpen.TabIndex = 23;
            this.chkSendPrtScrOnOpen.Text = "Send Al-PrtSc On Open";
            this.chkSendPrtScrOnOpen.UseVisualStyleBackColor = true;
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 552);
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
            this.Controls.Add(this.chkTrainingWheels);
            this.Controls.Add(this.lblTrainingWheels);
            this.Name = "UserOptionsForm";
            this.Text = "UserOptionsForm";
            this.Load += new System.EventHandler(this.UserOptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTrainingWheels;
        private System.Windows.Forms.CheckBox chkTrainingWheels;
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
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkSendPrtScrOnOpen;
    }
}