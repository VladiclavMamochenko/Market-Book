
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
        public Model.Book Book { get; set; } = new Book() { };
        public New_book()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Book());
        }
    }
}
