using MyApi.DTOs;
using MyApi.Models;

namespace MyApi.Services.Interfaces
{
    public interface IOrderItemsService : IService<OrderItem, OrderItemDTO>
    {
    }
}
