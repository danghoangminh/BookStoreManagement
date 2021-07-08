using System;
using System.Windows.Forms;
using BookStoreManagement.View.Forms;

namespace BookStoreManagement.View.UserControls
{
    public partial class ucSales : UserControl
    {
        public ucSales()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (frmFinishOrder uf = new frmFinishOrder())
            {
                uf.ShowDialog();
            }
        }

        private void ucSales_Load(object sender, EventArgs e)
        {

        }

        private void btnAddbill_Click(object sender, EventArgs e)
        {
            using (frmAddBillDetail addBillDetail = new frmAddBillDetail())
            {
                addBillDetail.ShowDialog();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
