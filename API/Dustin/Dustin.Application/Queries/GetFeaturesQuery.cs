using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Queries
{
    public record GetFeaturesQuery() : IRequest<List<FeatureDTO>>;

    public class GetFeaturesQueryHandler : IRequestHandler<GetFeaturesQuery, List<FeatureDTO>>
    {
        private readonly IFeatureRepository featureRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<GetFeaturesQueryHandler> logger;
        private readonly IMapper mapper;

        public GetFeaturesQueryHandler(IFeatureRepository featureRepository, ICacheService cacheService, ILogger<GetFeaturesQueryHandler> logger, IMapper mapper)
        {
            this.featureRepository = featureRepository;
            this.cacheService = cacheService;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<List<FeatureDTO>> Handle(GetFeaturesQuery request, CancellationToken cancellationToken)
        {
            List<FeatureDTO> features = new();

            try
            {
                features = cacheService.Get<List<FeatureDTO>>(CacheConstants.FeaturesList);

                if (features is not null)
                {
                    return features;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving features from cache");
            }

            try
            {
                var featureEntities = await featureRepository.GetAll();
                features = mapper.Map<List<FeatureDTO>>(featureEntities);
                cacheService.Set(CacheConstants.FeaturesList, features, TimeSpan.FromMinutes(CacheConstants.CacheDuration));
                return features;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving features.");
                throw;
            }
        }
    }
}