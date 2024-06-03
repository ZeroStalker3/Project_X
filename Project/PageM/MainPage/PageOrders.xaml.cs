using Project.Class;
using Project.Class.Database;
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

namespace Project.PageM.MainPage
{
    /// <summary>
    /// Interaction logic for PageOrders.xaml
    /// </summary>
    public partial class PageOrders : Page
    {
        public PageOrders()
        {
            InitializeComponent();

            ordersDataGrid.ItemsSource=OdbConectHelper.entObj.Order.ToList();

        }

        private void offorder_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageOfferOrder());
        }

        private void Production_Click(object sender, RoutedEventArgs e)
        {
           FrameApp.frmObj.Navigate(new PageProduction());
        }

        private void RbDec_Click(object sender, RoutedEventArgs e)
        {
            if (RbDec.IsChecked == true)
            {
                RbUp.IsChecked = false;
                ordersDataGrid.ItemsSource = OdbConectHelper.entObj.Order.OrderByDescending(x => x.OrderDate).ToList();
            }
        }

        private void RbUp_Click(object sender, RoutedEventArgs e)
        {
            if (RbUp.IsChecked == true)
            {
                RbDec.IsChecked = false;
                ordersDataGrid.ItemsSource = OdbConectHelper.entObj.Order.OrderBy(x => x.OrderDate).ToList();
            }
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            int z;
            if (int.TryParse(txt.Text, out z))
            {
                var results = OdbConectHelper.entObj.Order.Where(x => x.OrderNumber == z).ToList();
                if (results.Any())
                {
                    ordersDataGrid.ItemsSource = results; 
                }
                else
                {
                    MessageBox.Show("Заказов с указанным номером не найдено.",
                                    "Уведоление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    ordersDataGrid.ItemsSource = null;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите действительный номер заказа.",
                                "Уведоление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }
    }
}
