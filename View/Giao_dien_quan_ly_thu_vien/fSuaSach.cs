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
    public partial class fSuaSach : Form
    {
        int bChon = 0;
        public fSuaSach()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbLuu_Click(object sender, EventArgs e)
        {
            if (bChon == 1)
            {
                string query = "UPDATE SACH" +
                    " SET TENSACH = '" + txbTenSach.Text + "', MATG = (Select MATG From TACGIA Where TENTG = '" + cbTenTacGia.Text.ToString() + "'), " +
                    "TENLINHVUC = '" + cbTenLinhVuc.Text.ToString() + "', TENLOAISACH = '" + cbTenLoaiSach.Text.ToString() + "', GIAMUA = " +
                    numericUpDownGiaMua.Value + ", GIABIA = " + numericUpDownGiaBia.Value + ", LANTAIBAN = " + numericUpDownLanTaiBan.Value +
                    ", TENNHAXUATBAN = '" + cbTenNXB.Text.ToString() + "', NAMXUATBAN = '" + dateTimePicker_NamXuatBan.Text + "' WHERE MASACH = '" + txbMaSach.Text + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
                txbMaSach.Text = "";
                txbTenSach.Text = "";
                numericUpDownGiaMua.Value = 1000;
                numericUpDownGiaBia.Value = 1000;
                numericUpDownLanTaiBan.Value = 0;
                dateTimePicker_NamXuatBan.Text = DateTime.Now.ToString();
                listView1_SelectedIndexChanged();
                bChon = 0;
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
            }
        }


        private void listView1_SelectedIndexChanged()
        {
            string query = "Select MASACH, TENSACH, TENTG, TENLINHVUC, TENLOAISACH, GIAMUA, GIABIA, LANTAIBAN, " +
                "TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA ON SACH.MATG = TACGIA.MATG";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ SÁCH", 150);
            this.listView1.Columns.Add("TÊN SÁCH", 270);
            this.listView1.Columns.Add("TÁC GIẢ", 200);
            this.listView1.Columns.Add("LĨNH VỰC", 100);
            this.listView1.Columns.Add("LOẠI SÁCH", 150);
            this.listView1.Columns.Add("GIÁ MUA", 100);
            this.listView1.Columns.Add("GIÁ BÌA", 100);
            this.listView1.Columns.Add("LẦN TÁI BẢN", 100);
            this.listView1.Columns.Add("TÊN NXB", 160);
            this.listView1.Columns.Add("NĂM XUẤT BẢN", 200);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            this.listView1.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MASACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIAMUA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.listView1.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }
        }

        private void Load_ComboBox_TenTG()
        {
            string query = "Select TENTG from TACGIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cbTenTacGia.DataSource = data;
            cbTenTacGia.DisplayMember = "TENTG";
        }
        private void Load_ComboBox_TenNXB()
        {
            string query0 = "Select TENNHAXUATBAN from NHAXUATBAN";
            DataTable data0 = DataProvider.Instance.ExecuteQuery(query0);
            cbTenNXB.DataSource = data0;
            cbTenNXB.DisplayMember = "TENNHAXUATBAN";
        }
        private void Load_ComboBox_TenLinhVuc()
        {
            string query1 = "Select TENLINHVUC from LINHVUC";
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            cbTenLinhVuc.DataSource = data1;
            cbTenLinhVuc.DisplayMember = "TENLINHVUC";
        }
        private void Load_ComboBox_TenLoaiSach()
        {
            string query2 = "Select TENLOAISACH from LOAISACH";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            cbTenLoaiSach.DataSource = data2;
            cbTenLoaiSach.DisplayMember = "TENLOAISACH";
        }

        private void bbChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
            }

            else if (count == 1)
            {
                bChon = 1;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Checked == true)
                    {
                        txbMaSach.Text = item.SubItems[0].Text;
                        txbTenSach.Text = item.SubItems[1].Text;
                        Load_ComboBox_TenTG();
                        cbTenTacGia.Text = item.SubItems[2].Text;
                        Load_ComboBox_TenNXB();
                        cbTenNXB.Text = item.SubItems[8].Text;
                        Load_ComboBox_TenLinhVuc();
                        cbTenLinhVuc.Text = item.SubItems[3].Text;
                        Load_ComboBox_TenLoaiSach();
                        cbTenLoaiSach.Text = item.SubItems[4].Text;
                        numericUpDownGiaMua.Text = item.SubItems[5].Text;
                        numericUpDownGiaBia.Text = item.SubItems[6].Text;
                        numericUpDownLanTaiBan.Text = item.SubItems[7].Text;
                        dateTimePicker_NamXuatBan.Text = item.SubItems[9].Text;
                    }

                }
            }

            else
            {
                MessageBox.Show("KHÔNG THỂ CẬP NHẬP CÙNG LÚC NHIỀU SÁCH!", "THÔNG BÁO");
            }
        }
    }
}
