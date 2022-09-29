namespace TdInterface
{
    partial class MasterForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCredentialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewTrade = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCredentialsToolStripMenuItem,
            this.saveCredentialsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearCredentialsToolStripMenuItem
            // 
            this.clearCredentialsToolStripMenuItem.Name = "clearCredentialsToolStripMenuItem";
            this.clearCredentialsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.clearCredentialsToolStripMenuItem.Text = "Clear Credentials";
            this.clearCredentialsToolStripMenuItem.Click += new System.EventHandler(this.clearCredentialsToolStripMenuItem_Click);
            // 
            // saveCredentialsToolStripMenuItem
            // 
            this.saveCredentialsToolStripMenuItem.Name = "saveCredentialsToolStripMenuItem";
            this.saveCredentialsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.saveCredentialsToolStripMenuItem.Text = "Save Credentials";
            this.saveCredentialsToolStripMenuItem.Click += new System.EventHandler(this.saveCredentialsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // btnNewTrade
            // 
            this.btnNewTrade.Location = new System.Drawing.Point(292, 270);
            this.btnNewTrade.Name = "btnNewTrade";
            this.btnNewTrade.Size = new System.Drawing.Size(94, 29);
            this.btnNewTrade.TabIndex = 1;
            this.btnNewTrade.Text = "New Trade";
            this.btnNewTrade.UseVisualStyleBackColor = true;
            this.btnNewTrade.Click += new System.EventHandler(this.btnNewTrade_Click);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewTrade);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCredentialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Button btnNewTrade;
    }
}