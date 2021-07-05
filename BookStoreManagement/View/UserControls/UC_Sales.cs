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
    public partial class UC_Sales : UserControl
    {
        public UC_Sales()
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
    }
}
