using AutoMapper;
using MyApi.DTOs;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;

namespace MyApi.Services
{
    public class CategoryService : ServiceBase<Category, CategoryDTO, ICategoryRepository>, ICategoryService
    {
        public CategoryService(ICategoryRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
