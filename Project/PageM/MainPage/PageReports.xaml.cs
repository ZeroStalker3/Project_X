using Project.Class;
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
    /// Interaction logic for PageReports.xaml
    /// </summary>
    public partial class PageReports : Page
    {
        public PageReports()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            materialStockDataGrid.ItemsSource = OdbConectHelper.entObj.Inventory.ToList();
            materialStockDataGrid1.ItemsSource = OdbConectHelper.entObj.OrderedProducts.ToList();
            materialMovementDataGrid.ItemsSource = OdbConectHelper.entObj.MaterialMovement.ToList();
        }

        private void PrintStockReport(object sender, RoutedEventArgs e)
        {
            PrintHelper.PrintDataGrid(materialStockDataGrid, "Отчет по остаткам материалов");
        }

        private void PrintMovementReport(object sender, RoutedEventArgs e)
        {
            PrintHelper.PrintDataGrid(materialMovementDataGrid, "Отчет по движению материалов");
        }

        private void search1_Click(object sender, RoutedEventArgs e)
        {
            int z;
            if (int.TryParse(txt.Text, out z))
            {
                var results = OdbConectHelper.entObj.Order.Where(x => x.OrderNumber == z).ToList();
                if (results.Any())
                {
                    materialStockDataGrid1.ItemsSource = results;
                }
                else
                {
                    MessageBox.Show("Не найдено.",
                                    "Уведоление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    materialStockDataGrid1.ItemsSource = null;
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
        private void search2_Click(object sender, RoutedEventArgs e)
        {
            string orderNumber = txt.Text;
            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                var results = OdbConectHelper.entObj.MaterialMovement
                                .Where(x => x.Name.Contains(orderNumber))
                                .ToList();

                if (results.Any())
                {
                    materialMovementDataGrid.ItemsSource = results;
                }
                else
                {
                    MessageBox.Show("Не найдено.",
                                    "Уведоление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    materialMovementDataGrid.ItemsSource = null;
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

        private void search_Click(object sender, RoutedEventArgs e)
        {
            string orderNumber = txt.Text;
            if (!string.IsNullOrWhiteSpace(orderNumber))
            {
                var results = OdbConectHelper.entObj.Product
                                .Where(x => x.ProductID.Contains(orderNumber))
                                .ToList();

                if (results.Any())
                {
                    materialStockDataGrid.ItemsSource = results;
                }
                else
                {
                    MessageBox.Show("Не найдено.",
                                    "Уведоление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    materialStockDataGrid.ItemsSource = null;
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
