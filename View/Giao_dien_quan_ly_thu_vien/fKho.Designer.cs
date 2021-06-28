
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
            this.dataGridView_Kho = new System.Windows.Forms.DataGridView();
            this.fThoat = new System.Windows.Forms.Button();
            this.bThem = new System.Windows.Forms.Button();
            this.bXoa = new System.Windows.Forms.Button();
            this.bSua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Kho
            // 
            this.dataGridView_Kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kho.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Kho.Name = "dataGridView_Kho";
            this.dataGridView_Kho.RowHeadersWidth = 51;
            this.dataGridView_Kho.RowTemplate.Height = 29;
            this.dataGridView_Kho.Size = new System.Drawing.Size(563, 438);
            this.dataGridView_Kho.TabIndex = 13;
            // 
            // fThoat
            // 
            this.fThoat.Location = new System.Drawing.Point(454, 466);
            this.fThoat.Name = "fThoat";
            this.fThoat.Size = new System.Drawing.Size(121, 29);
            this.fThoat.TabIndex = 14;
            this.fThoat.Text = "THOÁT";
            this.fThoat.UseVisualStyleBackColor = true;
            this.fThoat.Click += new System.EventHandler(this.fThoat_Click);
            // 
            // bThem
            // 
            this.bThem.Location = new System.Drawing.Point(12, 466);
            this.bThem.Name = "bThem";
            this.bThem.Size = new System.Drawing.Size(80, 29);
            this.bThem.TabIndex = 15;
            this.bThem.Text = "THÊM";
            this.bThem.UseVisualStyleBackColor = true;
            this.bThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // bXoa
            // 
            this.bXoa.Location = new System.Drawing.Point(98, 466);
            this.bXoa.Name = "bXoa";
            this.bXoa.Size = new System.Drawing.Size(80, 29);
            this.bXoa.TabIndex = 16;
            this.bXoa.Text = "XÓA";
            this.bXoa.UseVisualStyleBackColor = true;
            this.bXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // bSua
            // 
            this.bSua.Location = new System.Drawing.Point(184, 466);
            this.bSua.Name = "bSua";
            this.bSua.Size = new System.Drawing.Size(80, 29);
            this.bSua.TabIndex = 17;
            this.bSua.Text = "SỬA";
            this.bSua.UseVisualStyleBackColor = true;
            this.bSua.Click += new System.EventHandler(this.bSua_Click);
            // 
            // fKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 507);
            this.Controls.Add(this.bSua);
            this.Controls.Add(this.bXoa);
            this.Controls.Add(this.bThem);
            this.Controls.Add(this.fThoat);
            this.Controls.Add(this.dataGridView_Kho);
            this.Name = "fKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Kho;
        private System.Windows.Forms.Button fThoat;
        private System.Windows.Forms.Button bThem;
        private System.Windows.Forms.Button bXoa;
        private System.Windows.Forms.Button bSua;
    }
}