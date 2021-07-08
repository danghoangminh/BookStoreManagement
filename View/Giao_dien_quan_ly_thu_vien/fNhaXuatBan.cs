using Giao_dien_quan_ly_thu_vien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fNhaXuatBan : Form
    {
        public fNhaXuatBan()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            cbXoaNXB_SelectedIndexChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select TENNHAXUATBAN From NHAXUATBAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("DANH SÁCH CÁC NHÀ XUẤT BẢN HIỆN CÓ", 610);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["TENNHAXUATBAN"].ToString());
                i++;
            }
        }

        private void bThemNXB_Click(object sender, EventArgs e)
        {
            if (txbThemNXB.Text == "")
            {
                MessageBox.Show("CHƯA NHẬP TÊN NHÀ XUẤT BẢN!", "THÔNG BÁO");
            }
            else
            {
                try
                {
                    string query = "Insert Into NHAXUATBAN Values('" + txbThemNXB.Text + "')";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaNXB_SelectedIndexChanged();
                    txbThemNXB.Text = "";
                    MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("ĐÃ TỒN TẠI!", "THÔNG BÁO");
                }
            }
        }

        private void cbXoaNXB_SelectedIndexChanged()
        {
            string query = "Select TENNHAXUATBAN From NHAXUATBAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbXoaNXB.DataSource = data;
            cbXoaNXB.ValueMember = "TENNHAXUATBAN";
            cbXoaNXB.DisplayMember = "TENNHAXUATBAN";
            cbXoaNXB.Text = null;
        }

        private void bXoaNXB_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete From NHAXUATBAN Where TENNHAXUATBAN = '" + cbXoaNXB.Text.ToString() + "' AND TENNHAXUATBAN NOT IN (Select TENNHAXUATBAN From SACH)";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaNXB_SelectedIndexChanged();
                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                }
            }
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
