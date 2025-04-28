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
    public class SaveProductCommandTest
    {
        private readonly Mock<IProductRepository> mockProductRepository;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly Mock<ILogger<SaveProductCommandHandler>> mockLogger;
        private readonly IMapper mapper;

        public SaveProductCommandTest()
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
            mockLogger = new Mock<ILogger<SaveProductCommandHandler>>();
        }

        [Fact]
        public async Task Should_SuccessfullySave_ForValidProductData()
        {
            var characterCommand = new SaveProductCommandHandler(mockProductRepository.Object, mockCacheService.Object, mockLogger.Object, mapper);
            var command = new SaveProductCommand(new CreateProductDTO());
            mockProductRepository.Setup(r => r.AddProduct(It.IsAny<Product>())).Returns(Task.CompletedTask);
            mockCacheService.Setup(c => c.Remove(CacheConstants.ProductsList)).Verifiable();

            await characterCommand.Handle(command, CancellationToken.None);

            mockCacheService.Verify(c => c.Remove(CacheConstants.ProductsList), Times.Once);
            mockProductRepository.Verify(r => r.AddProduct(It.IsAny<Product>()), Times.Once);
        }
    }
}