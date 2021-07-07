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
            using (frmAddCategory ac = new frmAddCategory())
            {
                ac.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
