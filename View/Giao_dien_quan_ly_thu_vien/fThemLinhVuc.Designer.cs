
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fThemLinhVuc
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txTenLinhVuc = new System.Windows.Forms.Label();
            this.bThem = new System.Windows.Forms.Button();
            this.fThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txTenLinhVuc);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 75);
            this.panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 27);
            this.textBox1.TabIndex = 1;
            // 
            // txTenLinhVuc
            // 
            this.txTenLinhVuc.AutoSize = true;
            this.txTenLinhVuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txTenLinhVuc.Location = new System.Drawing.Point(3, 28);
            this.txTenLinhVuc.Name = "txTenLinhVuc";
            this.txTenLinhVuc.Size = new System.Drawing.Size(147, 23);
            this.txTenLinhVuc.TabIndex = 0;
            this.txTenLinhVuc.Text = "TÊN LĨNH VỰC";
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(12, 107);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(186, 29);
            this.bThem.TabIndex = 13;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(404, 107);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // fThemLinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 143);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.panel1);
            this.Name = "fThemLinhVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txTenLinhVuc;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button fThoat;
    }
}