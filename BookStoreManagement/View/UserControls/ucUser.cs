using System;
using System.Windows.Forms;
using BookStoreManagement.Presenter;

namespace BookStoreManagement.View.UserControls
{
    public partial class ucUser : UserControl
    {
        UserPresenter presenter;

        public ucUser(string username)
        {
            InitializeComponent();

            string user = username;
            presenter = new UserPresenter(user);

            txbUsername.Text = user;
            txbPassword.Text = presenter.pwd;
            txbFirstname.Text = presenter.firstName;
            txbLastname.Text = presenter.lastName;
            txbEmail.Text = presenter.email;
            txbPhone.Text = presenter.phone;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == txbPasswordagain.Text && txbPassword.Text != null)
            {
                presenter.saveUserData(txbUsername.Text, txbPassword.Text, txbFirstname.Text, txbLastname.Text, txbEmail.Text, txbPhone.Text);
            }
        }
    }
}