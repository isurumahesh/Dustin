using Dustin.Application.Commands.Product;
using Dustin.Application.Interfaces;
using Dustin.Domain.Constants;
using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Dustin.UnitTests.Application.Commands
{
    public class DeleteProductCommandTest
    {
        private readonly Mock<IProductRepository> mockProductRepository;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly Mock<ILogger<DeleteProductCommandHandler>> mockLogger;

        public DeleteProductCommandTest()
        {
            mockProductRepository = new Mock<IProductRepository>();
            mockCacheService = new Mock<ICacheService>();
            mockLogger = new Mock<ILogger<DeleteProductCommandHandler>>();
        }

        [Fact]
        public async Task Should_SuccessfullyDeelete_ForValidProductId()
        {
            var characterCommand = new DeleteProductCommandHandler(mockProductRepository.Object, mockCacheService.Object, mockLogger.Object);
            var command = new DeleteProductCommand(Guid.NewGuid());
            mockProductRepository.Setup(r => r.DeleteProduct(It.IsAny<Product>())).Returns(Task.CompletedTask);
            mockCacheService.Setup(c => c.Remove(CacheConstants.ProductsList)).Verifiable();

            await characterCommand.Handle(command, CancellationToken.None);

            mockCacheService.Verify(c => c.Remove(CacheConstants.ProductsList), Times.Once);
            mockProductRepository.Verify(r => r.DeleteProduct(It.IsAny<Product>()), Times.Once);
        }
    }
}