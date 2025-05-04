namespace Dustin.Application.DTOs
{
    public record ProductDTO : BaseEntityDTO
    {
        public string Name { get; init; } = null!;
        public string Description { get; init; } = null!;
        public SubCategoryDTO SubCategory { get; init; } = null!;
        public BrandDTO Brand { get; init; } = null!;
        public List<ProductItemDTO> ProductItems { get; set; } = new();
    }
}