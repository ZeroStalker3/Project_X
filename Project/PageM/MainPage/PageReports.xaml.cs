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
    }
}
