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

        private void button2_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = new BindingSource(LoadSach(), "");
            dataGridView1.Columns[0].HeaderText = "MASACH";
            dataGridView1.Columns[1].HeaderText = "TENSACH";
            dataGridView1.Columns[2].HeaderText = "MATG";
            dataGridView1.Columns[3].HeaderText = "TENLINHVUC";
            dataGridView1.Columns[4].HeaderText = "TENLOAISACH";
            dataGridView1.Columns[5].HeaderText = "GIAMUA";
            dataGridView1.Columns[6].HeaderText = "GIABIA";
            dataGridView1.Columns[7].HeaderText = "LANTAIBAN";
            dataGridView1.Columns[8].HeaderText = "TENNHAXUATBAN";
            dataGridView1.Columns[9].HeaderText = "NAMXUATBAN";
            dataGridView1.Columns[0].Width = 95;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 102;
            dataGridView1.Columns[4].Width = 120;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 95;
            dataGridView1.Columns[8].Width = 150;
            dataGridView1.Columns[9].Width = 110;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

        }
    }
}
