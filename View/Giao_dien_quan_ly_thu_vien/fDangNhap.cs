using Giao_dien_quan_ly_thu_vien.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        int count = 1;

        private void bDangNhap_Click(object sender, EventArgs e)
        {

            string username = txbTenDangNhap.Text;
            string password = txbMatKhau.Text;

            if (Login(username, password))
            {
                frmViewTong f = new frmViewTong(txbTenDangNhap.Text);
                this.Hide(); 
                f.ShowDialog();
                this.Show();
            }
            else
            {
                count++;
                if (count <= 3)
                    MessageBox.Show("SAI TÊN ĐĂNG NHẬP HOẶC MẬT KHẨU!", "THÔNG BÁO");
                else
                {
                    DialogResult d;
                    d = MessageBox.Show("BẠN ĐÃ NHẬP SAI 3 LẦN LIÊN TIẾP. THOÁT CHƯƠNG TRÌNH ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (d == DialogResult.Yes)
                    {
                        Application.ExitThread();
                    }  
                    count = 1;
                }
            }
            txbTenDangNhap.Text = "";
            txbMatKhau.Text = "";
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Khi thoát chương trình sẽ được thông báo để quyết định có chắc chắn muốn thoát khỏi chương trình hay không
            if (MessageBox.Show("BẠN THẬT SỰ MUỐN THOÁT CHƯƠNG TRÌNH?","THÔNG BÁO", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void bThoat_Click(object sender, EventArgs e)
        {
            //Khi ấn nút thoát thì sẽ thoát khỏi chương trình
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTenDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}
