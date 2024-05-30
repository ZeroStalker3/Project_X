using Project.Class;
using Project.Class.Database;
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
            orderItemsDataGrid.ItemsSource = OdbConectHelper.entObj.OrderedProducts.ToList();
        }

        private void SaveOrder(object sender, RoutedEventArgs e)
        {

            // Предположим, что у вас есть ListBox с именем orderListBox
            var selectedOrder = orderItemsDataGrid.SelectedItem as Order;

            if (selectedOrder != null)
            {
                var customer = customerTextBox.Text;
                var manager = managerTextBox.Text;

                // Здесь используется только выделенный заказ
                var orderCost = selectedOrder.Cost;
                var orderQuantity = selectedOrder.OrderedProducts.Sum(item => item.Quantity);
                var totalOrderCost = orderCost * orderQuantity;

                MessageBox.Show($"Заказ сохранен.\nЗаказчик: {customer}\nМенеджер: {manager}\nОбщая стоимость: {totalOrderCost}");

                // Создаем новый заказ с использованием данных выделенного заказа
                Order order = new Order()
                {
                    OrderNumber = selectedOrder.OrderNumber, // Используем номер выделенного заказа
                    Status = "New",
                    Customer = customer,
                    Manager = manager,
                    Cost = totalOrderCost,
                    OrderDate = DateTime.Now
                };

                // Добавляем новый заказ в контекст и сохраняем изменения
                OdbConectHelper.entObj.Order.Add(order);
                OdbConectHelper.entObj.SaveChanges();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ для сохранения.");
            }
        }
    }
}
