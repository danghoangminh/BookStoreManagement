
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fBaoCao
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txTongDoanhThu = new System.Windows.Forms.Label();
            this.txbTongDoanhThu = new System.Windows.Forms.TextBox();
            this.txLoiNhuan = new System.Windows.Forms.Label();
            this.txbLoiNhuan = new System.Windows.Forms.TextBox();
            this.bThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(795, 406);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txTongDoanhThu
            // 
            this.txTongDoanhThu.AutoSize = true;
            this.txTongDoanhThu.Location = new System.Drawing.Point(12, 433);
            this.txTongDoanhThu.Name = "txTongDoanhThu";
            this.txTongDoanhThu.Size = new System.Drawing.Size(143, 20);
            this.txTongDoanhThu.TabIndex = 1;
            this.txTongDoanhThu.Text = "TỔNG DOANH THU:";
            // 
            // txbTongDoanhThu
            // 
            this.txbTongDoanhThu.BackColor = System.Drawing.SystemColors.Control;
            this.txbTongDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTongDoanhThu.Location = new System.Drawing.Point(161, 430);
            this.txbTongDoanhThu.Name = "txbTongDoanhThu";
            this.txbTongDoanhThu.Size = new System.Drawing.Size(216, 23);
            this.txbTongDoanhThu.TabIndex = 2;
            // 
            // txLoiNhuan
            // 
            this.txLoiNhuan.AutoSize = true;
            this.txLoiNhuan.Location = new System.Drawing.Point(12, 471);
            this.txLoiNhuan.Name = "txLoiNhuan";
            this.txLoiNhuan.Size = new System.Drawing.Size(91, 20);
            this.txLoiNhuan.TabIndex = 3;
            this.txLoiNhuan.Text = "LỢI NHUẬN:";
            // 
            // txbLoiNhuan
            // 
            this.txbLoiNhuan.BackColor = System.Drawing.SystemColors.Control;
            this.txbLoiNhuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLoiNhuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbLoiNhuan.Location = new System.Drawing.Point(161, 468);
            this.txbLoiNhuan.Name = "txbLoiNhuan";
            this.txbLoiNhuan.Size = new System.Drawing.Size(216, 23);
            this.txbLoiNhuan.TabIndex = 4;
            // 
            // bThoat
            // 
            this.bThoat.Location = new System.Drawing.Point(677, 462);
            this.bThoat.Name = "bThoat";
            this.bThoat.Size = new System.Drawing.Size(121, 29);
            this.bThoat.TabIndex = 5;
            this.bThoat.Text = "THOÁT";
            this.bThoat.UseVisualStyleBackColor = true;
            this.bThoat.Click += new System.EventHandler(this.bThoat_Click);
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 514);
            this.Controls.Add(this.bThoat);
            this.Controls.Add(this.txbLoiNhuan);
            this.Controls.Add(this.txLoiNhuan);
            this.Controls.Add(this.txbTongDoanhThu);
            this.Controls.Add(this.txTongDoanhThu);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label txTongDoanhThu;
        private System.Windows.Forms.TextBox txbTongDoanhThu;
        private System.Windows.Forms.Label txLoiNhuan;
        private System.Windows.Forms.TextBox txbLoiNhuan;
        private System.Windows.Forms.Button bThoat;
    }
}