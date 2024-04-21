using wsb_oop.Product.db;
using wsb_oop.Product.exceptions;
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

    public ProductDto GetProductById(string id)
    {
        var entity = productDbContext.ProductEntities.Find(Guid.Parse(id));
        if (entity is null)
        {
            throw new ProductNotFoundException($"Product with id: {id} not exists");
        }

        return productMapper.ToDto(entity);
    }

    public void DeleteProductById(string id)
    {
        var entity = productDbContext.ProductEntities.Find(Guid.Parse(id));
        if (entity == null) return;
        productDbContext.ProductEntities.Remove(entity);
        productDbContext.SaveChanges();
    }

    public ProductDto UpdateProductById(string id, UpdateProductDto updateProductDto)
    {
        var entity = productDbContext.ProductEntities.Find(Guid.Parse(id));
        if (entity is null)
        {
            throw new ProductNotFoundException(
                $"Cannot update product with id: {id} because product with this does not exists");
        }

        entity.Name = updateProductDto.Name;
        entity.Description = updateProductDto.Description;
        productDbContext.SaveChanges();
        return productMapper.ToDto(entity);
    }
}