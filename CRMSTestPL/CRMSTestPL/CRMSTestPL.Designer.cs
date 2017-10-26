namespace CRMSTestPL
{
    partial class CRMSTestPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRMSTestPL));
            this.btnTestConn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.txtToKhaiData = new System.Windows.Forms.RichTextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPhanLuong = new System.Windows.Forms.Button();
            this.cboLoaiNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQuaPL = new System.Windows.Forms.RichTextBox();
            this.dgvTieuChi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGiaTriDinh = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTieuChi_CT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaTriDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuChi_CT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(334, 12);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(112, 28);
            this.btnTestConn.TabIndex = 0;
            this.btnTestConn.Text = "Lấy dữ liệu tờ khai";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tờ khai";
            // 
            // txtSoTK
            // 
            this.txtSoTK.Location = new System.Drawing.Point(73, 17);
            this.txtSoTK.MaxLength = 12;
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(255, 20);
            this.txtSoTK.TabIndex = 2;
            // 
            // txtToKhaiData
            // 
            this.txtToKhaiData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtToKhaiData.Location = new System.Drawing.Point(12, 46);
            this.txtToKhaiData.Name = "txtToKhaiData";
            this.txtToKhaiData.Size = new System.Drawing.Size(434, 440);
            this.txtToKhaiData.TabIndex = 5;
            this.txtToKhaiData.Text = "";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(563, 17);
            this.txtURL.MaxLength = 12;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(323, 20);
            this.txtURL.TabIndex = 6;
            this.txtURL.Text = "http://10.15.119.17:8011";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "RESTFull service:";
            // 
            // btnPhanLuong
            // 
            this.btnPhanLuong.Location = new System.Drawing.Point(892, 12);
            this.btnPhanLuong.Name = "btnPhanLuong";
            this.btnPhanLuong.Size = new System.Drawing.Size(112, 28);
            this.btnPhanLuong.TabIndex = 8;
            this.btnPhanLuong.Text = "Phân luồng";
            this.btnPhanLuong.UseVisualStyleBackColor = true;
            this.btnPhanLuong.Click += new System.EventHandler(this.btnPhanLuong_Click);
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.FormattingEnabled = true;
            this.cboLoaiNV.Location = new System.Drawing.Point(563, 46);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Size = new System.Drawing.Size(231, 21);
            this.cboLoaiNV.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại nghiệp vụ:";
            // 
            // txtKetQuaPL
            // 
            this.txtKetQuaPL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKetQuaPL.Location = new System.Drawing.Point(468, 73);
            this.txtKetQuaPL.Name = "txtKetQuaPL";
            this.txtKetQuaPL.Size = new System.Drawing.Size(536, 129);
            this.txtKetQuaPL.TabIndex = 11;
            this.txtKetQuaPL.Text = "";
            // 
            // dgvTieuChi
            // 
            this.dgvTieuChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieuChi.Location = new System.Drawing.Point(468, 221);
            this.dgvTieuChi.Name = "dgvTieuChi";
            this.dgvTieuChi.Size = new System.Drawing.Size(536, 94);
            this.dgvTieuChi.TabIndex = 12;
            this.dgvTieuChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTieuChi_CellClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Danh sách tiêu chí dính";
            // 
            // dgvGiaTriDinh
            // 
            this.dgvGiaTriDinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaTriDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaTriDinh.Location = new System.Drawing.Point(468, 420);
            this.dgvGiaTriDinh.Name = "dgvGiaTriDinh";
            this.dgvGiaTriDinh.Size = new System.Drawing.Size(536, 66);
            this.dgvGiaTriDinh.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh sách giá trị dính";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(465, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tiêu chí chi tiết";
            // 
            // dgvTieuChi_CT
            // 
            this.dgvTieuChi_CT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTieuChi_CT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTieuChi_CT.Location = new System.Drawing.Point(468, 335);
            this.dgvTieuChi_CT.Name = "dgvTieuChi_CT";
            this.dgvTieuChi_CT.Size = new System.Drawing.Size(536, 66);
            this.dgvTieuChi_CT.TabIndex = 16;
            // 
            // CRMSTestPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvTieuChi_CT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvGiaTriDinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvTieuChi);
            this.Controls.Add(this.txtKetQuaPL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLoaiNV);
            this.Controls.Add(this.btnPhanLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtToKhaiData);
            this.Controls.Add(this.txtSoTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestConn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CRMSTestPL";
            this.Text = "CRMS (Customs Risk Management System)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaTriDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuChi_CT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.RichTextBox txtToKhaiData;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPhanLuong;
        private System.Windows.Forms.ComboBox cboLoaiNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtKetQuaPL;
        private System.Windows.Forms.DataGridView dgvTieuChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGiaTriDinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvTieuChi_CT;
    }
}