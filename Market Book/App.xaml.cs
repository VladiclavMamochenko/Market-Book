using Market_Book.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Market_Book
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User User { get; set; }
        public static Book Book { get; set; }
        public static AuthorBook AuthorBook { get; set; }
        public static Genre Genre{ get; set; }
    }

}
