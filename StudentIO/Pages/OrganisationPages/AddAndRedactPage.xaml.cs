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
    /// Логика взаимодействия для AddAndRedactPage.xaml
    /// </summary>
    public partial class AddAndRedactPage : Page
    {
        public DataBase.Employee AddRedactEmployee = new DataBase.Employee();

        public AddAndRedactPage(DataBase.Employee redactedEmployee)
        {
            InitializeComponent();

            if (redactedEmployee != null)
            {
                AddRedactEmployee = redactedEmployee;
                tbSecondNameEmployee.Text = redactedEmployee.SecondNameEmployee;
                tbFirstNameEmployee.Text = redactedEmployee.FirstNameEmployee;
                tbMiddleNameEmployee.Text = redactedEmployee.MiddleNameEmployee;
                tbLoginEmployee.Text = redactedEmployee.Login;
                tbPasswordEmployee.Text = redactedEmployee.Password;
            }
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbSecondNameEmployee.Text) &&
                !string.IsNullOrWhiteSpace(tbFirstNameEmployee.Text) &&
                !string.IsNullOrWhiteSpace(tbLoginEmployee.Text) &&
                !string.IsNullOrWhiteSpace(tbPasswordEmployee.Text))
            {
                if (!tbSecondNameEmployee.Text.Any(Char.IsDigit) &&
                    !tbFirstNameEmployee.Text.Any(Char.IsDigit) &&
                    !tbMiddleNameEmployee.Text.Any(Char.IsDigit))
                {
                    if (MessageBox.Show("Вы уверены, что хотите сохранить информацию об учетной записи сотрудника?", "Внимание",
                        MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        AddRedactEmployee.SecondNameEmployee = tbSecondNameEmployee.Text.Trim();
                        AddRedactEmployee.FirstNameEmployee = tbFirstNameEmployee.Text.Trim();

                        if (!string.IsNullOrWhiteSpace(tbMiddleNameEmployee.Text))
                            AddRedactEmployee.MiddleNameEmployee = tbMiddleNameEmployee.Text.Trim();

                        AddRedactEmployee.Login = tbLoginEmployee.Text;
                        AddRedactEmployee.Password = tbPasswordEmployee.Text;

                        if (AddRedactEmployee.IdEmployee == 0)
                            DataBase.StudentIOEntities2.GetContext().Employee.Add(AddRedactEmployee);

                        DataBase.StudentIOEntities2.GetContext().SaveChanges();

                        MessageBox.Show("Информация успешно сохранена!", "Информация",
                            MessageBoxButton.OK, MessageBoxImage.Information);

                        NavigationService.GoBack();
                    }
                }
                else
                    MessageBox.Show("Поля ФИО заполненны некорректно!", "Внимание", 
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
                MessageBox.Show("Все поля обязательны для заполнения!", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
