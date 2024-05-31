using Project.Class;
using Project.PageM.MainPage;
using Project.PageM.MainPage.PageWithListProduct;
using Project.PageM.MainPage.SecondPage;
using Project.PageM.Дирекция;
using Project.PageM.Заказчик;
using Project.PageM.Кладовщик;
using Project.PageM.Менеджер;
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
            var userObj = OdbConectHelper.entObj.User.FirstOrDefault(x => x.Username == logtxt.Text);

            if (string.IsNullOrWhiteSpace(logtxt.Text))
            {
                MessageBox.Show("Введите логин", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                if (string.IsNullOrWhiteSpace(psbtxt.Password))
                {
                    MessageBox.Show("Введите пароль", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            else
                if (userObj == null)
                {
                    MessageBox.Show("Такой пользователь отсутствует в приложении", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                    FrameApp.frmObj.Navigate(new PageReg());
                }
            else 
                if (!userObj.Password.Equals(psbtxt.Password, StringComparison.Ordinal))
                {
                    MessageBox.Show("Неверный пароль", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            else
            {
                switch (userObj.IdRole)
                {
                    case 1:
                        FrameApp.frmObj.Navigate(new PageSklad());
                        MessageBox.Show("Добро пожаловать", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information );
                        break;
                    case 2:
                        FrameApp.frmObj.Navigate(new PageZakazchik());
                        MessageBox.Show("Добро пожаловать", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case 3:
                        FrameApp.frmObj.Navigate(new PageDirector());
                        MessageBox.Show("Добро пожаловать", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    case 4:
                        FrameApp.frmObj.Navigate(new PageMenedger()); 
                        MessageBox.Show("Добро пожаловать", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                }
            }

        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageReg());
        }
    }
}
