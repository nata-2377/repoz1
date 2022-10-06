using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace DetMir.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew : Page
    {
        public PageEditNew()
        {
            InitializeComponent();
            ConnectOdb.ConObj.Manufacturer.Load();
            comboBox2.ItemsSource = ConnectOdb.ConObj.Manufacturer.Local;
            ConnectOdb.ConObj.Provider.Load();
            comboBox3.ItemsSource = ConnectOdb.ConObj.Provider.Local;

        }
    }
}
