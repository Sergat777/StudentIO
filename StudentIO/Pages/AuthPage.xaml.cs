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
            Classes.Navigation.InfoPanel.Visibility = Visibility.Hidden;
            Classes.Navigation.UserFIO.Visibility = Visibility.Collapsed;
        }

        private void btClear_Click(object sender, RoutedEventArgs e)
        {
            tbLogin.Clear();
            pswPassword.Clear();
        }

        private void btEnter_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(pswPassword.Password))
                MessageBox.Show("Заполните поля логина и пароля!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                DataBase.Employee employee = DataBase.StudentIOEntities2.GetContext().Employee.FirstOrDefault(u =>
                    u.Login == tbLogin.Text && u.Password == pswPassword.Password);

                if (employee == null)
                    MessageBox.Show("Пользователь с введенными данными не обнаружен.", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    MessageBox.Show($"Добро пожаловать, {employee.SecondNameEmployee} {employee.FirstNameEmployee} {employee.MiddleNameEmployee}!",
                        "Информация", MessageBoxButton.OK, MessageBoxImage.Information);


                    Classes.Navigation.CurrentEmployee = employee;
                    Classes.Navigation.FrameNavigation.Navigate(new Pages.MainPage());
                    Classes.Navigation.UserFIO.Visibility = Visibility.Visible;
                    Classes.Navigation.InfoPanel.Visibility = Visibility.Visible;
                    Classes.Navigation.TxtSecondName.Text = employee.SecondNameEmployee;
                    Classes.Navigation.TxtFirstName.Text = employee.FirstNameEmployee;
                    Classes.Navigation.TxtMiddleName.Text = employee.MiddleNameEmployee;
                }
            }
        }
    }
}
