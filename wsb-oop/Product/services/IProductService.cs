using wsb_oop.Product.model;

namespace wsb_oop.Product.services;

public interface IProductService
{
    ProductDto CreateProduct(CreateProductDto createProductDto);
}