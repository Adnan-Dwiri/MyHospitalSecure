using System.ComponentModel.DataAnnotations.Schema;

namespace MyHospitalSecure.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}
