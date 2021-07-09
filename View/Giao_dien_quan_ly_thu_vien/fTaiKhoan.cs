using Giao_dien_quan_ly_thu_vien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class frmTaiKhoan : Form
    {
        int bChonTK = 0;
        public frmTaiKhoan()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCapNhap_Click(object sender, EventArgs e)
        {
            if (bChonTK == 1)
            {
                string query0 = "Select * From TAIKHOAN WHERE USERNAME = '" + txbTenDangNhap.Text + "' AND PASS_WORD = '" + txbMKHienTai.Text + "'" ;
                int data0 = DataProvider.Instance.ExecuteNonQuery(query0);
                if (data0 == -1)
                {
                    if (txbMKMoi.Text == txbMKMoiNhapLai.Text)
                    {
                        string query = "Update TAIKHOAN set PASS_WORD='" + txbMKMoiNhapLai.Text + "' Where USERNAME='" + txbTenDangNhap.Text + "'";
                        DataTable data = DataProvider.Instance.ExecuteQuery(query);
                        txbTenDangNhap.Text = "";
                        txbMKMoiNhapLai.Text = "";
                        txbMKMoi.Text = "";
                        MessageBox.Show("CẬP NHẬP TÀI KHOẢN THÀNH CÔNG!", "THÔNG BÁO");
                        bChonTK = 0;
                        frmDangNhap f = new frmDangNhap();
                        this.Hide();
                        //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("MẬT KHẨU NHẬP LẠI KHÔNG ĐÚNG, MỜI NHẬP LẠI!", "THÔNG BÁO");
                    }
                }
                else
                {
                    MessageBox.Show("MẬT KHẨU HIỆN TẠI KHÔNG ĐÚNG, MỜI NHẬP LẠI!", "THÔNG BÁO");
                }
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN!", "THÔNG BÁO");
            } 
                
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select USERNAME From TAIKHOAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvTaiKhoan.Clear();
            this.dgvTaiKhoan.Items.Clear();
            this.dgvTaiKhoan.View = View.Details;
            this.dgvTaiKhoan.Columns.Add("DANH SÁCH CÁC NGƯỜI DÙNG", 480);
            this.dgvTaiKhoan.GridLines = true;
            this.dgvTaiKhoan.FullRowSelect = true;
            this.dgvTaiKhoan.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvTaiKhoan.Items.Add(row["USERNAME"].ToString());
                i++;
            }
        }

        private void bChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvTaiKhoan.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN TÀI KHOẢN NÀO!", "THÔNG BÁO");
            }
            else if (count == 1)
            {
                bChonTK = 1;
                foreach (ListViewItem item in this.dgvTaiKhoan.Items)
                {
                    if (item.Checked == true)
                    {
                        txbTenDangNhap.Text = item.SubItems[0].Text;
                    }
                }
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ CẬP NHẬP CÙNG LÚC NHIỀU TÀI KHOẢN!", "THÔNG BÁO");
            }
        }

        private void lblTenDangNhap1_Click(object sender, EventArgs e)
        {

        }
    }
}
