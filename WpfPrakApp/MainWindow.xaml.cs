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
using WpfPrakApp.Pages;

namespace WpfPrakApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigate.MainFrame = MainFrame;
            Navigate.MenuItemFrame = MenuFrame;
            Navigate.FullFrame = FullFrame;
            Navigate.MainFrame.Navigate(new WpfPrakApp.Pages.MainPages.EmployeeListPage());
            Navigate.MenuItemFrame.Navigate(new WpfPrakApp.Pages.StaticPages.MenuItemFrame());
        }
    }
}
