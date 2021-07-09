
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmKho
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbMaSachThem = new System.Windows.Forms.TextBox();
            this.Nhap_numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongThem = new System.Windows.Forms.Label();
            this.bThemKho = new System.Windows.Forms.Button();
            this.txMaSach_Them = new System.Windows.Forms.Label();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaSachSua = new System.Windows.Forms.TextBox();
            this.Sua_numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongSua = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblMaSach_Sua = new System.Windows.Forms.Label();
            this.dgvChonSach = new System.Windows.Forms.ListView();
            this.lblChonSach = new System.Windows.Forms.Label();
            this.btnChonSua = new System.Windows.Forms.Button();
            this.btnChonThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nhap_numericUpDownSoLuong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sua_numericUpDownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(763, 207);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbMaSachThem);
            this.panel1.Controls.Add(this.Nhap_numericUpDownSoLuong);
            this.panel1.Controls.Add(this.lblSoLuongThem);
            this.panel1.Controls.Add(this.bThemKho);
            this.panel1.Controls.Add(this.txMaSach_Them);
            this.panel1.Location = new System.Drawing.Point(12, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 92);
            this.panel1.TabIndex = 19;
            // 
            // txbMaSachThem
            // 
            this.txbMaSachThem.Location = new System.Drawing.Point(121, 11);
            this.txbMaSachThem.Name = "txbMaSachThem";
            this.txbMaSachThem.ReadOnly = true;
            this.txbMaSachThem.Size = new System.Drawing.Size(359, 27);
            this.txbMaSachThem.TabIndex = 20;
            // 
            // Nhap_numericUpDownSoLuong
            // 
            this.Nhap_numericUpDownSoLuong.Location = new System.Drawing.Point(121, 48);
            this.Nhap_numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Nhap_numericUpDownSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nhap_numericUpDownSoLuong.Name = "Nhap_numericUpDownSoLuong";
            this.Nhap_numericUpDownSoLuong.Size = new System.Drawing.Size(175, 27);
            this.Nhap_numericUpDownSoLuong.TabIndex = 18;
            this.Nhap_numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuongThem
            // 
            this.lblSoLuongThem.AutoSize = true;
            this.lblSoLuongThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoLuongThem.Location = new System.Drawing.Point(7, 52);
            this.lblSoLuongThem.Name = "lblSoLuongThem";
            this.lblSoLuongThem.Size = new System.Drawing.Size(85, 20);
            this.lblSoLuongThem.TabIndex = 17;
            this.lblSoLuongThem.Text = "SỐ LƯỢNG:";
            // 
            // bThemKho
            // 
            this.bThemKho.Location = new System.Drawing.Point(320, 48);
            this.bThemKho.Name = "bThemKho";
            this.bThemKho.Size = new System.Drawing.Size(160, 27);
            this.bThemKho.TabIndex = 13;
            this.bThemKho.Text = "THÊM";
            this.bThemKho.UseVisualStyleBackColor = true;
            this.bThemKho.Click += new System.EventHandler(this.bThemKho_Click);
            // 
            // txMaSach_Them
            // 
            this.txMaSach_Them.AutoSize = true;
            this.txMaSach_Them.Location = new System.Drawing.Point(7, 18);
            this.txMaSach_Them.Name = "txMaSach_Them";
            this.txMaSach_Them.Size = new System.Drawing.Size(77, 20);
            this.txMaSach_Them.TabIndex = 0;
            this.txMaSach_Them.Text = "MÃ SÁCH:";
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(548, 225);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(226, 29);
            this.btnXoaSach.TabIndex = 14;
            this.btnXoaSach.Text = "XÓA SÁCH ";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.bXoaSach_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMaSachSua);
            this.panel3.Controls.Add(this.Sua_numericUpDownSoLuong);
            this.panel3.Controls.Add(this.lblSoLuongSua);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.lblMaSach_Sua);
            this.panel3.Location = new System.Drawing.Point(11, 260);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 94);
            this.panel3.TabIndex = 22;
            // 
            // txbMaSachSua
            // 
            this.txbMaSachSua.Location = new System.Drawing.Point(119, 9);
            this.txbMaSachSua.Name = "txbMaSachSua";
            this.txbMaSachSua.ReadOnly = true;
            this.txbMaSachSua.Size = new System.Drawing.Size(365, 27);
            this.txbMaSachSua.TabIndex = 19;
            // 
            // Sua_numericUpDownSoLuong
            // 
            this.Sua_numericUpDownSoLuong.Location = new System.Drawing.Point(119, 45);
            this.Sua_numericUpDownSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Sua_numericUpDownSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Sua_numericUpDownSoLuong.Name = "Sua_numericUpDownSoLuong";
            this.Sua_numericUpDownSoLuong.Size = new System.Drawing.Size(178, 27);
            this.Sua_numericUpDownSoLuong.TabIndex = 18;
            this.Sua_numericUpDownSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoLuongSua
            // 
            this.lblSoLuongSua.AutoSize = true;
            this.lblSoLuongSua.Location = new System.Drawing.Point(8, 52);
            this.lblSoLuongSua.Name = "lblSoLuongSua";
            this.lblSoLuongSua.Size = new System.Drawing.Size(85, 20);
            this.lblSoLuongSua.TabIndex = 17;
            this.lblSoLuongSua.Text = "SỐ LƯỢNG:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(321, 45);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(163, 26);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.bLuu_Click);
            // 
            // lblMaSach_Sua
            // 
            this.lblMaSach_Sua.AutoSize = true;
            this.lblMaSach_Sua.Location = new System.Drawing.Point(8, 16);
            this.lblMaSach_Sua.Name = "lblMaSach_Sua";
            this.lblMaSach_Sua.Size = new System.Drawing.Size(77, 20);
            this.lblMaSach_Sua.TabIndex = 0;
            this.lblMaSach_Sua.Text = "MÃ SÁCH:";
            // 
            // dgvChonSach
            // 
            this.dgvChonSach.BackColor = System.Drawing.SystemColors.Info;
            this.dgvChonSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvChonSach.HideSelection = false;
            this.dgvChonSach.Location = new System.Drawing.Point(11, 397);
            this.dgvChonSach.Name = "dgvChonSach";
            this.dgvChonSach.Size = new System.Drawing.Size(766, 165);
            this.dgvChonSach.TabIndex = 23;
            this.dgvChonSach.UseCompatibleStateImageBehavior = false;
            // 
            // lblChonSach
            // 
            this.lblChonSach.AutoSize = true;
            this.lblChonSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChonSach.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblChonSach.Location = new System.Drawing.Point(12, 370);
            this.lblChonSach.Name = "lblChonSach";
            this.lblChonSach.Size = new System.Drawing.Size(129, 24);
            this.lblChonSach.TabIndex = 24;
            this.lblChonSach.Text = "CHỌN SÁCH";
            // 
            // btnChonSua
            // 
            this.btnChonSua.Location = new System.Drawing.Point(10, 225);
            this.btnChonSua.Name = "btnChonSua";
            this.btnChonSua.Size = new System.Drawing.Size(121, 29);
            this.btnChonSua.TabIndex = 25;
            this.btnChonSua.Text = "CHỌN SỬA";
            this.btnChonSua.UseVisualStyleBackColor = true;
            this.btnChonSua.Click += new System.EventHandler(this.bChon_Click);
            // 
            // btnChonThem
            // 
            this.btnChonThem.Location = new System.Drawing.Point(11, 568);
            this.btnChonThem.Name = "btnChonThem";
            this.btnChonThem.Size = new System.Drawing.Size(121, 29);
            this.btnChonThem.TabIndex = 26;
            this.btnChonThem.Text = "CHỌN THÊM";
            this.btnChonThem.UseVisualStyleBackColor = true;
            this.btnChonThem.Click += new System.EventHandler(this.bChonThem_Click);
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 727);
            this.Controls.Add(this.btnChonThem);
            this.Controls.Add(this.btnChonSua);
            this.Controls.Add(this.lblChonSach);
            this.Controls.Add(this.dgvChonSach);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nhap_numericUpDownSoLuong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sua_numericUpDownSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txMaSach_Them;
        private System.Windows.Forms.Button bThemKho;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Label lblSoLuongThem;
        private System.Windows.Forms.NumericUpDown Nhap_numericUpDownSoLuong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown Sua_numericUpDownSoLuong;
        private System.Windows.Forms.Label lblSoLuongSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblMaSach_Sua;
        private System.Windows.Forms.ListView dgvChonSach;
        private System.Windows.Forms.Label lblChonSach;
        private System.Windows.Forms.Button btnChonSua;
        private System.Windows.Forms.TextBox txbMaSachSua;
        private System.Windows.Forms.Button btnChonThem;
        private System.Windows.Forms.TextBox txbMaSachThem;
    }
}