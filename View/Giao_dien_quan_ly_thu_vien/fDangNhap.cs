using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbTenDangNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void bDangNhap_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện ViewTong
            fViewTong f = new fViewTong();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Khi thoát chương trình sẽ được thông báo để quyết định có chắc chắn muốn thoát khỏi chương trình hay không
            if (MessageBox.Show("BẠN THẬT SỰ MUỐN THOÁT CHƯƠNG TRÌNH?","THÔNG BÁO", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            //Khi ấn nút thoát thì sẽ thoát khỏi chương trình
            Application.Exit();
        }
    }
}
