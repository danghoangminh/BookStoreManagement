﻿using System;
using System.Windows.Forms;

namespace BookStoreManagement.View.Forms
{
    public partial class frmAddPublisher : Form
    {
        public frmAddPublisher()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}