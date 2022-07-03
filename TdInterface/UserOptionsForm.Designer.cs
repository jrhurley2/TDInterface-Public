
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
            this.SuspendLayout();
            // 
            // lblTrainingWheels
            // 
            this.lblTrainingWheels.AutoSize = true;
            this.lblTrainingWheels.Location = new System.Drawing.Point(53, 54);
            this.lblTrainingWheels.Name = "lblTrainingWheels";
            this.lblTrainingWheels.Size = new System.Drawing.Size(114, 20);
            this.lblTrainingWheels.TabIndex = 1;
            this.lblTrainingWheels.Text = "Training Wheels";
            // 
            // chkTrainingWheels
            // 
            this.chkTrainingWheels.AutoSize = true;
            this.chkTrainingWheels.Location = new System.Drawing.Point(275, 54);
            this.chkTrainingWheels.Name = "chkTrainingWheels";
            this.chkTrainingWheels.Size = new System.Drawing.Size(18, 17);
            this.chkTrainingWheels.TabIndex = 2;
            this.chkTrainingWheels.UseVisualStyleBackColor = true;
            this.chkTrainingWheels.CheckedChanged += new System.EventHandler(this.chkTrainingWheels_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Max Shares (TrainingWheels)";
            // 
            // txtMaxShares
            // 
            this.txtMaxShares.Location = new System.Drawing.Point(275, 78);
            this.txtMaxShares.Name = "txtMaxShares";
            this.txtMaxShares.Size = new System.Drawing.Size(125, 27);
            this.txtMaxShares.TabIndex = 4;
            // 
            // lblMaxRisk
            // 
            this.lblMaxRisk.AutoSize = true;
            this.lblMaxRisk.Location = new System.Drawing.Point(53, 102);
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
            // UserOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaxRisk);
            this.Controls.Add(this.lblMaxRisk);
            this.Controls.Add(this.txtMaxShares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTrainingWheels);
            this.Controls.Add(this.lblTrainingWheels);
            this.Name = "UserOptionsForm";
            this.Text = "UserOptionsForm";
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
    }
}