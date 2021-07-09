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
    public partial class frmLinhVuc : Form
    {
        public frmLinhVuc()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            cbXoaLinhVuc_SelectedIndexChanged();
        }

        private void bXoa_Click(object sender, EventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                try
                {
                    string query = "Delete From LINHVUC Where TENLINHVUC = '" + cboXoaLinhVuc.Text.ToString() + "'";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaLinhVuc_SelectedIndexChanged();
                    MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                }
            }
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (txbThemLinhVuc.Text == "")
            {
                MessageBox.Show("CHƯA NHẬP TÊN LĨNH VỰC!", "THÔNG BÁO");
            }    
            else
            {
                try
                {
                    string query = "Insert Into LINHVUC Values('" + txbThemLinhVuc.Text + "')";
                    DataTable data = DataProvider.Instance.ExecuteQuery(query);
                    listView1_SelectedIndexChanged();
                    cbXoaLinhVuc_SelectedIndexChanged();
                    txbThemLinhVuc.Text = "";
                    MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                }
                catch
                {
                    MessageBox.Show("ĐÃ TỒN TẠI!", "THÔNG BÁO");
                }
            }
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select TENLINHVUC From LINHVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvLinhVuc.Clear();
            this.dgvLinhVuc.Items.Clear();
            this.dgvLinhVuc.View = View.Details;
            this.dgvLinhVuc.Columns.Add("DANH SÁCH CÁC TÊN LĨNH VỰC HIỆN CÓ", 610);
            this.dgvLinhVuc.GridLines = true;
            this.dgvLinhVuc.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvLinhVuc.Items.Add(row["TENLINHVUC"].ToString());
                i++;
            }
        }

        private void cbXoaLinhVuc_SelectedIndexChanged()
        {
            string query = "Select TENLINHVUC From LINHVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboXoaLinhVuc.DataSource = data;
            cboXoaLinhVuc.ValueMember = "TENLINHVUC";
            cboXoaLinhVuc.DisplayMember = "TENLINHVUC";
            cboXoaLinhVuc.Text = null;
        }
    }
}
