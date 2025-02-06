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

namespace WpfPrakApp.Pages.StaticPages
{
    /// <summary>
    /// Логика взаимодействия для MenuItemFrame.xaml
    /// </summary>
    public partial class MenuItemFrame : Page
    {
        public MenuItemFrame()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            if(AppData.Navigate.MainFrame.CanGoBack)
                AppData.Navigate.MainFrame.GoBack();
        }

        private void EmloyeesBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigate.MainFrame.Navigate(new Pages.MainPages.EmployeeListPage());
        }
    }
}
