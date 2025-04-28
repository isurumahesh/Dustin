using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using ProductEntity = Dustin.Domain.Entities.Product;

namespace Dustin.Application.Commands.Product
{
    public record SaveProductCommand(CreateProductDTO CreateProductDTO) : IRequest<ProductEntity>;

    public class SaveProductCommandHandler : IRequestHandler<SaveProductCommand, ProductEntity>
    {
        private readonly IProductRepository productRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<SaveProductCommandHandler> logger;
        private readonly IMapper mapper;

        public SaveProductCommandHandler(IProductRepository productRepository, ICacheService cacheService, ILogger<SaveProductCommandHandler> logger, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.cacheService = cacheService;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<ProductEntity> Handle(SaveProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var product = mapper.Map<ProductEntity>(request.CreateProductDTO);
                cacheService.Remove(CacheConstants.ProductsList);
                await productRepository.AddProduct(product);
                return product;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while saving product");
                throw;
            }
        }
    }
}