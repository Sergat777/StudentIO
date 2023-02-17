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
    /// Interaction logic for ControlNumbers.xaml
    /// </summary>
    public partial class ControlNumbers : Page
    {
        public ControlNumbers(DataBase.SelectionCampaign selectionCampaign)
        {
            InitializeComponent();
            txtDescription.Text = $"Контрольные цифры приема ПРИЕМНОЙ КАМПАНИИ {selectionCampaign.CampaignYear} года.\n" +
                                  $"По следующим специальностям следующее количество мест:"; 
            dgControlNumbers.ItemsSource = DataBase.StudentIOEntities2.GetContext().AdmissionControlNumber.
                Where(u => u.SelectionCampaignId == selectionCampaign.IdSelectionCampaign).ToList();

            if (selectionCampaign.IsOver)
            {
                txtCampaignOver.Text = $"По результатам ПРИЕМНОЙ КАМПАНИИ {selectionCampaign.CampaignYear} года\n" +
                                       $"на следующие специальности было зачисленно следующее количество студентов:";

                dgAdmissionStudents.Visibility = Visibility.Visible;
            }
        }

        private void btGoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
