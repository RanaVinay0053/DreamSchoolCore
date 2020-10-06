using System.ComponentModel.DataAnnotations;

namespace DreamSchool.BO.Account
{
    public class LoginBO
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string UserID { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }

    }
}
