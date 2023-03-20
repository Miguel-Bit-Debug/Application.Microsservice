using Domain.Interfaces.Repositories;
using Domain.Models;
using Infra.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProduct(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetallProducts()
        {
            return await _context.Product.OrderBy(x => x.ProductName).ToListAsync();
        }
    }
}
