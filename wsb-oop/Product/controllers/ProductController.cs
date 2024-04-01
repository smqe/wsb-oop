using Microsoft.AspNetCore.Mvc;
using wsb_oop.Product.model;
using wsb_oop.Product.services;

namespace wsb_oop.Product.controllers;

[ApiController]
[Route("/product")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost]
    public IActionResult CreateProduct(CreateProductDto createProductDto)
    {
        var productDto = _productService.CreateProduct(createProductDto);
        return Ok(productDto);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var response = new ProductDto(12, "test", "description");
        return Ok(response);
    }
}
