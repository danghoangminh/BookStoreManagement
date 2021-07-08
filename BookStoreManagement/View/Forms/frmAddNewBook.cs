using BookStoreManagement.Presenter;
using System;
using System.Windows.Forms;
using BookStoreManagement.Model;

namespace BookStoreManagement.View.Forms
{
    public partial class frmAddNewBook : Form
    {
        public BookPresenter presenter = new BookPresenter();
        public BookModel model;

        public frmAddNewBook()
        {
            InitializeComponent();

            txbBookID.Text = presenter.generateID();
            load();
        }

        private void load()
        {
            model = new BookModel();

            cboAuthor.DataSource = model.LoadList("AUTHOR", "AUTHORNAME");
            cboAuthor.DisplayMember = "AUTHOR";

            cboPublisher.DataSource = model.LoadList("PUBLISHER", "PUBLISHERNAME");
            cboPublisher.DisplayMember = "PUBLISHER";

            cboCategory.DataSource = model.LoadList("CATEGORY", "CATEGORYNAME");
            cboCategory.DisplayMember = "CATEGORY";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddcategory_Click(object sender, EventArgs e)
        {
            using (frmAddCategory addCategory= new frmAddCategory())
            {
                addCategory.ShowDialog();
            }
            load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddauthor_Click(object sender, EventArgs e)
        {
            using (frmAddAuthor addAuthor = new frmAddAuthor())
            {
                addAuthor.ShowDialog();
            }
            load();
        }

        private void btnAddpublisher_Click(object sender, EventArgs e)
        {
            using (frmAddPublisher addPublisher = new frmAddPublisher())
            {
                addPublisher.ShowDialog();
            }
            load();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            presenter.addBook(txbBookID.Text, txbBooktitle.Text, cboAuthor.Text, cboCategory.Text, cboPublisher.Text, ((int)nudCostprice.Value), ((int)nudSellingprice.Value), ((int)nudQuantity.Value));
            this.Dispose();
        }
    }
}
