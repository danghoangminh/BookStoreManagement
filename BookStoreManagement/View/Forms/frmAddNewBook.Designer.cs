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
            this.bSave = new System.Windows.Forms.Button();
            this.txbBooktitle = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lSellingprice = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.lPublisher = new System.Windows.Forms.Label();
            this.lCostprice = new System.Windows.Forms.Label();
            this.lAuthor = new System.Windows.Forms.Label();
            this.lBooktitle = new System.Windows.Forms.Label();
            this.lPurchasebooks = new System.Windows.Forms.Label();
            this.lQuantity = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.cmbAuthor = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.lLanguage = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudCostprice = new System.Windows.Forms.NumericUpDown();
            this.nudSellingprice = new System.Windows.Forms.NumericUpDown();
            this.nudReprint = new System.Windows.Forms.NumericUpDown();
            this.lReprint = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellingprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReprint)).BeginInit();
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
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bSave.BackColor = System.Drawing.Color.SeaGreen;
            this.bSave.FlatAppearance.BorderSize = 0;
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSave.ForeColor = System.Drawing.Color.White;
            this.bSave.Location = new System.Drawing.Point(570, 440);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(164, 38);
            this.bSave.TabIndex = 20;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = false;
            // 
            // txbBooktitle
            // 
            this.txbBooktitle.Location = new System.Drawing.Point(545, 88);
            this.txbBooktitle.Name = "txbBooktitle";
            this.txbBooktitle.Size = new System.Drawing.Size(234, 32);
            this.txbBooktitle.TabIndex = 14;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(176, 88);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(177, 32);
            this.txbID.TabIndex = 18;
            // 
            // lSellingprice
            // 
            this.lSellingprice.AutoSize = true;
            this.lSellingprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSellingprice.Location = new System.Drawing.Point(412, 282);
            this.lSellingprice.Name = "lSellingprice";
            this.lSellingprice.Size = new System.Drawing.Size(133, 23);
            this.lSellingprice.TabIndex = 5;
            this.lSellingprice.Text = "Selling Price:";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lID.Location = new System.Drawing.Point(46, 97);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(124, 23);
            this.lID.TabIndex = 6;
            this.lID.Text = "Tracking ID:";
            // 
            // lPublisher
            // 
            this.lPublisher.AutoSize = true;
            this.lPublisher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPublisher.Location = new System.Drawing.Point(46, 188);
            this.lPublisher.Name = "lPublisher";
            this.lPublisher.Size = new System.Drawing.Size(102, 23);
            this.lPublisher.TabIndex = 7;
            this.lPublisher.Text = "Publisher:";
            // 
            // lCostprice
            // 
            this.lCostprice.AutoSize = true;
            this.lCostprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCostprice.Location = new System.Drawing.Point(412, 235);
            this.lCostprice.Name = "lCostprice";
            this.lCostprice.Size = new System.Drawing.Size(114, 23);
            this.lCostprice.TabIndex = 8;
            this.lCostprice.Text = "Cost Price:";
            // 
            // lAuthor
            // 
            this.lAuthor.AutoSize = true;
            this.lAuthor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAuthor.Location = new System.Drawing.Point(46, 143);
            this.lAuthor.Name = "lAuthor";
            this.lAuthor.Size = new System.Drawing.Size(80, 23);
            this.lAuthor.TabIndex = 9;
            this.lAuthor.Text = "Author:";
            // 
            // lBooktitle
            // 
            this.lBooktitle.AutoSize = true;
            this.lBooktitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBooktitle.Location = new System.Drawing.Point(412, 97);
            this.lBooktitle.Name = "lBooktitle";
            this.lBooktitle.Size = new System.Drawing.Size(109, 23);
            this.lBooktitle.TabIndex = 10;
            this.lBooktitle.Text = "Book Title:";
            // 
            // lPurchasebooks
            // 
            this.lPurchasebooks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lPurchasebooks.AutoSize = true;
            this.lPurchasebooks.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPurchasebooks.Location = new System.Drawing.Point(319, 30);
            this.lPurchasebooks.Name = "lPurchasebooks";
            this.lPurchasebooks.Size = new System.Drawing.Size(221, 32);
            this.lPurchasebooks.TabIndex = 11;
            this.lPurchasebooks.Text = "Purchase Books";
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantity.Location = new System.Drawing.Point(412, 143);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(99, 23);
            this.lQuantity.TabIndex = 5;
            this.lQuantity.Text = "Quantity:";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategory.Location = new System.Drawing.Point(46, 235);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(108, 23);
            this.lCategory.TabIndex = 9;
            this.lCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(176, 227);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(177, 31);
            this.cmbCategory.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(359, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bClear.BackColor = System.Drawing.Color.Red;
            this.bClear.FlatAppearance.BorderSize = 0;
            this.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.ForeColor = System.Drawing.Color.White;
            this.bClear.Location = new System.Drawing.Point(425, 440);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(138, 38);
            this.bClear.TabIndex = 20;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = false;
            // 
            // bExit
            // 
            this.bExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bExit.BackColor = System.Drawing.Color.White;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExit.Location = new System.Drawing.Point(744, 14);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(57, 39);
            this.bExit.TabIndex = 20;
            this.bExit.Text = "X";
            this.bExit.UseVisualStyleBackColor = false;
            this.bExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // cmbAuthor
            // 
            this.cmbAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAuthor.FormattingEnabled = true;
            this.cmbAuthor.Location = new System.Drawing.Point(176, 135);
            this.cmbAuthor.Name = "cmbAuthor";
            this.cmbAuthor.Size = new System.Drawing.Size(177, 31);
            this.cmbAuthor.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(359, 135);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 29);
            this.button5.TabIndex = 23;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(176, 180);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(177, 31);
            this.cmbPublisher.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(359, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(33, 29);
            this.button6.TabIndex = 25;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // lLanguage
            // 
            this.lLanguage.AutoSize = true;
            this.lLanguage.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLanguage.Location = new System.Drawing.Point(46, 282);
            this.lLanguage.Name = "lLanguage";
            this.lLanguage.Size = new System.Drawing.Size(114, 23);
            this.lLanguage.TabIndex = 26;
            this.lLanguage.Text = "Language:";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(176, 274);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(177, 31);
            this.cmbLanguage.TabIndex = 27;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(359, 274);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(33, 29);
            this.button7.TabIndex = 28;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = false;
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
            this.nudQuantity.TabIndex = 33;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCostprice
            // 
            this.nudCostprice.Location = new System.Drawing.Point(545, 227);
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
            this.nudCostprice.TabIndex = 34;
            this.nudCostprice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudSellingprice
            // 
            this.nudSellingprice.Location = new System.Drawing.Point(545, 273);
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
            this.nudSellingprice.TabIndex = 35;
            this.nudSellingprice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // nudReprint
            // 
            this.nudReprint.Location = new System.Drawing.Point(545, 179);
            this.nudReprint.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudReprint.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReprint.Name = "nudReprint";
            this.nudReprint.Size = new System.Drawing.Size(234, 32);
            this.nudReprint.TabIndex = 36;
            this.nudReprint.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lReprint
            // 
            this.lReprint.AutoSize = true;
            this.lReprint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReprint.Location = new System.Drawing.Point(412, 188);
            this.lReprint.Name = "lReprint";
            this.lReprint.Size = new System.Drawing.Size(83, 23);
            this.lReprint.TabIndex = 37;
            this.lReprint.Text = "Reprint:";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lYear.Location = new System.Drawing.Point(412, 329);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(60, 23);
            this.lYear.TabIndex = 38;
            this.lYear.Text = "Year:";
            // 
            // dtpYear
            // 
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYear.Location = new System.Drawing.Point(545, 320);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(234, 32);
            this.dtpYear.TabIndex = 39;
            // 
            // frmAddNewBook
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 523);
            this.Controls.Add(this.dtpYear);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.lReprint);
            this.Controls.Add(this.nudReprint);
            this.Controls.Add(this.nudSellingprice);
            this.Controls.Add(this.nudCostprice);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lLanguage);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cmbAuthor);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.txbBooktitle);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lSellingprice);
            this.Controls.Add(this.lID);
            this.Controls.Add(this.lPublisher);
            this.Controls.Add(this.lCategory);
            this.Controls.Add(this.lCostprice);
            this.Controls.Add(this.lAuthor);
            this.Controls.Add(this.lBooktitle);
            this.Controls.Add(this.lPurchasebooks);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudReprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox txbBooktitle;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lSellingprice;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.Label lPublisher;
        private System.Windows.Forms.Label lCostprice;
        private System.Windows.Forms.Label lAuthor;
        private System.Windows.Forms.Label lBooktitle;
        private System.Windows.Forms.Label lPurchasebooks;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bClear;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbAuthor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lLanguage;
        private System.Windows.Forms.NumericUpDown nudSellingprice;
        private System.Windows.Forms.NumericUpDown nudCostprice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lReprint;
        private System.Windows.Forms.NumericUpDown nudReprint;
    }
}