
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fKho
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
            this.txSoLuong = new System.Windows.Forms.Label();
            this.bThemKho = new System.Windows.Forms.Button();
            this.txMaSach = new System.Windows.Forms.Label();
            this.bXoaSach = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMaSachSua = new System.Windows.Forms.TextBox();
            this.Sua_numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bLuu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.bChonSua = new System.Windows.Forms.Button();
            this.bChonThem = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.txSoLuong);
            this.panel1.Controls.Add(this.bThemKho);
            this.panel1.Controls.Add(this.txMaSach);
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
            // txSoLuong
            // 
            this.txSoLuong.AutoSize = true;
            this.txSoLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txSoLuong.Location = new System.Drawing.Point(0, 52);
            this.txSoLuong.Name = "txSoLuong";
            this.txSoLuong.Size = new System.Drawing.Size(91, 23);
            this.txSoLuong.TabIndex = 17;
            this.txSoLuong.Text = "Số lượng";
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
            // txMaSach
            // 
            this.txMaSach.AutoSize = true;
            this.txMaSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMaSach.Location = new System.Drawing.Point(-1, 15);
            this.txMaSach.Name = "txMaSach";
            this.txMaSach.Size = new System.Drawing.Size(85, 23);
            this.txMaSach.TabIndex = 0;
            this.txMaSach.Text = "Mã sách";
            // 
            // bXoaSach
            // 
            this.bXoaSach.Location = new System.Drawing.Point(548, 225);
            this.bXoaSach.Name = "bXoaSach";
            this.bXoaSach.Size = new System.Drawing.Size(226, 29);
            this.bXoaSach.TabIndex = 14;
            this.bXoaSach.Text = "XÓA SÁCH ";
            this.bXoaSach.UseVisualStyleBackColor = true;
            this.bXoaSach.Click += new System.EventHandler(this.bXoaSach_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(551, 686);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(226, 29);
            this.fThoat.TabIndex = 21;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMaSachSua);
            this.panel3.Controls.Add(this.Sua_numericUpDownSoLuong);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bLuu);
            this.panel3.Controls.Add(this.label2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Số lượng";
            // 
            // bLuu
            // 
            this.bLuu.Location = new System.Drawing.Point(321, 45);
            this.bLuu.Name = "bLuu";
            this.bLuu.Size = new System.Drawing.Size(163, 26);
            this.bLuu.TabIndex = 13;
            this.bLuu.Text = "LƯU";
            this.bLuu.UseVisualStyleBackColor = true;
            this.bLuu.Click += new System.EventHandler(this.bLuu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.Info;
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(11, 397);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(766, 165);
            this.listView2.TabIndex = 23;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(12, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Chọn Sách";
            // 
            // bChonSua
            // 
            this.bChonSua.Location = new System.Drawing.Point(11, 225);
            this.bChonSua.Name = "bChonSua";
            this.bChonSua.Size = new System.Drawing.Size(121, 29);
            this.bChonSua.TabIndex = 25;
            this.bChonSua.Text = "CHỌN SỬA";
            this.bChonSua.UseVisualStyleBackColor = true;
            this.bChonSua.Click += new System.EventHandler(this.bChon_Click);
            // 
            // bChonThem
            // 
            this.bChonThem.Location = new System.Drawing.Point(11, 568);
            this.bChonThem.Name = "bChonThem";
            this.bChonThem.Size = new System.Drawing.Size(121, 29);
            this.bChonThem.TabIndex = 26;
            this.bChonThem.Text = "CHỌN THÊM";
            this.bChonThem.UseVisualStyleBackColor = true;
            this.bChonThem.Click += new System.EventHandler(this.bChonThem_Click);
            // 
            // fKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 727);
            this.Controls.Add(this.bChonThem);
            this.Controls.Add(this.bChonSua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bXoaSach);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fKho";
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
        private System.Windows.Forms.Label txMaSach;
        private System.Windows.Forms.Button bThemKho;
        private System.Windows.Forms.Button bXoaSach;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Label txSoLuong;
        private System.Windows.Forms.NumericUpDown Nhap_numericUpDownSoLuong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown Sua_numericUpDownSoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bLuu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bChonSua;
        private System.Windows.Forms.TextBox txbMaSachSua;
        private System.Windows.Forms.Button bChonThem;
        private System.Windows.Forms.TextBox txbMaSachThem;
    }
}