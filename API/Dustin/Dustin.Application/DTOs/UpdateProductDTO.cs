namespace Dustin.Application.DTOs
{
    public record UpdateProductDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public Guid BrandId { get; init; }
        public Guid SubCategoryId { get; init; }

        public List<UpdateProductItemDTO> ProductItems { get; set; } = new();
    }
}