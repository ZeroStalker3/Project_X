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

namespace Project.PageM.Кладовщик
{
    /// <summary>
    /// Interaction logic for PageSklad.xaml
    /// </summary>
    public partial class PageSklad : Page
    {
        public PageSklad()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            DgFabric.ItemsSource = OdbConectHelper.entObj.Fabric.ToList();
            DgFurniture.ItemsSource = OdbConectHelper.entObj.Accessory.ToList();
        }
    }
}
