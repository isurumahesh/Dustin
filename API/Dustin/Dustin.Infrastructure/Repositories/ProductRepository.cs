using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Dustin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Dustin.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DustinDbContext _dbContext;

        public ProductRepository(DustinDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product?> Get(Guid id)
        {
            return await _dbContext.Products
                 .AsSplitQuery()
                .Include(a => a.ProductItems)
                .ThenInclude(a => a.ProductItemSubFeatures)
                .ThenInclude(a => a.SubFeature)
                .ThenInclude(a => a.Feature)
                .Include(a => a.Brand)
                .Include(a => a.SubCategory)
                .ThenInclude(a => a.Category)
                .SingleOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Product>> GetAll()
        {
            return await _dbContext.Products
                .AsSplitQuery()
                .Include(a => a.ProductItems)
                .ThenInclude(a => a.ProductItemSubFeatures)
                .ThenInclude(a => a.SubFeature)
                .ThenInclude(a => a.Feature)
                .Include(a => a.Brand)
                .Include(a => a.SubCategory)
                .ThenInclude(a => a.Category)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task AddProduct(Product product)
        {
            await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            _dbContext.Products.Update(product);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            _dbContext.Products.Remove(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}