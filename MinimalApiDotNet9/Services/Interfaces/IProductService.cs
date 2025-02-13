using MinimalApiDotNet9.Models;

namespace MinimalApiDotNet9.Services.Interfaces
{
    public interface IProductService
    {
         Task<List<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int productId);
        Task<Product> CreateUpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int productId);
    }
}
