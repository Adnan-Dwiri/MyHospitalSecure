using Microsoft.AspNetCore.Identity;

namespace MyHospitalSecure.Models
{
    public class AppUser : IdentityUser
    {
        public bool IsAdmin { get; set; }
    }
}
