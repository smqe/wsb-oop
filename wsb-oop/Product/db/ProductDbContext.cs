using Microsoft.EntityFrameworkCore;
using wsb_oop.Product.model;

namespace wsb_oop.Product.db;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet<ProductEntity> ProductEntities { get; set; } = null!;
}