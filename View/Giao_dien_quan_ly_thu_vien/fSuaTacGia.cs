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
    public partial class fSuaTacGia : Form
    {
        int bChonTG = 0;
        public fSuaTacGia()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select MATG, TENTG, NAMSINH, NAMMAT, QUEQUAN From TACGIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("MÃ TÁC GIẢ", 100);
            this.listView1.Columns.Add("TÊN TÁC GIẢ", 180);
            this.listView1.Columns.Add("NĂM SINH", 100);
            this.listView1.Columns.Add("NĂM MẤT", 100);
            this.listView1.Columns.Add("QUÊ QUÁN", 200);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;
            this.listView1.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["MATG"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.listView1.Items[i].SubItems.Add(row["NAMSINH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["NAMMAT"].ToString());
                this.listView1.Items[i].SubItems.Add(row["QUEQUAN"].ToString());
                i++;
            }
        }

        private void bChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count++;
            }

            if (count == 0)
            {
                MessageBox.Show("CHƯA CHỌN TÁC GIẢ!", "THÔNG BÁO");
            }

            else if (count == 1)
            {
                bChonTG = 1;
                foreach (ListViewItem item in this.listView1.Items)
                {
                    if (item.Checked == true)
                    {
                        txbMaTacGia.Text = item.SubItems[0].Text;
                        txbTenTacGia.Text = item.SubItems[1].Text;
                        txbQueQuan.Text = item.SubItems[4].Text;
                        dateTimePicker_NgaySinh.Text = item.SubItems[2].Text;
                        dateTimePicker_NgayMat.Text = item.SubItems[3].Text;
                        if (dateTimePicker_NgaySinh.Text == DateTime.MinValue.ToString())
                        {
                            checkBox_NgaySinh.Checked = true;
                        }
                        else
                        {
                            checkBox_NgaySinh.Checked = false;
                        }
                        if (dateTimePicker_NgayMat.Text == DateTime.MaxValue.ToString())
                        {
                            checkBox_NgayMat.Checked = true;
                        }
                        else
                        {
                            checkBox_NgayMat.Checked = false;
                        }
                    }

                }
            }

            else
            {
                MessageBox.Show("KHÔNG THỂ CẬP NHẬP CÙNG LÚC NHIỀU TÁC GIẢ!", "THÔNG BÁO");
            }
        }

        private void checkBox_NgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NgaySinh.Checked)
            {
                dateTimePicker_NgaySinh.Text = DateTime.MinValue.ToString();
            }
            else
            {
                dateTimePicker_NgaySinh.Text = DateTime.Now.ToString();
            }
        }

        private void checkBox_NgayMat_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_NgayMat.Checked)
            {
                dateTimePicker_NgayMat.Text = DateTime.MaxValue.ToString();
            }
            else
            {
                dateTimePicker_NgayMat.Text = DateTime.Now.ToString();
            }
        }

        private void checkBox_QueQuan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_QueQuan.Checked)
            {
                checkBox_QueQuan.Text = "(Không có thông tin)";
                txbQueQuan.Text = "(Không có thông tin)";
                txbQueQuan.ReadOnly = true;
            }
            else
            {
                checkBox_QueQuan.Text = "CHƯA RÕ";
                txbQueQuan.Text = "";
                txbQueQuan.ReadOnly = false;
            }
        }

        private void bbLuu_Click(object sender, EventArgs e)
        {
            if (bChonTG == 1)
            {
                string query = "UPDATE TACGIA" +
                    " SET TENTACGIA = '" + txbTenTacGia.Text + "', NAMSINH = '" + dateTimePicker_NgaySinh.Text + "', " +
                    "NAMMAT = '" + dateTimePicker_NgayMat.Text + "', QUEQUAN = '" + txbQueQuan.Text + "' WHERE MATACGIA = '" + txbMaTacGia.Text + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);                
                MessageBox.Show("ĐÃ CẬP NHẬP", "THÔNG BÁO"); 
                txbMaTacGia.Text = "";
                txbTenTacGia.Text = "";
                txbQueQuan.Text = "";
                checkBox_QueQuan.Checked = false;
                checkBox_NgaySinh.Checked = false;
                checkBox_NgayMat.Checked = false;
                dateTimePicker_NgaySinh.Text = DateTime.Now.ToString();
                dateTimePicker_NgayMat.Text = DateTime.Now.ToString();
                listView1_SelectedIndexChanged();
                bChonTG = 0;
            }
            else
            {
                MessageBox.Show("CHƯA CHỌN TÁC GIẢ!", "THÔNG BÁO");
            }
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
