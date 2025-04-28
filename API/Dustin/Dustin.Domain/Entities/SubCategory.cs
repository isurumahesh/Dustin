namespace Dustin.Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        public string Value { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}