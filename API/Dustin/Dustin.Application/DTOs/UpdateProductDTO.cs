namespace Dustin.Application.DTOs
{
    public class UpdateProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid BrandId { get; set; }
        public Guid SubCategoryId { get; set; }

        public List<UpdateProductItemDTO> ProductItems { get; set; } = new();
    }
}