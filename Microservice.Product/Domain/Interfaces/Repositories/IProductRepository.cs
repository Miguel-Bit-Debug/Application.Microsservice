using Domain.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task AddProduct(Product product);
        Task<IEnumerable<Product>> GetallProducts();
    }
}
