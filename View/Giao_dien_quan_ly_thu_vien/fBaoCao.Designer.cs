
namespace Giao_dien_quan_ly_thu_vien
{
    partial class fBaoCao
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
            this.dataGridView_BaoCao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BaoCao
            // 
            this.dataGridView_BaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BaoCao.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_BaoCao.Name = "dataGridView_BaoCao";
            this.dataGridView_BaoCao.RowHeadersWidth = 51;
            this.dataGridView_BaoCao.RowTemplate.Height = 29;
            this.dataGridView_BaoCao.Size = new System.Drawing.Size(776, 426);
            this.dataGridView_BaoCao.TabIndex = 0;
            // 
            // fBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_BaoCao);
            this.Name = "fBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BaoCao;
    }
}