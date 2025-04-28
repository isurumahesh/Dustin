using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Dustin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Dustin.Infrastructure.Repositories
{
    public class FeatureRepository : IFeatureRepository
    {
        private readonly DustinDbContext _dbContext;

        public FeatureRepository(DustinDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Feature?> Get(Guid id)
        {
            return await _dbContext.Features.SingleOrDefaultAsync(f => f.Id == id);
        }

        public async Task<List<Feature>> GetAll()
        {
            return await _dbContext.Features.Include(a=>a.SubFeatures).ToListAsync();
        }
    }
}