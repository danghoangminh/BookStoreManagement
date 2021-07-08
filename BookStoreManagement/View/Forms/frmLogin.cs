﻿using System;
using System.Windows.Forms;
using BookStoreManagement.Presenter;

namespace BookStoreManagement.View.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _ = new LoginPresenter(txbUser.Text, txbPassword.Text);
        }
    }
}