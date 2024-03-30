using GetProductAPI.Application.Interface;
using GetProductAPI.Domain;
using GetProductAPI.Infrastructure.Interfaces;

namespace GetProductAPI.Application.Implementation
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetProducts();
        }
    }
}
