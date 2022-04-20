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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            var connection = new DB();
            var user = connection.User.FirstOrDefault(u => u.Login == Login.Text & u.Password == Password.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");

            }
            else
            {
                App.User = user;
                NavigationService.Navigate(new Menu());
            }
        }
    }
}
