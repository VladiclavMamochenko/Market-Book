
using Market_Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Market_Book.Pages
{
    /// <summary>
    /// Логика взаимодействия для New_book.xaml
    /// </summary>
   
    public partial class New_book : Page
    {
        public DB Connection { get; set; } = new DB();
        public Model.Book Book { get; set; } = new Model.Book() { };
        public AuthorBook Author { get; set; } = new AuthorBook() { };
        public Genre Genre { get; set; } = new Genre() { };
      
        public New_book()
         
        {
            InitializeComponent();
            ComboboxAuthor.ItemsSource = Connection.AuthorBook.ToList();
            ComboboxGenre.ItemsSource = Connection.Genre.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Book.AuthorBook = Author;
                Book.Genre = Genre;
                Connection.Book.Add(Book);

                Connection.SaveChanges();
                MessageBox.Show("Сохранено");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Данные введены не правильно", "Ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
