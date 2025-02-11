using MinimalApiDotNet9.Models;

namespace MinimalApiDotNet9.Services.Interfaces
{
    public interface IProductService
    {
        public Task<List<Product>> GetProductsAsync();
    }
}
