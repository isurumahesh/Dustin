using AutoMapper;
using Dustin.Application;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Application.Queries.Product;
using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Dustin.UnitTests.Application.Queries
{
    public class GetProductsQueryTest
    {
        private readonly Mock<IProductRepository> mockProductRepository;
        private readonly Mock<ILogger<GetProductsQueryHandler>> mockLogger;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly IMapper mapper;

        public GetProductsQueryTest()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            mapper = mappingConfig.CreateMapper();

            mockProductRepository = new Mock<IProductRepository>();
            mockCacheService = new Mock<ICacheService>();
            mockLogger = new Mock<ILogger<GetProductsQueryHandler>>();
        }

        [Fact]
        public async Task Should_ProductsReturnFromCache_WhenCacheIsValid()
        {
            var categoriesQuery = new GetProductsQueryHandler(
                mockProductRepository.Object,
                mockCacheService.Object,
                mockLogger.Object,
                mapper
            );

            mockCacheService.Setup(x => x.Get<List<ProductDTO>>(It.IsAny<string>()))
                .Returns(GetProductDTOList());

            var result = await categoriesQuery.Handle(new GetProductsQuery(), new CancellationToken());

            Assert.Equal("IPhone", result.First().Name);
            Assert.True(result.Any());
        }

        [Fact]
        public async Task Should_ProductsReturnFromDatabase_WhenCacheIsInValid()
        {
            var categoriesQuery = new GetProductsQueryHandler(
                mockProductRepository.Object,
                mockCacheService.Object,
                mockLogger.Object,
                mapper
            );

            mockCacheService.Setup(x => x.Get<List<ProductDTO>>(It.IsAny<string>()))
                .Returns(() => null);

            mockProductRepository.Setup(x => x.GetAll()).ReturnsAsync(GetProductList());

            var result = await categoriesQuery.Handle(new GetProductsQuery(), new CancellationToken());

            Assert.Equal("TV", result.First().Name);

            Assert.True(result.Any());
        }

        private List<ProductDTO> GetProductDTOList()
        {
            return new List<ProductDTO>
            {
                new ProductDTO
                {
                    Name = "IPhone",
                }
            };
        }

        private List<Product> GetProductList()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "TV",
                }
            };
        }
    }
}