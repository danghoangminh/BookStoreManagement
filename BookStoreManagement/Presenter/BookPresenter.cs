using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BookStoreManagement.Model;

namespace BookStoreManagement.Presenter
{
    public class BookPresenter
    {
        public DataTable ds;
        BookModel book = new BookModel();
        
        public BookPresenter()
        {
            ds = book.LoadData();
        }

        public string generateID()
        {
            int length = 4;
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();
            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }

        public void addBook(string bookid, string title, string author, string category, string publisher, int costprice, int sellprice, int quantity)
        {
            if (title != "" && costprice > 0 && sellprice > 0 && quantity > 0)
            {
                book.AddBook(bookid, title, author, category, publisher, costprice, sellprice, quantity);
                MessageBox.Show("ADD BOOK COMPLETE!", "NOFICATION");
            }
            else
            {
                MessageBox.Show("ADD BOOK FAILURE!", "NOFICATION");
            }
        }

        public void addItem(string item, string column)
        {
            if (item != "")
            {
                book.AddItem(item, column);
                MessageBox.Show($"ADD {column} COMPLETE!", "NOFICATION");
            }
            else
            {
                MessageBox.Show($"ADD {column} FAILURE!!", "NOFICATION");
            }
        }
    }
}
