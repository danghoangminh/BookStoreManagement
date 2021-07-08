
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fLinhVuc
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
            this.fThoat = new System.Windows.Forms.Button();
            this.bThem = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThemLinhVuc = new System.Windows.Forms.TextBox();
            this.txTenLinhVuc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbXoaLinhVuc = new System.Windows.Forms.ComboBox();
            this.txThemLinhVuc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(404, 389);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(226, 29);
            this.fThoat.TabIndex = 12;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(498, 9);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(121, 29);
            this.bThem.TabIndex = 13;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(499, 9);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(121, 29);
            this.bXoa.TabIndex = 14;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 203);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemLinhVuc);
            this.panel1.Controls.Add(this.txTenLinhVuc);
            this.panel1.Controls.Add(this.bThem);
            this.panel1.Location = new System.Drawing.Point(11, 239);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 69);
            this.panel1.TabIndex = 16;
            // 
            // txbThemLinhVuc
            // 
            this.txbThemLinhVuc.Location = new System.Drawing.Point(167, 11);
            this.txbThemLinhVuc.Name = "txbThemLinhVuc";
            this.txbThemLinhVuc.Size = new System.Drawing.Size(309, 27);
            this.txbThemLinhVuc.TabIndex = 1;
            // 
            // txTenLinhVuc
            // 
            this.txTenLinhVuc.AutoSize = true;
            this.txTenLinhVuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTenLinhVuc.Location = new System.Drawing.Point(-1, 15);
            this.txTenLinhVuc.Name = "txTenLinhVuc";
            this.txTenLinhVuc.Size = new System.Drawing.Size(164, 23);
            this.txTenLinhVuc.TabIndex = 0;
            this.txTenLinhVuc.Text = "THÊM LĨNH VỰC";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbXoaLinhVuc);
            this.panel2.Controls.Add(this.txThemLinhVuc);
            this.panel2.Controls.Add(this.bXoa);
            this.panel2.Location = new System.Drawing.Point(10, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 69);
            this.panel2.TabIndex = 17;
            // 
            // cbXoaLinhVuc
            // 
            this.cbXoaLinhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXoaLinhVuc.FormattingEnabled = true;
            this.cbXoaLinhVuc.Location = new System.Drawing.Point(169, 10);
            this.cbXoaLinhVuc.Name = "cbXoaLinhVuc";
            this.cbXoaLinhVuc.Size = new System.Drawing.Size(308, 28);
            this.cbXoaLinhVuc.TabIndex = 15;
            // 
            // txThemLinhVuc
            // 
            this.txThemLinhVuc.AutoSize = true;
            this.txThemLinhVuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txThemLinhVuc.Location = new System.Drawing.Point(-1, 15);
            this.txThemLinhVuc.Name = "txThemLinhVuc";
            this.txThemLinhVuc.Size = new System.Drawing.Size(150, 23);
            this.txThemLinhVuc.TabIndex = 0;
            this.txThemLinhVuc.Text = "XÓA LĨNH VỰC";
            // 
            // fLinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fLinhVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LĨNH VỰC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemLinhVuc;
        private System.Windows.Forms.Label txTenLinhVuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbXoaLinhVuc;
        private System.Windows.Forms.Label txThemLinhVuc;
    }
}