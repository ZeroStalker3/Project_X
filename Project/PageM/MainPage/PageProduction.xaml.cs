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
    /// Interaction logic for PageProduction.xaml
    /// </summary>
    public partial class PageProduction : Page
    {
        public PageProduction()
        {
            InitializeComponent();
        }

        private void SaveProduction(object sender, RoutedEventArgs e)
        {
            //var product = productTextBox.Text;
            //var quantity = int.Parse(quantityTextBox.Text);
            //var usedMaterials = usedMaterialsTextBox.Text;
            //MessageBox.Show($"Производство сохранено.\nИзделие: {product}\nКоличество: {quantity}\nИспользованные материалы: {usedMaterials}");
        }
    }
}
