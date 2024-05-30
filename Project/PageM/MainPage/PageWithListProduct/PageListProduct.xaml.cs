using Project.Class;
using Project.Class.Database;
using Project.PageM.MainPage.SecondPage;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
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

namespace Project.PageM.MainPage.PageWithListProduct
{
    /// <summary>
    /// Interaction logic for PageListProduct.xaml
    /// </summary>
    public partial class PageListProduct : Page
    {
        
        public PageListProduct()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            GridList.ItemsSource = OdbConectHelper.entObj.Product.ToList();
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAddProduct());
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (GridList.SelectedItems.Count > 0)
                {
                    foreach (var selectedItem in GridList.SelectedItems.Cast<Product>().ToList())
                    {
                        OdbConectHelper.entObj.Product.Remove(selectedItem);
                    }

                    OdbConectHelper.entObj.SaveChanges();
                    GridList.ItemsSource = OdbConectHelper.entObj.Product.ToList();

                    MessageBox.Show("Выбранные строки удалены.",
                                    "Уведомление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Не выбраны строки для удаления.",
                                    "Уведомление",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла критическая ошибка: " + ex.Message,
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageEdit((sender as Button).DataContext as Product));
        }
    }

    public class ByteArrayToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is byte[] byteArray && byteArray.Length > 0)
            {
                BitmapImage image = new BitmapImage();
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    image.BeginInit();
                    image.StreamSource = ms;
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.EndInit();
                }
                return image;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
