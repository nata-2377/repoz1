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

        private void BtnPerson_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = ConnectOdb.ConObj.Users.FirstOrDefault(x => x.login == tbLog.Text && x.password == PbPass.Password);
                if (userObj==null)
                {
                    MessageBox.Show("Такого пользователя не существует", "Ошибка авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.role)
                    {
                        case 1: MessageBox.Show("Добро пожаловать. Вы авторизировались как администратор  " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        case 2:
                            MessageBox.Show("Добро пожаловать. Вы авторизировались как менеджер  " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        case 3:
                            MessageBox.Show("Добро пожаловать. Вы авторизировались как пользователь  " + userObj.FIO, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            break;
                    }
                }

            }
            catch (Exception Ex)
            {

                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка работы приложения!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
