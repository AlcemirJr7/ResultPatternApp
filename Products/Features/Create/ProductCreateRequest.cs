namespace ResultPatternApp.Products.Features.Create;

public record ProductCreateRequest
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public decimal Price { get; init; }
}
