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
    public partial class frmXoaSach : Form
    {
        public frmXoaSach()
        {
            InitializeComponent();
            listView1_ItemChecked();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_ItemChecked()
        {
            string query = "Select MASACH, TENSACH, TENTG From SACH LEFT JOIN TACGIA ON SACH.MATG = TACGIA.MATG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            this.dgvXoaSach.Items.Clear();
            this.dgvXoaSach.View = View.Details;
            this.dgvXoaSach.Columns.Add("MÃ SÁCH", 150);
            this.dgvXoaSach.Columns.Add("TÊN SÁCH", 370);
            this.dgvXoaSach.Columns.Add("TÊN TÁC GIẢ", 200);
            this.dgvXoaSach.GridLines = true;
            this.dgvXoaSach.FullRowSelect = true;
            this.dgvXoaSach.CheckBoxes = true;

            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                this.dgvXoaSach.Items.Add(row["MASACH"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["TENSACH"].ToString());
                this.dgvXoaSach.Items[i].SubItems.Add(row["TENTG"].ToString());
                i++;
            }
        }


        private void bXoa_Click(object sender, EventArgs e)
        {
            int count0 = 0;
            foreach (ListViewItem item in this.dgvXoaSach.Items)
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
                    int count = 0;
                    foreach (ListViewItem item in this.dgvXoaSach.Items)
                    {
                        if (item.Checked == true)
                        {
                            try
                            {
                                count++;
                                string Ma = item.Text;
                                string query = "Delete From SACH Where MASACH = '" + Ma + "'";
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
    }
}
