
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fXoaTacGia
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
            this.cbMaTacGia = new System.Windows.Forms.ComboBox();
            this.txMaTacGia = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTenTacGia = new System.Windows.Forms.TextBox();
            this.txTenTacGia = new System.Windows.Forms.Label();
            this.bXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMaTacGia);
            this.panel2.Controls.Add(this.txMaTacGia);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 3;
            // 
            // cbMaTacGia
            // 
            this.cbMaTacGia.FormattingEnabled = true;
            this.cbMaTacGia.Location = new System.Drawing.Point(182, 23);
            this.cbMaTacGia.Name = "cbMaTacGia";
            this.cbMaTacGia.Size = new System.Drawing.Size(328, 28);
            this.cbMaTacGia.TabIndex = 5;
            // 
            // txMaTacGia
            // 
            this.txMaTacGia.AutoSize = true;
            this.txMaTacGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMaTacGia.Location = new System.Drawing.Point(3, 28);
            this.txMaTacGia.Name = "txMaTacGia";
            this.txMaTacGia.Size = new System.Drawing.Size(126, 23);
            this.txMaTacGia.TabIndex = 0;
            this.txMaTacGia.Text = "MÃ TÁC GIẢ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTenTacGia);
            this.panel1.Controls.Add(this.txTenTacGia);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 75);
            this.panel1.TabIndex = 4;
            // 
            // txbTenTacGia
            // 
            this.txbTenTacGia.Location = new System.Drawing.Point(182, 24);
            this.txbTenTacGia.Name = "txbTenTacGia";
            this.txbTenTacGia.ReadOnly = true;
            this.txbTenTacGia.Size = new System.Drawing.Size(328, 27);
            this.txbTenTacGia.TabIndex = 1;
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
            this.bXoa.Location = new System.Drawing.Point(12, 190);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(183, 29);
            this.bXoa.TabIndex = 16;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(403, 190);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 17;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fXoaTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 232);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fXoaTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txMaTacGia;
        private System.Windows.Forms.ComboBox cbMaTacGia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenTacGia;
        private System.Windows.Forms.Label txTenTacGia;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button fThoat;
    }
}