using System.ComponentModel.DataAnnotations;

namespace ProjectCaNhan.Models.Users
{
    public class RegisterRequest
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Hoten { get; set; }
    }
}
