using System;
using System.Windows.Forms;
using BookStoreManagement.Presenter;

namespace BookStoreManagement.View.Forms
{
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookPresenter presenter = new BookPresenter();
            presenter.addItem(txbCategoryname.Text, "CATEGORY");
        }
    }
}
