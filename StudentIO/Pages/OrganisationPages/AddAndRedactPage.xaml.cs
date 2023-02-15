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

            if (redactedEmployee == null)
                Title = "ДОБАВЛЕНИЕ СОТРУДНИКА";
            else
            {
                Title = "РЕДАКТИРОВАНИЕ СОТРУДНИКА";
                AddRedactEmployee = redactedEmployee;
            }
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btConfirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
