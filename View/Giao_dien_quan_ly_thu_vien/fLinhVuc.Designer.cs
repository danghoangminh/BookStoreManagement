
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmLinhVuc
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
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvLinhVuc = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThemLinhVuc = new System.Windows.Forms.TextBox();
            this.lblTenLinhVuc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboXoaLinhVuc = new System.Windows.Forms.ComboBox();
            this.lblThemLinhVuc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(498, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 29);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.bThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(499, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 29);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.bXoa_Click);
            // 
            // dgvLinhVuc
            // 
            this.dgvLinhVuc.HideSelection = false;
            this.dgvLinhVuc.Location = new System.Drawing.Point(11, 12);
            this.dgvLinhVuc.Name = "dgvLinhVuc";
            this.dgvLinhVuc.Size = new System.Drawing.Size(640, 221);
            this.dgvLinhVuc.TabIndex = 15;
            this.dgvLinhVuc.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemLinhVuc);
            this.panel1.Controls.Add(this.lblTenLinhVuc);
            this.panel1.Controls.Add(this.btnThem);
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
            // lblTenLinhVuc
            // 
            this.lblTenLinhVuc.AutoSize = true;
            this.lblTenLinhVuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTenLinhVuc.Location = new System.Drawing.Point(3, 10);
            this.lblTenLinhVuc.Name = "lblTenLinhVuc";
            this.lblTenLinhVuc.Size = new System.Drawing.Size(159, 28);
            this.lblTenLinhVuc.TabIndex = 0;
            this.lblTenLinhVuc.Text = "THÊM LĨNH VỰC:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboXoaLinhVuc);
            this.panel2.Controls.Add(this.lblThemLinhVuc);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Location = new System.Drawing.Point(10, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 69);
            this.panel2.TabIndex = 17;
            // 
            // cboXoaLinhVuc
            // 
            this.cboXoaLinhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoaLinhVuc.FormattingEnabled = true;
            this.cboXoaLinhVuc.Location = new System.Drawing.Point(169, 10);
            this.cboXoaLinhVuc.Name = "cboXoaLinhVuc";
            this.cboXoaLinhVuc.Size = new System.Drawing.Size(308, 28);
            this.cboXoaLinhVuc.TabIndex = 15;
            // 
            // lblThemLinhVuc
            // 
            this.lblThemLinhVuc.AutoSize = true;
            this.lblThemLinhVuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThemLinhVuc.Location = new System.Drawing.Point(4, 9);
            this.lblThemLinhVuc.Name = "lblThemLinhVuc";
            this.lblThemLinhVuc.Size = new System.Drawing.Size(147, 28);
            this.lblThemLinhVuc.TabIndex = 0;
            this.lblThemLinhVuc.Text = "XÓA LĨNH VỰC:";
            // 
            // frmLinhVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 391);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLinhVuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLinhVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LĨNH VỰC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView dgvLinhVuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemLinhVuc;
        private System.Windows.Forms.Label lblTenLinhVuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaLinhVuc;
        private System.Windows.Forms.Label lblThemLinhVuc;
    }
}