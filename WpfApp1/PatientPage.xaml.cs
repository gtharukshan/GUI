using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
    {
    public partial class PatientPage : UserControl
    {
        private readonly HospitalDbContext _dbContext;
        public PatientPage()
        {
            InitializeComponent();
            _dbContext=new HospitalDbContext();
            
        }

        public  void LoadPatientData()
        {
            try
            {
                PatientsGrid.ItemsSource = _dbContext.Patients.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddPatients addPatientswinow = new AddPatients();
                addPatientswinow.ShowDialog();
                LoadPatientData();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void UpdatePatient_Click(object obj, RoutedEventArgs e)
        {

        }
        public void DeletePatient_Click(object obj, RoutedEventArgs e)
        {

        }
    }
}
