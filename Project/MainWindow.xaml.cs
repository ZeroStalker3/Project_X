﻿using Project.Class;
using Project.PageM;
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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool size = false;
        public MainWindow()
        {
            InitializeComponent();
            OdbConectHelper.entObj = new Class.Database.TextileProductionEntities();

            FrameApp.frmObj = FrmMain;
            FrmMain.Navigate(new PageAuth());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAuth());
        }
        //private void Exit_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}

        //private void Min_Click(object sender, RoutedEventArgs e)
        //{
        //    this.WindowState = WindowState.Minimized;
        //}

        //private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.DragMove();
        //}

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        //private void Resize_Click(object sender, RoutedEventArgs e)
        //{
        //    if (size == false)
        //    {
        //        this.WindowState = WindowState.Maximized;
        //        size = true;
        //    }
        //    else
        //    {
        //        this.WindowState = WindowState.Normal;
        //        size = false;
        //    }
        //}
    }
}
