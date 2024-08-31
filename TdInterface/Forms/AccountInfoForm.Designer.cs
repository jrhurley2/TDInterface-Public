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
            groupBox1 = new System.Windows.Forms.GroupBox();
            chkTdaEnableEquity = new System.Windows.Forms.CheckBox();
            txtConsumerKey = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            chkTsEnableEquity = new System.Windows.Forms.CheckBox();
            chkUseSimAccount = new System.Windows.Forms.CheckBox();
            txtClientSecret = new System.Windows.Forms.TextBox();
            txtClientId = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnClearCreds = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            chkSchwabEnableEquity = new System.Windows.Forms.CheckBox();
            txtSchwabClientSecret = new System.Windows.Forms.TextBox();
            txtSchwabClientId = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtSchwabAccountNumber = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkTdaEnableEquity);
            groupBox1.Controls.Add(txtConsumerKey);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new System.Drawing.Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(284, 110);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "TD Ameritrade";
            // 
            // chkTdaEnableEquity
            // 
            chkTdaEnableEquity.AutoSize = true;
            chkTdaEnableEquity.Location = new System.Drawing.Point(16, 25);
            chkTdaEnableEquity.Name = "chkTdaEnableEquity";
            chkTdaEnableEquity.Size = new System.Drawing.Size(138, 23);
            chkTdaEnableEquity.TabIndex = 2;
            chkTdaEnableEquity.Text = "Enable for Equity";
            chkTdaEnableEquity.UseVisualStyleBackColor = true;
            chkTdaEnableEquity.CheckedChanged += chkTdaEnableEquity_CheckedChanged;
            // 
            // txtConsumerKey
            // 
            txtConsumerKey.Location = new System.Drawing.Point(16, 73);
            txtConsumerKey.Name = "txtConsumerKey";
            txtConsumerKey.PasswordChar = '*';
            txtConsumerKey.Size = new System.Drawing.Size(256, 26);
            txtConsumerKey.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "Consumer Key";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkTsEnableEquity);
            groupBox2.Controls.Add(chkUseSimAccount);
            groupBox2.Controls.Add(txtClientSecret);
            groupBox2.Controls.Add(txtClientId);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new System.Drawing.Point(27, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(283, 187);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "TradeStation";
            // 
            // chkTsEnableEquity
            // 
            chkTsEnableEquity.AutoSize = true;
            chkTsEnableEquity.Location = new System.Drawing.Point(14, 23);
            chkTsEnableEquity.Name = "chkTsEnableEquity";
            chkTsEnableEquity.Size = new System.Drawing.Size(138, 23);
            chkTsEnableEquity.TabIndex = 7;
            chkTsEnableEquity.Text = "Enable for Equity";
            chkTsEnableEquity.UseVisualStyleBackColor = true;
            chkTsEnableEquity.CheckedChanged += chkTsEnableEquity_CheckedChanged;
            // 
            // chkUseSimAccount
            // 
            chkUseSimAccount.AutoSize = true;
            chkUseSimAccount.Location = new System.Drawing.Point(15, 156);
            chkUseSimAccount.Name = "chkUseSimAccount";
            chkUseSimAccount.Size = new System.Drawing.Size(138, 23);
            chkUseSimAccount.TabIndex = 6;
            chkUseSimAccount.Text = "Use Sim Account";
            chkUseSimAccount.UseVisualStyleBackColor = true;
            // 
            // txtClientSecret
            // 
            txtClientSecret.Location = new System.Drawing.Point(14, 124);
            txtClientSecret.Name = "txtClientSecret";
            txtClientSecret.PasswordChar = '*';
            txtClientSecret.Size = new System.Drawing.Size(257, 26);
            txtClientSecret.TabIndex = 3;
            // 
            // txtClientId
            // 
            txtClientId.Location = new System.Drawing.Point(15, 71);
            txtClientId.Name = "txtClientId";
            txtClientId.PasswordChar = '*';
            txtClientId.Size = new System.Drawing.Size(256, 26);
            txtClientId.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(15, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 19);
            label2.TabIndex = 2;
            label2.Text = "Client Secret";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 19);
            label3.TabIndex = 4;
            label3.Text = "Client Id";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(201, 597);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 28);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(11, 597);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 28);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClearCreds
            // 
            btnClearCreds.Location = new System.Drawing.Point(11, 561);
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
            textBox1.Location = new System.Drawing.Point(12, 634);
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
            groupBox3.Location = new System.Drawing.Point(27, 128);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(283, 223);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Schwab";
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
            // AccountInfoForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(353, 709);
            Controls.Add(groupBox3);
            Controls.Add(textBox1);
            Controls.Add(btnClearCreds);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3);
            MaximizeBox = false;
            Name = "AccountInfoForm";
            Text = "EZTM Account Settings";
            Load += AccountInfoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtConsumerKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkUseSimAccount;
        private System.Windows.Forms.CheckBox chkTdaEnableEquity;
        private System.Windows.Forms.CheckBox chkTsEnableEquity;
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