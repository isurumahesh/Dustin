using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Queries.Product
{
    public record GetProductsQuery() : IRequest<List<ProductDTO>>;

    public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, List<ProductDTO>>
    {
        private readonly IProductRepository productRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<GetProductsQueryHandler> logger;
        private readonly IMapper mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, ICacheService caheService, ILogger<GetProductsQueryHandler> logger, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.cacheService = caheService;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<List<ProductDTO>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            List<ProductDTO> products = new();

            try
            {
                products = cacheService.Get<List<ProductDTO>>(CacheConstants.ProductsList);

                if (products is not null)
                {
                    return products;
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving products from cache");
            }

            try
            {
                var productEntities = await productRepository.GetAll();
                products = mapper.Map<List<ProductDTO>>(productEntities);
                cacheService.Set(CacheConstants.ProductsList, products, TimeSpan.FromMinutes(CacheConstants.CacheDurationProducts));
                return products;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while retrieving products");
                throw;
            }
        }
    }
}