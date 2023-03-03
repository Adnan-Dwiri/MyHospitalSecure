using Microsoft.EntityFrameworkCore;
using MyHospitalSecure.Models;

namespace MyHospitalSecure.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext()
        {

        }

        public HospitalDbContext(DbContextOptions<HospitalDbContext> options):base(options)
        {

        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
    }
}
