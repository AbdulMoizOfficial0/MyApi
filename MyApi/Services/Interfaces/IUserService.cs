using MyApi.DTOs;
using MyApi.Models;

namespace MyApi.Services.Interfaces
{
    public interface IUserService : IService<User, UserDTO>
    {
    }
}
