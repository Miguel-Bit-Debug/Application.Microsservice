using Domain.Models;

namespace Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<bool> AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
    }
}
