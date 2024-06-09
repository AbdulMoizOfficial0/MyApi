using MyApi.DTOs;
using MyApi.Models;

namespace MyApi.Services.Interfaces
{
    public interface IOrderService : IService<Order, OrderDTO>
    {
    }
}
