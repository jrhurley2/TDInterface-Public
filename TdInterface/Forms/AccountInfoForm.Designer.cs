namespace EZTM.Forms.UI.Forms
{
    partial class AccountInfoForm
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
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnClearCreds = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            txtSchwabAccountNumber = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            chkSchwabEnableEquity = new System.Windows.Forms.CheckBox();
            txtSchwabClientSecret = new System.Windows.Forms.TextBox();
            txtSchwabClientId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(202, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 28);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(12, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 28);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClearCreds
            // 
            btnClearCreds.Location = new System.Drawing.Point(12, 254);
            btnClearCreds.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClearCreds.Name = "btnClearCreds";
            btnClearCreds.Size = new System.Drawing.Size(284, 29);
            btnClearCreds.TabIndex = 4;
            btnClearCreds.Text = "Clear Credentials";
            btnClearCreds.UseVisualStyleBackColor = true;
            btnClearCreds.Click += btnClearCreds_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            textBox1.Location = new System.Drawing.Point(13, 327);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(283, 62);
            textBox1.TabIndex = 5;
            textBox1.Text = "At this time, there is NO support for futures trading in the application.\r\nIt is on our list of features to add.";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtSchwabAccountNumber);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(chkSchwabEnableEquity);
            groupBox3.Controls.Add(txtSchwabClientSecret);
            groupBox3.Controls.Add(txtSchwabClientId);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new System.Drawing.Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(283, 223);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Schwab";
            // 
            // txtSchwabAccountNumber
            // 
            txtSchwabAccountNumber.Location = new System.Drawing.Point(14, 184);
            txtSchwabAccountNumber.Name = "txtSchwabAccountNumber";
            txtSchwabAccountNumber.PasswordChar = '*';
            txtSchwabAccountNumber.Size = new System.Drawing.Size(257, 26);
            txtSchwabAccountNumber.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(15, 162);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 19);
            label6.TabIndex = 8;
            label6.Text = "Account Number";
            // 
            // chkSchwabEnableEquity
            // 
            chkSchwabEnableEquity.AutoSize = true;
            chkSchwabEnableEquity.Location = new System.Drawing.Point(14, 23);
            chkSchwabEnableEquity.Name = "chkSchwabEnableEquity";
            chkSchwabEnableEquity.Size = new System.Drawing.Size(138, 23);
            chkSchwabEnableEquity.TabIndex = 7;
            chkSchwabEnableEquity.Text = "Enable for Equity";
            chkSchwabEnableEquity.UseVisualStyleBackColor = true;
            // 
            // txtSchwabClientSecret
            // 
            txtSchwabClientSecret.Location = new System.Drawing.Point(14, 124);
            txtSchwabClientSecret.Name = "txtSchwabClientSecret";
            txtSchwabClientSecret.PasswordChar = '*';
            txtSchwabClientSecret.Size = new System.Drawing.Size(257, 26);
            txtSchwabClientSecret.TabIndex = 3;
            // 
            // txtSchwabClientId
            // 
            txtSchwabClientId.Location = new System.Drawing.Point(15, 71);
            txtSchwabClientId.Name = "txtSchwabClientId";
            txtSchwabClientId.PasswordChar = '*';
            txtSchwabClientId.Size = new System.Drawing.Size(256, 26);
            txtSchwabClientId.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 102);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 19);
            label4.TabIndex = 2;
            label4.Text = "Client Secret";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 49);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 19);
            label5.TabIndex = 4;
            label5.Text = "Client Id";
            // 
            // AccountInfoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(353, 430);
            Controls.Add(groupBox3);
            Controls.Add(textBox1);
            Controls.Add(btnClearCreds);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3);
            MaximizeBox = false;
            Name = "AccountInfoForm";
            Text = "EZTM Account Settings";
            Load += AccountInfoForm_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearCreds;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSchwabEnableEquity;
        private System.Windows.Forms.TextBox txtSchwabClientSecret;
        private System.Windows.Forms.TextBox txtSchwabClientId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSchwabAccountNumber;
        private System.Windows.Forms.Label label6;
    }
}