namespace Dustin.Application.DTOs
{
    public record UpdateProductItemDTO
    {
        public Guid Id { get; init; }
        public string Sku { get; init; }
        public int Stock { get; init; }
        public decimal Price { get; init; }

        public List<CreateProductSubFeatureDTO> SubFeatures { get; set; } = new();
    }
}