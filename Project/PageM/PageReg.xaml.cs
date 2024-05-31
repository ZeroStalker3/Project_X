using Project.Class;
using Project.Class.Database;
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
    /// Interaction logic for PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            try { 
            string NameZakazchik = NameTxt.Text;
            string login = LoginTxt.Text;
            if (PasswordTxt.Password == RepeatPasswordTxt.Password)
            {
                string password = PasswordTxt.Password;

                User user = new User
                {
                    Username = login,
                    Password = password,
                    IdRole = 2,  
                    Name = NameZakazchik
                };
                OdbConectHelper.entObj.User.Add(user);
                OdbConectHelper.entObj.SaveChanges();
                MessageBox.Show("Заказчик" + " успешно добавлен", "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
                FrameApp.frmObj.GoBack();
            }
            else
            {
                MessageBox.Show("Пароль не совпадает ", "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения " + ex.Message.ToString(), "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
