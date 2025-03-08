using Microsoft.EntityFrameworkCore;
using System.Security.RightsManagement;
using WpfApp1;

namespace WpfApp1
{
    public class HospitalDbContext : DbContext
{
    public DbSet<Doctors>? Doctors{ get; set; }
    public DbSet<Patient>? Patients { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=ospitalDbContext.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctors>()
            .HasKey(d => d.DoctorId); // Define primary key here
        modelBuilder.Entity<Patient>()
            .HasKey(d => d.PatientId);
        }

    public void InitializeDatabase()
    {
        this.Database.EnsureCreated(); // Ensures the database and tables are created
    }
}
}