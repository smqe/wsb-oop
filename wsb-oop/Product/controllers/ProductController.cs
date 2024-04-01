using Microsoft.AspNetCore.Mvc;
using wsb_oop.Product.model;
using wsb_oop.Product.services;

namespace wsb_oop.Product.controllers;

[ApiController]
[Route("/product")]
public class ProductController(IProductService productService) : ControllerBase
{
    [HttpPost]
    public IActionResult CreateProduct(CreateProductDto createProductDto)
    {
        var productDto = productService.CreateProduct(createProductDto);
        return Ok(productDto);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var response = new ProductDto(Guid.NewGuid(),"test", "description");
        return Ok(response);
    }
}
