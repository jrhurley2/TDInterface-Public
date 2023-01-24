namespace TdInterface.Forms
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTdaEnableEquity = new System.Windows.Forms.CheckBox();
            this.txtConsumerKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTsEnableEquity = new System.Windows.Forms.CheckBox();
            this.chkUseSimAccount = new System.Windows.Forms.CheckBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTdaEnableEquity);
            this.groupBox1.Controls.Add(this.txtConsumerKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TD Ameritrade";
            // 
            // chkTdaEnableEquity
            // 
            this.chkTdaEnableEquity.AutoSize = true;
            this.chkTdaEnableEquity.Location = new System.Drawing.Point(15, 26);
            this.chkTdaEnableEquity.Name = "chkTdaEnableEquity";
            this.chkTdaEnableEquity.Size = new System.Drawing.Size(144, 24);
            this.chkTdaEnableEquity.TabIndex = 2;
            this.chkTdaEnableEquity.Text = "Enable for Equity";
            this.chkTdaEnableEquity.UseVisualStyleBackColor = true;
            this.chkTdaEnableEquity.CheckedChanged += new System.EventHandler(this.chkTdaEnableEquity_CheckedChanged);
            // 
            // txtConsumerKey
            // 
            this.txtConsumerKey.Location = new System.Drawing.Point(134, 66);
            this.txtConsumerKey.Name = "txtConsumerKey";
            this.txtConsumerKey.Size = new System.Drawing.Size(125, 27);
            this.txtConsumerKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumer Key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTsEnableEquity);
            this.groupBox2.Controls.Add(this.chkUseSimAccount);
            this.groupBox2.Controls.Add(this.txtClientSecret);
            this.groupBox2.Controls.Add(this.txtClientId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TradeStation";
            // 
            // chkTsEnableEquity
            // 
            this.chkTsEnableEquity.AutoSize = true;
            this.chkTsEnableEquity.Location = new System.Drawing.Point(15, 25);
            this.chkTsEnableEquity.Name = "chkTsEnableEquity";
            this.chkTsEnableEquity.Size = new System.Drawing.Size(144, 24);
            this.chkTsEnableEquity.TabIndex = 7;
            this.chkTsEnableEquity.Text = "Enable for Equity";
            this.chkTsEnableEquity.UseVisualStyleBackColor = true;
            this.chkTsEnableEquity.CheckedChanged += new System.EventHandler(this.chkTsEnableEquity_CheckedChanged);
            // 
            // chkUseSimAccount
            // 
            this.chkUseSimAccount.AutoSize = true;
            this.chkUseSimAccount.Location = new System.Drawing.Point(319, 25);
            this.chkUseSimAccount.Name = "chkUseSimAccount";
            this.chkUseSimAccount.Size = new System.Drawing.Size(142, 24);
            this.chkUseSimAccount.TabIndex = 6;
            this.chkUseSimAccount.Text = "Use Sim Account";
            this.chkUseSimAccount.UseVisualStyleBackColor = true;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(134, 100);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(125, 27);
            this.txtClientSecret.TabIndex = 3;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(134, 55);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(125, 27);
            this.txtClientId.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Secret";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Client Id";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(630, 295);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(630, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AccountInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountInfoForm";
            this.Text = "AccountInfo";
            this.Load += new System.EventHandler(this.AccountInfoForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

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
    }
}