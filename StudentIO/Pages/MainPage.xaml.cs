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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btEnrollee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btSelectionCampaign_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btEntranceTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btOrganization_Click(object sender, RoutedEventArgs e)
        {
            mainPageFrame.Navigate(new OrganisationPage());
        }
    }
}
