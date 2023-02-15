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
    /// Логика взаимодействия для OrganisationPage.xaml
    /// </summary>
    public partial class OrganisationPage : Page
    {
        public OrganisationPage()
        {
            InitializeComponent();
            //OrganisationFrame = Classes.Navigation.FrameNavigation;
        }

        private void btPersonalFiles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btGroups_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btSpecialties_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btOrders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btEmployees_Click(object sender, RoutedEventArgs e)
        {
            OrganisationFrame.Navigate(new Pages.OrganisationPages.EmployeesPage());
        }
    }
}
