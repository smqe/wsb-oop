using wsb_oop.Product.model;

namespace wsb_oop.Product.services;

public interface IProductService
{
    ProductDto CreateProduct(CreateProductDto createProductDto);

    ProductDto GetProductById(string id);

    void DeleteProductById(string id);
    
    ProductDto UpdateProductById(string id, UpdateProductDto updateProductDto);
}