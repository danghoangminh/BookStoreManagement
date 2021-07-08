using System.Windows.Forms;

namespace BookStoreManagement.View.UserControls
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
