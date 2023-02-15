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
    /// Логика взаимодействия для EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public Frame ParentFrame;

        public EmployeesPage(Frame parentFrame)
        {
            InitializeComponent();
            ParentFrame = parentFrame;
            //dgEmployees.ItemsSource = DataBase.StudentIOEntities.GetContext().Employee.ToList();
        }

        private void btRedact_Click(object sender, RoutedEventArgs e)
        {
            if (dgEmployees.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана запись для редактирования!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (MessageBox.Show("Вы уверены что хотите изменить учетную запись выбранного сотрудника?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ParentFrame.Navigate(new AddAndRedactPage(dgEmployees.SelectedItem as DataBase.Employee));
            }
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            ParentFrame.Navigate(new AddAndRedactPage(null));
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgEmployees.SelectedItem == null)
            {
                MessageBox.Show("Не выбрана запись для удаления!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Classes.Navigation.CurrentEmployee == dgEmployees.SelectedItem as DataBase.Employee)
                MessageBox.Show("Невозможно выполнить удаление сотрудника, выполнившего вход в систему!", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            else if(MessageBox.Show("Вы уверены что хотите удалить учетную запись выбранного сотрудника?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                DataBase.Employee deletedEmployee = dgEmployees.SelectedItem as DataBase.Employee;
                DataBase.StudentIOEntities.GetContext().Employee.Remove(deletedEmployee);
                DataBase.StudentIOEntities.GetContext().SaveChanges();

                MessageBox.Show("Удаление учетной записи сотрудника прошло успешно!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                dgEmployees.ItemsSource = DataBase.StudentIOEntities.GetContext().Employee.ToList();
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dgEmployees.ItemsSource = DataBase.StudentIOEntities.GetContext().Employee.
                Where(u => u.SecondNameEmployee.Contains(tbSearch.Text) ||
                           u.FirstNameEmployee.Contains(tbSearch.Text) ||
                           u.MiddleNameEmloyee.Contains(tbSearch.Text) ||
                           u.Login.Contains(tbSearch.Text) ||
                           u.Password.Contains(tbSearch.Text)).ToList();
        }
    }
}
