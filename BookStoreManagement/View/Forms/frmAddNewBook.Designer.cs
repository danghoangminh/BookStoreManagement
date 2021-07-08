namespace BookStoreManagement.Forms
{
    partial class frmAddNewBook
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbBooktitle = new System.Windows.Forms.TextBox();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.lblSellingprice = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblCostprice = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblBooktitle = new System.Windows.Forms.Label();
            this.lblPurchasebooks = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddcategory = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.btnAddauthor = new System.Windows.Forms.Button();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.btnAddpublisher = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudCostprice = new System.Windows.Forms.NumericUpDown();
            this.nudSellingprice = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingprice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 503);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(804, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 513);
            this.panel4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 10);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(570, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txbBooktitle
            // 
            this.txbBooktitle.Location = new System.Drawing.Point(545, 88);
            this.txbBooktitle.Name = "txbBooktitle";
            this.txbBooktitle.Size = new System.Drawing.Size(234, 32);
            this.txbBooktitle.TabIndex = 5;
            // 
            // txbBookID
            // 
            this.txbBookID.Location = new System.Drawing.Point(176, 88);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.ReadOnly = true;
            this.txbBookID.Size = new System.Drawing.Size(177, 32);
            this.txbBookID.TabIndex = 1;
            // 
            // lblSellingprice
            // 
            this.lblSellingprice.AutoSize = true;
            this.lblSellingprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingprice.Location = new System.Drawing.Point(412, 236);
            this.lblSellingprice.Name = "lblSellingprice";
            this.lblSellingprice.Size = new System.Drawing.Size(133, 23);
            this.lblSellingprice.TabIndex = 5;
            this.lblSellingprice.Text = "Selling Price:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.Location = new System.Drawing.Point(46, 97);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(92, 23);
            this.lblBookID.TabIndex = 6;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(46, 188);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(102, 23);
            this.lblPublisher.TabIndex = 7;
            this.lblPublisher.Text = "Publisher:";
            // 
            // lblCostprice
            // 
            this.lblCostprice.AutoSize = true;
            this.lblCostprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostprice.Location = new System.Drawing.Point(412, 190);
            this.lblCostprice.Name = "lblCostprice";
            this.lblCostprice.Size = new System.Drawing.Size(114, 23);
            this.lblCostprice.TabIndex = 8;
            this.lblCostprice.Text = "Cost Price:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(46, 143);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(80, 23);
            this.lblAuthor.TabIndex = 9;
            this.lblAuthor.Text = "Author:";
            // 
            // lblBooktitle
            // 
            this.lblBooktitle.AutoSize = true;
            this.lblBooktitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooktitle.Location = new System.Drawing.Point(412, 97);
            this.lblBooktitle.Name = "lblBooktitle";
            this.lblBooktitle.Size = new System.Drawing.Size(109, 23);
            this.lblBooktitle.TabIndex = 10;
            this.lblBooktitle.Text = "Book Title:";
            // 
            // lblPurchasebooks
            // 
            this.lblPurchasebooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPurchasebooks.AutoSize = true;
            this.lblPurchasebooks.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasebooks.Location = new System.Drawing.Point(319, 30);
            this.lblPurchasebooks.Name = "lblPurchasebooks";
            this.lblPurchasebooks.Size = new System.Drawing.Size(221, 32);
            this.lblPurchasebooks.TabIndex = 11;
            this.lblPurchasebooks.Text = "Purchase Books";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(46, 235);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(108, 23);
            this.lblCategory.TabIndex = 9;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(176, 227);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(177, 31);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnAddcategory
            // 
            this.btnAddcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddcategory.FlatAppearance.BorderSize = 0;
            this.btnAddcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddcategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddcategory.ForeColor = System.Drawing.Color.White;
            this.btnAddcategory.Location = new System.Drawing.Point(359, 227);
            this.btnAddcategory.Name = "btnAddcategory";
            this.btnAddcategory.Size = new System.Drawing.Size(33, 29);
            this.btnAddcategory.TabIndex = 20;
            this.btnAddcategory.Text = "+";
            this.btnAddcategory.UseVisualStyleBackColor = false;
            this.btnAddcategory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(744, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(57, 39);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(176, 135);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(177, 31);
            this.cmbAuthor.TabIndex = 2;
            // 
            // btnAddauthor
            // 
            this.btnAddauthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddauthor.FlatAppearance.BorderSize = 0;
            this.btnAddauthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddauthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddauthor.ForeColor = System.Drawing.Color.White;
            this.btnAddauthor.Location = new System.Drawing.Point(359, 135);
            this.btnAddauthor.Name = "btnAddauthor";
            this.btnAddauthor.Size = new System.Drawing.Size(33, 29);
            this.btnAddauthor.TabIndex = 23;
            this.btnAddauthor.Text = "+";
            this.btnAddauthor.UseVisualStyleBackColor = false;
            this.btnAddauthor.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(176, 180);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(177, 31);
            this.cmbPublisher.TabIndex = 3;
            // 
            // btnAddpublisher
            // 
            this.btnAddpublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnAddpublisher.FlatAppearance.BorderSize = 0;
            this.btnAddpublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddpublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddpublisher.ForeColor = System.Drawing.Color.White;
            this.btnAddpublisher.Location = new System.Drawing.Point(359, 180);
            this.btnAddpublisher.Name = "btnAddpublisher";
            this.btnAddpublisher.Size = new System.Drawing.Size(33, 29);
            this.btnAddpublisher.TabIndex = 25;
            this.btnAddpublisher.Text = "+";
            this.btnAddpublisher.UseVisualStyleBackColor = false;
            this.btnAddpublisher.Click += new System.EventHandler(this.btnAddpublisher_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(545, 134);
            this.nudQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(234, 32);
            this.nudQuantity.TabIndex = 6;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCostprice
            // 
            this.nudCostprice.Location = new System.Drawing.Point(545, 181);
            this.nudCostprice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudCostprice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCostprice.Name = "nudCostprice";
            this.nudCostprice.Size = new System.Drawing.Size(234, 32);
            this.nudCostprice.TabIndex = 7;
            this.nudCostprice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudSellingprice
            // 
            this.nudSellingprice.Location = new System.Drawing.Point(545, 227);
            this.nudSellingprice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudSellingprice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSellingprice.Name = "nudSellingprice";
            this.nudSellingprice.Size = new System.Drawing.Size(234, 32);
            this.nudSellingprice.TabIndex = 8;
            this.nudSellingprice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(412, 143);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(99, 23);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity:";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(400, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 38);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // frmAddNewBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 523);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudSellingprice);
            this.Controls.Add(this.nudCostprice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddpublisher);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.btnAddauthor);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnAddcategory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbBooktitle);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txbBookID);
            this.Controls.Add(this.lblSellingprice);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCostprice);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBooktitle);
            this.Controls.Add(this.lblPurchasebooks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddNewBook";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingprice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbBooktitle;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Label lblSellingprice;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblCostprice;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblBooktitle;
        private System.Windows.Forms.Label lblPurchasebooks;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddcategory;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddpublisher;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Button btnAddauthor;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.NumericUpDown nudSellingprice;
        private System.Windows.Forms.NumericUpDown nudCostprice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnCancel;
    }
}