using AutoMapper;
using Dustin.Application.DTOs;
using Dustin.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Dustin.Application.Queries.Product
{
    public record GetProductsByIdQuery(Guid ProductId) : IRequest<ProductDTO?>;

    public class GetProductsByIdQueryHandler : IRequestHandler<GetProductsByIdQuery, ProductDTO?>
    {
        private readonly IProductRepository productRepository;
        private readonly ILogger<GetProductsByIdQueryHandler> logger;
        private readonly IMapper mapper;

        public GetProductsByIdQueryHandler(IProductRepository productRepository, ILogger<GetProductsByIdQueryHandler> logger, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.logger = logger;
            this.mapper = mapper;
        }

        public async Task<ProductDTO?> Handle(GetProductsByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var product = await productRepository.Get(request.ProductId);

                if (product is null)
                {
                    return null;
                }

                var mappedProduct = mapper.Map<ProductDTO>(product);
                return mappedProduct;
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Error retrieving Product by Id:{request.ProductId}");
                throw;
            }
        }
    }
}