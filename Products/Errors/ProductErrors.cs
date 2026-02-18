using ResultPatternApp.AppResults;

namespace ResultPatternApp.Products.Errors;

public readonly record struct ProductErrors
{
    internal static readonly ErrorDetails InvalidName =
        new("PRODUCT_VALIDATION", "Nome do produto inválido ou não informado.");
}
