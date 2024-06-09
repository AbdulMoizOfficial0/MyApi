using MyApi.Data;
using MyApi.Models;
using MyApi.Repositories.Interfaces;

namespace MyApi.Repositories
{
    public class OrderItemsRepository : RepositoryBase<OrderItem>, IOrderItemsRepository
    {
        public OrderItemsRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
