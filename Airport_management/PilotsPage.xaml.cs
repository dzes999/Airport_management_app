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

namespace Airport_management
{
    public partial class PilotsPage : Page
    {
        public PilotsPage()
        {
            InitializeComponent();
        }
        private void BT_add_Click(object sender, RoutedEventArgs e)
        {
            AddPilotPage addPilotPage = new AddPilotPage();
            ((MainWindow)Application.Current.MainWindow).Content = addPilotPage;
        }
        private void BT_back_Click(object sender, RoutedEventArgs e)
        {
            MainApp mainApp = new MainApp();
            ((MainWindow)Application.Current.MainWindow).Content = mainApp;
        }

        private void BT_find_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BT_all_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
