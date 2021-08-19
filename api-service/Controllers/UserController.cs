using api_service.Controllers.Base;
using api_service.Model;
using api_service.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace api_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<User,UserRepository>
    {
        public UserController(UserRepository repository) : base(repository)
        {
            
        }
    }
}
