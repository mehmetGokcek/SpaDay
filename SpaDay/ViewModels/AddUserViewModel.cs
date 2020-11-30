using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = " must be between 5 and 15 characters long")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = " must be between 6 and 20 characters long")]
        public string Password { get; set; }


        [Required(ErrorMessage = "Password verification is required")]
        [Compare("Password", ErrorMessage = "Passwords must match!")]
        public string VerifyPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
