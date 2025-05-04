namespace Dustin.Application.DTOs
{
    public record SubCategoryDTO : BaseEntityDTO
    {
        public string Value { get; init; }
        public Guid CategoryId { get; init; }
        public CategoryDTO Category { get; init; }
    }
}