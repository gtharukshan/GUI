using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    public class Doctors
    {
        [Key]
        public int DoctorId { get; set; }  // Use int instead of string

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Specialization { get; set; } // Nullable to prevent constructor issues

        public string? DoctorsNum { get; set; } // Nullable

        public string? DocEmail { get; set; } // Nullable
    }
}
