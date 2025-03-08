using System.ComponentModel.DataAnnotations;

namespace WpfApp1
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }  // Unique identifier for the patient

        [Required]
        public string Name { get; set; } = string.Empty;  // Patient's name

        public string? PhoneNumber { get; set; }  // Patient's phone number

        public string? Disease { get; set; }  // Patient's disease or condition

        public bool IsEmergency { get; set; }  // Indicates if the case is an emergency

        public string? Address { get; set; }  // Patient's address
    }
}