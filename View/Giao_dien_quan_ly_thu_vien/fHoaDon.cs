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
    public partial class frmHoaDon : Form
    {
        int bChonHD = 0;
        string mahd;
        public frmHoaDon()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            listView3_SelectedIndexChanged();
            txbMaHD_TextChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select MAHOADON, TENKHACHHANG, NGAYLAP, TONGTIEN From HOADON";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvHoaDon.Clear();
            this.dgvHoaDon.Items.Clear();
            this.dgvHoaDon.View = View.Details;
            this.dgvHoaDon.Columns.Add("MÃ HÓA ĐƠN", 110);
            this.dgvHoaDon.Columns.Add("TÊN KHÁCH HÀNG", 190);
            this.dgvHoaDon.Columns.Add("NGÀY LẬP", 200);
            this.dgvHoaDon.Columns.Add("TỔNG TIỀN", 100);
            this.dgvHoaDon.GridLines = true;
            this.dgvHoaDon.FullRowSelect = true;
            this.dgvHoaDon.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvHoaDon.Items.Add(row["MAHOADON"].ToString());
                this.dgvHoaDon.Items[i].SubItems.Add(row["TENKHACHHANG"].ToString());
                this.dgvHoaDon.Items[i].SubItems.Add(row["NGAYLAP"].ToString());
                this.dgvHoaDon.Items[i].SubItems.Add(row["TONGTIEN"].ToString());
                i++;
            }
        }
        private void bChonSua_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvHoaDon.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 1)
            {
                bChonHD = 1;
                foreach (ListViewItem item in this.dgvHoaDon.Items)
                {
                    if (item.Checked == true)
                    {
                        mahd = item.SubItems[0].Text;
                        txbTenKH_Sua.Text = item.SubItems[1].Text;
                        dateTimePicker_Sua.Text = item.SubItems[2].Text;
                    }

                }
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ SỬA CÙNG LÚC NHIỀU HÓA ĐƠN!", "THÔNG BÁO");
            }
        }

        private void bLuu_Click(object sender, EventArgs e)
        {
            if (bChonHD == 1)
            {
                DateTime ngaysua = dateTimePicker_Sua.Value;
                string query = "UPDATE HOADON SET TENKHACHHANG = '" + txbTenKH_Sua.Text + "', NGAYLAP = '" + ngaysua.ToString("yyyy-MM-dd") + "' Where MAHOADON = '" + mahd + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                txbTenKH_Sua.Text = "";
                dateTimePicker_Sua.Text = DateTime.Now.ToString();
                listView1_SelectedIndexChanged();
                bChonHD = 0;
                MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN!", "THÔNG BÁO");
            }
        }

        private void bCTHD_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvHoaDon.Items)
            {
                if (item.Checked)
                {
                    count++;
                    txbTenKhachHang.Text = item.SubItems[1].Text;
                }
            }

            if (count == 1)
            {
                bChonHD = 1;
                foreach (ListViewItem item in this.dgvHoaDon.Items)
                {
                    if (item.Checked == true)
                    {
                        mahd = item.SubItems[0].Text;
                    }

                }
                listView2_SelectedIndexChanged();
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN HÓA ĐƠN NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ XEM CHI TIẾT CÙNG LÚC NHIỀU HÓA ĐƠN!", "THÔNG BÁO");
            }
            listView1_SelectedIndexChanged();
        }

        private void listView2_SelectedIndexChanged()
        {
            string query2 = "Select MAHOADON, CHITIETHOADON.MASACH, TENSACH, SOLUONG, GIATIEN, THANHTIEN " +
                "From CHITIETHOADON LEFT JOIN SACH ON CHITIETHOADON.MASACH = SACH. MASACH Where MAHOADON = '" + mahd + "'";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);

            this.dgvChiTietHoaDon.Clear();
            this.dgvChiTietHoaDon.Items.Clear();
            this.dgvChiTietHoaDon.View = View.Details;
            this.dgvChiTietHoaDon.Columns.Add("MÃ HÓA ĐƠN", 110);
            this.dgvChiTietHoaDon.Columns.Add("MÃ SÁCH", 110);
            this.dgvChiTietHoaDon.Columns.Add("TÊN SÁCH", 190);
            this.dgvChiTietHoaDon.Columns.Add("SỐ LƯỢNG", 110);
            this.dgvChiTietHoaDon.Columns.Add("GIÁ TIỀN", 150);
            this.dgvChiTietHoaDon.Columns.Add("THÀNH TIỀN", 190);
            this.dgvChiTietHoaDon.GridLines = true;
            this.dgvChiTietHoaDon.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data2.Rows)
            {
                this.dgvChiTietHoaDon.Items.Add(row["MAHOADON"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["MASACH"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["GIATIEN"].ToString());
                this.dgvChiTietHoaDon.Items[i].SubItems.Add(row["THANHTIEN"].ToString());
                i++;
            }
        }

        private void bXoaHD_Click(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.dgvHoaDon.Items)
            {
                if (item.Checked)
                    count0++;
            }
            if (count0 > 0)
            {
                DialogResult d;
                d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    int count = 0;
                    foreach (ListViewItem item in this.dgvHoaDon.Items)
                    {
                        if (item.Checked == true)
                        {
                            count++;
                            string Ma = item.Text;
                            string query0 = "Delete From CHITIETHOADON Where MAHOADON = '" + Ma + "'";
                            DataTable data0 = DataProvider.Instance.ExecuteQuery(query0);
                            string query = "Delete From HOADON Where MAHOADON = '" + Ma + "'";
                            DataTable data = DataProvider.Instance.ExecuteQuery(query);
                            item.Remove();
                            MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ GÌ ĐỂ XÓA!", "THÔNG BÁO");
            }
        }

        private void txbMaHD_TextChanged()
        {
            Random rd = new Random();
            txbMaHD.Text = ("HD0" + rd.Next(99, 1000));
        }


        int tong=0;
        private void bChonSach_Click(object sender, EventArgs e)
        {
            if (txbTenKH.Text == "")
            {
                MessageBox.Show("NHẬP TÊN KHÁCH HÀNG!", "THÔNG BÁO");
                txbTenKH.ReadOnly = false;
            }
            else
            {
                txbTenKH.ReadOnly = true;
                int dem = 0;
                foreach (ListViewItem item in this.dgvChonSach.Items)
                {
                    if (item.Checked)
                    {
                        dem++;
                    }
                }

                if (dem == 1)
                {
                    int hientai = 0;
                    foreach (ListViewItem item in this.dgvChonSach.Items)
                    {
                        if (item.Checked == true)
                        {
                            string query4 = "Select SOLUONG From KHO where MASACH = '" + item.SubItems[0].Text + "'";
                            object data4 = DataProvider.Instance.ExecuteScalar(query4);
                            int hieu;
                            hieu = Convert.ToInt32(data4) - Convert.ToInt32(numericUpDownSoLuong.Value);
                            if (hieu >= Convert.ToInt32(numericUpDownSoLuong.Value))
                            {
                                hientai = Convert.ToInt32(item.SubItems[2].Text) * Convert.ToInt32(numericUpDownSoLuong.Value);
                                try
                                {
                                    DateTime ngaylap = dateTimePicker_NgayLap.Value;
                                    string query1 = "Insert into HOADON values ('" + txbMaHD.Text + "', '" + txbTenKH.Text + "', '" +
                                        ngaylap.ToString("yyyy-MM-dd") + "', " + hientai + ")";
                                    DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
                                    tong = tong + hientai;
                                }
                                catch
                                {
                                    tong = tong + hientai;
                                    string query2 = "Update HOADON set TONGTIEN = " + tong + " where MAHOADON = '" + txbMaHD.Text + "'";
                                    DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
                                }

                                string query3 = "Insert into CHITIETHOADON values ('" + txbMaHD.Text + "', '" + item.SubItems[0].Text + "', '"
                                    + numericUpDownSoLuong.Value + "', '" + item.SubItems[2].Text + "', " + hientai + ")";
                                DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);

                                string query5 = "UPDATE KHO SET SOLUONG = " + hieu + " Where MASACH = '" + item.SubItems[0].Text + "'";
                                DataTable data5 = DataProvider.Instance.ExecuteQuery(query5);
                                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                            }
                            else
                            {
                                MessageBox.Show("KHÔNG CÒN SÁCH '" + item.SubItems[1].Text + "' TRONG KHO", "THÔNG BÁO");
                            }
                            listView1_SelectedIndexChanged();
                        }
                    }
                    numericUpDownSoLuong.Value = 1;
                    listView3_SelectedIndexChanged();
                }
                else if (dem == 0)
                {
                    MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
                }    
                else
                {
                    MessageBox.Show("CHỌN TỪNG SÁCH VÀ NHẬP SỐ LƯỢNG!", "THÔNG BÁO");
                }
            }
        }

        private void listView3_SelectedIndexChanged()
        {
            string query3 = "Select MASACH, TENSACH, GIABIA, TACGIA.MATG, TENTG, TENLINHVUC, TENLOAISACH From SACH LEFT JOIN TACGIA " +
                "ON SACH.MATG = TACGIA.MATG";
            DataTable data3 = DataProvider.Instance.ExecuteQuery(query3);

            this.dgvChonSach.Clear();
            this.dgvChonSach.Items.Clear();
            this.dgvChonSach.View = View.Details;
            this.dgvChonSach.Columns.Add("MÃ SÁCH", 100);
            this.dgvChonSach.Columns.Add("TÊN SÁCH", 240);
            this.dgvChonSach.Columns.Add("GIÁ BÌA", 150);
            this.dgvChonSach.Columns.Add("MÃ TÁC GIẢ", 100);
            this.dgvChonSach.Columns.Add("TÊN TÁC GIẢ", 180);
            this.dgvChonSach.Columns.Add("TÊN LĨNH VỰC", 150);
            this.dgvChonSach.Columns.Add("TÊN LOẠI SÁCH", 150);
            this.dgvChonSach.GridLines = true;
            this.dgvChonSach.FullRowSelect = true;
            this.dgvChonSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data3.Rows)
            {
                this.dgvChonSach.Items.Add(row["MASACH"].ToString());
                this.dgvChonSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.dgvChonSach.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.dgvChonSach.Items[i].SubItems.Add(row["MATG"].ToString());
                this.dgvChonSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.dgvChonSach.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.dgvChonSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                i++;
            }
        }

        private void bThemHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOÀN THÀNH HÓA ĐƠN!", "THÔNG BÁO");
            listView1_SelectedIndexChanged();
            listView3_SelectedIndexChanged();
            txbMaHD_TextChanged();
            txbTenKH.Text = "";
            dateTimePicker_NgayLap.Text = DateTime.Now.ToString();
            tong = 0;
            txbTenKH.ReadOnly = false;
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
