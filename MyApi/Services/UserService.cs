using AutoMapper;
using MyApi.DTOs;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;

namespace MyApi.Services
{
    public class UserService : ServiceBase<User, UserDTO, IUserRepository>, IUserService
    {
        public UserService(IUserRepository repository, IMapper mapper) : base(repository, mapper)
        {
            
        }
    }
}
