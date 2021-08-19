using api_service.Helper;
using api_service.Model;
using Microsoft.EntityFrameworkCore;

namespace api_service.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] passwordHash, passwordSalt;

            PasswordHash.Create("test", out passwordHash, out passwordSalt);

            modelBuilder.Entity<User>().HasData(
                new User() { Id=1, Username = "admin", PasswordHash = passwordHash, PasswordSalt = passwordSalt }
            );
        }
    }
}
