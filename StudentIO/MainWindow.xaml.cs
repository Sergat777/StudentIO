using StudentIO.DataBase;
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
            Classes.Navigation.InfoPanel = navigationPanel;
            Classes.Navigation.UserFIO = UserFIO;

            Classes.Navigation.TxtSecondName = txtEmployeeSecondName;
            Classes.Navigation.TxtFirstName = txtEmployeeFirstName;
            Classes.Navigation.TxtMiddleName = txtEmployeeMiddleName;

            //mainFrame.Navigate(new Pages.AuthPage());



            //private static StudentIOEntities1 _context;

            //public static StudentIOEntities1 GetContext()
            //{
            //    if (_context == null)
            //        _context = new StudentIOEntities1();

            //    return _context;
            //}


            mainFrame.Navigate(new Pages.MainPage());

        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти из текущей учетной записи?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                mainFrame.Navigate(new Pages.AuthPage());
            }
        }

        private void btInfo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
