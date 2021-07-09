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
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
            txbMaTacGia_TextChanged();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbMaTacGia_TextChanged()
        {
            Random rd = new Random();
            txbMaTacGia.Text = ("TG0" + rd.Next(99, 1000));
        }

        private void bThem_Click(object sender, EventArgs e)
        {
            if (txbTenTacGia.Text == "")
            {
                MessageBox.Show("VUI LÒNG ĐIỀN TÊN TÁC GIẢ!", "THÔNG BÁO");
            }
            else
            {
                string query;
                if (chkNgaySinh.Checked  && !chkNgayMat.Checked )
                {
                    query = "Insert into TACGIA VALUES ('" + txbMaTacGia.Text + "', '" + txbTenTacGia.Text + "', '" +
                           null + "', '" + dateTimePicker_NgayMat.Text + "', '" + txbQueQuan.Text + "')";      
                }
                else if (!chkNgaySinh.Checked && chkNgayMat.Checked)
                {
                     query = "Insert into TACGIA VALUES ('" + txbMaTacGia.Text + "', '" + txbTenTacGia.Text + "', '" +
                           dateTimePicker_NgaySinh.Text + "', '" + null + "', '" + txbQueQuan.Text + "')";      
                }
                else if (chkNgaySinh.Checked  && chkNgayMat.Checked )
                {
                    query = "Insert into TACGIA VALUES ('" + txbMaTacGia.Text + "', '" + txbTenTacGia.Text + "', '" +
                           null + "', '" + null + "', '" + txbQueQuan.Text + "')";    
                }
                else 
                {
                    query = "Insert into TACGIA VALUES ('" + txbMaTacGia.Text + "', '" + txbTenTacGia.Text + "', '" +
                           dateTimePicker_NgaySinh.Text + "', '" + dateTimePicker_NgayMat.Text + "', '" + txbQueQuan.Text + "')";
                }
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("ĐÃ THÊM!", "THÔNG BÁO");
                txbMaTacGia_TextChanged();
                txbTenTacGia.Text = "";
                txbQueQuan.Text = "";
                chkQueQuan.Checked = false;
                chkNgaySinh.Checked = false;
                chkNgayMat.Checked = false;
                dateTimePicker_NgaySinh.Text = DateTime.Now.ToString();
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
    }
}