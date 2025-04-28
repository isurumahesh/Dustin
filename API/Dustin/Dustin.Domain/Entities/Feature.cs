namespace Dustin.Domain.Entities
{
    public class Feature : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<SubFeature> SubFeatures { get; set; }
    }
}