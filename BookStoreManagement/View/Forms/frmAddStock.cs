using System;
using System.Windows.Forms;
using BookStoreManagement.Model;
using BookStoreManagement.Presenter;

namespace BookStoreManagement.View.Forms
{
    public partial class frmAddStock : Form
    {
        public BookModel model = new BookModel();
        public BookPresenter presenter = new BookPresenter();

        public frmAddStock()
        {
            InitializeComponent();

            cboBookTittle.DataSource = model.LoadList("BOOK", "BOOKTITLE");
            cboBookTittle.DisplayMember = "BOOK";
            cboBookTittle.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.addQty("BOOK", "QUANTITY", ((int)nudQuantity.Value), "BOOKID", txbBookID.Text);
        }

        private void cboBookTittle_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbBookID.Text = model.LoadItem("BOOKID", "BOOK", "BOOKTITLE", cboBookTittle.Text);
        }
    }
}
