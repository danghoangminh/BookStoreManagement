
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fXoaKho
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
            this.bXoa = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbMaSach);
            this.panel2.Controls.Add(this.txMaSach);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 75);
            this.panel2.TabIndex = 3;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(182, 23);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(328, 28);
            this.cbMaSach.TabIndex = 1;
            this.cbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbMaSach_SelectedIndexChanged);
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
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(12, 102);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(184, 29);
            this.bXoa.TabIndex = 11;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseCompatibleTextRendering = true;
            this.bXoa.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(404, 102);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 13;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fXoaKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 139);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.panel2);
            this.Name = "fXoaKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Label txMaSach;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button fThoat;
    }
}