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
        int eCount = 0;
        void HideItems(TextBlock textBlock, Button btnEdit, TextBox textBox, Button btnSave, Button btnCancel)
        {
            if (eCount == 0)
            {
                textBlock.Visibility = Visibility.Collapsed;
                textBox.Visibility = Visibility.Visible;
                btnSave.Visibility = Visibility.Visible;
                btnCancel.Visibility = Visibility.Visible;
                btnEdit.Visibility = Visibility.Collapsed;
                eCount = 1;
            }
        }
        void ShowItems(TextBlock textBlock, Button btnEdit, TextBox textBox, Button btnSave, Button btnCancel)
        {
            if (eCount != 0)
            {
                textBlock.Visibility = Visibility.Visible;
                textBox.Visibility = Visibility.Collapsed;
                btnSave.Visibility = Visibility.Collapsed;
                btnCancel.Visibility = Visibility.Collapsed;
                btnEdit.Visibility = Visibility.Visible;
                eCount = 0;
            }
        }
        public EmployeeChoosenPage(Employees empls)
        {
            InitializeComponent();
            PositionWr_C.ItemsSource = Connection.context.Positions.ToList();
            if (empls == null)
                empls = new Employees();
            DataContext = employees = empls;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (employees.EmployeeImage == null)
            {
                //EmployeeImage.Source = new BitmapImage(new Uri("pack://application:,,,/Recources/Images/Edit.png"));

            }
        }

        private void FirstNameChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            HideItems(FirstNameRd, FirstNameChangeBtn, FirstNameWr, FirstNameChangedBtn, FirstNameCancelChangesBtn);
            FirstNameWr.Text = employees.firstName;
        }

        private void SecondNameChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            HideItems(SecondNameRd, SecondNameChangeBtn, SecondNameWr, SecondNameChangedBtn, SecondNameCancelChangesBtn);
            SecondNameWr.Text = employees.secondName;
        }

        private void PatronymicChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            HideItems(PatronymicRd, PatronymicChangeBtn, PatronymicWr, PatronymicChangedBtn, PatronymicCancelChangesBtn);
            PatronymicWr.Text = employees.patronymic;
        }

        private void AgeChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            HideItems(AgeRd, AgeChangeBtn, AgeWr, AgeChangedBtn, AgeCancelChangesBtn);
        }

        private void EmailChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            HideItems(EmailRd, EmailChangeBtn, EmailWr, EmailChangedBtn, EmailCancelChangesBtn);
        }

        private void AdressChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            HideItems(AdressRd, AdressChangeBtn, AdressWr, AdressCancelChangesBtn, AdressChangedBtn);
        }

        private void PositionChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            PositionRd.Visibility = Visibility.Collapsed;
            PositionChangeBtn.Visibility = Visibility.Collapsed;
            
            PositionWr_C.Visibility = Visibility.Visible;
            PositionChangedBtn.Visibility = Visibility.Visible;
            PositionCancelChangesBtn.Visibility = Visibility.Visible;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FirstNameChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(FirstNameRd, FirstNameChangeBtn, FirstNameWr, FirstNameChangedBtn, FirstNameCancelChangesBtn);
        }

        private void FirstNameCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(FirstNameRd, FirstNameChangeBtn, FirstNameWr, FirstNameChangedBtn, FirstNameCancelChangesBtn);
        }

        private void SecondNameChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(SecondNameRd, SecondNameChangeBtn, SecondNameWr, SecondNameChangedBtn, SecondNameCancelChangesBtn);
        }

        private void SecondNameCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(SecondNameRd, SecondNameChangeBtn, SecondNameWr, SecondNameChangedBtn, SecondNameCancelChangesBtn);
        }

        private void PatronymicCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(PatronymicRd, PatronymicChangeBtn, PatronymicWr, PatronymicChangedBtn, PatronymicCancelChangesBtn);
        }

        private void PatronymicChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(PatronymicRd, PatronymicChangeBtn, PatronymicWr, PatronymicChangedBtn, PatronymicCancelChangesBtn);
        }

        private void AgeChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(AgeRd, AgeChangeBtn, AgeWr, AgeChangedBtn, AgeCancelChangesBtn);
        }

        private void AgeCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(AgeRd, AgeChangeBtn, AgeWr, AgeChangedBtn, AgeCancelChangesBtn);
        }

        private void EmailChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(EmailRd, EmailChangeBtn, EmailWr, EmailChangedBtn, EmailCancelChangesBtn);
        }

        private void EmailCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(EmailRd, EmailChangeBtn, EmailWr, EmailChangedBtn, EmailCancelChangesBtn);
        }

        private void AdressChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(AdressRd, AdressChangeBtn, AdressWr, AdressCancelChangesBtn, AdressChangedBtn);
        }

        private void AdressCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowItems(AdressRd, AdressChangeBtn, AdressWr, AdressCancelChangesBtn, AdressChangedBtn);
        }

        private void PositionCancelChangesBtn_Click(object sender, RoutedEventArgs e)
        {
            PositionRd.Visibility = Visibility.Visible;
            PositionChangeBtn.Visibility = Visibility.Visible;

            PositionWr_C.Visibility = Visibility.Collapsed;
            PositionChangedBtn.Visibility = Visibility.Collapsed;
            PositionCancelChangesBtn.Visibility = Visibility.Collapsed;
        }

        private void PositionChangedBtn_Click(object sender, RoutedEventArgs e)
        {
            PositionRd.Visibility = Visibility.Visible;
            PositionChangeBtn.Visibility = Visibility.Visible;

            PositionWr_C.Visibility = Visibility.Collapsed;
            PositionChangedBtn.Visibility = Visibility.Collapsed;
            PositionCancelChangesBtn.Visibility = Visibility.Collapsed;
        }
    }
}
