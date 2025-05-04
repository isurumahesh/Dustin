using Dustin.Domain.Entities;

namespace Dustin.Application.DTOs
{
    public record ProductItemDTO : BaseEntityDTO
    {
        public string Sku { get; init; }
        public int Stock { get; init; }
        public decimal Price { get; init; }
        public ProductDTO Product { get; init; }
        public List<ProductItemSubFeatureDTO> ProductItemSubFeatures { get; set; } = new();
    }
}