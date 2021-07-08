
namespace BookStoreManagement.View.Forms
{
    partial class frmAddBillDetail
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddbilldetail = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.txbBillID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.cmbBooktitle = new System.Windows.Forms.ComboBox();
            this.lblBooktitle = new System.Windows.Forms.Label();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txbSellprice = new System.Windows.Forms.TextBox();
            this.lblTotalprice = new System.Windows.Forms.Label();
            this.txbTotalprice = new System.Windows.Forms.TextBox();
            this.dgvBillDetail = new System.Windows.Forms.DataGridView();
            this.btnAddbilldetail = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 10);
            this.panel1.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1516, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 524);
            this.panel5.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 524);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1516, 10);
            this.panel3.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1516, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 514);
            this.panel2.TabIndex = 24;
            // 
            // lblAddbilldetail
            // 
            this.lblAddbilldetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddbilldetail.AutoSize = true;
            this.lblAddbilldetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddbilldetail.Location = new System.Drawing.Point(186, 27);
            this.lblAddbilldetail.Name = "lblAddbilldetail";
            this.lblAddbilldetail.Size = new System.Drawing.Size(161, 25);
            this.lblAddbilldetail.TabIndex = 25;
            this.lblAddbilldetail.Text = "Add Bill Detail";
            // 
            // lblBillID
            // 
            this.lblBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.Location = new System.Drawing.Point(55, 92);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(62, 20);
            this.lblBillID.TabIndex = 26;
            this.lblBillID.Text = "Bill ID:";
            // 
            // txbBillID
            // 
            this.txbBillID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbBillID.Location = new System.Drawing.Point(217, 89);
            this.txbBillID.Name = "txbBillID";
            this.txbBillID.ReadOnly = true;
            this.txbBillID.Size = new System.Drawing.Size(274, 26);
            this.txbBillID.TabIndex = 27;
            // 
            // lblBookID
            // 
            this.lblBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(55, 210);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(79, 20);
            this.lblBookID.TabIndex = 28;
            this.lblBookID.Text = "Book ID:";
            // 
            // cmbBooktitle
            // 
            this.cmbBooktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbBooktitle.FormattingEnabled = true;
            this.cmbBooktitle.Location = new System.Drawing.Point(217, 146);
            this.cmbBooktitle.Name = "cmbBooktitle";
            this.cmbBooktitle.Size = new System.Drawing.Size(274, 28);
            this.cmbBooktitle.TabIndex = 29;
            // 
            // lblBooktitle
            // 
            this.lblBooktitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBooktitle.AutoSize = true;
            this.lblBooktitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooktitle.Location = new System.Drawing.Point(55, 150);
            this.lblBooktitle.Name = "lblBooktitle";
            this.lblBooktitle.Size = new System.Drawing.Size(94, 20);
            this.lblBooktitle.TabIndex = 30;
            this.lblBooktitle.Text = "Book Title:";
            // 
            // txbBookID
            // 
            this.txbBookID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbBookID.Location = new System.Drawing.Point(217, 207);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.ReadOnly = true;
            this.txbBookID.Size = new System.Drawing.Size(274, 26);
            this.txbBookID.TabIndex = 31;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(55, 268);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(81, 20);
            this.lblQuantity.TabIndex = 32;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nudQuantity.Location = new System.Drawing.Point(217, 265);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(274, 26);
            this.nudQuantity.TabIndex = 33;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.Location = new System.Drawing.Point(55, 326);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(89, 20);
            this.lblSellPrice.TabIndex = 34;
            this.lblSellPrice.Text = "Sell Price:";
            // 
            // txbSellprice
            // 
            this.txbSellprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbSellprice.Location = new System.Drawing.Point(217, 323);
            this.txbSellprice.Name = "txbSellprice";
            this.txbSellprice.ReadOnly = true;
            this.txbSellprice.Size = new System.Drawing.Size(274, 26);
            this.txbSellprice.TabIndex = 35;
            // 
            // lblTotalprice
            // 
            this.lblTotalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalprice.AutoSize = true;
            this.lblTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalprice.Location = new System.Drawing.Point(55, 384);
            this.lblTotalprice.Name = "lblTotalprice";
            this.lblTotalprice.Size = new System.Drawing.Size(99, 20);
            this.lblTotalprice.TabIndex = 36;
            this.lblTotalprice.Text = "Total Price:";
            // 
            // txbTotalprice
            // 
            this.txbTotalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txbTotalprice.Location = new System.Drawing.Point(217, 381);
            this.txbTotalprice.Name = "txbTotalprice";
            this.txbTotalprice.ReadOnly = true;
            this.txbTotalprice.Size = new System.Drawing.Size(274, 26);
            this.txbTotalprice.TabIndex = 37;
            // 
            // dgvBillDetail
            // 
            this.dgvBillDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetail.Location = new System.Drawing.Point(620, 48);
            this.dgvBillDetail.Name = "dgvBillDetail";
            this.dgvBillDetail.RowHeadersWidth = 51;
            this.dgvBillDetail.RowTemplate.Height = 24;
            this.dgvBillDetail.Size = new System.Drawing.Size(831, 467);
            this.dgvBillDetail.TabIndex = 38;
            // 
            // btnAddbilldetail
            // 
            this.btnAddbilldetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddbilldetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddbilldetail.FlatAppearance.BorderSize = 0;
            this.btnAddbilldetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddbilldetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddbilldetail.ForeColor = System.Drawing.Color.White;
            this.btnAddbilldetail.Location = new System.Drawing.Point(59, 477);
            this.btnAddbilldetail.Name = "btnAddbilldetail";
            this.btnAddbilldetail.Size = new System.Drawing.Size(138, 38);
            this.btnAddbilldetail.TabIndex = 39;
            this.btnAddbilldetail.Text = "Add Item";
            this.btnAddbilldetail.UseVisualStyleBackColor = false;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDone.BackColor = System.Drawing.Color.Green;
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(353, 477);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(138, 38);
            this.btnDone.TabIndex = 41;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1457, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 39);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(989, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Bill Detail";
            // 
            // frmAddBillDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1526, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnAddbilldetail);
            this.Controls.Add(this.dgvBillDetail);
            this.Controls.Add(this.txbTotalprice);
            this.Controls.Add(this.lblTotalprice);
            this.Controls.Add(this.txbSellprice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbBookID);
            this.Controls.Add(this.lblBooktitle);
            this.Controls.Add(this.cmbBooktitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txbBillID);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.lblAddbilldetail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddBillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddBillDetail";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddbilldetail;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.TextBox txbBillID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.ComboBox cmbBooktitle;
        private System.Windows.Forms.Label lblBooktitle;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txbSellprice;
        private System.Windows.Forms.Label lblTotalprice;
        private System.Windows.Forms.TextBox txbTotalprice;
        private System.Windows.Forms.DataGridView dgvBillDetail;
        private System.Windows.Forms.Button btnAddbilldetail;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}