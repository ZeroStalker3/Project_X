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
    /// Interaction logic for PageProductDetail1.xaml
    /// </summary>
    public partial class PageProductDetail1 : Page
    {
        public PageProductDetail1()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void LoadData()
        {
            DataGridList.ItemsSource = OdbConectHelper.entObj.TheProduct.ToList();
            Cmbselect.DisplayMemberPath = "Наименование";
            Cmbselect.SelectedValuePath = "Артикул";
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageProductdetail((sender as Button).DataContext as TheProduct));
        }

        private void Cmbselect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string select = Convert.ToString(Cmbselect.SelectedValue);
            DataGridList.ItemsSource = OdbConectHelper.entObj.TheProduct.Where(x
                => x.Артикул == select).ToList();
            DataGridList.SelectedIndex = 0;
        }
    }
}
    