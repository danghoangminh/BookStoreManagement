using System;
using System.Data;
using System.Windows.Forms;
using BookStoreManagement.Forms;
using BookStoreManagement.Model;

namespace BookStoreManagement.UserControls
{
    public partial class ucBooks : UserControl
    {
        public ucBooks()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using (frmAddNewBook abn = new frmAddNewBook())
            {
                abn.ShowDialog();
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            using (frmAddStock ads = new frmAddStock())
            {
                ads.ShowDialog();
            }
        }

        private void LoadBook(object sender, EventArgs e)
        {
            BookModel book = new BookModel();
            DataTable ds = book.LoadData();

            dgvListBook.DataSource = ds;
            dgvListBook.AllowUserToAddRows = false;
            dgvListBook.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
    }
}
