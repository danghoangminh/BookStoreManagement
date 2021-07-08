using System.Windows.Forms;
using BookStoreManagement.Model;

namespace BookStoreManagement.Presenter
{
    public class AuthorPresenter
    {
        AuthorModel model = new AuthorModel();

        public void addAuthor(string fullname, string place, string birth, string death)
        {
            model.AddAuthor(fullname, place, birth, death);
            MessageBox.Show("ADD AUTHOR COMPLETE!", "NOFICATION");
        }
    }
}
