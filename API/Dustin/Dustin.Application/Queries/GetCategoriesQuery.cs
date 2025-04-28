using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Queries
{
    public record GetCategoriesQuery() : IRequest<List<CategoryDTO>>;

    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, List<CategoryDTO>>
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<GetCategoriesQueryHandler> logger;
        private readonly IMapper mapper;

        public GetCategoriesQueryHandler(ICategoryRepository categoryRepository, ICacheService cacheService, ILogger<GetCategoriesQueryHandler> logger, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.cacheService = cacheService;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<List<CategoryDTO>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            List<CategoryDTO> categories = new();
            try
            {
                categories = cacheService.Get<List<CategoryDTO>>(CacheConstants.CategoriesList);

                if (categories is not null)
                {
                    return categories;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving categories from cache");
            }

            try
            {
                var categoryEntities = await categoryRepository.GetAll();
                categories = mapper.Map<List<CategoryDTO>>(categoryEntities);
                return categories;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving categories.");
                throw;
            }
        }
    }
}