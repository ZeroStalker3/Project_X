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
    public partial class PageConstruct : Page
    {
        public PageConstruct()
        {
            InitializeComponent();
        }

        private void DropTargetRectangle_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
                DropTargetRectangle.Fill = Brushes.Green;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void DropTargetRectangle_DragLeave(object sender, DragEventArgs e)
        {
            DropTargetRectangle.Fill = Brushes.LightGray;
        }

        private void DropTargetRectangle_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effects = DragDropEffects.Copy;
            }
            else
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void DropTargetRectangle_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0)
                {
                    string filePath = files[0];
                    try
                    {
                        BitmapImage bitmap = new BitmapImage(new Uri(filePath));
                        DroppedImage.Source = bitmap;

                        // Установить CenterX и CenterY для поворота из центра изображения
                        bitmap.DownloadCompleted += (s, ev) =>
                        {
                            ImageRotateTransform.CenterX = DroppedImage.ActualWidth / 2;
                            ImageRotateTransform.CenterY = DroppedImage.ActualHeight / 2;
                            ImageScaleTransform.CenterX = DroppedImage.ActualWidth / 2;
                            ImageScaleTransform.CenterY = DroppedImage.ActualHeight / 2;
                        };

                        DropTargetRectangle.Fill = Brushes.LightGray;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }

        private void RotationSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ImageRotateTransform != null)
            {
                ImageRotateTransform.Angle = e.NewValue;
            }
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ImageScaleTransform != null)
            {
                ImageScaleTransform.ScaleX = e.NewValue;
            }
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ImageScaleTransform != null)
            {
                ImageScaleTransform.ScaleY = e.NewValue;
            }
        }
    }
}