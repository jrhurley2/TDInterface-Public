
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
            this.SuspendLayout();
            // 
            // lblTrainingWheels
            // 
            this.lblTrainingWheels.AutoSize = true;
            this.lblTrainingWheels.Location = new System.Drawing.Point(46, 40);
            this.lblTrainingWheels.Name = "lblTrainingWheels";
            this.lblTrainingWheels.Size = new System.Drawing.Size(72, 15);
            this.lblTrainingWheels.TabIndex = 1;
            this.lblTrainingWheels.Text = "Trade Shares";
            // 
            // chkTrainingWheels
            // 
            this.chkTrainingWheels.AutoSize = true;
            this.chkTrainingWheels.Location = new System.Drawing.Point(241, 40);
            this.chkTrainingWheels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTrainingWheels.Name = "chkTrainingWheels";
            this.chkTrainingWheels.Size = new System.Drawing.Size(15, 14);
            this.chkTrainingWheels.TabIndex = 2;
            this.chkTrainingWheels.UseVisualStyleBackColor = true;
            this.chkTrainingWheels.CheckedChanged += new System.EventHandler(this.chkTrainingWheels_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Shares (Trade Shares)";
            // 
            // txtMaxShares
            // 
            this.txtMaxShares.Location = new System.Drawing.Point(241, 58);
            this.txtMaxShares.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxShares.Name = "txtMaxShares";
            this.txtMaxShares.Size = new System.Drawing.Size(110, 23);
            this.txtMaxShares.TabIndex = 4;
            // 
            // lblMaxRisk
            // 
            this.lblMaxRisk.AutoSize = true;
            this.lblMaxRisk.Location = new System.Drawing.Point(46, 76);
            this.lblMaxRisk.Name = "lblMaxRisk";
            this.lblMaxRisk.Size = new System.Drawing.Size(54, 15);
            this.lblMaxRisk.TabIndex = 5;
            this.lblMaxRisk.Text = "Max Risk";
            // 
            // txtMaxRisk
            // 
            this.txtMaxRisk.Location = new System.Drawing.Point(241, 84);
            this.txtMaxRisk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxRisk.Name = "txtMaxRisk";
            this.txtMaxRisk.Size = new System.Drawing.Size(110, 23);
            this.txtMaxRisk.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(108, 273);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(204, 273);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Use Bid/Ask Oco Calc";
            // 
            // chkUseBidAskOcoCalc
            // 
            this.chkUseBidAskOcoCalc.AccessibleName = "chkUseBidAskOcoCalc";
            this.chkUseBidAskOcoCalc.AutoSize = true;
            this.chkUseBidAskOcoCalc.Location = new System.Drawing.Point(242, 116);
            this.chkUseBidAskOcoCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUseBidAskOcoCalc.Name = "chkUseBidAskOcoCalc";
            this.chkUseBidAskOcoCalc.Size = new System.Drawing.Size(15, 14);
            this.chkUseBidAskOcoCalc.TabIndex = 10;
            this.chkUseBidAskOcoCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUseBidAskOcoCalc.UseVisualStyleBackColor = true;
            // 
            // txtOneRSharePct
            // 
            this.txtOneRSharePct.Location = new System.Drawing.Point(241, 137);
            this.txtOneRSharePct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOneRSharePct.Name = "txtOneRSharePct";
            this.txtOneRSharePct.Size = new System.Drawing.Size(110, 23);
            this.txtOneRSharePct.TabIndex = 11;
            this.txtOneRSharePct.Text = "25";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "1st Target Share Percentage";
            // 
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}