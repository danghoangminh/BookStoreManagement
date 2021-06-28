
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fXoaSach
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txMaSach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTenSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbTenTacGia = new System.Windows.Forms.TextBox();
            this.txTenTacGia = new System.Windows.Forms.Label();
            this.bXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txMaSach);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // txMaSach
            // 
            this.txMaSach.AutoSize = true;
            this.txMaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMaSach.Location = new System.Drawing.Point(3, 28);
            this.txMaSach.Name = "txMaSach";
            this.txMaSach.Size = new System.Drawing.Size(99, 23);
            this.txMaSach.TabIndex = 0;
            this.txMaSach.Text = "MÃ SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTenSach);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 75);
            this.panel1.TabIndex = 4;
            // 
            // txbTenSach
            // 
            this.txbTenSach.Location = new System.Drawing.Point(182, 24);
            this.txbTenSach.Name = "txbTenSach";
            this.txbTenSach.ReadOnly = true;
            this.txbTenSach.Size = new System.Drawing.Size(328, 27);
            this.txbTenSach.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN SÁCH";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTenTacGia);
            this.panel3.Controls.Add(this.txTenTacGia);
            this.panel3.Location = new System.Drawing.Point(12, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 75);
            this.panel3.TabIndex = 5;
            // 
            // txbTenTacGia
            // 
            this.txbTenTacGia.Location = new System.Drawing.Point(182, 24);
            this.txbTenTacGia.Name = "txbTenTacGia";
            this.txbTenTacGia.ReadOnly = true;
            this.txbTenTacGia.Size = new System.Drawing.Size(328, 27);
            this.txbTenTacGia.TabIndex = 2;
            // 
            // txTenTacGia
            // 
            this.txTenTacGia.AutoSize = true;
            this.txTenTacGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTenTacGia.Location = new System.Drawing.Point(3, 28);
            this.txTenTacGia.Name = "txTenTacGia";
            this.txTenTacGia.Size = new System.Drawing.Size(134, 23);
            this.txTenTacGia.TabIndex = 0;
            this.txTenTacGia.Text = "TÊN TÁC GIẢ";
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(12, 267);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(183, 29);
            this.bXoa.TabIndex = 13;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(404, 267);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fXoaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 310);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fXoaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txMaSach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbTenTacGia;
        private System.Windows.Forms.Label txTenTacGia;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button fThoat;
    }
}