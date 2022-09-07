using System.ComponentModel.DataAnnotations;

namespace MicroBlogging_Site.Models
{
    public class testmodel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        public int PhoneNumber { get; set; }
    }
}
