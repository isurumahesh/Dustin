namespace Dustin.Domain.Entities
{
    public class ProductItem : BaseEntity
    {
        public string Sku { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        public ICollection<ProductItemSubFeature> ProductItemSubFeatures { get; set; }
    }
}