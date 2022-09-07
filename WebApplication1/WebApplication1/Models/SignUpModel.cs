using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class SignUpModel
    {
        [Required]
        public string? ProfileImageUrl { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? ContactNumber { get; set; }
        [Required]
        public string? CountryOfRedsidence { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string ? Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password does not match")]
        public string? ConformedPassword { get; set; }
        [Required]
        [Display(Name ="Choose Profile Image")]
        public IFormFile? ProfileImage { get; set; }
       
    }
}
