using System;
using System.Linq;
using System.Numerics;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class Doctorpage : UserControl
    {
        private readonly HospitalDbContext _dbContext;

        public Doctorpage()
        {
            InitializeComponent();
            _dbContext = new HospitalDbContext();
            LoadDoctorsData();
        }

        public void LoadDoctorsData() // Changed from private to public
        {
            try
            {
                DoctorsGrid.ItemsSource = _dbContext.Doctors.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading doctors: {ex.Message}", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddDoctor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddDoctors addDoctorWindow = new AddDoctors();
                addDoctorWindow.ShowDialog();
                LoadDoctorsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding doctor: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteDoctor_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorsGrid.SelectedItem is Doctors selectedDoctor)
            {
                var result = MessageBox.Show($"Are you sure you want to delete Dr. {selectedDoctor.Name}?",
                                             "Confirm Deletion",
                                             MessageBoxButton.YesNo,
                                             MessageBoxImage.Warning);

                if (result == MessageBoxResult.Yes)
                {
                    try
                    {
                        _dbContext.Doctors.Remove(selectedDoctor);
                        _dbContext.SaveChanges();
                        MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        LoadDoctorsData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting doctor: {ex.Message}", "Database Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void UpdateDoctor_Click(object sender, RoutedEventArgs e)
        {
            if (DoctorsGrid.SelectedItem is Doctors selectedDoctor)
            {
                try
                {
                    EditDoctors updateDoctorWindow = new EditDoctors(selectedDoctor); // Make sure this constructor exists
                    updateDoctorWindow.ShowDialog();
                    LoadDoctorsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating doctor: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to update.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Dispose of the DbContext when the page is unloaded
        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            _dbContext.Dispose();
        }
    }
}
