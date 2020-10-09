using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DreamSchool.Models
{ 

    public class LoginViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(50, ErrorMessage = "You can't add more than 50 characters")]
        public string username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter Password.")]
        [StringLength(200, ErrorMessage = "You can't add more than 200 characters")]
        public string password { get; set; }

       
        public string defaultReal { get; set; }

        public string ReturnUrl { get; set; }
        public string defaultRealHashnew { get; set; }
        public string CaptchaCode { get; set; }

       
    }
}
