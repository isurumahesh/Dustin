namespace Dustin.Application.DTOs
{
    public record CreateProductItemDTO
    {
        public string Sku { get; set; } = null!;
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public List<CreateProductSubFeatureDTO> SubFeatures { get; set; } = new();
    }
}