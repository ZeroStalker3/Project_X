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
    /// Interaction logic for PageOfferOrder.xaml
    /// </summary>
    public partial class PageOfferOrder : Page
    {
        public PageOfferOrder()
        {
            InitializeComponent();
            orderItemsDataGrid.ItemsSource = OdbConectHelper.entObj.OrderedProducts.ToList();
        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {
            var customer = customerTextBox.Text;
            var manager = managerTextBox.Text;
            var OrderCost = OdbConectHelper.entObj.Order.Sum(item => item.Cost);
            var OrderQuantity = OdbConectHelper.entObj.OrderedProducts.Sum(item => item.Quantity);
            var totalOrderCost = OrderCost * OrderQuantity;
            MessageBox.Show($"Заказ сохранен.\nЗаказчик: {customer}\nМенеджер: {manager}\nОбщая стоимость: {totalOrderCost}");

            Order order = new Order() {
            OrderNumber = 1231,
            Status = "New",
            //Customer = customer,
            //Manager = manager,
            Cost = totalOrderCost,
            OrderDate = DateTime.Now
            };
            OdbConectHelper.entObj.Order.Add(order);
            OdbConectHelper.entObj.SaveChanges();

        }
    }
}
