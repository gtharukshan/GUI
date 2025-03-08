using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void BtnDoctors_Click(object sender, RoutedEventArgs e)
        {
            WelcomePanel.Visibility = Visibility.Collapsed;
            MainContent.Content = new Doctorpage(); 
        }
        private void BtnPatient_Click(object sender, RoutedEventArgs e)
        {
            WelcomePanel.Visibility = Visibility.Collapsed;
            MainContent.Content = new PatientPage(); 
        }
        private void BtnBilling_Click(object sender, RoutedEventArgs e)
        {
            WelcomePanel.Visibility = Visibility.Collapsed;
            MainContent.Content = new Billingpage(); 
        }

    }

       
}
