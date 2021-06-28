
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fThongKe
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
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            this.txTuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txDenNgay = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.fThoat = new System.Windows.Forms.Button();
            this.bXuatBC = new System.Windows.Forms.Button();
            this.bTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(8, 8);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.RowHeadersWidth = 51;
            this.dataGridView_HoaDon.RowTemplate.Height = 29;
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(1425, 438);
            this.dataGridView_HoaDon.TabIndex = 13;
            // 
            // txTuNgay
            // 
            this.txTuNgay.AutoSize = true;
            this.txTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTuNgay.Location = new System.Drawing.Point(3, 14);
            this.txTuNgay.Name = "txTuNgay";
            this.txTuNgay.Size = new System.Drawing.Size(80, 23);
            this.txTuNgay.TabIndex = 14;
            this.txTuNgay.Text = "TỪ NGÀY";
            // 
            // dateTimePicker_TuNgay
            // 
            this.dateTimePicker_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_TuNgay.Location = new System.Drawing.Point(109, 10);
            this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            this.dateTimePicker_TuNgay.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_TuNgay.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txTuNgay);
            this.panel1.Controls.Add(this.dateTimePicker_TuNgay);
            this.panel1.Location = new System.Drawing.Point(12, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 48);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txDenNgay);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(378, 463);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 48);
            this.panel2.TabIndex = 17;
            // 
            // txDenNgay
            // 
            this.txDenNgay.AutoSize = true;
            this.txDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txDenNgay.Location = new System.Drawing.Point(2, 14);
            this.txDenNgay.Name = "txDenNgay";
            this.txDenNgay.Size = new System.Drawing.Size(93, 23);
            this.txDenNgay.TabIndex = 14;
            this.txDenNgay.Text = "ĐẾN NGÀY";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(1312, 472);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 18;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // bXuatBC
            // 
            this.bXuatBC.Location = new System.Drawing.Point(12, 522);
            this.bXuatBC.Name = "bXuatBC";
            this.bXuatBC.Size = new System.Drawing.Size(277, 29);
            this.bXuatBC.TabIndex = 19;
            this.bXuatBC.Text = "XUẤT BÁO CÁO";
            this.bXuatBC.UseVisualStyleBackColor = true;
            this.bXuatBC.Click += new System.EventHandler(this.bXuatBC_Click);
            // 
            // bTimKiem
            // 
            this.bTimKiem.Location = new System.Drawing.Point(794, 471);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(143, 29);
            this.bTimKiem.TabIndex = 20;
            this.bTimKiem.Text = "TÌM KIẾM";
            this.bTimKiem.UseVisualStyleBackColor = true;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 563);
            this.Controls.Add(this.bTimKiem);
            this.Controls.Add(this.bXuatBC);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_HoaDon);
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
        private System.Windows.Forms.Label txTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TuNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bXuatBC;
        private System.Windows.Forms.Button bTimKiem;
    }
}