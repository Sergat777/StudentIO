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
    /// Interaction logic for EnrolleePage.xaml
    /// </summary>
    public partial class EnrolleePage : Page
    {
        public EnrolleePage()
        {
            InitializeComponent();
            dgEnrollees.ItemsSource = DataBase.StudentIOEntities2.GetContext().Enrollee.ToList();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgEnrollees.ItemsSource = DataBase.StudentIOEntities2.GetContext().Enrollee.
                Where(u => u.SecondNameEnrollee.Contains(tbSearch.Text) ||
                           u.FirstNameEnrollee.Contains(tbSearch.Text) ||
                           u.MiddleNameEnrollee.Contains(tbSearch.Text)).ToList();
        }

        private void btEditEnrollee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btViewEnrollee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btAddEnrollee_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
