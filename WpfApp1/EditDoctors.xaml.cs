using System;
using System.Windows;

namespace WpfApp1
{
    public partial class EditDoctors : Window
    {
        private readonly HospitalDbContext _dbContext;
        private readonly Doctors _doctorToEdit;

        public EditDoctors(Doctors doctor)
        {
            InitializeComponent();
            _dbContext = new HospitalDbContext();
            _doctorToEdit = doctor;

            // Pre-fill form with existing data
            NameBox.Text = doctor.Name;
            SpecializationBox.Text = doctor.Specialization;
            PhoneNumberBox.Text = doctor.DoctorsNum;
            EmailBox.Text = doctor.DocEmail;
        }

        private void SaveDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _doctorToEdit.Name = NameBox.Text;
                _doctorToEdit.Specialization = SpecializationBox.Text;
                _doctorToEdit.DoctorsNum = PhoneNumberBox.Text;
                _doctorToEdit.DocEmail = EmailBox.Text;

                _dbContext.SaveChanges();
                MessageBox.Show("Doctor details updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating doctor: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
