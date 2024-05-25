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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project.PageM.MainPage
{
    /// <summary>
    /// Interaction logic for PageInventory.xaml
    /// </summary>
    public partial class PageInventory : Page
    {
        public PageInventory()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            inventoryDataGrid.ItemsSource = OdbConectHelper.entObj.Inventory.ToList();
        }

        private void PerformInventory(object sender, RoutedEventArgs e)
        {
            var discrepancies = OdbConectHelper.entObj.Inventory.Where(item => (item.DifferencePercentage) > 20).ToList();
            if (discrepancies.Any())
            {
                MessageBox.Show("Есть расхождения более 20%. Необходимо утверждение директора.");
            }
            else
            {
                MessageBox.Show("Инвентаризация успешно проведена.");
            }
        }
    }
}
