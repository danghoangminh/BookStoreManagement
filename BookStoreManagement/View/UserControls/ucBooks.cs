using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStoreManagement.Forms;
using BookStoreManagement.Model;
using System.Data.SqlClient;

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
