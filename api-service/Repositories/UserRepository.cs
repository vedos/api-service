using api_service.Data;
using api_service.Model;
using api_service.Repositories.Base;
using System.Linq;

namespace api_service.Repositories
{
    public class UserRepository : BaseRepository<User, EFContext>
    {
        private EFContext _context;
        public UserRepository(EFContext context) : base(context)
        {
            _context = context;
        }

        public User GetUserByUsername(string username) 
        {
            var user = _context.Users.Where(x => x.Username == username).SingleOrDefault();
            return user;
        }
    }
}
