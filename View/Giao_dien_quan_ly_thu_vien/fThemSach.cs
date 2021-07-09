using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Giao_dien_quan_ly_thu_vien.DAO;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class frmThemSach : Form
    {
        public frmThemSach()
        {
            InitializeComponent();
            txbMaSach_TextChanged();
            cbMaTacGia_SelectedIndexChanged();
            cbTenLinhVuc_SelectedIndexChanged();
            cbTenLoaiSach_SelectedIndexChanged();
            cbTenNXB_SelectedIndexChanged();
        }

        private void txbMaSach_TextChanged()
        {
            Random rd = new Random();
            txbMaSach.Text = ("SA0" + rd.Next(99, 1000));
        }

        private void cbMaTacGia_SelectedIndexChanged()
        {
            string query = "Select MATG, TENTG from TACGIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenTacGia.DataSource = data;
            cboTenTacGia.ValueMember = "MATG";
            cboTenTacGia.DisplayMember = "TENTG";
        }

        private void cbTenLinhVuc_SelectedIndexChanged()
        {
            string query = "Select TENLINHVUC from LINHVUC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenLinhVuc.DataSource = data;
            cboTenLinhVuc.DisplayMember = "TENLINHVUC";
        }

        private void cbTenLoaiSach_SelectedIndexChanged()
        {
            string query = "Select TENLOAISACH from LOAISACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenLoaiSach.DataSource = data;
            cboTenLoaiSach.DisplayMember = "TENLOAISACH";
        }

        private void cbTenNXB_SelectedIndexChanged()
        {
            string query = "Select TENNHAXUATBAN from NHAXUATBAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenNXB.DataSource = data;
            cboTenNXB.DisplayMember = "TENNHAXUATBAN";
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (txbTenSach.Text == "" || cboTenTacGia.Text == "" || cboTenLinhVuc.Text == "" || cboTenLoaiSach.Text == "" || cboTenNXB.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN ĐỦ THÔNG TIN!", "THÔNG BÁO");
            }
            else
            {
                DateTime namxb = dateTimePickerNamXuatBan.Value;
                
                string query = "Insert into SACH values('" + txbMaSach.Text + "','" + txbTenSach.Text + "'," +
                        "(Select MATG From TACGIA Where TENTG = '" + cboTenTacGia.Text.ToString() + "'),'" + cboTenLinhVuc.Text + "','" + cboTenLoaiSach.Text + "','" + numericUpDownGiaMua.Value + "'," +
                        "'" + numericUpDownGiaBia.Value + "','" + numericUpDownLanTaiBan.Value + "','" + cboTenNXB.Text.ToString() + "'," +
                        "'" + namxb.ToString("yyyy-MM-dd") + "')";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                txbMaSach_TextChanged();
                txbTenSach.Text = "";
                cbMaTacGia_SelectedIndexChanged();
                cbTenLinhVuc_SelectedIndexChanged();
                cbTenLoaiSach_SelectedIndexChanged();
                cbTenNXB_SelectedIndexChanged();
                numericUpDownGiaMua.Value = 1000;
                numericUpDownGiaBia.Value = 1000;
                numericUpDownLanTaiBan.Value = 0;
                dateTimePickerNamXuatBan.Text = DateTime.Now.ToString();
            }
        }
    }
}
