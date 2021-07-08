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
    public partial class fThongKe : Form
    {
        public fThongKe()
        {
            InitializeComponent();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bXuatBC_Click(object sender, EventArgs e)
        {
            fBaoCao f = new fBaoCao();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select MAHOADON, TENKHACHHANG, NGAYLAP, TONGTIEN from HOADON where NGAYLAP between '" + 
                dateTimePicker_TuNgay.Text + "' and '" + dateTimePicker_Den.Text + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ HÓA ĐƠN", 150);
            this.listView1.Columns.Add("TÊN KHÁCH HÀNG", 250);
            this.listView1.Columns.Add("NGÀY LẬP", 200);
            this.listView1.Columns.Add("TỔNG TIỀN", 200);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MAHOADON"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.listView1.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }

        private void bTimKiem_Click(object sender, EventArgs e)
        {
            listView1_SelectedIndexChanged();
        }
    }
}
