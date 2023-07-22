using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ProjectCaNhan.Entities
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Hoten { get; set; }
        public Role Role { get; set; }

        [JsonIgnore]  // su dung de loai tru khong duoc anh xa
        public string PasswordHash { get; set; }

        //[JsonIgnore]
        //public List<RefreshToken> RefreshTokens { get; set; }
    }
}
