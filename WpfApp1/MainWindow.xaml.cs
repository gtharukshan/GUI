using Microsoft.Data.Sqlite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                Home home = new Home();
                home.Show();

                // Close the current login window
                this.Close();
            }
            else
            {
                lblMessage.Text = "Invalid Username or Password";
            }
        }

        private bool ValidateUser(string username, string password)
        {
            // Hardcoded username and password (Replace with your own credentials)
            string validUsername = "admin";
            string validPassword = "1234";

            return username == validUsername && password == validPassword;
        }
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}