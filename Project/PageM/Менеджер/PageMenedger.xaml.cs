﻿using Project.PageM.MainPage;
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

namespace Project.PageM.Менеджер
{
    /// <summary>
    /// Interaction logic for PageMenedger.xaml
    /// </summary>
    public partial class PageMenedger : Page
    {
        public PageMenedger()
        {
            InitializeComponent();
            FrProductList.Navigate(new PageProductDetail1());
            FrOrders.Navigate(new PageOrders());
        }
    }
}
