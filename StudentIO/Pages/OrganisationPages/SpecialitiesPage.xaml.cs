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

namespace StudentIO.Pages.OrganisationPages
{
    /// <summary>
    /// Interaction logic for SpecialitiesPage.xaml
    /// </summary>
    public partial class SpecialitiesPage : Page
    {
        public Frame ParentFrame;

        public SpecialitiesPage(Frame parentFrame)
        {
            InitializeComponent();
            ParentFrame = parentFrame;
            dgSpecialities.ItemsSource = DataBase.StudentIOEntities.GetContext().Speciality.ToList();
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgSpecialities.ItemsSource = DataBase.StudentIOEntities.GetContext().Speciality.
               Where(u => u.CodeSpeciality.Contains(tbSearch.Text) ||
                          u.SpecialityFullName.Contains(tbSearch.Text) ||
                          u.FormOfEducation.FormName.Contains(tbSearch.Text) ||
                          u.EducationDuration.ToString().Contains(tbSearch.Text));
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            ParentFrame.Navigate(new AddAndRedactSpecialityPage(null));
        }
    }
}
