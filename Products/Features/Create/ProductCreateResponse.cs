namespace ResultPatternApp.Products.Features.Create;

public record ProductCreateResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
