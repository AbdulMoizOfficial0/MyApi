using MyApi.Data;
using MyApi.Models;
using MyApi.Repositories.Interfaces;

namespace MyApi.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
