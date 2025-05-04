namespace Dustin.Application.DTOs
{
    public record FeatureDTO : BaseEntityDTO
    {
        public string Name { get; init; }
        public List<SubFeatureDTO> SubFeatures { get; set; } = new();
    }
}