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
    public partial class ucRecords : UserControl
    {
        public ucRecords()
        {
            InitializeComponent();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            using (frmStatistic statistic = new frmStatistic())
            {
                statistic.ShowDialog();
            }
        }
    }
}
