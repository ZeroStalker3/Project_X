using Project.Class;
using Project.Class.Database;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
    public partial class PageProductdetail : Page
    {
        private readonly int _productId;
        private static OdbConectHelper _context;
        private string Atributes;

        public PageProductdetail(Product theProduct)
        {
            InitializeComponent();
            Atributes = theProduct.ProductID;
            LoadData();
            LoadProductDetails();
        }

        private void LoadData() 
        {
            SpecificationList.ItemsSource = OdbConectHelper.entObj.Product.ToList();
        }

        private void LoadProductDetails()
        {
            var product = OdbConectHelper.entObj.Product.Find(Atributes);

            if (product != null)
            {
                //ProductImage.Source = new BitmapImage(new Uri(product.Изображени)); //Добавить изображение в базу данных
                ProductName.Text = product.Name;
                ProductDescription.Text = product.Comment;
                ProductComposition.Text = product.ProductID;
            }
        }
    }
}