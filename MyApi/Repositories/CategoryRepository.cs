using MyApi.Data;
using MyApi.Models;
using MyApi.Repositories.Interfaces;

namespace MyApi.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
