using Microsoft.Win32;
using Project.Class;
using Project.Class.Database;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Project.PageM.MainPage.SecondPage
{
    /// <summary>
    /// Interaction logic for PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        public PageAddProduct()
        {
            InitializeComponent();
        }

        private void SelectImgae_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFileName = openFileDialog.FileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();

                ProductImage.Source = bitmap;
            }
        }

        private byte[] ImageToByteArray(BitmapImage image)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));

            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string articule = txtAtributes.Text;
                string name = txtName.Text;
                decimal width = Convert.ToDecimal(txtWidth.Text);
                decimal leght = Convert.ToDecimal(txtLegth.Text);
                string coment = txtComment.Text;

                //byte[] DroppedImage = File.ReadAllBytes();

                Product product = new Product()
                {
                    ProductID = articule,
                    Name = name,
                    Width = width,
                    Length = leght,
                    Comment = coment,
                    Image = ImageToByteArray((BitmapImage)ProductImage.Source)
                };

                OdbConectHelper.entObj.Product.Add(product);
                OdbConectHelper.entObj.SaveChanges();
                MessageBox.Show("Заказчик" + " успешно добавлен", "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения " + ex.Message.ToString(), "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
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

        //                DropTargetRectangle.Fill = Brushes.LightGray;
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error loading image: " + ex.Message);
        //            }
        //        }
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
    }
}
