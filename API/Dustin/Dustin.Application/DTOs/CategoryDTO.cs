namespace Dustin.Application.DTOs
{
    public record CategoryDTO : BaseEntityDTO
    {
        public string Name { get; set; } = null!;
        public List<SubCategoryDTO> SubCategories { get; set; } = new();
    }
}