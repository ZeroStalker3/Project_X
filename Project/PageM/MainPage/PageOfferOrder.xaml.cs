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
    /// Interaction logic for PageOfferOrder.xaml
    /// </summary>
    public partial class PageOfferOrder : Page
    {
        public PageOfferOrder()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmbCustomer.ItemsSource = OdbConectHelper.entObj.Order.ToList();
            cmbCustomer.SelectedValuePath = "OrderNumber";
            cmbCustomer.DisplayMemberPath = "Customer";

            cmbManager.ItemsSource = OdbConectHelper.entObj.Order.ToList();
            cmbManager.SelectedValuePath = "OrderNumber";
            cmbManager.DisplayMemberPath = "Manager";
        }

        //private void SaveOrder(object sender, RoutedEventArgs e)
        //{
        //    //Просто добавление заказа
        //}

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddProduct());

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            int Number1 = Convert.ToInt32(txtnumber.Text);
            string Customer = Convert.ToString(cmbCustomer.SelectedValue);
            string Manager = Convert.ToString(cmbManager.SelectedValue);
            int price = Convert.ToInt32(txtCost.Text);

            Order order = new Order()
            {
                OrderNumber = Number1, 
                Customer = Customer, 
                Manager = Manager,
                OrderDate = DateTime.Now,
                Status = "New",
                Cost = price
            };
            OdbConectHelper.entObj.Order.Add(order);
            OdbConectHelper.entObj.SaveChanges();
            MessageBox.Show("Заказ Успешно добавлен",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void txtnumber_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = "1234567890".IndexOf(e.Text) < 0;
        }
    }
}
