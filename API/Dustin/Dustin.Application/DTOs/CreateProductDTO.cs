namespace Dustin.Application.DTOs
{
    public record CreateProductDTO
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid BrandId { get; set; }
        public Guid SubCategoryId { get; set; }

        public List<CreateProductItemDTO> ProductItems { get; set; } = new();
    }
}