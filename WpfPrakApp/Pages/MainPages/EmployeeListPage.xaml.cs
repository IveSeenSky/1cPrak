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
    /// Логика взаимодействия для EmployeeListPage.xaml
    /// </summary>
    public partial class EmployeeListPage : Page
    {
        public EmployeeListPage()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            EmployeeLV.ItemsSource = Connection.context.Employees.ToList();
        }

        private void EmployeeLV_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (EmployeeLV.SelectedItem != null)
            {
                Employees employees = (Employees) EmployeeLV.SelectedItem;
                Navigate.MainFrame.Navigate(new EmployeeChoosenPage(employees));
            }
        }
    }
}
