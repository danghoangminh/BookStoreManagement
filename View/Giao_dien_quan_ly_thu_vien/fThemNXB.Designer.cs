﻿
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fThemNXB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTenNXB = new System.Windows.Forms.TextBox();
            this.txTenNXB = new System.Windows.Forms.Label();
            this.bThem = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbTenNXB);
            this.panel1.Controls.Add(this.txTenNXB);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 75);
            this.panel1.TabIndex = 4;
            // 
            // txbTenNXB
            // 
            this.txbTenNXB.Location = new System.Drawing.Point(208, 24);
            this.txbTenNXB.Name = "txbTenNXB";
            this.txbTenNXB.Size = new System.Drawing.Size(328, 27);
            this.txbTenNXB.TabIndex = 1;
            // 
            // txTenNXB
            // 
            this.txTenNXB.AutoSize = true;
            this.txTenNXB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTenNXB.Location = new System.Drawing.Point(3, 28);
            this.txTenNXB.Name = "txTenNXB";
            this.txTenNXB.Size = new System.Drawing.Size(195, 23);
            this.txTenNXB.TabIndex = 0;
            this.txTenNXB.Text = "TÊN NHÀ XUẤT BẢN";
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(12, 102);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(186, 29);
            this.bThem.TabIndex = 14;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(430, 102);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 15;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 139);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.panel1);
            this.Name = "fThemNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenNXB;
        private System.Windows.Forms.Label txTenNXB;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button fThoat;
    }
}