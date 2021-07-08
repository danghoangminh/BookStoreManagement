
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fThongKe
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
            this.txTuNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txDenNgay = new System.Windows.Forms.Label();
            this.dateTimePicker_Den = new System.Windows.Forms.DateTimePicker();
            this.fThoat = new System.Windows.Forms.Button();
            this.bXuatBC = new System.Windows.Forms.Button();
            this.bTimKiem = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txTuNgay
            // 
            this.txTuNgay.AutoSize = true;
            this.txTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTuNgay.Location = new System.Drawing.Point(3, 14);
            this.txTuNgay.Name = "txTuNgay";
            this.txTuNgay.Size = new System.Drawing.Size(80, 23);
            this.txTuNgay.TabIndex = 14;
            this.txTuNgay.Text = "TỪ NGÀY";
            // 
            // dateTimePicker_TuNgay
            // 
            this.dateTimePicker_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_TuNgay.Location = new System.Drawing.Point(109, 10);
            this.dateTimePicker_TuNgay.Name = "dateTimePicker_TuNgay";
            this.dateTimePicker_TuNgay.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_TuNgay.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txTuNgay);
            this.panel1.Controls.Add(this.dateTimePicker_TuNgay);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 48);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txDenNgay);
            this.panel2.Controls.Add(this.dateTimePicker_Den);
            this.panel2.Location = new System.Drawing.Point(459, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 48);
            this.panel2.TabIndex = 17;
            // 
            // txDenNgay
            // 
            this.txDenNgay.AutoSize = true;
            this.txDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txDenNgay.Location = new System.Drawing.Point(2, 14);
            this.txDenNgay.Name = "txDenNgay";
            this.txDenNgay.Size = new System.Drawing.Size(93, 23);
            this.txDenNgay.TabIndex = 14;
            this.txDenNgay.Text = "ĐẾN NGÀY";
            // 
            // dateTimePicker_Den
            // 
            this.dateTimePicker_Den.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Den.Location = new System.Drawing.Point(109, 10);
            this.dateTimePicker_Den.Name = "dateTimePicker_Den";
            this.dateTimePicker_Den.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker_Den.TabIndex = 15;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(914, 524);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 18;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // bXuatBC
            // 
            this.bXuatBC.Location = new System.Drawing.Point(12, 514);
            this.bXuatBC.Name = "bXuatBC";
            this.bXuatBC.Size = new System.Drawing.Size(228, 48);
            this.bXuatBC.TabIndex = 19;
            this.bXuatBC.Text = "XUẤT BÁO CÁO";
            this.bXuatBC.UseVisualStyleBackColor = true;
            this.bXuatBC.Click += new System.EventHandler(this.bXuatBC_Click);
            // 
            // bTimKiem
            // 
            this.bTimKiem.Location = new System.Drawing.Point(879, 12);
            this.bTimKiem.Name = "bTimKiem";
            this.bTimKiem.Size = new System.Drawing.Size(143, 39);
            this.bTimKiem.TabIndex = 20;
            this.bTimKiem.Text = "TÌM KIẾM";
            this.bTimKiem.UseVisualStyleBackColor = true;
            this.bTimKiem.Click += new System.EventHandler(this.bTimKiem_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1023, 402);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 574);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bTimKiem);
            this.Controls.Add(this.bXuatBC);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_TuNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Den;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bXuatBC;
        private System.Windows.Forms.Button bTimKiem;
        private System.Windows.Forms.ListView listView1;
    }
}