using AutoMapper;
using MyApi.DTOs;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;

namespace MyApi.Services
{
    public class OrderItemsService : ServiceBase<OrderItem, OrderItemDTO, IOrderItemsRepository>, IOrderItemsService
    {
        public OrderItemsService(IOrderItemsRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
