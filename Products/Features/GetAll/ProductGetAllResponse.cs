namespace ResultPatternApp.Products.Features.GetAll;

public record ProductGetAllResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
