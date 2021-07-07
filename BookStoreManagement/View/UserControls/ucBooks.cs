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

        SqlConnection con = new SqlConnection(@"Data Source=HTT27\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=SSPI");
        public DataTable LoadSach()
        {
            //con.Open();
            string str = "select * from SACH ";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            return dt;
            con.Close();
        }

        private void fViewTong_Load(object sender, EventArgs e)
        {
            dgvListBook.DataSource = new BindingSource(LoadSach(), "");
            dgvListBook.Columns[0].HeaderText = "MASACH";
            dgvListBook.Columns[1].HeaderText = "TENSACH";
            dgvListBook.Columns[2].HeaderText = "MATG";
            dgvListBook.Columns[3].HeaderText = "TENLINHVUC";
            dgvListBook.Columns[4].HeaderText = "TENLOAISACH";
            dgvListBook.Columns[5].HeaderText = "GIAMUA";
            dgvListBook.Columns[6].HeaderText = "GIABIA";
            dgvListBook.Columns[7].HeaderText = "LANTAIBAN";
            dgvListBook.Columns[8].HeaderText = "TENNHAXUATBAN";
            dgvListBook.Columns[9].HeaderText = "NAMXUATBAN";
            dgvListBook.Columns[0].Width = 95;
            dgvListBook.Columns[1].Width = 100;
            dgvListBook.Columns[2].Width = 100;
            dgvListBook.Columns[3].Width = 102;
            dgvListBook.Columns[4].Width = 120;
            dgvListBook.Columns[5].Width = 100;
            dgvListBook.Columns[6].Width = 100;
            dgvListBook.Columns[7].Width = 95;
            dgvListBook.Columns[8].Width = 150;
            dgvListBook.Columns[9].Width = 110;

            dgvListBook.AllowUserToAddRows = false;
            dgvListBook.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
    }
}
