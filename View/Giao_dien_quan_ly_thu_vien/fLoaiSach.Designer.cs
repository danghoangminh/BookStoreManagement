
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fLoaiSach
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
            this.txbThemLoaiSach = new System.Windows.Forms.TextBox();
            this.txThemLoaiSach = new System.Windows.Forms.Label();
            this.bThemLoaiSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbXoaLoaiSach = new System.Windows.Forms.ComboBox();
            this.txXoaLoaiSach = new System.Windows.Forms.Label();
            this.bXoaLoaiSach = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(640, 203);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemLoaiSach);
            this.panel1.Controls.Add(this.txThemLoaiSach);
            this.panel1.Controls.Add(this.bThemLoaiSach);
            this.panel1.Location = new System.Drawing.Point(11, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 69);
            this.panel1.TabIndex = 17;
            // 
            // txbThemLoaiSach
            // 
            this.txbThemLoaiSach.Location = new System.Drawing.Point(181, 11);
            this.txbThemLoaiSach.Name = "txbThemLoaiSach";
            this.txbThemLoaiSach.Size = new System.Drawing.Size(295, 27);
            this.txbThemLoaiSach.TabIndex = 1;
            // 
            // txThemLoaiSach
            // 
            this.txThemLoaiSach.AutoSize = true;
            this.txThemLoaiSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txThemLoaiSach.Location = new System.Drawing.Point(-1, 15);
            this.txThemLoaiSach.Name = "txThemLoaiSach";
            this.txThemLoaiSach.Size = new System.Drawing.Size(176, 23);
            this.txThemLoaiSach.TabIndex = 0;
            this.txThemLoaiSach.Text = "THÊM LOẠI SÁCH";
            // 
            // bThemLoaiSach
            // 
            this.bThemLoaiSach.Location = new System.Drawing.Point(498, 9);
            this.bThemLoaiSach.Name = "bThemLoaiSach";
            this.bThemLoaiSach.Size = new System.Drawing.Size(121, 29);
            this.bThemLoaiSach.TabIndex = 13;
            this.bThemLoaiSach.Text = "THÊM";
            this.bThemLoaiSach.UseVisualStyleBackColor = true;
            this.bThemLoaiSach.Click += new System.EventHandler(this.bThemSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbXoaLoaiSach);
            this.panel2.Controls.Add(this.txXoaLoaiSach);
            this.panel2.Controls.Add(this.bXoaLoaiSach);
            this.panel2.Location = new System.Drawing.Point(11, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 69);
            this.panel2.TabIndex = 18;
            // 
            // cbXoaLoaiSach
            // 
            this.cbXoaLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXoaLoaiSach.FormattingEnabled = true;
            this.cbXoaLoaiSach.Location = new System.Drawing.Point(181, 10);
            this.cbXoaLoaiSach.Name = "cbXoaLoaiSach";
            this.cbXoaLoaiSach.Size = new System.Drawing.Size(296, 28);
            this.cbXoaLoaiSach.TabIndex = 15;
            // 
            // txXoaLoaiSach
            // 
            this.txXoaLoaiSach.AutoSize = true;
            this.txXoaLoaiSach.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txXoaLoaiSach.Location = new System.Drawing.Point(-1, 15);
            this.txXoaLoaiSach.Name = "txXoaLoaiSach";
            this.txXoaLoaiSach.Size = new System.Drawing.Size(162, 23);
            this.txXoaLoaiSach.TabIndex = 0;
            this.txXoaLoaiSach.Text = "XÓA LOẠI SÁCH";
            // 
            // bXoaLoaiSach
            // 
            this.bXoaLoaiSach.Location = new System.Drawing.Point(499, 9);
            this.bXoaLoaiSach.Name = "bXoaLoaiSach";
            this.bXoaLoaiSach.Size = new System.Drawing.Size(121, 29);
            this.bXoaLoaiSach.TabIndex = 14;
            this.bXoaLoaiSach.Text = "XÓA";
            this.bXoaLoaiSach.UseVisualStyleBackColor = true;
            this.bXoaLoaiSach.Click += new System.EventHandler(this.bXoaSach_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(405, 386);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(226, 29);
            this.fThoat.TabIndex = 19;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 425);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI SÁCH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemLoaiSach;
        private System.Windows.Forms.Label txThemLoaiSach;
        private System.Windows.Forms.Button bThemLoaiSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbXoaLoaiSach;
        private System.Windows.Forms.Label txXoaLoaiSach;
        private System.Windows.Forms.Button bXoaLoaiSach;
        private System.Windows.Forms.Button fThoat;
    }
}