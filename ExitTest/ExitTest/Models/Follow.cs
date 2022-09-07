using System.ComponentModel.DataAnnotations;

namespace ExitTest.Models
{
    public class Follow
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string? FId { get; set; }
        [Required]
        public string? UId { get; set; }
        [Required]

        public string? FollowName { get; set; }
        [Required]
        public string? FallowProfileUrl { get; set; }

    }
}
