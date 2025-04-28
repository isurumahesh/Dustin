using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Commands.Product
{
    public record UpdateProductCommand(UpdateProductDTO CreateProductDTO) : IRequest;

    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository productRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<UpdateProductCommandHandler> logger;
        private readonly IMapper mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, ICacheService cacheService, ILogger<UpdateProductCommandHandler> logger, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.cacheService = cacheService;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var existingProduct = await productRepository.Get(request.CreateProductDTO.Id);
                var product = mapper.Map(request.CreateProductDTO, existingProduct);
                cacheService.Remove(CacheConstants.ProductsList);
                await productRepository.UpdateProduct(product);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while updating product");
                throw;
            }
        }
    }
}