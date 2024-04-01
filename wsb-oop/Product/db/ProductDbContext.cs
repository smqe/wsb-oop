using Microsoft.EntityFrameworkCore;
using wsb_oop.Product.model;

namespace wsb_oop.Product.db;

public class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    public DbSet<ProductEntity> ProductEntities { get; init; } = null!;
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductEntity>()
            .HasKey(p => p.Id);
        modelBuilder.Entity<ProductEntity>()
            .Property(p => p.Name)
            .IsRequired();
    }
}