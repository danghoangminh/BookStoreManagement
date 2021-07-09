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
    public partial class frmViewTong : Form
    {
        public frmViewTong(string username)
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            txbTenNguoiDung.Text = username;
        }

        private void DangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fTaiKhoan
            frmTaiKhoan f = new frmTaiKhoan();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void ThemsachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThemSach
            frmThemSach f = new frmThemSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void XoasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fXoaSach
            frmXoaSach f = new frmXoaSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void SuasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fSuaSach
            frmSuaSach f = new frmSuaSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void LinhvucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fLinhVuc
            frmLinhVuc f = new frmLinhVuc();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void LoaisachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fLoaiSach
            frmLoaiSach f = new frmLoaiSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void KhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fKho
            frmKho f = new frmKho();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void NhaxuatbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fNhaXuatBan
            frmNhaXuatBan f = new frmNhaXuatBan();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void HoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fHoaDon
            frmHoaDon f = new frmHoaDon();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void ThongkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThongKe
            frmThongKe f = new frmThongKe();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void XoaTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXoaTacGia f = new frmXoaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void ThemTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemTacGia f = new frmThemTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void SuaTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSuaTacGia f = new frmSuaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void fViewTong_Load()
        {
            DateTime tg = DateTime.Now;
            lblTime.Text = tg.ToString("dddd, dd/MM/yyyy");
           //string query = "Select USERNAME From TAIKHOAN";
           // object data = DataProvider.Instance.ExecuteScalar(query);
            //txbUser.Text = data.ToString();
        }

        private void listView1_SelectedIndexChanged()
        {
            fViewTong_Load();
            string query = "Select TENSACH, TENTG, TENLINHVUC, TENLOAISACH, " +
                "GIABIA, LANTAIBAN, TENNHAXUATBAN, NAMXUATBAN From SACH LEFT JOIN TACGIA " +
                "ON SACH.MATG = TACGIA.MATG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvSach.Clear();
            this.dgvSach.Items.Clear();
            this.dgvSach.View = View.Details;
            this.dgvSach.Columns.Add("TÊN SÁCH", 400);
            this.dgvSach.Columns.Add("TÁC GIẢ", 250);
            this.dgvSach.Columns.Add("LĨNH VỰC", 220);
            this.dgvSach.Columns.Add("LOẠI SÁCH", 200);
            this.dgvSach.Columns.Add("GIÁ BÌA", 200);
            this.dgvSach.Columns.Add("LẦN TB", 70);
            this.dgvSach.Columns.Add("TÊN NXB", 140);
            this.dgvSach.Columns.Add("NĂM XB", 120);
            this.dgvSach.GridLines = true;
            this.dgvSach.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvSach.Items.Add(row["TENSACH"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.dgvSach.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }

            
            
            string timenow = DateTime.Now.ToString("yyyy/MM/dd");
            string query2 = "Select SUM(TONGTIEN) AS [DOANHTHU] From HOADON Where NGAYLAP = '" + timenow + "'";
            object data2 = DataProvider.Instance.ExecuteScalar(query2);
            if (data2.ToString() == "")
            {
                txbDoanhThu.Text = 0 + " VND";
            }
            else
            {
                txbDoanhThu.Text = data2.ToString() + " VND";
            }

            string query3 = "Select Count(MAHOADON) From HOADON Where NGAYLAP = '" + timenow + "'"; 
            object data3 = DataProvider.Instance.ExecuteScalar(query3);
            txbSLKhach.Text = data3.ToString() + " người";
        }

        private void fViewTong_Load(object sender, EventArgs e)
        {

        }

        private void txbSLKhach_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
