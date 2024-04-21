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
    
    [HttpGet("{id}")]
    public IActionResult GetProductId(string id)
    {
        var response = productService.GetProductById(id);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteById(string id)
    {
        productService.DeleteProductById(id);
        return NoContent();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateById(string id, UpdateProductDto updateProductDto)
    {
        var response = productService.UpdateProductById(id, updateProductDto);
        return Ok(response);
    }
}