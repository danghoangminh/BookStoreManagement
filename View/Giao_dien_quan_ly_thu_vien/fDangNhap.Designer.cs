
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fDangNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bThoat = new System.Windows.Forms.Button();
            this.bDangNhap = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txMatKhau = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txTenDangNhap = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bThoat);
            this.panel1.Controls.Add(this.bDangNhap);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 198);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bThoat
            // 
            this.bThoat.Location = new System.Drawing.Point(392, 162);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(121, 29);
            this.bThoat.TabIndex = 4;
            this.bThoat.Text = "THOÁT";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // bDangNhap
            // 
            this.bDangNhap.Location = new System.Drawing.Point(185, 162);
            this.bDangNhap.Name = "bDangNhap";
            this.bDangNhap.Size = new System.Drawing.Size(121, 29);
            this.bDangNhap.TabIndex = 3;
            this.bDangNhap.Text = "ĐĂNG NHẬP";
            this.bDangNhap.UseVisualStyleBackColor = true;
            this.bDangNhap.Click += new System.EventHandler(this.bDangNhap_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMatKhau);
            this.panel3.Controls.Add(this.txMatKhau);
            this.panel3.Location = new System.Drawing.Point(3, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 75);
            this.panel3.TabIndex = 2;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(182, 24);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(328, 27);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // txMatKhau
            // 
            this.txMatKhau.AutoSize = true;
            this.txMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMatKhau.Location = new System.Drawing.Point(3, 27);
            this.txMatKhau.Name = "txMatKhau";
            this.txMatKhau.Size = new System.Drawing.Size(116, 23);
            this.txMatKhau.TabIndex = 0;
            this.txMatKhau.Text = "MẬT KHẨU:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTenDangNhap);
            this.panel2.Controls.Add(this.txTenDangNhap);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 0;
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(182, 24);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(328, 27);
            this.txbTenDangNhap.TabIndex = 1;
            // 
            // txTenDangNhap
            // 
            this.txTenDangNhap.AutoSize = true;
            this.txTenDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTenDangNhap.Location = new System.Drawing.Point(3, 27);
            this.txTenDangNhap.Name = "txTenDangNhap";
            this.txTenDangNhap.Size = new System.Drawing.Size(174, 23);
            this.txTenDangNhap.TabIndex = 0;
            this.txTenDangNhap.Text = "TÊN ĐĂNG NHẬP:";
            // 
            // fDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 220);
            this.Controls.Add(this.panel1);
            this.Name = "fDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txTenDangNhap;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label txMatKhau;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Button bDangNhap;
        private System.Windows.Forms.Button bThoat;
    }
}