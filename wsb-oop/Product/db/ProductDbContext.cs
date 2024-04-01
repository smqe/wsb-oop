using Microsoft.EntityFrameworkCore;
using wsb_oop.Product.model;

namespace wsb_oop.Product.db;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    public DbSet<ProductEntity> ProductEntities { get; set; } = null!;
}