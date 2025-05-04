namespace Dustin.Application.DTOs
{
    public record SubFeatureDTO : BaseEntityDTO
    {
        public string Value { get; init; }
        public Guid FeaturedId { get; init; }       
    }
}