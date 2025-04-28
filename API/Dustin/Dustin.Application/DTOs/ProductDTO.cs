namespace Dustin.Application.DTOs
{
    public class ProductDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public SubCategoryDTO SubCategory { get; set; }
        public BrandDTO Brand { get; set; }
        public List<ProductItemDTO> ProductItems { get; set; } = new();
    }
}