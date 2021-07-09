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
    public partial class frmLoaiSach : Form
    {
        public frmLoaiSach()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            cbXoaLoaiSach_SelectedIndexChanged();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select TENLOAISACH From LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvLoaiSach.Clear();
            this.dgvLoaiSach.Items.Clear();
            this.dgvLoaiSach.View = View.Details;
            this.dgvLoaiSach.Columns.Add("DANH SÁCH CÁC LOẠI SÁCH HIỆN CÓ", 610);
            this.dgvLoaiSach.GridLines = true;
            this.dgvLoaiSach.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvLoaiSach.Items.Add(row["TENLOAISACH"].ToString());
                i++;
            }
        }

        private void cbXoaLoaiSach_SelectedIndexChanged()
        {
            string query = "Select TENLOAISACH From LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboXoaLoaiSach.DataSource = data;
            cboXoaLoaiSach.ValueMember = "TENLOAISACH";
            cboXoaLoaiSach.DisplayMember = "TENLOAISACH";
            cboXoaLoaiSach.Text = null;
        }

        private void bThemSach_Click(object sender, EventArgs e)
        {
            if (txbThemLoaiSach.Text == "")
            {
                MessageBox.Show("CHƯA NHẬP TÊN LOẠI SÁCH!", "THÔNG BÁO");
            }
            else
            {
                try
                {
                    string query = "Insert Into LOAISACH Values('" + txbThemLoaiSach.Text + "')";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaLoaiSach_SelectedIndexChanged();
                    txbThemLoaiSach.Text = "";
                    MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("ĐÃ TỒN TẠI!", "THÔNG BÁO");
                }
            }
        }

        private void bXoaSach_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete From LOAISACH Where TENLOAISACH = '" + cboXoaLoaiSach.Text.ToString() + "' AND TENLOAISACH NOT IN (Select TENLOAISACH From SACH)";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaLoaiSach_SelectedIndexChanged();
                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                }
            }
        }
    }
}
