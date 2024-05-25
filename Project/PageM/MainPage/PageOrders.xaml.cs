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
    /// Interaction logic for PageOrders.xaml
    /// </summary>
    public partial class PageOrders : Page
    {
        public PageOrders()
        {
            InitializeComponent();

            ordersDataGrid.ItemsSource=OdbConectHelper.entObj.OrderedProducts.ToList();
        }

        private void offorder_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageOfferOrder());
        }
    }
}
