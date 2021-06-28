
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fThemKho
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
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.txMaSach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.txSoLuong = new System.Windows.Forms.Label();
            this.bThem = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMaSach);
            this.panel2.Controls.Add(this.txMaSach);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 2;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(182, 23);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(328, 28);
            this.cbMaSach.TabIndex = 1;
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
            this.panel1.Controls.Add(this.numericUpDown_SoLuong);
            this.panel1.Controls.Add(this.txSoLuong);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 75);
            this.panel1.TabIndex = 3;
            // 
            // numericUpDown_SoLuong
            // 
            this.numericUpDown_SoLuong.Location = new System.Drawing.Point(182, 24);
            this.numericUpDown_SoLuong.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_SoLuong.Name = "numericUpDown_SoLuong";
            this.numericUpDown_SoLuong.Size = new System.Drawing.Size(328, 27);
            this.numericUpDown_SoLuong.TabIndex = 1;
            this.numericUpDown_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txSoLuong
            // 
            this.txSoLuong.AutoSize = true;
            this.txSoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSoLuong.Location = new System.Drawing.Point(3, 28);
            this.txSoLuong.Name = "txSoLuong";
            this.txSoLuong.Size = new System.Drawing.Size(119, 23);
            this.txSoLuong.TabIndex = 0;
            this.txSoLuong.Text = "SỐ LƯỢNG";
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(12, 184);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(184, 29);
            this.bThem.TabIndex = 10;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(404, 184);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 12;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fThemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 222);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fThemKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Label txMaSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_SoLuong;
        private System.Windows.Forms.Label txSoLuong;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button fThoat;
    }
}