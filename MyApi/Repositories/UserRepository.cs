using MyApi.Data;
using MyApi.Models;
using MyApi.Repositories.Interfaces;

namespace MyApi.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
