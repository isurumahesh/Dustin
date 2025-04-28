namespace Dustin.Domain.Entities
{
    public class Product : AuditEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }

        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }

        public ICollection<ProductItem> ProductItems { get; set; }
    }
}