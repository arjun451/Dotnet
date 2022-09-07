using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class UserFollow
    {

        [Key]
        public int Id { get; set; }
        public string UId { get; set; }
        [Required]
        public string? FollowUserName { get; set; }
        [Required]
        public string? FallowUserProfileUrl { get; set; }virtual 
        public ICollection<ApplicationUser>? applicationUsers { get; set; }
    }
}
