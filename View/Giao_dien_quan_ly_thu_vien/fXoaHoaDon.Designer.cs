
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fXoaHoaDon
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txMaHoaDon = new System.Windows.Forms.Label();
            this.cbMaKhachHang = new System.Windows.Forms.ComboBox();
            this.bXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbMaKhachHang);
            this.panel3.Controls.Add(this.txMaHoaDon);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 75);
            this.panel3.TabIndex = 5;
            // 
            // txMaHoaDon
            // 
            this.txMaHoaDon.AutoSize = true;
            this.txMaHoaDon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMaHoaDon.Location = new System.Drawing.Point(3, 28);
            this.txMaHoaDon.Name = "txMaHoaDon";
            this.txMaHoaDon.Size = new System.Drawing.Size(137, 23);
            this.txMaHoaDon.TabIndex = 0;
            this.txMaHoaDon.Text = "MÃ HÓA ĐƠN";
            // 
            // cbMaKhachHang
            // 
            this.cbMaKhachHang.FormattingEnabled = true;
            this.cbMaKhachHang.Location = new System.Drawing.Point(210, 23);
            this.cbMaKhachHang.Name = "cbMaKhachHang";
            this.cbMaKhachHang.Size = new System.Drawing.Size(328, 28);
            this.cbMaKhachHang.TabIndex = 4;
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(12, 107);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(183, 29);
            this.bXoa.TabIndex = 15;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(429, 107);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 16;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fXoaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 148);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.panel3);
            this.Name = "fXoaHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txMaHoaDon;
        private System.Windows.Forms.ComboBox cbMaKhachHang;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button fThoat;
    }
}