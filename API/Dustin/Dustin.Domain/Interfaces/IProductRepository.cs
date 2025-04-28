using Dustin.Domain.Entities;

namespace Dustin.Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);
    }
}