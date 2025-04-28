namespace Dustin.Application.DTOs
{
    public class CategoryDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public ICollection<SubCategoryDTO> SubCategories { get; set; }
    }
}