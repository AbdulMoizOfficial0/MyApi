using MyApi.DTOs;
using MyApi.Models;

namespace MyApi.Services.Interfaces
{
    public interface ICategoryService : IService<Category, CategoryDTO>
    {
    }
}
