using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<bool> AddProduct(Product product)
        {
            if(product == null)
            {
                return false;
            }

            await _productRepository.AddProduct(product);

            return true;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _productRepository.GetallProducts();

            return products;
        }
    }
}
