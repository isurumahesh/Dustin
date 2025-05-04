namespace Dustin.Application.DTOs
{
    public record BrandDTO : BaseEntityDTO
    {
        public string Name { get; init; } = null!;
    }
}