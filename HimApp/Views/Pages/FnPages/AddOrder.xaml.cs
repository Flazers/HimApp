﻿using HimApp.BD;
using HimApp.Controllers;
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

namespace HimApp.Views.Pages.FnPages
{
    /// <summary>
    /// Логика взаимодействия для AddOrder.xaml
    /// </summary>
    public partial class AddOrder : Page
    {
        public AddOrder()
        {
            InitializeComponent();
            WConnect.MainWindowMethod.PageTitle.Text = "Новый заказ";
            PreLoad();
        }

        private void PreLoad()
        {
            executor.ItemsSource = HimBDEntities.GetContext().Users.Where(x => x.UserInfo.role_id == 2).ToList();
        }
    }
}
