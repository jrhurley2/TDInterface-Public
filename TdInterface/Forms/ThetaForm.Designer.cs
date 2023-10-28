namespace TdInterface.Forms
{
    partial class ThetaForm
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
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnGetTransactions = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(205, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "txtSymbol";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(120, 133);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Symbol";
            // 
            // btnGetTransactions
            // 
            btnGetTransactions.Location = new System.Drawing.Point(199, 248);
            btnGetTransactions.Name = "btnGetTransactions";
            btnGetTransactions.Size = new System.Drawing.Size(94, 29);
            btnGetTransactions.TabIndex = 2;
            btnGetTransactions.Text = "GetTransactions";
            btnGetTransactions.UseVisualStyleBackColor = true;
            btnGetTransactions.Click += btnGetTransactions_Click;
            // 
            // ThetaForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnGetTransactions);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ThetaForm";
            Text = "ThetaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetTransactions;
    }
}