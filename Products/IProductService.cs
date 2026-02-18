using ResultPatternApp.AppResults;
using ResultPatternApp.Products.Features.Create;
using ResultPatternApp.Products.Features.GetAll;

namespace ResultPatternApp.Products;

public interface IProductService
{
    Task<AppResult<ProductCreateResponse>> CreateAsync(ProductCreateRequest request);
    Task<AppResult<List<ProductGetAllResponse>>> GetAllAsync();
}
