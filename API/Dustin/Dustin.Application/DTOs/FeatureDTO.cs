namespace Dustin.Application.DTOs
{
    public class FeatureDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public ICollection<SubFeatureDTO> SubFeatures { get; set; }
    }
}