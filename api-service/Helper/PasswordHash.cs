using api_service.ErrorHandling;
using System;
using System.Security.Cryptography;
using System.Text;

namespace api_service.Helper
{
    public class PasswordHash
    {
        public static void Create(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool Verify(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            try
            {
                using (var hmac = new HMACSHA512(passwordSalt))
                {
                    var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                    for (int i = 0; i < computedHash.Length; i++)
                    {
                        if (computedHash[i] != passwordHash[i]) return false;
                    }
                }
            }
            catch (Exception e) 
            {
                throw new AppException("Email or password is incorrect");
            }
            return true;
        }
    }
}
