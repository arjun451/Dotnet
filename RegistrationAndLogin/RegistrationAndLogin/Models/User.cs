﻿using System.ComponentModel.DataAnnotations;

namespace RegistrationAndLogin.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
   
        [Required]
        public string Password{ get; set; }

        
        [Required]
        public string PhoneNumber{ get; set; }



        [Required]
        
        public string ConformedPassword { get; set; }

    }
}
