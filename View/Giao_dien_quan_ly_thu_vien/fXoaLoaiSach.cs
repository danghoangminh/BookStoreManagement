using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Giao_dien_quan_ly_thu_vien
{
    public partial class fXoaLoaiSach : Form
    {
        public fXoaLoaiSach()
        {
            InitializeComponent();
        }

        private void fThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTenLinhVuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
