using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ApplicationUser:IdentityUser
    {
       
        public string? FirstName { get; set; }
       
        public string? LastName { get; set; }

        
        public string? ProfileImageUrl { get; set; }

        public int Follow { get; set; }
        public int Followers { get; set; }
        public string? CountryOfRedience { get; set; }
    }
}
