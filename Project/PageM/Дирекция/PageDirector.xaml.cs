using Project.Class;
using Project.PageM.MainPage;
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

namespace Project.PageM.Дирекция
{
    /// <summary>
    /// Interaction logic for PageDirector.xaml
    /// </summary>
    public partial class PageDirector : Page
    {
        public PageDirector()
        {
            InitializeComponent();
        }

        private void PageAccountingMaterials_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageAccountingMaterials());
        }

        private void PageConstructorProducts_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageConstruct());
        }
    }
}
