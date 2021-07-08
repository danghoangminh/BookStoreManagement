
using System.Windows.Forms;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            this.bXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(7, 389);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(183, 29);
            this.bXoa.TabIndex = 13;
            this.bXoa.Text = "XÓA SÁCH";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(640, 389);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(7, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 379);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // fXoaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 428);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bXoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fXoaSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÓA SÁCH";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.ListView listView1;


    }
}