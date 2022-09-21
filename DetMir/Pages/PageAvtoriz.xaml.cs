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


namespace DetMir.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAvtoriz.xaml
    /// </summary>
    public partial class PageAvtoriz : Page
    {
        public PageAvtoriz()
        {
            InitializeComponent();
          
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new Page3Admin());
        }

        private void BtnGuest_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new Page1Guest());
        }
    }
}
