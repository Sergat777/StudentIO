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

namespace StudentIO.Pages
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tbLogin.Clear();
            pswPassword.Clear();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(pswPassword.Password))
                MessageBox.Show("Заполните поля логина и пароля", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {

                //Entities.User user = Entities.VahicleDBEntities.GetContext().User.FirstOrDefault(u =>
                //    u.loginUser == tbLogin.Text && u.passwordUser == pswPassword.Password);

                //if (user == null)
                //    MessageBox.Show("Пользователь с введенными данными не обнаружен", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                //else
                //{
                //    MessageBox.Show($"Добро пожаловать, {user.lastName} {user.firstName} {user.middleName}!", "Уведомление",
                //        MessageBoxButton.OK, MessageBoxImage.Information);
                //}
            }
        }
    }
}
