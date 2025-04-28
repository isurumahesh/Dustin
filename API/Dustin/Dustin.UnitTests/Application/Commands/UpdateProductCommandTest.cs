using AutoMapper;
using Dustin.Application;
using Dustin.Application.Commands.Product;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Dustin.UnitTests.Application.Commands
{
    public class UpdateProductCommandTest
    {
        private readonly Mock<IProductRepository> mockProductRepository;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly Mock<ILogger<UpdateProductCommandHandler>> mockLogger;
        private readonly IMapper mapper;

        public UpdateProductCommandTest()
        {
            if (mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AutoMapperProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                this.mapper = mapper;
            }

            mockProductRepository = new Mock<IProductRepository>();
            mockCacheService = new Mock<ICacheService>();
            mockLogger = new Mock<ILogger<UpdateProductCommandHandler>>();
        }

        [Fact]
        public async Task Should_SuccessfullyUpdated_ForValidProductData()
        {
            var characterCommand = new UpdateProductCommandHandler(mockProductRepository.Object, mockCacheService.Object, mockLogger.Object, mapper);
            var command = new UpdateProductCommand(new UpdateProductDTO());
            mockProductRepository.Setup(r => r.UpdateProduct(It.IsAny<Product>())).Returns(Task.CompletedTask);
            mockCacheService.Setup(c => c.Remove(CacheConstants.ProductsList)).Verifiable();

            await characterCommand.Handle(command, CancellationToken.None);

            mockCacheService.Verify(c => c.Remove(CacheConstants.ProductsList), Times.Once);
            mockProductRepository.Verify(r => r.UpdateProduct(It.IsAny<Product>()), Times.Once);
        }
    }
}