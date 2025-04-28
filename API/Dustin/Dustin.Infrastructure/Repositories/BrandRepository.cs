using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Dustin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Dustin.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly DustinDbContext _dbContext;

        public BrandRepository(DustinDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Brand> Get(Guid id)
        {
            return await _dbContext.Brands.SingleAsync(a => a.Id == id);
        }

        public async Task<List<Brand>> GetAll()
        {
            return await _dbContext.Brands.ToListAsync();
        }
    }
}