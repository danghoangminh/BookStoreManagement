
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmThemTacGia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbMaTacGia = new System.Windows.Forms.TextBox();
            this.lblMaTacGia = new System.Windows.Forms.Label();
            this.txbTenTacGia = new System.Windows.Forms.TextBox();
            this.lblTenTacGia = new System.Windows.Forms.Label();
            this.chkQueQuan = new System.Windows.Forms.CheckBox();
            this.txbQueQuan = new System.Windows.Forms.TextBox();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.chkNgaySinh = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.chkNgayMat = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_NgayMat = new System.Windows.Forms.DateTimePicker();
            this.lblNgayMat = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbMaTacGia);
            this.panel2.Controls.Add(this.lblMaTacGia);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 2;
            // 
            // txbMaTacGia
            // 
            this.txbMaTacGia.Location = new System.Drawing.Point(182, 24);
            this.txbMaTacGia.Name = "txbMaTacGia";
            this.txbMaTacGia.ReadOnly = true;
            this.txbMaTacGia.Size = new System.Drawing.Size(328, 27);
            this.txbMaTacGia.TabIndex = 1;
            // 
            // lblMaTacGia
            // 
            this.lblMaTacGia.AutoSize = true;
            this.lblMaTacGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaTacGia.Location = new System.Drawing.Point(3, 28);
            this.lblMaTacGia.Name = "lblMaTacGia";
            this.lblMaTacGia.Size = new System.Drawing.Size(126, 23);
            this.lblMaTacGia.TabIndex = 0;
            this.lblMaTacGia.Text = "MÃ TÁC GIẢ";
            // 
            // txbTenTacGia
            // 
            this.txbTenTacGia.Location = new System.Drawing.Point(194, 96);
            this.txbTenTacGia.Name = "txbTenTacGia";
            this.txbTenTacGia.Size = new System.Drawing.Size(328, 27);
            this.txbTenTacGia.TabIndex = 1;
            // 
            // lblTenTacGia
            // 
            this.lblTenTacGia.AutoSize = true;
            this.lblTenTacGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenTacGia.Location = new System.Drawing.Point(15, 100);
            this.lblTenTacGia.Name = "lblTenTacGia";
            this.lblTenTacGia.Size = new System.Drawing.Size(134, 23);
            this.lblTenTacGia.TabIndex = 0;
            this.lblTenTacGia.Text = "TÊN TÁC GIẢ";
            // 
            // chkQueQuan
            // 
            this.chkQueQuan.AutoSize = true;
            this.chkQueQuan.Location = new System.Drawing.Point(426, 144);
            this.chkQueQuan.Name = "chkQueQuan";
            this.chkQueQuan.Size = new System.Drawing.Size(96, 24);
            this.chkQueQuan.TabIndex = 11;
            this.chkQueQuan.Text = "CHƯA RÕ";
            this.chkQueQuan.UseVisualStyleBackColor = true;
            this.chkQueQuan.CheckedChanged += new System.EventHandler(this.checkBox_QueQuan_CheckedChanged);
            // 
            // txbQueQuan
            // 
            this.txbQueQuan.Location = new System.Drawing.Point(194, 144);
            this.txbQueQuan.Name = "txbQueQuan";
            this.txbQueQuan.Size = new System.Drawing.Size(226, 27);
            this.txbQueQuan.TabIndex = 1;
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQueQuan.Location = new System.Drawing.Point(19, 148);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(113, 23);
            this.lblQueQuan.TabIndex = 0;
            this.lblQueQuan.Text = "QUÊ QUÁN";
            // 
            // chkNgaySinh
            // 
            this.chkNgaySinh.AutoSize = true;
            this.chkNgaySinh.Location = new System.Drawing.Point(426, 194);
            this.chkNgaySinh.Name = "chkNgaySinh";
            this.chkNgaySinh.Size = new System.Drawing.Size(96, 24);
            this.chkNgaySinh.TabIndex = 10;
            this.chkNgaySinh.Text = "CHƯA RÕ";
            this.chkNgaySinh.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(194, 194);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(226, 27);
            this.dateTimePicker_NgaySinh.TabIndex = 9;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgaySinh.Location = new System.Drawing.Point(19, 198);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(117, 23);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "NGÀY SINH";
            // 
            // chkNgayMat
            // 
            this.chkNgayMat.AutoSize = true;
            this.chkNgayMat.Location = new System.Drawing.Point(426, 245);
            this.chkNgayMat.Name = "chkNgayMat";
            this.chkNgayMat.Size = new System.Drawing.Size(96, 24);
            this.chkNgayMat.TabIndex = 11;
            this.chkNgayMat.Text = "CHƯA RÕ";
            this.chkNgayMat.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_NgayMat
            // 
            this.dateTimePicker_NgayMat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgayMat.Location = new System.Drawing.Point(194, 245);
            this.dateTimePicker_NgayMat.Name = "dateTimePicker_NgayMat";
            this.dateTimePicker_NgayMat.Size = new System.Drawing.Size(226, 27);
            this.dateTimePicker_NgayMat.TabIndex = 9;
            // 
            // lblNgayMat
            // 
            this.lblNgayMat.AutoSize = true;
            this.lblNgayMat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgayMat.Location = new System.Drawing.Point(22, 249);
            this.lblNgayMat.Name = "lblNgayMat";
            this.lblNgayMat.Size = new System.Drawing.Size(114, 23);
            this.lblNgayMat.TabIndex = 0;
            this.lblNgayMat.Text = "NGÀY MẤT";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 305);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(215, 29);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(404, 305);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // frmThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 343);
            this.Controls.Add(this.chkNgayMat);
            this.Controls.Add(this.chkNgaySinh);
            this.Controls.Add(this.dateTimePicker_NgayMat);
            this.Controls.Add(this.chkQueQuan);
            this.Controls.Add(this.lblNgayMat);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.txbTenTacGia);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txbQueQuan);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.lblTenTacGia);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThemTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM TÁC GIẢ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbMaTacGia;
        private System.Windows.Forms.Label lblMaTacGia;
        private System.Windows.Forms.TextBox txbTenTacGia;
        private System.Windows.Forms.Label lblTenTacGia;
        private System.Windows.Forms.TextBox txbQueQuan;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgayMat;
        private System.Windows.Forms.Label lblNgayMat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.CheckBox chkNgaySinh;
        private System.Windows.Forms.CheckBox chkNgayMat;
        private System.Windows.Forms.CheckBox chkQueQuan;
    }
}