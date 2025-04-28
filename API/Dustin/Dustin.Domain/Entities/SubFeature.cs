namespace Dustin.Domain.Entities
{
    public class SubFeature : BaseEntity
    {
        public string Value { get; set; }
        public Guid FeatureId { get; set; }
        public Feature Feature { get; set; }
        public ICollection<ProductItemSubFeature> ProductItemSubFeatures { get; set; }
    }
}