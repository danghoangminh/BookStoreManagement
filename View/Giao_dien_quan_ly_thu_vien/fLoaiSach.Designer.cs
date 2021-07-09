
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmLoaiSach
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
            this.dgvLoaiSach = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThemLoaiSach = new System.Windows.Forms.TextBox();
            this.lblThemLoaiSach = new System.Windows.Forms.Label();
            this.btnThemLoaiSach = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboXoaLoaiSach = new System.Windows.Forms.ComboBox();
            this.lblXoaLoaiSach = new System.Windows.Forms.Label();
            this.btnXoaLoaiSach = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiSach
            // 
            this.dgvLoaiSach.HideSelection = false;
            this.dgvLoaiSach.Location = new System.Drawing.Point(11, 12);
            this.dgvLoaiSach.Name = "dgvLoaiSach";
            this.dgvLoaiSach.Size = new System.Drawing.Size(640, 218);
            this.dgvLoaiSach.TabIndex = 16;
            this.dgvLoaiSach.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemLoaiSach);
            this.panel1.Controls.Add(this.lblThemLoaiSach);
            this.panel1.Controls.Add(this.btnThemLoaiSach);
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
            // lblThemLoaiSach
            // 
            this.lblThemLoaiSach.AutoSize = true;
            this.lblThemLoaiSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThemLoaiSach.Location = new System.Drawing.Point(3, 11);
            this.lblThemLoaiSach.Name = "lblThemLoaiSach";
            this.lblThemLoaiSach.Size = new System.Drawing.Size(169, 28);
            this.lblThemLoaiSach.TabIndex = 0;
            this.lblThemLoaiSach.Text = "THÊM LOẠI SÁCH:";
            // 
            // btnThemLoaiSach
            // 
            this.btnThemLoaiSach.Location = new System.Drawing.Point(498, 9);
            this.btnThemLoaiSach.Name = "btnThemLoaiSach";
            this.btnThemLoaiSach.Size = new System.Drawing.Size(121, 29);
            this.btnThemLoaiSach.TabIndex = 13;
            this.btnThemLoaiSach.Text = "THÊM";
            this.btnThemLoaiSach.UseVisualStyleBackColor = true;
            this.btnThemLoaiSach.Click += new System.EventHandler(this.bThemSach_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboXoaLoaiSach);
            this.panel2.Controls.Add(this.lblXoaLoaiSach);
            this.panel2.Controls.Add(this.btnXoaLoaiSach);
            this.panel2.Location = new System.Drawing.Point(11, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 69);
            this.panel2.TabIndex = 18;
            // 
            // cboXoaLoaiSach
            // 
            this.cboXoaLoaiSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoaLoaiSach.FormattingEnabled = true;
            this.cboXoaLoaiSach.Location = new System.Drawing.Point(181, 10);
            this.cboXoaLoaiSach.Name = "cboXoaLoaiSach";
            this.cboXoaLoaiSach.Size = new System.Drawing.Size(296, 28);
            this.cboXoaLoaiSach.TabIndex = 15;
            // 
            // lblXoaLoaiSach
            // 
            this.lblXoaLoaiSach.AutoSize = true;
            this.lblXoaLoaiSach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblXoaLoaiSach.Location = new System.Drawing.Point(3, 9);
            this.lblXoaLoaiSach.Name = "lblXoaLoaiSach";
            this.lblXoaLoaiSach.Size = new System.Drawing.Size(157, 28);
            this.lblXoaLoaiSach.TabIndex = 0;
            this.lblXoaLoaiSach.Text = "XÓA LOẠI SÁCH:";
            // 
            // btnXoaLoaiSach
            // 
            this.btnXoaLoaiSach.Location = new System.Drawing.Point(499, 9);
            this.btnXoaLoaiSach.Name = "btnXoaLoaiSach";
            this.btnXoaLoaiSach.Size = new System.Drawing.Size(121, 29);
            this.btnXoaLoaiSach.TabIndex = 14;
            this.btnXoaLoaiSach.Text = "XÓA";
            this.btnXoaLoaiSach.UseVisualStyleBackColor = true;
            this.btnXoaLoaiSach.Click += new System.EventHandler(this.bXoaSach_Click);
            // 
            // frmLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLoaiSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLoaiSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOẠI SÁCH";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dgvLoaiSach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemLoaiSach;
        private System.Windows.Forms.Label lblThemLoaiSach;
        private System.Windows.Forms.Button btnThemLoaiSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaLoaiSach;
        private System.Windows.Forms.Label lblXoaLoaiSach;
        private System.Windows.Forms.Button btnXoaLoaiSach;
    }
}