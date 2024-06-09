using AutoMapper;
using MyApi.DTOs;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;

namespace MyApi.Services
{
    public class OrderService : ServiceBase<Order, OrderDTO, IOrderRepository>, IOrderService
    {
        public OrderService(IOrderRepository repository, IMapper mapper) : base(repository, mapper)
        {
            
        }
    }
}
