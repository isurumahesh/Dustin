using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Commands.Product
{
    public record DeleteProductCommand(Guid ProductId) : IRequest;

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository productRepository;
        private readonly ICacheService cacheService;
        private readonly ILogger<DeleteProductCommandHandler> logger;

        public DeleteProductCommandHandler(IProductRepository productRepository, ICacheService cacheService, ILogger<DeleteProductCommandHandler> logger)
        {
            this.productRepository = productRepository;
            this.cacheService = cacheService;
            this.logger = logger;
        }

        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var deleteProduct = await productRepository.Get(request.ProductId);
                cacheService.Remove(CacheConstants.ProductsList);
                await productRepository.DeleteProduct(deleteProduct);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred while deleting product");
                throw;
            }
        }
    }
}