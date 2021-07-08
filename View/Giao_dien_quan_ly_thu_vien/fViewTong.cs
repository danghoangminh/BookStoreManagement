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
    public partial class fViewTong : Form
    {
        public fViewTong(string username)
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
            txbUser.Text = username;
        }

        private void DangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fTaiKhoan
            fTaiKhoan f = new fTaiKhoan();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void ThemsachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThemSach
            fThemSach f = new fThemSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void XoasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fXoaSach
            fXoaSach f = new fXoaSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void SuasachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fSuaSach
            fSuaSach f = new fSuaSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void LinhvucToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fLinhVuc
            fLinhVuc f = new fLinhVuc();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void LoaisachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fLoaiSach
            fLoaiSach f = new fLoaiSach();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void KhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fKho
            fKho f = new fKho();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void NhaxuatbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fNhaXuatBan
            fNhaXuatBan f = new fNhaXuatBan();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void HoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fHoaDon
            fHoaDon f = new fHoaDon();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void ThongkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Khi ấn đăng nhập thì hiện ra giao diện fThongKe
            fThongKe f = new fThongKe();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void XoaTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXoaTacGia f = new fXoaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void ThemTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThemTacGia f = new fThemTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void SuaTGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSuaTacGia f = new fSuaTacGia();
            this.Hide();
            //Khi thao tác trên dialog xong thì mới chạy lệnh show ở dưới
            f.ShowDialog();
            this.Show();
            listView1_SelectedIndexChanged();
        }

        private void fViewTong_Load()
        {
            DateTime tg = DateTime.Now;
            txTime.Text = tg.ToString("dddd, dd/MM/yyyy");
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

            this.listView1.Clear();
            this.listView1.Items.Clear();
            this.listView1.View = View.Details;
            this.listView1.Columns.Add("TÊN SÁCH", 400);
            this.listView1.Columns.Add("TÁC GIẢ", 250);
            this.listView1.Columns.Add("LĨNH VỰC", 220);
            this.listView1.Columns.Add("LOẠI SÁCH", 200);
            this.listView1.Columns.Add("GIÁ BÌA", 200);
            this.listView1.Columns.Add("LẦN TB", 70);
            this.listView1.Columns.Add("TÊN NXB", 140);
            this.listView1.Columns.Add("NĂM XB", 120);
            this.listView1.GridLines = true;
            this.listView1.FullRowSelect = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.listView1.Items.Add(row["TENSACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENTG"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENLINHVUC"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENLOAISACH"].ToString());
                this.listView1.Items[i].SubItems.Add(row["GIABIA"].ToString());
                this.listView1.Items[i].SubItems.Add(row["LANTAIBAN"].ToString());
                this.listView1.Items[i].SubItems.Add(row["TENNHAXUATBAN"].ToString());
                this.listView1.Items[i].SubItems.Add(row["NAMXUATBAN"].ToString());
                i++;
            }

            
            string timenow = DateTime.Now.ToString("yyyy/MM/dd");
            string query2 = "Select SUM(TONGTIEN) AS [DOANHTHU] From HOADON Where NGAYLAP = '" + timenow + "'";
            object data2 = DataProvider.Instance.ExecuteScalar(query2);
            txbDoanhThu.Text = data2.ToString() + " VND";

            string query3 = "Select Count(MAHOADON) From HOADON";
            object data3 = DataProvider.Instance.ExecuteScalar(query3);
            txbSLKhach.Text = data3.ToString() + " người";
        }

        private void fViewTong_Load(object sender, EventArgs e)
        {

        }
    }
}
