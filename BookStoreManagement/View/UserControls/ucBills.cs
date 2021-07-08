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

namespace BookStoreManagement.UserControls
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
