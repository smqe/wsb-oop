using wsb_oop.Product.db;
using wsb_oop.Product.model;

namespace wsb_oop.Product.services;

public class ProductService(ProductDbContext productDbContext) : IProductService
{
    public ProductDto CreateProduct(CreateProductDto createProductDto)
    {
        var productEntity = new ProductEntity("asd", "asdfggghh");
        productDbContext.Add(productEntity);
        productDbContext.SaveChanges();

        return new ProductDto(
            Name: createProductDto.Name,
            Description: createProductDto.Description,
            Id: Guid.NewGuid()
        );
    }
}