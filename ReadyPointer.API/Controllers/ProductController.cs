using Microsoft.AspNetCore.Mvc;
using ReadyPointer.API.IServices;

namespace ReadyPointer.API.Controllers;

[ApiController]
[Route("api/product")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductService _productService;
   
    public ProductController(ILogger<ProductController> logger, 
                             IProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet]
    [Route("products")]
    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetProducts();
        return Ok(products);
    }
}