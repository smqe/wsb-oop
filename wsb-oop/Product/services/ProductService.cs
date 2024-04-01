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
}