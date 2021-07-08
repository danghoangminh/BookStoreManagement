
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fXoaTacGia
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
            this.bXoaTG = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(624, 383);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 17;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click_1);
            // 
            // bXoaTG
            // 
            this.bXoaTG.Location = new System.Drawing.Point(12, 383);
            this.bXoaTG.Name = "bXoaTG";
            this.bXoaTG.Size = new System.Drawing.Size(213, 29);
            this.bXoaTG.TabIndex = 20;
            this.bXoaTG.Text = "XÓA TÁC GIẢ";
            this.bXoaTG.UseVisualStyleBackColor = true;
            this.bXoaTG.Click += new System.EventHandler(this.bXoaTG_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(732, 365);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // fXoaTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 424);
            this.Controls.Add(this.bXoaTG);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.fThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fXoaTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " XÓA TÁC GIẢ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bXoaTG;
        private System.Windows.Forms.ListView listView1;
    }
}