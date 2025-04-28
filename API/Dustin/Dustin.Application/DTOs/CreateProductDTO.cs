namespace Dustin.Application.DTOs
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid BrandId { get; set; }
        public Guid SubCategoryId { get; set; }

        public List<CreateProductItemDTO> ProductItems { get; set; } = new();
    }
}