using Dustin.Domain.Entities;

namespace Dustin.Application.DTOs
{
    public class ProductItemDTO : BaseEntityDTO
    {
        public string Sku { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public ProductDTO Product { get; set; }
        public List<ProductItemSubFeatureDTO> ProductItemSubFeatures { get; set; } = new();
    }
}