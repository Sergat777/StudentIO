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
    /// Логика взаимодействия для SelectionCampaings.xaml
    /// </summary>
    public partial class SelectionCampaings : Page
    {
        public Frame ParentFrame;

        public SelectionCampaings(Frame parentFrame)
        {
            InitializeComponent();
            ParentFrame = parentFrame;
            lvCampaings.ItemsSource = DataBase.StudentIOEntities2.GetContext().SelectionCampaign.ToList();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            ParentFrame.Navigate(new AddNewSelectionCampaingPage());
        }

        private void btViewOrder_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btViewControlNumbers_Click(object sender, RoutedEventArgs e)
        {
            ParentFrame.Navigate(new ControlNumbers((sender as Button).DataContext as DataBase.SelectionCampaign));
        }

        private void btMakeOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btMakeControlNumbers_Click(object sender, RoutedEventArgs e)
        {
            ParentFrame.Navigate(new AddControlNumbers((sender as Button).DataContext as DataBase.SelectionCampaign));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
                lvCampaings.ItemsSource = DataBase.StudentIOEntities2.GetContext().SelectionCampaign.ToList();
        }
    }
}
