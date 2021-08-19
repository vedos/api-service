using api_service.Helper;
using api_service.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace api_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        private UserRepository _userRepository;

        public LoginController(IConfiguration config,UserRepository userRepository) 
        {
            _config = config;
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Login(string username, string pass) 
        {
            IActionResult response = Unauthorized();

            //get user by username from database
            var dbUser = _userRepository.GetUserByUsername(username);

            var user = JwtAuthorization.AuthenticateUser(pass, dbUser);

            if (user != null)
            {
                var tokenStr = JwtAuthorization.GenerateJsonWebToken(user, _config);
                response = Ok(new { token = tokenStr });
            }
            return response;
        }


        //TODO Register user
    }
}
