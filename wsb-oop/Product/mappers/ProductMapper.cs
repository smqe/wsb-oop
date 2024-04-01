using wsb_oop.Product.model;

namespace wsb_oop.Product.mappers;

public class ProductMapper
{
    public ProductEntity ToEntity(CreateProductDto createProductDto)
    {
        return new ProductEntity(
            name: createProductDto.Name,
            description: createProductDto.Description
        );
    }

    public ProductDto ToDto(ProductEntity productEntity)
    {
        return new ProductDto(
            Name: productEntity.Name,
            Description: productEntity.Description,
            Id: productEntity.Id
        );
    }
}