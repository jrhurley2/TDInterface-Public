namespace EZTM.Forms.UI.Forms
{
    partial class OptionsForm
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
            button1 = new System.Windows.Forms.Button();
            txtSymbol = new System.Windows.Forms.TextBox();
            dgExpirationDates = new System.Windows.Forms.DataGridView();
            txtOptionChain = new System.Windows.Forms.TextBox();
            txtGrokResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgExpirationDates).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(80, 469);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSymbol
            // 
            txtSymbol.Location = new System.Drawing.Point(103, 93);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new System.Drawing.Size(150, 31);
            txtSymbol.TabIndex = 1;
            txtSymbol.Leave += txtSymbol_Leave;
            // 
            // dgExpirationDates
            // 
            dgExpirationDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExpirationDates.Location = new System.Drawing.Point(80, 200);
            dgExpirationDates.Name = "dgExpirationDates";
            dgExpirationDates.RowHeadersWidth = 62;
            dgExpirationDates.Size = new System.Drawing.Size(735, 225);
            dgExpirationDates.TabIndex = 2;
            // 
            // txtOptionChain
            // 
            txtOptionChain.Location = new System.Drawing.Point(80, 525);
            txtOptionChain.Multiline = true;
            txtOptionChain.Name = "txtOptionChain";
            txtOptionChain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtOptionChain.Size = new System.Drawing.Size(1042, 173);
            txtOptionChain.TabIndex = 3;
            // 
            // txtGrokResult
            // 
            txtGrokResult.Location = new System.Drawing.Point(80, 790);
            txtGrokResult.Multiline = true;
            txtGrokResult.Name = "txtGrokResult";
            txtGrokResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtGrokResult.Size = new System.Drawing.Size(1033, 499);
            txtGrokResult.TabIndex = 4;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1338, 1371);
            Controls.Add(txtGrokResult);
            Controls.Add(txtOptionChain);
            Controls.Add(dgExpirationDates);
            Controls.Add(txtSymbol);
            Controls.Add(button1);
            Name = "OptionsForm";
            Text = "OptionsForm";
            ((System.ComponentModel.ISupportInitialize)dgExpirationDates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dgExpirationDates;
        private System.Windows.Forms.TextBox txtOptionChain;
        private System.Windows.Forms.TextBox txtGrokResult;
    }
}