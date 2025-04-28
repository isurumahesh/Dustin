namespace Dustin.Application.DTOs
{
    public class UpdateProductItemDTO
    {
        public Guid Id { get; set; }
        public string Sku { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public List<CreateProductSubFeatureDTO> SubFeatures { get; set; } = new();
    }
}