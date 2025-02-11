using Microsoft.EntityFrameworkCore;
using MinimalApiDotNet9.Models;
using MinimalApiDotNet9.Services.Interfaces;

namespace MinimalApiDotNet9.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
