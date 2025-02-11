using Microsoft.EntityFrameworkCore;
using MinimalApiDotNet9.Models;

namespace MinimalApiDotNet9
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }

}
