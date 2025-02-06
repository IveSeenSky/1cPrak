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

namespace WpfPrakApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if(Connection.context.Users.FirstOrDefault(x => x.UserLogin == LoginBx.Text) != null &&
                Connection.context.Users.FirstOrDefault(x => x.UserPassword == PswrdBx.Text) != null)
            {
                Navigate.FullFrame.Navigate(null);
                Navigate.MainFrame.Navigate(null);
                Navigate.MenuItemFrame.Navigate(new Pages.StaticPages.MenuItemFrame());
            } else
            {
                ErrorTxtBl.Text = "Неверные данные";
            }
        }
    }
}
