using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Product> Product { get; set; }
    }
}
