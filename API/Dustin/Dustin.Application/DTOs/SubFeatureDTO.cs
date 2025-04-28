namespace Dustin.Application.DTOs
{
    public class SubFeatureDTO : BaseEntityDTO
    {
        public string Value { get; set; }
        public Guid FeaturedId { get; set; }
        public FeatureDTO Feature { get; set; }
    }
}