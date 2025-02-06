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
using WpfPrakApp.AppData;

namespace WpfPrakApp.Pages.MainPages
{
    /// <summary>
    /// Логика взаимодействия для EmployeeChoosenPage.xaml
    /// </summary>
    public partial class EmployeeChoosenPage : Page
    {
        Employees employees;
        public EmployeeChoosenPage(Employees empls)
        {
            InitializeComponent();
            if (empls == null)
                empls = new Employees();

            DataContext = employees = empls;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (employees.EmployeeImage == null)
            {
                EmployeeImage.Source = new BitmapImage(new Uri("pack://application:,,,/Recources/Images/Edit.png"));
            }
        }

        private void FirstNameChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SecondNameChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PatronymicChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AgeChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EmailChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AdressChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PositionChangeBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
