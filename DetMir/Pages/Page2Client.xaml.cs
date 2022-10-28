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
using System.Windows.Threading;

namespace DetMir.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page2Client.xaml
    /// </summary>
    public partial class Page2Client : Page
    {
        public Page2Client(object DataContext)
        {
            InitializeComponent();
            clientTX.Text = "Вы вошли как клиент " + (string)DataContext;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
          
            timer.Start();


            ConnectOdb.ConObj.Provider.Load();
            gridList.ItemsSource = ConnectOdb.ConObj.Product.ToList();

        }
      
        
        public void UpdateData(object sender, object e)
        {
            var HistoryProduct = ConnectOdb.ConObj.Product.ToList();
            ListProduct.ItemsSource = HistoryProduct;
            ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Where(x => x.name.StartsWith(PoiskTB.Text)).ToList();
                   
          
            RowCount(); 
        }
        public void RowCount()
        {
           
           rowCount.Text = $"Выведено {gridList.Items.Count} записей из { ConnectOdb.ConObj.Product.Local.Count}";
        }

        private void PoiskTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            gridList.ItemsSource = null;
            gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.name.ToLower().Contains(PoiskTB.Text.ToLower()));
            RowCount();
        }

        private void sortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (sortCB.SelectedIndex)
            {
                case 0:
                    gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.OrderBy(x => x.stoimost);
                    ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Local.OrderBy(x => x.stoimost);
                    break;
                case 1:
                    gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.OrderByDescending(x => x.stoimost);
                    ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Local.OrderByDescending(x => x.stoimost);
                    break;
                default:
                    break;
            
            }
            
        }

        private void filtCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (filtCB.SelectedIndex)
            {
                case 0:
                    gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.ToList();
                    ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Local.ToList();
                    break;
                case 1:
                    gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.discount <= 10);
                    ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.discount <= 10);
                    break;
                case 2:
                    gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.discount >= 11 && x.discount <= 14);
                    ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.discount >= 11 && x.discount <= 14);
                    break;
                case 3:
                    gridList.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.discount >= 15);
                    ListProduct.ItemsSource = ConnectOdb.ConObj.Product.Local.Where(x => x.discount >= 15);
                    break;
                         
                default:
                    break;
            }
        }
    }
}
