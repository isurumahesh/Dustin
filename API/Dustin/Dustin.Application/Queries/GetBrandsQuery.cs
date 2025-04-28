using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Queries
{
    public record GetBrandsQuery() : IRequest<List<BrandDTO>>;

    public class GetBrandsQueryHandler : IRequestHandler<GetBrandsQuery, List<BrandDTO>>
    {
        private readonly IBrandRepository brandRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<GetBrandsQueryHandler> logger;
        private readonly IMapper mapper;

        public GetBrandsQueryHandler(IBrandRepository brandRepository, ICacheService cacheService, ILogger<GetBrandsQueryHandler> logger, IMapper mapper)
        {
            this.brandRepository = brandRepository;
            this.cacheService = cacheService;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<List<BrandDTO>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
        {
            List<BrandDTO> brands = new();
            try
            {
                brands = cacheService.Get<List<BrandDTO>>(CacheConstants.BrandsList);

                if (brands is not null)
                {
                    return brands;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving brands from cache");
            }

            try
            {
                var brandsEntities = await brandRepository.GetAll();
                brands = mapper.Map<List<BrandDTO>>(brandsEntities);
                cacheService.Set(CacheConstants.BrandsList, brands, TimeSpan.FromMinutes(CacheConstants.CacheDuration));
                return brands;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving brands.");
                throw;
            }
        }
    }
}