using ResultPatternApp.AppResults;
using ResultPatternApp.Products.Errors;
using ResultPatternApp.Products.Features.Create;
using ResultPatternApp.Products.Features.GetAll;

namespace ResultPatternApp.Products;

public sealed class ProductService : IProductService
{
    public async Task<AppResult<ProductCreateResponse>> CreateAsync(ProductCreateRequest request)
    {
        if (string.IsNullOrEmpty(request.Name))
            return AppResult<ProductCreateResponse>.Failure(ProductErrors.InvalidName);

        var result = new ProductCreateResponse
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Price = request.Price
        };

        return result;
    }

    public async Task<AppResult<List<ProductGetAllResponse>>> GetAllAsync()
    {
        var result = new List<ProductGetAllResponse>
        {
            new ProductGetAllResponse
            {
                Id = Guid.NewGuid(),
                Name = "Café",
                Price = 30_000
            },
            new ProductGetAllResponse
            {
                Id = Guid.NewGuid(),
                Name = "Notebook",
                Price = 2_500
            }   
        };

        return result;
    }
}
