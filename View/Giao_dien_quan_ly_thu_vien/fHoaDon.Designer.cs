
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fHoaDon
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
            this.fThoat = new System.Windows.Forms.Button();
            this.bThem = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            this.bChiTietHoaDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(1316, 465);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 8;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(12, 465);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(124, 29);
            this.bThem.TabIndex = 9;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(180, 465);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(124, 29);
            this.bXoa.TabIndex = 10;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // bSua
            // 
            this.bSua.Location = new System.Drawing.Point(351, 465);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(124, 29);
            this.bSua.TabIndex = 11;
            this.bSua.Text = "SỬA";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.RowHeadersWidth = 51;
            this.dataGridView_HoaDon.RowTemplate.Height = 29;
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(1425, 438);
            this.dataGridView_HoaDon.TabIndex = 12;
            // 
            // bChiTietHoaDon
            // 
            this.bChiTietHoaDon.Location = new System.Drawing.Point(756, 463);
            this.bChiTietHoaDon.Name = "bChiTietHoaDon";
            this.bChiTietHoaDon.Size = new System.Drawing.Size(365, 29);
            this.bChiTietHoaDon.TabIndex = 13;
            this.bChiTietHoaDon.Text = "CHI TIẾT HÓA ĐƠN";
            this.bChiTietHoaDon.UseVisualStyleBackColor = true;
            this.bChiTietHoaDon.Click += new System.EventHandler(this.bChiTietHoaDon_Click);
            // 
            // fHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 504);
            this.Controls.Add(this.bChiTietHoaDon);
            this.Controls.Add(this.dataGridView_HoaDon);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.fThoat);
            this.Name = "fHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HÓA ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
        private System.Windows.Forms.Button bChiTietHoaDon;
    }
}