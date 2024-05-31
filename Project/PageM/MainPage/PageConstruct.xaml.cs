using Project.Class;
using Project.Class.Database;
using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class PageConstruct : Page
    {
        public PageConstruct()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            cmbcloth.ItemsSource = OdbConectHelper.entObj.Fabric.ToList();
            cmbcloth.DisplayMemberPath = "Name";
            cmbcloth.SelectedValuePath = "FabricID";

            cmbOcontovka.ItemsSource = OdbConectHelper.entObj.Accessory.ToList();
            cmbOcontovka.DisplayMemberPath = "Name"; 
            cmbOcontovka.SelectedValuePath = "AccessoryID";

            cmbProduct.ItemsSource = OdbConectHelper.entObj.Product.ToList();
            cmbProduct.DisplayMemberPath = "Name";
            cmbProduct.SelectedValuePath = "ProductID";


            cmbOcontovka1.ItemsSource = OdbConectHelper.entObj.Accessory.ToList();
            cmbOcontovka1.DisplayMemberPath = "Name";
            cmbOcontovka1.SelectedValuePath = "AccessoryID";
        }

        private void Clicker_Click(object sender, RoutedEventArgs e)
        {
            decimal width = Convert.ToDecimal(txtbox.Text);
            decimal hight = Convert.ToDecimal(txtbox1.Text);
            string cloth = Convert.ToString(cmbcloth.SelectedValue);
            int IdOrder = Convert.ToInt32(tekstbox.Text);
            string Ocontovka = Convert.ToString(cmbOcontovka.SelectedValue);
            string Ocontovka1 = Convert.ToString(cmbOcontovka1.SelectedValue);
            string Product = Convert.ToString(cmbProduct.SelectedValue);
            int Koli4estvoTxt = Convert.ToInt32(Koli4estvoTxt1.Text);
            int Rotate = Convert.ToInt32(textbox.Text); 
            DateTime orderDate = DateTime.Now;
            decimal productPrice = (
        Convert.ToDecimal(OdbConectHelper.entObj.Fabric.Where(u => u.FabricID == (string)cmbcloth.SelectedValue).FirstOrDefault().Price) +
        Convert.ToDecimal(OdbConectHelper.entObj.Accessory.Where(u => u.AccessoryID == (string)cmbOcontovka.SelectedValue).FirstOrDefault().Price) 
    ) * Convert.ToDecimal(Koli4estvoTxt1.Text);
            Order order = new Order()
            {
                OrderNumber = IdOrder ,
                OrderDate = orderDate,
                Status = "New",
                Customer = "customer1" ,
                Manager = " manager1",
                Cost = Convert.ToDecimal(OdbConectHelper.entObj.Fabric.Where(u => u.FabricID == (string)cmbcloth.SelectedValue).FirstOrDefault().Price)
            };

            OrderItem orderitem = new OrderItem()
            {
                IdOreder = IdOrder,
                IdProduct = Product,
                IdFabric = cloth,
                IdAccessory = Ocontovka,
                Width = width,
                Height = hight,
                Price = productPrice,
                RorarionAngle = Rotate,
                Amount = Koli4estvoTxt
            };

            OdbConectHelper.entObj.Order.Add(order);
            OdbConectHelper.entObj.OrderItem.Add(orderitem);
            OdbConectHelper.entObj.SaveChanges();
        }

        public string ImagesPath = @"pack://siteoforigin:,,,/Logo/";

        private void cmbcloth_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //MessageBox.Show(ImagesPath + @"Изделия/");
                ImProductView.Source = new BitmapImage(new Uri(ImagesPath + @"Изделия/" + cmbcloth.SelectedValue + ".jpg", UriKind.RelativeOrAbsolute));
            }
            catch
            {
                ImProductView.Source = new BitmapImage(new Uri(@".\..\Logo\Image\no-image.jpg", UriKind.RelativeOrAbsolute));
            }
        }

        private void cmbOcontovka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //MessageBox.Show(ImagesPath + @"Изделия/");
                ImProductView.Source = new BitmapImage(new Uri(ImagesPath + @"Изделия/" + cmbOcontovka.SelectedValue + ".jpg", UriKind.RelativeOrAbsolute));
            }
            catch
            {
                ImProductView.Source = new BitmapImage(new Uri(@".\..\Logo\Image\no-image.jpg", UriKind.RelativeOrAbsolute));
            }
        }

        private void cmbOcontovka1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //MessageBox.Show(ImagesPath + @"Изделия/");
                ImProductView.Source = new BitmapImage(new Uri(ImagesPath + @"Изделия/" + cmbOcontovka1.SelectedValue + ".jpg", UriKind.RelativeOrAbsolute));
            }
            catch
            {
                ImProductView.Source = new BitmapImage(new Uri(@".\..\Logo\Image\no-image.jpg", UriKind.RelativeOrAbsolute));
            }
        }

        private void cmbProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                //MessageBox.Show(ImagesPath + @"Изделия/");
                ImProductView.Source = new BitmapImage(new Uri(ImagesPath + @"Изделия/" + cmbProduct.SelectedValue + ".jpg", UriKind.RelativeOrAbsolute));
            }
            catch
            {
                ImProductView.Source = new BitmapImage(new Uri(@".\..\Logo\Image\no-image.jpg", UriKind.RelativeOrAbsolute));
            }
        }

        //private void DropTargetRectangle_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        e.Effects = DragDropEffects.Copy;
        //        DropTargetRectangle.Fill = Brushes.Green;
        //    }
        //    else
        //    {
        //        e.Effects = DragDropEffects.None;
        //    }
        //}

        //private void DropTargetRectangle_DragLeave(object sender, DragEventArgs e)
        //{
        //    DropTargetRectangle.Fill = Brushes.LightGray;
        //}

        //private void DropTargetRectangle_DragOver(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        e.Effects = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        e.Effects = DragDropEffects.None;
        //    }
        //}

        //private void DropTargetRectangle_Drop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //        if (files.Length > 0)
        //        {
        //            string filePath = files[0];
        //            try
        //            {
        //                BitmapImage bitmap = new BitmapImage(new Uri(filePath));
        //                DroppedImage.Source = bitmap;

        //                // Установить CenterX и CenterY для поворота из центра изображения
        //                bitmap.DownloadCompleted += (s, ev) =>
        //                {
        //                    ImageRotateTransform.CenterX = DroppedImage.ActualWidth / 2;
        //                    ImageRotateTransform.CenterY = DroppedImage.ActualHeight / 2;
        //                    ImageScaleTransform.CenterX = DroppedImage.ActualWidth / 2;
        //                    ImageScaleTransform.CenterY = DroppedImage.ActualHeight / 2;
        //                };

        //                DropTargetRectangle.Fill = Brushes.LightGray;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error loading image: " + ex.Message);
        //            }
        //        }
        //    }
        //}

        //private void RotationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (ImageRotateTransform != null)
        //    {
        //        ImageRotateTransform.Angle = e.NewValue;
        //    }
        //}

        //private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (ImageScaleTransform != null)
        //    {
        //        ImageScaleTransform.ScaleX = e.NewValue;
        //    }
        //}

        //private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (ImageScaleTransform != null)
        //    {
        //        ImageScaleTransform.ScaleY = e.NewValue;
        //    }
        //}
    }
}