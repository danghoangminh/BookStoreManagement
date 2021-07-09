
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmTaiKhoan
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
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txbMKMoi = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txbMKMoiNhapLai = new System.Windows.Forms.TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.btnCapNhap = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.dgvTaiKhoan = new System.Windows.Forms.ListView();
            this.btnChon = new System.Windows.Forms.Button();
            this.txbMKHienTai = new System.Windows.Forms.TextBox();
            this.lblMatKhauHienTai = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTenDangNhap);
            this.panel2.Controls.Add(this.lblTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(12, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 1;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(239, 24);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.ReadOnly = true;
            this.txbTenDangNhap.Size = new System.Drawing.Size(271, 27);
            this.txbTenDangNhap.TabIndex = 7;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTenDangNhap.Location = new System.Drawing.Point(3, 27);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(173, 24);
            this.lblTenDangNhap.TabIndex = 0;
            this.lblTenDangNhap.Text = "TÊN ĐĂNG NHẬP";
            this.lblTenDangNhap.Click += new System.EventHandler(this.lblTenDangNhap1_Click);
            // 
            // txbMKMoi
            // 
            this.txbMKMoi.Location = new System.Drawing.Point(251, 285);
            this.txbMKMoi.Name = "txbMKMoi";
            this.txbMKMoi.Size = new System.Drawing.Size(270, 27);
            this.txbMKMoi.TabIndex = 3;
            this.txbMKMoi.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatKhauMoi.Location = new System.Drawing.Point(15, 288);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(159, 24);
            this.lblMatKhauMoi.TabIndex = 0;
            this.lblMatKhauMoi.Text = "MẬT KHẨU MỚI";
            // 
            // txbMKMoiNhapLai
            // 
            this.txbMKMoiNhapLai.Location = new System.Drawing.Point(251, 334);
            this.txbMKMoiNhapLai.Name = "txbMKMoiNhapLai";
            this.txbMKMoiNhapLai.Size = new System.Drawing.Size(270, 27);
            this.txbMKMoiNhapLai.TabIndex = 4;
            this.txbMKMoiNhapLai.UseSystemPasswordChar = true;
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNhapLai.Location = new System.Drawing.Point(15, 337);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(100, 24);
            this.lblNhapLai.TabIndex = 0;
            this.lblNhapLai.Text = "NHẬP LẠI";
            // 
            // btnCapNhap
            // 
            this.btnCapNhap.Location = new System.Drawing.Point(11, 405);
            this.btnCapNhap.Name = "btnCapNhap";
            this.btnCapNhap.Size = new System.Drawing.Size(183, 29);
            this.btnCapNhap.TabIndex = 5;
            this.btnCapNhap.Text = "CẬP NHẬT";
            this.btnCapNhap.UseVisualStyleBackColor = true;
            this.btnCapNhap.Click += new System.EventHandler(this.bCapNhap_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(385, 405);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(136, 29);
            this.fThoat.TabIndex = 6;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.HideSelection = false;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(12, 12);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.Size = new System.Drawing.Size(510, 104);
            this.dgvTaiKhoan.TabIndex = 16;
            this.dgvTaiKhoan.UseCompatibleStateImageBehavior = false;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(11, 125);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(123, 29);
            this.btnChon.TabIndex = 17;
            this.btnChon.Text = "CHỌN";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.bChon_Click);
            // 
            // txbMKHienTai
            // 
            this.txbMKHienTai.Location = new System.Drawing.Point(251, 238);
            this.txbMKHienTai.Name = "txbMKHienTai";
            this.txbMKHienTai.Size = new System.Drawing.Size(270, 27);
            this.txbMKHienTai.TabIndex = 3;
            this.txbMKHienTai.UseSystemPasswordChar = true;
            // 
            // lblMatKhauHienTai
            // 
            this.lblMatKhauHienTai.AutoSize = true;
            this.lblMatKhauHienTai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatKhauHienTai.Location = new System.Drawing.Point(15, 241);
            this.lblMatKhauHienTai.Name = "lblMatKhauHienTai";
            this.lblMatKhauHienTai.Size = new System.Drawing.Size(203, 24);
            this.lblMatKhauHienTai.TabIndex = 0;
            this.lblMatKhauHienTai.Text = "MẬT KHẨU HIỆN TẠI";
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(533, 442);
            this.Controls.Add(this.txbMKHienTai);
            this.Controls.Add(this.txbMKMoiNhapLai);
            this.Controls.Add(this.txbMKMoi);
            this.Controls.Add(this.lblNhapLai);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lblMatKhauHienTai);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.btnCapNhap);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN TÀI KHOẢN";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txbMKMoi;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txbMKMoiNhapLai;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.Button btnCapNhap;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.ListView dgvTaiKhoan;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txbMKHienTai;
        private System.Windows.Forms.Label lblMatKhauHienTai;
    }
}