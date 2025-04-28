namespace Dustin.Application.DTOs
{
    public class SubCategoryDTO : BaseEntityDTO
    {
        public string Value { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
    }
}