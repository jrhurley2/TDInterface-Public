namespace TdInterface.Forms
{
    partial class StockPreferenceForm
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            limitOffsetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            minimumRiskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stockPreferenceBindingSource = new System.Windows.Forms.BindingSource(components);
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockPreferenceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { stockDataGridViewTextBoxColumn, limitOffsetDataGridViewTextBoxColumn, minimumRiskDataGridViewTextBoxColumn });
            dataGridView1.DataSource = stockPreferenceBindingSource;
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(428, 353);
            dataGridView1.TabIndex = 0;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.MinimumWidth = 6;
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.Width = 125;
            // 
            // limitOffsetDataGridViewTextBoxColumn
            // 
            limitOffsetDataGridViewTextBoxColumn.DataPropertyName = "LimitOffset";
            limitOffsetDataGridViewTextBoxColumn.HeaderText = "LimitOffset";
            limitOffsetDataGridViewTextBoxColumn.MinimumWidth = 6;
            limitOffsetDataGridViewTextBoxColumn.Name = "limitOffsetDataGridViewTextBoxColumn";
            limitOffsetDataGridViewTextBoxColumn.Width = 125;
            // 
            // minimumRiskDataGridViewTextBoxColumn
            // 
            minimumRiskDataGridViewTextBoxColumn.DataPropertyName = "MinimumRisk";
            minimumRiskDataGridViewTextBoxColumn.HeaderText = "MinimumRisk";
            minimumRiskDataGridViewTextBoxColumn.MinimumWidth = 6;
            minimumRiskDataGridViewTextBoxColumn.Name = "minimumRiskDataGridViewTextBoxColumn";
            minimumRiskDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockPreferenceBindingSource
            // 
            stockPreferenceBindingSource.DataSource = typeof(Model.StockPreference);
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(27, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(94, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(127, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // StockPreferenceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dataGridView1);
            Name = "StockPreferenceForm";
            Text = "StockPreferenceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockPreferenceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitOffsetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimumRiskDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockPreferenceBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}