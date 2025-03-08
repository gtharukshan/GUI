using System;
using System.Linq;
using System.Numerics;
using System.Windows;

namespace WpfApp1
{
    public partial class AddDoctors : Window
    {
        private readonly HospitalDbContext _dbContext;

        public AddDoctors()
        {
            InitializeComponent();
            _dbContext = new HospitalDbContext();
        }

        private void AddDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create a new doctor object
                Doctors newDoctor = new Doctors
                {
                    Name = NameBox.Text,
                    Specialization = SpecializationBox.Text,
                    DoctorsNum = PhoneNumberBox.Text,
                    DocEmail = EmailBox.Text
                };

                // Add the new doctor to the database
                _dbContext.Doctors.Add(newDoctor);
                _dbContext.SaveChanges();

                MessageBox.Show("Doctor details added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                // Close the window after adding the doctor
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
