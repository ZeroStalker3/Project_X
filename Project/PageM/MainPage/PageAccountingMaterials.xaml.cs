using Project.Class;
using Project.Class.Database;
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
            FabricDataGrid.ItemsSource = OdbConectHelper.entObj.Fabric.ToList();
            AccessoryDataGrid.ItemsSource = OdbConectHelper.entObj.Accessory.ToList();
            ProductDataGrid.ItemsSource = OdbConectHelper.entObj.Product.ToList();

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

        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddProduct());
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
