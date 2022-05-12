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
    /// Логика взаимодействия для SelectionBook.xaml
    /// </summary>
    public partial class SelectionBook : Page
    {
        public Model.DB Connection { get; set; } = new Model.DB();
        public Model.Book Book { get; set; } = new Model.Book() { };
        public Model.Market Market { get; set; } = new Model.Market() { };
 

        public SelectionBook()
        {
            InitializeComponent();
            ComboboxBook.ItemsSource = Connection.Book.ToList();
            ComboboxMarket.ItemsSource = Connection.Market.ToList();
        }

        private void GoToTrash(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Basket(Book, Market));
        }
    }
}
