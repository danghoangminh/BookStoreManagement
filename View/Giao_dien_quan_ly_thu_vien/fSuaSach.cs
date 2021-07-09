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
    public partial class frmSuaSach : Form
    {
        int bChon = 0;
        public frmSuaSach()
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
                DateTime namxb = dateTimePicker_NamXuatBan.Value;
                
                string query = "UPDATE SACH" +
                    " SET TENSACH = '" + txbTenSach.Text + "', MATG = (Select MATG From TACGIA Where TENTG = '" + cboTenTacGia.Text.ToString() + "'), " +
                    "TENLINHVUC = '" + cboTenLinhVuc.Text.ToString() + "', TENLOAISACH = '" + cboTenLoaiSach.Text.ToString() + "', GIAMUA = " +
                    numericUpDownGiaMua.Value + ", GIABIA = " + numericUpDownGiaBia.Value + ", LANTAIBAN = " + numericUpDownLanTaiBan.Value +
                    ", TENNHAXUATBAN = '" + cboTenNXB.Text.ToString() + "', NAMXUATBAN = '" + namxb.ToString("yyyy-MM-dd") + "' WHERE MASACH = '" + txbMaSach.Text + "'";
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

            this.dgvSuaSach.Clear();
            this.dgvSuaSach.Items.Clear();
            this.dgvSuaSach.View = View.Details;
            this.dgvSuaSach.Columns.Add("MÃ SÁCH", 150);
            this.dgvSuaSach.Columns.Add("TÊN SÁCH", 270);
            this.dgvSuaSach.Columns.Add("TÁC GIẢ", 200);
            this.dgvSuaSach.Columns.Add("LĨNH VỰC", 100);
            this.dgvSuaSach.Columns.Add("LOẠI SÁCH", 150);
            this.dgvSuaSach.Columns.Add("GIÁ MUA", 100);
            this.dgvSuaSach.Columns.Add("GIÁ BÌA", 100);
            this.dgvSuaSach.Columns.Add("LẦN TÁI BẢN", 100);
            this.dgvSuaSach.Columns.Add("TÊN NXB", 160);
            this.dgvSuaSach.Columns.Add("NĂM XUẤT BẢN", 200);
            this.dgvSuaSach.GridLines = true;
            this.dgvSuaSach.FullRowSelect = true;
            this.dgvSuaSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvSuaSach.Items.Add(row["MASACH"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["GIAMUA"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.dgvSuaSach.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }
        }

        private void Load_ComboBox_TenTG()
        {
            string query = "Select TENTG from TACGIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            cboTenTacGia.DataSource = data;
            cboTenTacGia.DisplayMember = "TENTG";
        }
        private void Load_ComboBox_TenNXB()
        {
            string query0 = "Select TENNHAXUATBAN from NHAXUATBAN";
            DataTable data0 = DataProvider.Instance.ExecuteQuery(query0);
            cboTenNXB.DataSource = data0;
            cboTenNXB.DisplayMember = "TENNHAXUATBAN";
        }
        private void Load_ComboBox_TenLinhVuc()
        {
            string query1 = "Select TENLINHVUC from LINHVUC";
            DataTable data1 = DataProvider.Instance.ExecuteQuery(query1);
            cboTenLinhVuc.DataSource = data1;
            cboTenLinhVuc.DisplayMember = "TENLINHVUC";
        }
        private void Load_ComboBox_TenLoaiSach()
        {
            string query2 = "Select TENLOAISACH from LOAISACH";
            DataTable data2 = DataProvider.Instance.ExecuteQuery(query2);
            cboTenLoaiSach.DataSource = data2;
            cboTenLoaiSach.DisplayMember = "TENLOAISACH";
        }

        private void bbChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvSuaSach.Items)
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
                foreach (ListViewItem item in this.dgvSuaSach.Items)
                {
                    if (item.Checked == true)
                    {
                        txbMaSach.Text = item.SubItems[0].Text;
                        txbTenSach.Text = item.SubItems[1].Text;
                        Load_ComboBox_TenTG();
                        cboTenTacGia.Text = item.SubItems[2].Text;
                        Load_ComboBox_TenNXB();
                        cboTenNXB.Text = item.SubItems[8].Text;
                        Load_ComboBox_TenLinhVuc();
                        cboTenLinhVuc.Text = item.SubItems[3].Text;
                        Load_ComboBox_TenLoaiSach();
                        cboTenLoaiSach.Text = item.SubItems[4].Text;
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
