using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Dustin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Dustin.Infrastructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DustinDbContext _dbContext;

        public CategoryRepository(DustinDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Category?> Get(Guid id)
        {
            return await _dbContext.Categories.SingleOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Category>> GetAll()
        {
            return await _dbContext.Categories.Include(a=>a.SubCategories).ToListAsync();
        }
    }
}