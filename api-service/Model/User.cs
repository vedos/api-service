using api_service.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_service.Model
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }

        [NotMapped]
        public string Password { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
