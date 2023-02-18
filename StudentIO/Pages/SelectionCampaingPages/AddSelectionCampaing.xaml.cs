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
    /// Логика взаимодействия для AddNewSelectionCampaingPage.xaml
    /// </summary>
    public partial class AddNewSelectionCampaingPage : Page
    {
        public AddNewSelectionCampaingPage()
        {
            InitializeComponent();
            cmbxResponsibleEmployee.ItemsSource = DataBase.StudentIOEntities2.GetContext().Employee.ToList();
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите вернуться назад? Все изменения будут утеряны.", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                NavigationService.GoBack();
        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (dtStartDate.SelectedDate != null &&
                dtEndDate.SelectedDate != null &&
                cmbxResponsibleEmployee.SelectedIndex >= 0)
            {
                if (dtStartDate.SelectedDate < dtEndDate.SelectedDate)
                {
                    if (DataBase.StudentIOEntities2.GetContext().SelectionCampaign.
                        FirstOrDefault(u => u.StartDate.Year == dtStartDate.SelectedDate.Value.Year) == null)
                    {
                        if (MessageBox.Show("Вы уверены, что хотите сохранить информацию о новой приемной кампании?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                        {
                            DataBase.SelectionCampaign campaign = new DataBase.SelectionCampaign();

                            campaign.StartDate = dtStartDate.SelectedDate.Value;
                            campaign.EndDate = dtEndDate.SelectedDate.Value;
                            campaign.ResponsibleEmployeeId = (cmbxResponsibleEmployee.SelectedItem as DataBase.Employee).IdEmployee;

                            DataBase.StudentIOEntities2.GetContext().SelectionCampaign.Add(campaign);

                            DataBase.StudentIOEntities2.GetContext().SaveChanges();

                            MessageBox.Show("Информация успешно сохранена!", "Информация",
                                MessageBoxButton.OK, MessageBoxImage.Information);

                            NavigationService.GoBack();
                        }
                    }
                    else
                        MessageBox.Show("На данные сроки уже назначена другая приемная кампания!", "Внимание",
                            MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                    MessageBox.Show("Дата начала кампании не может быть позднее даты окончания!", "Внимание",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Все поля обязательны для заполнения!", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
