
namespace Giao_dien_quan_ly_thu_vien
{
    partial class frmNhaXuatBan
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
            this.dgvNhaXuatBan = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThemNXB = new System.Windows.Forms.TextBox();
            this.lblThemNXB = new System.Windows.Forms.Label();
            this.btnThemNXB = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboXoaNXB = new System.Windows.Forms.ComboBox();
            this.lblXoaNXB = new System.Windows.Forms.Label();
            this.btnXoaNXB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhaXuatBan
            // 
            this.dgvNhaXuatBan.HideSelection = false;
            this.dgvNhaXuatBan.Location = new System.Drawing.Point(11, 12);
            this.dgvNhaXuatBan.Name = "dgvNhaXuatBan";
            this.dgvNhaXuatBan.Size = new System.Drawing.Size(640, 219);
            this.dgvNhaXuatBan.TabIndex = 17;
            this.dgvNhaXuatBan.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThemNXB);
            this.panel1.Controls.Add(this.lblThemNXB);
            this.panel1.Controls.Add(this.btnThemNXB);
            this.panel1.Location = new System.Drawing.Point(11, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 69);
            this.panel1.TabIndex = 18;
            // 
            // txbThemNXB
            // 
            this.txbThemNXB.Location = new System.Drawing.Point(153, 11);
            this.txbThemNXB.Name = "txbThemNXB";
            this.txbThemNXB.Size = new System.Drawing.Size(323, 27);
            this.txbThemNXB.TabIndex = 1;
            // 
            // lblThemNXB
            // 
            this.lblThemNXB.AutoSize = true;
            this.lblThemNXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThemNXB.Location = new System.Drawing.Point(3, 11);
            this.lblThemNXB.Name = "lblThemNXB";
            this.lblThemNXB.Size = new System.Drawing.Size(111, 28);
            this.lblThemNXB.TabIndex = 0;
            this.lblThemNXB.Text = "THÊM NXB:";
            // 
            // btnThemNXB
            // 
            this.btnThemNXB.Location = new System.Drawing.Point(498, 9);
            this.btnThemNXB.Name = "btnThemNXB";
            this.btnThemNXB.Size = new System.Drawing.Size(121, 29);
            this.btnThemNXB.TabIndex = 13;
            this.btnThemNXB.Text = "THÊM";
            this.btnThemNXB.UseVisualStyleBackColor = true;
            this.btnThemNXB.Click += new System.EventHandler(this.bThemNXB_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboXoaNXB);
            this.panel2.Controls.Add(this.lblXoaNXB);
            this.panel2.Controls.Add(this.btnXoaNXB);
            this.panel2.Location = new System.Drawing.Point(11, 312);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 69);
            this.panel2.TabIndex = 19;
            // 
            // cboXoaNXB
            // 
            this.cboXoaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboXoaNXB.FormattingEnabled = true;
            this.cboXoaNXB.Location = new System.Drawing.Point(153, 10);
            this.cboXoaNXB.Name = "cboXoaNXB";
            this.cboXoaNXB.Size = new System.Drawing.Size(324, 28);
            this.cboXoaNXB.TabIndex = 15;
            // 
            // lblXoaNXB
            // 
            this.lblXoaNXB.AutoSize = true;
            this.lblXoaNXB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblXoaNXB.Location = new System.Drawing.Point(3, 10);
            this.lblXoaNXB.Name = "lblXoaNXB";
            this.lblXoaNXB.Size = new System.Drawing.Size(99, 28);
            this.lblXoaNXB.TabIndex = 0;
            this.lblXoaNXB.Text = "XÓA NXB:";
            // 
            // btnXoaNXB
            // 
            this.btnXoaNXB.Location = new System.Drawing.Point(499, 9);
            this.btnXoaNXB.Name = "btnXoaNXB";
            this.btnXoaNXB.Size = new System.Drawing.Size(121, 29);
            this.btnXoaNXB.TabIndex = 14;
            this.btnXoaNXB.Text = "XÓA";
            this.btnXoaNXB.UseVisualStyleBackColor = true;
            this.btnXoaNXB.Click += new System.EventHandler(this.bXoaNXB_Click);
            // 
            // frmNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 390);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNhaXuatBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNhaXuatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÀ XUẤT BẢN";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dgvNhaXuatBan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThemNXB;
        private System.Windows.Forms.Label lblThemNXB;
        private System.Windows.Forms.Button btnThemNXB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboXoaNXB;
        private System.Windows.Forms.Label lblXoaNXB;
        private System.Windows.Forms.Button btnXoaNXB;
    }
}