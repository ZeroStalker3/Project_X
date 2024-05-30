using Project.Class;
using Project.Class.Database;
using Project.PageM.MainPage.PageWithListProduct;
using Project.PageM.MainPage.SecondPage;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            //Сортировка
            CmbFabric.ItemsSource = OdbConectHelper.entObj.Fabric.ToList();
            CmbFabric.DisplayMemberPath = "Name";
            CmbFabric.SelectedValuePath = "FabricID";

            CmbAccessory.ItemsSource = OdbConectHelper.entObj.Accessory.ToList();
            CmbAccessory.DisplayMemberPath = "Name";
            CmbAccessory.SelectedValuePath = "AccessoryID";

            CmbProduct.ItemsSource = OdbConectHelper.entObj.Product.ToList();
            CmbProduct.DisplayMemberPath = "Name";
            CmbProduct.SelectedValuePath = "ProductID";

            //Вывод данных
            FabricDataGrid.ItemsSource = OdbConectHelper.entObj.Fabric.ToList();
            AccessoryDataGrid.ItemsSource = OdbConectHelper.entObj.AccessoryStock.ToList();
            ProductDataGrid.ItemsSource = OdbConectHelper.entObj.OrderedProducts.ToList();

            FabricUnitComboBox.DisplayMemberPath = "Name";
            FabricUnitComboBox.SelectedValuePath = "FabricID";
            FabricUnitComboBox.ItemsSource = OdbConectHelper.entObj.Fabric.ToList();

            AccessoryUnitComboBox.DisplayMemberPath = "Name";
            AccessoryUnitComboBox.SelectedValuePath = "AccessoryID";
            AccessoryUnitComboBox.ItemsSource = OdbConectHelper.entObj.Accessory.ToList();
        }

        private void FabricRecalculate_Click(object sender, RoutedEventArgs e)
        {
            //float quantity = Convert.ToInt32(FabricQuantityTextBox.Text);
            //string text = FabricUnitComboBox.Text;
            //int select = Convert.ToInt32(FabricUnitComboBox.SelectedValue);

            //Warehouse_Cloth warehouse_Cloth = new Warehouse_Cloth()
            //{
            //    Рулон = Convert.ToInt32(select)
            //};

            //OdbConectHelper.entObj.Warehouse_Accessories.Add(warehouse_Cloth);
            //OdbConectHelper.entObj.SaveChanges();

        }

        private void AccessoryRecalculate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            //// Получаем выбранный элемент из DataGrid
            //var selectedProduct = ProductDataGrid.SelectedItem as Project.Class.Database.Product;

            //// Проверяем, что элемент был выбран
            //if (selectedProduct != null)
            //{
            //    // Удаляем выбранный элемент из источника данных
            //    OdbConectHelper.entObj.Product.Remove(selectedProduct);
            //    OdbConectHelper.entObj.SaveChangesAsync();
            //}
            //else
            //{

            //}
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddProduct());
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageListProduct());
        }

        private void CmbFabric_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string select = Convert.ToString(CmbFabric.SelectedValue);
            FabricDataGrid.ItemsSource = OdbConectHelper.entObj.Fabric.Where(x
                => x.FabricID == select).ToList();
            FabricDataGrid.SelectedIndex = 0;
        }

        private void CmbAccessory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string select = Convert.ToString(CmbAccessory.SelectedValue);
            AccessoryDataGrid.ItemsSource = OdbConectHelper.entObj.AccessoryStock.Where(x
                => x.AccessoryID == select).ToList();
            AccessoryDataGrid.SelectedIndex = 0;
        }

        private void CmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string select = Convert.ToString(CmbProduct.SelectedValue);
            ProductDataGrid.ItemsSource = OdbConectHelper.entObj.OrderedProducts.Where(x
                => x.ProductID == select).ToList();
            ProductDataGrid.SelectedIndex = 0;
        }
    }
}
