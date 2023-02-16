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
    /// Interaction logic for AddAndRedactSpecialityPage.xaml
    /// </summary>
    public partial class AddAndRedactSpecialityPage : Page
    {
        bool isNewSpeciality = false;
        public DataBase.Speciality AddRedactSpeciality = new DataBase.Speciality();

        public AddAndRedactSpecialityPage(DataBase.Speciality editedSpeciality)
        {
            InitializeComponent();
            cmbxFormOfEducation.ItemsSource = DataBase.StudentIOEntities1.GetContext().FormOfEducation.ToList();

            if (editedSpeciality != null)
            {
                AddRedactSpeciality = editedSpeciality;
                isNewSpeciality = true;

                tbCodeSpeciality.Text = editedSpeciality.CodeSpeciality;
                tbSpecialityFullName.Text = editedSpeciality.SpecialityFullName;
                tbEducationDuration.Text = editedSpeciality.EducationDuration.ToString();
                cmbxFormOfEducation.SelectedIndex = editedSpeciality.FormOfEducationId - 1;
            }
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbCodeSpeciality.Text) &&
                !string.IsNullOrWhiteSpace(tbSpecialityFullName.Text) &&
                !string.IsNullOrWhiteSpace(tbEducationDuration.Text) &&
                cmbxFormOfEducation.SelectedIndex >= 0)
            {
                if (tbEducationDuration.Text.All(Char.IsDigit))
                {
                    if (MessageBox.Show("Вы уверены, что хотите сохранить информацию о новой специальности?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        AddRedactSpeciality.CodeSpeciality = tbCodeSpeciality.Text;
                        AddRedactSpeciality.SpecialityFullName = tbSpecialityFullName.Text;
                        AddRedactSpeciality.EducationDuration = Convert.ToInt16(tbEducationDuration.Text);
                        AddRedactSpeciality.FormOfEducationId = cmbxFormOfEducation.SelectedIndex + 1;

                        if (isNewSpeciality)
                            DataBase.StudentIOEntities1.GetContext().Speciality.Add(AddRedactSpeciality);

                        DataBase.StudentIOEntities1.GetContext().SaveChanges();

                        MessageBox.Show("Информация успешно сохранена!", "Информация",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                        NavigationService.GoBack();
                    }
                }
                else
                    MessageBox.Show("Количество курсов введено некоректно!", "Внимание",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Все поля обязательны для заполнения!", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
