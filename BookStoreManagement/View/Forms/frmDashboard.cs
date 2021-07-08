using System;
using System.Windows.Forms;
using BookStoreManagement.View.UserControls;

namespace BookStoreManagement.View.Forms
{
    public partial class frmDashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public frmDashboard(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
            timerTime.Start();
            PanelWidth = pnlFunction.Width;
            isCollapsed = false;
            ucBooks ucBooks = new ucBooks();
            AddControlsToPanel(ucBooks);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnlFunction.Width += 80;
                if (pnlFunction.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlFunction.Width -= 80;
                if (pnlFunction.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
        {
            pnlSide.Top = btn.Top;
            pnlSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            pnlControls.Controls.Clear();
            pnlControls.Controls.Add(ctrl);
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBooks);
            ucBooks ucBooks = new ucBooks();
            AddControlsToPanel(ucBooks);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSales);
            ucSales ucSales = new ucSales();
            AddControlsToPanel(ucSales);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnRecords);
            ucRecords ucRecords = new ucRecords();
            AddControlsToPanel(ucRecords);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsers);
            ucUser ucUser = new ucUser(lblUsername.Text);
            AddControlsToPanel(ucUser);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("dd/MM/yyyy      HH:MM:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
