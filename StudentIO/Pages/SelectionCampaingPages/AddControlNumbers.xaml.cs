using StudentIO.DataBase;
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

namespace StudentIO.Pages.SelectionCampaingPages
{
    /// <summary>
    /// Interaction logic for AddControlNumbers.xaml
    /// </summary>
    public partial class AddControlNumbers : Page
    {
        public SelectionCampaign SelectionCampaign;

        public AddControlNumbers(DataBase.SelectionCampaign campaign)
        {
            InitializeComponent();

            SelectionCampaign = campaign;

            txtDescription.Text = $"Формирование контрольных цифр приема ПРИЕМНОЙ КАМПАНИИ {campaign.CampaignYear} года\n" +
                                  $"Выберите специальность, форму обучения, укажите количество мест и осуществляется ли обучение на платной основе:";

            dgSpecialities.ItemsSource = DataBase.StudentIOEntities2.GetContext().Speciality.ToList();
            cmbxFormOfEducation.ItemsSource = DataBase.StudentIOEntities2.GetContext().FormOfEducation.ToList();
            //dgControlNumbers.ItemsSource = DataBase.StudentIOEntities2.GetContext().AdmissionControlNumber.ToList();
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите вернуться назад? Все изменения будут утеряны.", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                NavigationService.GoBack();
        }

        private void btAddSpeciality_Click(object sender, RoutedEventArgs e)
        {
            if (dgSpecialities.SelectedItem != null)
            {
                if (cmbxFormOfEducation.SelectedIndex >= 0)
                {
                    if (!string.IsNullOrWhiteSpace(tbNumberOfStudents.Text) && tbNumberOfStudents.Text.All(Char.IsDigit))
                    {
                        foreach(var speciality in dgControlNumbers.Items)
                        {
                            if ((speciality as AdmissionControlNumber).SpecialityCode == (dgSpecialities.SelectedItem as Speciality).CodeSpeciality)
                            {
                                MessageBox.Show("Данная специальность уже добавлена в список контрольных цифр приема.", "Внимание",
                                    MessageBoxButton.OK, MessageBoxImage.Stop);
                                return;
                            }
                        }

                        AdmissionControlNumber controlNumber = new AdmissionControlNumber()
                        {
                            SelectionCampaignId = SelectionCampaign.IdSelectionCampaign,
                            SpecialityCode = (dgSpecialities.SelectedItem as Speciality).CodeSpeciality,
                            FormOfEducationId = (cmbxFormOfEducation.SelectedItem as FormOfEducation).IdForm,
                            NumberOfStudent = Convert.ToInt16(tbNumberOfStudents.Text),
                            IsPaidBasis = (bool)chPaidBase.IsChecked
                        };

                        StudentIOEntities2.GetContext().AdmissionControlNumber.Add(controlNumber);
                        StudentIOEntities2.GetContext().SaveChanges();

                        dgControlNumbers.Items.Add(controlNumber);
                    }
                    else
                        MessageBox.Show("Количество мест должно указываться числом", "Внимание",
                            MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                    MessageBox.Show("Выберите доступную форму обучения.", "Внимание",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Выберите одну специальность для добавления.", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);


        }

        private void btAddControlNumbers_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сохранить информацию об учетной записи сотрудника?", "Внимание",
                           MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show($"Контрольные цифры приема ПРИЕМНОЙ КАМПАНИИ {SelectionCampaign.CampaignYear} года успешно сохранены.", "Информация",
                           MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
        }

        private void btDeleteSpeciality_Click(object sender, RoutedEventArgs e)
        {
            StudentIOEntities2.GetContext().AdmissionControlNumber.Remove((sender as Button).DataContext as AdmissionControlNumber);
            dgControlNumbers.Items.Remove((sender as Button).DataContext as AdmissionControlNumber);
            StudentIOEntities2.GetContext().SaveChanges();
        }

        private void dgSpecialities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Speciality speciality = dgSpecialities.SelectedItem as Speciality;
            cmbxFormOfEducation.IsEnabled = true;

            if (speciality.FormOfEducationId == 3)
                cmbxFormOfEducation.ItemsSource = StudentIOEntities2.GetContext().FormOfEducation.ToList();
            else
            {
                cmbxFormOfEducation.IsEnabled = false;
                cmbxFormOfEducation.SelectedIndex = speciality.FormOfEducationId - 1;
            }

        }
    }
}
