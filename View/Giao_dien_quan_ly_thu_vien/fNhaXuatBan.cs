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
    public partial class frmNhaXuatBan : Form
    {
        public frmNhaXuatBan()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            cbXoaNXB_SelectedIndexChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select TENNHAXUATBAN From NHAXUATBAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvNhaXuatBan.Clear();
            this.dgvNhaXuatBan.Items.Clear();
            this.dgvNhaXuatBan.View = View.Details;
            this.dgvNhaXuatBan.Columns.Add("DANH SÁCH CÁC NHÀ XUẤT BẢN HIỆN CÓ", 610);
            this.dgvNhaXuatBan.GridLines = true;
            this.dgvNhaXuatBan.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvNhaXuatBan.Items.Add(row["TENNHAXUATBAN"].ToString());
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
            cboXoaNXB.DataSource = data;
            cboXoaNXB.ValueMember = "TENNHAXUATBAN";
            cboXoaNXB.DisplayMember = "TENNHAXUATBAN";
            cboXoaNXB.Text = null;
        }

        private void bXoaNXB_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete From NHAXUATBAN Where TENNHAXUATBAN = '" + cboXoaNXB.Text.ToString() + "' AND TENNHAXUATBAN NOT IN (Select TENNHAXUATBAN From SACH)";
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
