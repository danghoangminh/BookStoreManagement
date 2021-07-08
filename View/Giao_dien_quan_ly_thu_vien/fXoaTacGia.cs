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
    public partial class fXoaTacGia : Form
    {
        public fXoaTacGia()
        {
            InitializeComponent();
            listView1_SelectedIndexChanged();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bXoaTG_Click(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.listView1.Items)
            {
                if (item.Checked)
                    count0++;
            }

            if (count0 > 0)
            {
                DialogResult d;
                d = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN XÓA?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    foreach (ListViewItem item in this.listView1.Items)
                    {
                        if (item.Checked == true)
                        {
                            try
                            {
                                string Ma = item.Text;
                                string query = "Delete From TACGIA Where MATG = '" + Ma + "'";
                                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                                item.Remove();
                                MessageBox.Show("ĐÃ XÓA!", "THÔNG BÁO");
                            }
                            catch
                            {
                                MessageBox.Show("KHÔNG THỂ XÓA!", "THÔNG BÁO");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("KHÔNG CÓ GÌ ĐỂ XÓA!", "THÔNG BÁO");
            }
        }

        private void fThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
