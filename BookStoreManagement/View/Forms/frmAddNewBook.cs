using System;
using System.Windows.Forms;

namespace BookStoreManagement.Forms
{
    public partial class frmAddNewBook : Form
    {
        public frmAddNewBook()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (frmAddCategory addCategory= new frmAddCategory())
            {
                addCategory.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (frmAddAuthor addAuthor = new frmAddAuthor())
            {
                addAuthor.ShowDialog();
            }
        }

        private void btnAddpublisher_Click(object sender, EventArgs e)
        {
            using (frmAddPublisher addPublisher = new frmAddPublisher())
            {
                addPublisher.ShowDialog();
            }
        }
    }
}
