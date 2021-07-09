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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bXuatBC_Click(object sender, EventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void listView1_SelectedIndexChanged()
        {
            DateTime tungay = dateTimePicker_TuNgay.Value;
            DateTime denngay = dateTimePicker_DenNgay.Value;
            string query = "Select MAHOADON, TENKHACHHANG, NGAYLAP, TONGTIEN from HOADON where NGAYLAP between '" + 
                tungay.ToString("yyyy/MM/dd") + "' and '" + denngay.ToString("yyyy/MM/dd") + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvThongKe.Clear();
            this.dgvThongKe.Items.Clear();
            this.dgvThongKe.View = View.Details;
            this.dgvThongKe.Columns.Add("MÃ HÓA ĐƠN", 150);
            this.dgvThongKe.Columns.Add("TÊN KHÁCH HÀNG", 250);
            this.dgvThongKe.Columns.Add("NGÀY LẬP", 200);
            this.dgvThongKe.Columns.Add("TỔNG TIỀN", 200);
            this.dgvThongKe.GridLines = true;
            this.dgvThongKe.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvThongKe.Items.Add(row["MAHOADON"].ToString());
                this.dgvThongKe.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.dgvThongKe.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.dgvThongKe.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }

        private void bTimKiem_Click(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged();
        }
    }
}
