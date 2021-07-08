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
    public partial class fKho : Form
    {
        int bSua = 0;
        int bThem = 0;
        public fKho()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            listView2_SelectedIndexChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select SACH.MASACH, TENSACH, SOLUONG From KHO LEFT JOIN SACH ON KHO.MASACH = SACH.MASACH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ SÁCH", 200);
            this.listView1.Columns.Add("TÊN SÁCH", 370);
            this.listView1.Columns.Add("SỐ LƯỢNG", 160);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            this.listView1.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MASACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["SOLUONG"].ToString());
                i++;
            }
        }

        private void bXoaSach_Click(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count0++;
            }
            if (count0 == 0)
            {
                MessageBox.Show("CHƯA CHỌN SÁCH NÀO!", "THÔNG BÁO");
            }
            else if (count0 > 0)
            {
                DialogResult d;
                d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    foreach (ListViewItem item in this.listView1.Items)
                    {
                        if (item.Checked == true)
                        {
                            string Ma = item.Text;
                            string query = "Delete From KHO Where MASACH = '" + Ma + "'";
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
            listView2_SelectedIndexChanged();
        }

        private void bChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 1)
            {
                bSua = 1;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Checked == true)
                    {
                        txbMaSachSua.Text = item.SubItems[0].Text;
                    }

                }
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN SÁCH NÀO!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("KHÔNG THỂ SỬA CÙNG LÚC NHIỀU SÁCH!", "THÔNG BÁO");
            }
        }

        private void bLuu_Click(object sender, EventArgs e)
        {
            if (bSua == 1)
            {
                string query = "UPDATE KHO SET SOLUONG = " + Sua_numericUpDownSoLuong.Value + "Where MASACH = '" + txbMaSachSua.Text + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ CẬP NHẬP!", "THÔNG BÁO");
                txbMaSachSua.Text = "";
                Sua_numericUpDownSoLuong.Value = 1;
                listView1_SelectedIndexChanged();
                bSua = 0;
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
            }
        }

        private void listView2_SelectedIndexChanged()
        {
            string query = "Select MASACH, TENSACH, TENTG, TENLINHVUC, TENLOAISACH, GIAMUA, GIABIA, " +
                "LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA ON SACH.MATG = TACGIA.MATG " +
                "Where MASACH IN(Select SACH.MASACH From SACH Except (Select KHO.MASACH From KHO))";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView2.Clear();
            this.listView2.Items.Clear();
            this.listView2.View = View.Details;
            this.listView2.Columns.Add("MÃ SÁCH", 150);
            this.listView2.Columns.Add("TÊN SÁCH", 270);
            this.listView2.Columns.Add("TÁC GIẢ", 200);
            this.listView2.Columns.Add("LĨNH VỰC", 100);
            this.listView2.Columns.Add("LOẠI SÁCH", 150);
            this.listView2.Columns.Add("GIÁ MUA", 100);
            this.listView2.Columns.Add("GIÁ BÌA", 100);
            this.listView2.Columns.Add("LẦN TÁI BẢN", 100);
            this.listView2.Columns.Add("TÊN NXB", 160);
            this.listView2.Columns.Add("NĂM XUẤT BẢN", 200);
            this.listView2.GridLines = true;
            this.listView2.FullRowSelect = true;
            this.listView2.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView2.Items.Add(row["MASACH"].ToString());
                this.listView2.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.listView2.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.listView2.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.listView2.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.listView2.Items[i].SubItems.Add(row["GIAMUA"].ToString());
                this.listView2.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.listView2.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.listView2.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.listView2.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }
        }

        private void bThemKho_Click(object sender, EventArgs e)
        {
            if (bThem == 1)
            {
                string query = "Insert Into KHO Values('" + txbMaSachThem.Text + "', " + Nhap_numericUpDownSoLuong.Value + ")";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                txbMaSachThem.Text = "";
                Nhap_numericUpDownSoLuong.Value = 1;
                listView1_SelectedIndexChanged();
                listView2_SelectedIndexChanged();
                bThem = 0;
                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN SÁCH!", "THÔNG BÁO");
            }
        }

        private void bChonThem_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.listView2.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 1)
            {
                bThem = 1;
                foreach (ListViewItem item in this.listView2.Items)
                {
                    if (item.Checked == true)
                    {
                        txbMaSachThem.Text = item.SubItems[0].Text;
                    }

                }
            }
            else if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN SÁCH NÀO!", "THÔNG BÁO");
            }    
            else
            {
                MessageBox.Show("KHÔNG THỂ THÊM CÙNG LÚC NHIỀU SÁCH!", "THÔNG BÁO");
            }
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
