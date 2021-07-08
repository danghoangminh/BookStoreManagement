using System;
using System.Windows.Forms;
using BookStoreManagement.View.Forms;
using BookStoreManagement.Presenter;

namespace BookStoreManagement.View.UserControls
{
    public partial class ucBooks : UserControl
    {
        public ucBooks()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (frmAddNewBook addNewBook = new frmAddNewBook())
            {
                addNewBook.ShowDialog();
            }
            loadDGV();
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            using (frmAddStock addStock = new frmAddStock())
            {
                addStock.ShowDialog();
            }
            loadDGV();
        }

        protected void loadDGV()
        {
            BookPresenter presenter = new BookPresenter();

            dgvListBook.DataSource = presenter.ds;
            dgvListBook.AllowUserToAddRows = false;
            dgvListBook.EditMode = DataGridViewEditMode.EditProgrammatically;

            dgvListBook.Columns[0].HeaderText = "BOOK_ID";
            dgvListBook.Columns[1].HeaderText = "BOOK_TITLE";
            dgvListBook.Columns[5].HeaderText = "COST_PRICE";
            dgvListBook.Columns[6].HeaderText = "SELL_PRICE";

            dgvListBook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListBook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListBook.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListBook.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListBook.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListBook.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListBook.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvListBook.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void LoadBook(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txbSearch.Text;
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
