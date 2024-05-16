using Project.Class;
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
        public PageProductdetail(string Атрибут)
        {
            InitializeComponent();
            _context = new OdbConectHelper();
            string _productId = Атрибут;
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            var product = OdbConectHelper.entObj.TheProducts.Find(_productId);

            if (product != null)
            {
                //ProductImage.Source = new BitmapImage(new Uri(product.ImagePath));
                //ProductName.Text = product.Name;
                //ProductDescription.Text = product.Description;
                //ProductComposition.Text = product.Composition;
                //ProductCareInstructions.Text = product.CareInstructions;
                //SpecificationList.ItemsSource = product.Specifications;
                //SpecificationHistoryList.ItemsSource = product.SpecificationHistories;
            }
        }
    }
}