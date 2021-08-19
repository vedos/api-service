using api_service.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace api_service.Helper
{
    public class JwtAuthorization
    {

        public static string GenerateJsonWebToken(User userinfo, IConfiguration _config)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userinfo.Username)
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            var encodedtoken = new JwtSecurityTokenHandler().WriteToken(token);

            return encodedtoken;

        }

        public static User AuthenticateUser(string password,User user)
        {
            if (user == null)
                return null;

            if (!PasswordHash.Verify(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return user;
        }
    }
}
