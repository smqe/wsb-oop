using wsb_oop.Product.db;
using wsb_oop.Product.mappers;
using wsb_oop.Product.model;

namespace wsb_oop.Product.services;

public class ProductService(ProductDbContext productDbContext, ProductMapper productMapper) : IProductService
{
    public ProductDto CreateProduct(CreateProductDto createProductDto)
    {
        var entity = productMapper.ToEntity(createProductDto);
        productDbContext.Add(entity);
        productDbContext.SaveChanges();
        return productMapper.ToDto(entity);
    }

    public ProductDto GetProduct(string id)
    {
        var entity = productDbContext.ProductEntities.Find(Guid.Parse(id));
        if (entity != null) return productMapper.ToDto(entity);
        return null;
    }

    public void DeleteProduct(string id)
    {
        var guid = Guid.Parse(id);
        var entity = productDbContext.ProductEntities.Find(Guid.Parse(id));
        productDbContext.ProductEntities.Remove(entity);
        productDbContext.SaveChanges();
    }
}