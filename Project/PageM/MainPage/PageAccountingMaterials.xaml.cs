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
    /// Interaction logic for PageAccountingMaterials.xaml
    /// </summary>
    public partial class PageAccountingMaterials : Page
    {
        float recul;
        public PageAccountingMaterials()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            FabricDataGrid.ItemsSource = OdbConectHelper.entObj.Clothes.ToList();
            AccessoryDataGrid.ItemsSource = OdbConectHelper.entObj.Accessories.ToList();
            ProductDataGrid.ItemsSource = OdbConectHelper.entObj.Ordered_Products.ToList();

            FabricUnitComboBox.DisplayMemberPath = "Наименование";
            FabricUnitComboBox.SelectedValuePath = "Артикул";
            FabricUnitComboBox.ItemsSource = OdbConectHelper.entObj.Clothes.ToList();

            AccessoryUnitComboBox.DisplayMemberPath = "Наименование";
            AccessoryUnitComboBox.SelectedValuePath = "Артикул";
            AccessoryUnitComboBox.ItemsSource = OdbConectHelper.entObj.Accessories.ToList();

        }

        private void FabricRecalculate_Click(object sender, RoutedEventArgs e)
        {
            //float quantity = Convert.ToInt32(FabricQuantityTextBox.Text);
            //string selected = (string)this.FabricUnitComboBox.DisplayMemberPath;

            //var obj = OdbConectHelper.entObj.Clothes.Where(x => x.Наименование == selected);
            //if (selected == Convert.ToString(obj)) 
            //{
            //    Warehouse_Cloth warehouse_Cloth = new Warehouse_Cloth
            //    {
            //        Рулон = Convert.ToInt32(quantity)
            //    };
            //}

        }

        private void AccessoryRecalculate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
