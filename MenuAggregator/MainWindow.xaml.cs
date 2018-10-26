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

namespace MenuAggregator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string UserName = "haah";//Environment.UserName; //"v-fitatu";  //
        public static string Cafe;
        public MainWindow()
        {
            
            MenuBuilderDataSet ds = new MenuBuilderDataSet();
            MenuBuilderDataSetTableAdapters.MenuBuilder_UsersTableAdapter userAdapter = new MenuBuilderDataSetTableAdapters.MenuBuilder_UsersTableAdapter();

            InitializeComponent();

            if (userAdapter.IsAuth(ds._MenuBuilder_Users, UserName) > 0)
            {
                mainFrame.Source = new Uri("pages\\Home.xaml", UriKind.Relative);
                Cafe = ds._MenuBuilder_Users.Rows[0][2].ToString();
            }
            else
            {
                mainFrame.Source = new Uri("pages\\FirstTime.xaml", UriKind.Relative);
            }

        }
    }
}
