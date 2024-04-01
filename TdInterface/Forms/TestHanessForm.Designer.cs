namespace EZTM.Forms.UI.Forms
{
    partial class TestHanessForm
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
            btnRefreshToken = new System.Windows.Forms.Button();
            txtResults = new System.Windows.Forms.TextBox();
            btnAccountNumberHash = new System.Windows.Forms.Button();
            btnAccounts = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnRefreshToken
            // 
            btnRefreshToken.Location = new System.Drawing.Point(32, 35);
            btnRefreshToken.Name = "btnRefreshToken";
            btnRefreshToken.Size = new System.Drawing.Size(113, 29);
            btnRefreshToken.TabIndex = 0;
            btnRefreshToken.Text = "Refresh Token";
            btnRefreshToken.UseVisualStyleBackColor = true;
            btnRefreshToken.Click += btnRefreshToken_Click;
            // 
            // txtResults
            // 
            txtResults.Location = new System.Drawing.Point(78, 315);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.Size = new System.Drawing.Size(610, 123);
            txtResults.TabIndex = 1;
            // 
            // btnAccountNumberHash
            // 
            btnAccountNumberHash.Location = new System.Drawing.Point(33, 73);
            btnAccountNumberHash.Name = "btnAccountNumberHash";
            btnAccountNumberHash.Size = new System.Drawing.Size(193, 29);
            btnAccountNumberHash.TabIndex = 2;
            btnAccountNumberHash.Text = "Account Number Hash";
            btnAccountNumberHash.UseVisualStyleBackColor = true;
            btnAccountNumberHash.Click += btnAccountNumberHash_Click;
            // 
            // btnAccounts
            // 
            btnAccounts.Location = new System.Drawing.Point(40, 116);
            btnAccounts.Name = "btnAccounts";
            btnAccounts.Size = new System.Drawing.Size(94, 29);
            btnAccounts.TabIndex = 3;
            btnAccounts.Text = "Accounts";
            btnAccounts.UseVisualStyleBackColor = true;
            btnAccounts.Click += btnAccounts_Click;
            // 
            // TestHanessForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnAccounts);
            Controls.Add(btnAccountNumberHash);
            Controls.Add(txtResults);
            Controls.Add(btnRefreshToken);
            Name = "TestHanessForm";
            Text = "TestHanessForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnRefreshToken;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnAccountNumberHash;
        private System.Windows.Forms.Button btnAccounts;
    }
}