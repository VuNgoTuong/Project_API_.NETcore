using ProjectCaNhan.Entities;
using System.Text.Json.Serialization;

namespace ProjectCaNhan.Models.Users
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Hoten { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        //[JsonIgnore] 
        //public string RefreshToken { get; set; }

        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            Username = user.Username;
            Email = user.Email;
            Hoten = user.Hoten;
            Role = user.Role;
            Token = token;
           // RefreshToken = refreshToken;
        } 
    }
}
