using wsb_oop.Product.model;

namespace wsb_oop.Product.services;

public interface IProductService
{
    ProductDto CreateProduct(CreateProductDto createProductDto);

    ProductDto GetProduct(string id);
    
    void DeleteProduct(string id);
    
}