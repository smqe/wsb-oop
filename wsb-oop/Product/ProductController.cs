using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace wsb_oop.Product;

[ApiController]
[Route("/product")]
public class ProductController : ControllerBase

{
    [HttpPost]
    public IActionResult CreateProduct(CreateProductDto createProductDto)
    {
        return Ok(createProductDto);
    }

    [HttpGet]
    public IActionResult GetAllProducts()
    {
        var response = new ProductDto("test", "description");
        return Ok(response);
    }
}