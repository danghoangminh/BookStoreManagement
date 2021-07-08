using BookStoreManagement.Presenter;
using System;
using System.Windows.Forms;

namespace BookStoreManagement.View.Forms
{
    public partial class frmAddAuthor : Form
    {
        public frmAddAuthor()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AuthorPresenter presenter = new AuthorPresenter();

            if (checkBox1.Checked)
            {
                presenter.addAuthor(txbFullname.Text, txbPlace.Text, "", dateTimePicker2.Text);
            }
            else if (checkBox2.Checked)
            {
                presenter.addAuthor(txbFullname.Text, txbPlace.Text, dateTimePicker1.Text, "");
            }
            else if (checkBox1.Checked && checkBox2.Checked)
            {
                presenter.addAuthor(txbFullname.Text, txbPlace.Text, "", "");
            }
            else
            {
                presenter.addAuthor(txbFullname.Text, txbPlace.Text, dateTimePicker1.Text, dateTimePicker2.Text);
            }
            this.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else if (!checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dateTimePicker2.Enabled = false;
            }
            else if (!checkBox2.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
        }
    }
}
