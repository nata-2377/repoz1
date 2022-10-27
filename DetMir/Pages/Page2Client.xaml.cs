﻿using System;
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
    /// Логика взаимодействия для Page2Client.xaml
    /// </summary>
    public partial class Page2Client : Page
    {
        public Page2Client(object DataContext)
        {
            InitializeComponent();

            clientTX.Text = "Вы вошли как клиент " + (string)DataContext;

        }
    }
}
