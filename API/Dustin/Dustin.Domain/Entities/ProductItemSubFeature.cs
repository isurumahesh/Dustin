namespace Dustin.Domain.Entities
{
    public class ProductItemSubFeature
    {
        public Guid SubFeatureId { get; set; }
        public SubFeature SubFeature { get; set; }
        public Guid ProductItemId { get; set; }
        public ProductItem ProductItem { get; set; }
    }
}