using Microsoft.Win32;
using Project.Class;
using Project.Class.Database;
using System;
using System.Data.Odbc;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Project.PageM.MainPage.PageWithListProduct
{
    /// <summary>
    /// Interaction logic for PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        private Product _product;
        public PageEdit(Product theProduct)
        {
            InitializeComponent();

            _product = theProduct;

            textBoxName.Text = theProduct.Name;
            textBoxLength.Text = theProduct.Length.ToString();
            textBoxWidth.Text = theProduct.Width.ToString();
            textBoxComment.Text = theProduct.Comment;
            if (_product.Image != null)
            {
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = new MemoryStream(_product.Image);
                bitmap.EndInit();
                ProductImage.Source = bitmap;
            }
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

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _product.Name = textBoxName.Text;
                _product.Length = decimal.Parse(textBoxLength.Text);
                _product.Width = decimal.Parse(textBoxWidth.Text);
                _product.Comment = textBoxComment.Text;
                _product.Image = ImageToByteArray((BitmapImage)ProductImage.Source);

                OdbConectHelper.entObj.SaveChanges();

                MessageBox.Show("Данные успешно изменены.",
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
                FrameApp.frmObj.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении изменений: " + ex.Message,
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

    }
}

