namespace BookStoreManagement.UserControls
{
    partial class ucSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddbill = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.txbCustomername = new System.Windows.Forms.TextBox();
            this.txbBillID = new System.Windows.Forms.TextBox();
            this.lblCustomername = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddbill
            // 
            this.btnAddbill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddbill.FlatAppearance.BorderSize = 0;
            this.btnAddbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddbill.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddbill.ForeColor = System.Drawing.Color.White;
            this.btnAddbill.Location = new System.Drawing.Point(335, 314);
            this.btnAddbill.Name = "btnAddbill";
            this.btnAddbill.Size = new System.Drawing.Size(138, 38);
            this.btnAddbill.TabIndex = 2;
            this.btnAddbill.Text = "Add bill";
            this.btnAddbill.UseVisualStyleBackColor = false;
            this.btnAddbill.Click += new System.EventHandler(this.btnAddbill_Click);
            // 
            // lblBill
            // 
            this.lblBill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBill.AutoSize = true;
            this.lblBill.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(300, 11);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(234, 32);
            this.lblBill.TabIndex = 0;
            this.lblBill.Text = "Bill Management";
            // 
            // lblBillID
            // 
            this.lblBillID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.Location = new System.Drawing.Point(83, 99);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(69, 23);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Text = "Bill ID:";
            // 
            // txbCustomername
            // 
            this.txbCustomername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCustomername.Location = new System.Drawing.Point(292, 152);
            this.txbCustomername.Name = "txbCustomername";
            this.txbCustomername.Size = new System.Drawing.Size(380, 32);
            this.txbCustomername.TabIndex = 1;
            // 
            // txbBillID
            // 
            this.txbBillID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbBillID.Location = new System.Drawing.Point(292, 90);
            this.txbBillID.Name = "txbBillID";
            this.txbBillID.ReadOnly = true;
            this.txbBillID.Size = new System.Drawing.Size(380, 32);
            this.txbBillID.TabIndex = 1;
            // 
            // lblCustomername
            // 
            this.lblCustomername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCustomername.AutoSize = true;
            this.lblCustomername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomername.Location = new System.Drawing.Point(83, 160);
            this.lblCustomername.Name = "lblCustomername";
            this.lblCustomername.Size = new System.Drawing.Size(176, 23);
            this.lblCustomername.TabIndex = 0;
            this.lblCustomername.Text = "Customer Name:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(83, 221);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(62, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(292, 214);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(380, 32);
            this.dtpDate.TabIndex = 4;
            // 
            // dgvBill
            // 
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(23, 383);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.Size = new System.Drawing.Size(801, 228);
            this.dgvBill.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 639);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 10);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 639);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 10);
            this.panel1.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(843, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 629);
            this.panel4.TabIndex = 27;
            // 
            // ucSales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnAddbill);
            this.Controls.Add(this.txbCustomername);
            this.Controls.Add(this.txbBillID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.lblCustomername);
            this.Controls.Add(this.lblBill);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(853, 649);
            this.Load += new System.EventHandler(this.ucSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddbill;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.TextBox txbCustomername;
        private System.Windows.Forms.TextBox txbBillID;
        private System.Windows.Forms.Label lblCustomername;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}
