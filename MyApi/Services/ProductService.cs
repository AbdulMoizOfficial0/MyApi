using AutoMapper;
using MyApi.DTOs;
using MyApi.Models;
using MyApi.Repositories.Interfaces;
using MyApi.Services.Interfaces;

namespace MyApi.Services
{
    public class ProductService : ServiceBase<Product, ProductDTO, IProductRepository>, IProductService
    {
        public ProductService(IProductRepository repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
