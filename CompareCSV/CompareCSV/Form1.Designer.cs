namespace CompareCSV
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.btnCSV1 = new System.Windows.Forms.Button();
            this.btnCSV2 = new System.Windows.Forms.Button();
            this.txtPathCSV1 = new System.Windows.Forms.TextBox();
            this.txtPathCSV2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCompareCSVFile = new System.Windows.Forms.Button();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "csv files (*.csv)|*.csv";
            // 
            // btnCSV1
            // 
            this.btnCSV1.Location = new System.Drawing.Point(434, 19);
            this.btnCSV1.Name = "btnCSV1";
            this.btnCSV1.Size = new System.Drawing.Size(108, 23);
            this.btnCSV1.TabIndex = 0;
            this.btnCSV1.Text = "Choose file CSV 1";
            this.btnCSV1.UseVisualStyleBackColor = true;
            this.btnCSV1.Click += new System.EventHandler(this.btnCSV1_Click);
            // 
            // btnCSV2
            // 
            this.btnCSV2.Location = new System.Drawing.Point(434, 54);
            this.btnCSV2.Name = "btnCSV2";
            this.btnCSV2.Size = new System.Drawing.Size(108, 23);
            this.btnCSV2.TabIndex = 1;
            this.btnCSV2.Text = "Choose file CSV 2";
            this.btnCSV2.UseVisualStyleBackColor = true;
            this.btnCSV2.Click += new System.EventHandler(this.btnCSV2_Click);
            // 
            // txtPathCSV1
            // 
            this.txtPathCSV1.Location = new System.Drawing.Point(21, 21);
            this.txtPathCSV1.Name = "txtPathCSV1";
            this.txtPathCSV1.ReadOnly = true;
            this.txtPathCSV1.Size = new System.Drawing.Size(407, 20);
            this.txtPathCSV1.TabIndex = 2;
            // 
            // txtPathCSV2
            // 
            this.txtPathCSV2.Location = new System.Drawing.Point(21, 57);
            this.txtPathCSV2.Name = "txtPathCSV2";
            this.txtPathCSV2.ReadOnly = true;
            this.txtPathCSV2.Size = new System.Drawing.Size(407, 20);
            this.txtPathCSV2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colStatus});
            this.dataGridView1.Location = new System.Drawing.Point(21, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 241);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnCompareCSVFile
            // 
            this.btnCompareCSVFile.Location = new System.Drawing.Point(21, 93);
            this.btnCompareCSVFile.Name = "btnCompareCSVFile";
            this.btnCompareCSVFile.Size = new System.Drawing.Size(110, 23);
            this.btnCompareCSVFile.TabIndex = 6;
            this.btnCompareCSVFile.Text = "Compare 2 CSV File";
            this.btnCompareCSVFile.UseVisualStyleBackColor = true;
            this.btnCompareCSVFile.Click += new System.EventHandler(this.btnCompareCSVFile_Click);
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Width = 500;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.btnCompareCSVFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPathCSV2);
            this.Controls.Add(this.txtPathCSV1);
            this.Controls.Add(this.btnCSV2);
            this.Controls.Add(this.btnCSV1);
            this.Name = "Form1";
            this.Text = "Compare two CSV file";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnCSV1;
        private System.Windows.Forms.Button btnCSV2;
        private System.Windows.Forms.TextBox txtPathCSV1;
        private System.Windows.Forms.TextBox txtPathCSV2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCompareCSVFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}

