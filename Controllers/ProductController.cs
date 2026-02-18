using Microsoft.AspNetCore.Mvc;
using ResultPatternApp.Products;
using ResultPatternApp.Products.Features.Create;

namespace ResultPatternApp.Controllers;

public class ProductController(IProductService productService) : AbstractApiController
{
    [HttpPost("Create")]
    public async Task<IActionResult> Create(ProductCreateRequest request) 
        => ProcessResult(await productService.CreateAsync(request));

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
        => ProcessResult(await productService.GetAllAsync());
}
