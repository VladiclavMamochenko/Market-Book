using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Market.xaml
    /// </summary>
    public partial class Market : Page
    {
        private static readonly Model.DB _db = new Model.DB();
        public ObservableCollection<Model.Market> Markets { get; set; } = new ObservableCollection<Model.Market>(_db.Market.ToList());
        public Market()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Menu());
        }
    }
}
