using wsb_oop.Product.db;
using wsb_oop.Product.model;

namespace wsb_oop.Product.services;

public class ProductService : IProductService
{
    private readonly ProductDbContext _productDbContext;

    public ProductService(ProductDbContext productDbContext)
    {
        _productDbContext = productDbContext;
    }

    public ProductDto CreateProduct(CreateProductDto createProductDto)
    {
        var productEntity = new ProductEntity("");
        _productDbContext.Add(productEntity);
        _productDbContext.SaveChanges();

        return new ProductDto(
            Name: createProductDto.Name,
            Description: createProductDto.Description,
            Id: 12
        );
    }
}