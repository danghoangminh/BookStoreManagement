
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fChiTietHoaDon
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fThoat = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(915, 502);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 7;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // bSua
            // 
            this.bSua.Location = new System.Drawing.Point(939, 338);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(91, 29);
            this.bSua.TabIndex = 10;
            this.bSua.Text = "SỬA";
            this.bSua.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.RowHeadersWidth = 51;
            this.dataGridView_HoaDon.RowTemplate.Height = 29;
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(1425, 438);
            this.dataGridView_HoaDon.TabIndex = 13;
            // 
            // fChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1448, 463);
            this.Controls.Add(this.dataGridView_HoaDon);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.fThoat);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "fChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHI TIẾT HÓA ĐƠN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bSua;
        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
    }
}

