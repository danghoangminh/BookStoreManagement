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
    public partial class frmSuaTacGia : Form
    {
        int bChonTG = 0;
        public frmSuaTacGia()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
        }

        private void listView1_SelectedIndexChanged()
        {
            string query = "Select MATG, TENTG, NAMSINH, NAMMAT, QUEQUAN From TACGIA";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvTacGia.Clear();
            this.dgvTacGia.Items.Clear();
            this.dgvTacGia.View = View.Details;
            this.dgvTacGia.Columns.Add("MÃ TÁC GIẢ", 100);
            this.dgvTacGia.Columns.Add("TÊN TÁC GIẢ", 180);
            this.dgvTacGia.Columns.Add("NĂM SINH", 100);
            this.dgvTacGia.Columns.Add("NĂM MẤT", 100);
            this.dgvTacGia.Columns.Add("QUÊ QUÁN", 200);
            this.dgvTacGia.GridLines = true;
            this.dgvTacGia.FullRowSelect = true;
            this.dgvTacGia.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvTacGia.Items.Add(row["MATG"].ToString());
                this.dgvTacGia.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.dgvTacGia.Items[i].SubItems.Add(row["NAMSINH"].ToString());
                this.dgvTacGia.Items[i].SubItems.Add(row["NAMMAT"].ToString());
                this.dgvTacGia.Items[i].SubItems.Add(row["QUEQUAN"].ToString());
                i++;
            }
        }

        private void bChon_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ListViewItem item in this.dgvTacGia.Items)
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
                foreach (ListViewItem item in this.dgvTacGia.Items)
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
                            chkNgaySinh.Checked = true;
                        }
                        else
                        {
                            chkNgaySinh.Checked = false;
                        }
                        if (dateTimePicker_NgayMat.Text == DateTime.MaxValue.ToString())
                        {
                            chkNgayMat.Checked = true;
                        }
                        else
                        {
                            chkNgayMat.Checked = false;
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
            if (chkNgaySinh.Checked)
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
            if (chkNgayMat.Checked)
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
            if (chkQueQuan.Checked)
            {
                chkQueQuan.Text = "(Không có thông tin)";
                txbQueQuan.Text = "(Không có thông tin)";
                txbQueQuan.ReadOnly = true;
            }
            else
            {
                chkQueQuan.Text = "CHƯA RÕ";
                txbQueQuan.Text = "";
                txbQueQuan.ReadOnly = false;
            }
        }

        private void bbLuu_Click(object sender, EventArgs e)
        {
            if (bChonTG == 1)
            {
                DateTime ngaysinh = dateTimePicker_NgaySinh.Value;
                DateTime ngaymat = dateTimePicker_NgayMat.Value;
                string query = "UPDATE TACGIA" +
                    " SET TENTG = '" + txbTenTacGia.Text + "', NAMSINH = '" + ngaysinh.ToString("yyyy-MM-dd") + "', " +
                    "NAMMAT = '" + ngaymat.ToString("yyyy-MM-dd") + "', QUEQUAN = '" + txbQueQuan.Text + "' WHERE MATG = '" + txbMaTacGia.Text + "'";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);                
                MessageBox.Show("ĐÃ CẬP NHẬP", "THÔNG BÁO"); 
                txbMaTacGia.Text = "";
                txbTenTacGia.Text = "";
                txbQueQuan.Text = "";
                chkQueQuan.Checked = false;
                chkNgaySinh.Checked = false;
                chkNgayMat.Checked = false;
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
