﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
    /// Логика взаимодействия для Page3Admin.xaml
    /// </summary>
    public partial class Page3Admin : Page
    {

       
        public Page3Admin(object DataContext)
        {
            InitializeComponent();
           
            adminTX.Text = (string)DataContext;
        }

       
        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageAddProduct());
        }

        private void BtnProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageProduct());
        }

        private void BtnClient_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageClientSpisok());
        }
    }
}
