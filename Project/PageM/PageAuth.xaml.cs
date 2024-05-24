using Project.Class;
using Project.PageM.MainPage;
using Project.PageM.MainPage.PageWithListProduct;
using Project.PageM.MainPage.SecondPage;
using Project.PageM.Дирекция;
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

namespace Project.PageM
{
    /// <summary>
    /// Interaction logic for PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Page
    {
        public PageAuth()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var userObj = OdbConectHelper.entObj.User.FirstOrDefault(x => x.Username == logtxt.Text && x.Password == psbtxt.Password);
            if (userObj == null)
            {
                MessageBox.Show("Такой пользователь отсутсвует в приложения",
                    "Уведомление",
                     MessageBoxButton.OK,
                     MessageBoxImage.Warning);
                FrameApp.frmObj.Navigate(new PageReg());
            }
            else
            {
                FrameApp.frmObj.Navigate(new PageDirector());
                
            }
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageReg());
        }
    }
}
