using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace StudentIO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Classes.Navigation.FrameNavigation = mainFrame;

            //mainFrame.Navigate(new Pages.AuthPage());

            mainFrame.Navigate(new Pages.MainPage());

        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из текущей учетной записи?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                mainFrame.Navigate(new Pages.AuthPage());
                txtEmployeeSecondName.Text = "";
                txtEmployeeFirstName.Text = "";
                txtEmployeeMiddleName.Text = "";
            }
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
