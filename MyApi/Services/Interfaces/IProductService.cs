using MyApi.DTOs;
using MyApi.Models;

namespace MyApi.Services.Interfaces
{
    public interface IProductService : IService<Product, ProductDTO>
    {
    }
}
