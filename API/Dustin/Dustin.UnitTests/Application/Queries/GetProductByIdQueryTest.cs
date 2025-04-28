using AutoMapper;
using Dustin.Application;
using Dustin.Application.Queries.Product;
using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Dustin.UnitTests.Application.Queries
{
    public class GetProductByIdQueryTest
    {
        private readonly Mock<IProductRepository> mockProductRepository;
        private readonly Mock<ILogger<GetProductsByIdQueryHandler>> mockLogger;
        private readonly IMapper mapper;

        public GetProductByIdQueryTest()
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
            mockLogger = new Mock<ILogger<GetProductsByIdQueryHandler>>();
        }

        [Fact]
        public async Task Should_ProducIsReturned_ForValidProductId()
        {
            var charactersQuery = new GetProductsByIdQueryHandler(mockProductRepository.Object, mockLogger.Object, mapper);

            mockProductRepository.Setup(x => x.Get(It.IsAny<Guid>()))
               .ReturnsAsync(GetProduct());

            var result = await charactersQuery.Handle(new GetProductsByIdQuery(Guid.NewGuid()), new CancellationToken());

            Assert.Equal("IPhone", result.Name);
            Assert.Equal("IPhone 16", result.Description);
            Assert.Equal("Apple", result.Brand.Name);
        }

        [Fact]
        public async Task Should_RetunNUll_ForInValidProductId()
        {
            var charactersQuery = new GetProductsByIdQueryHandler(mockProductRepository.Object, mockLogger.Object, mapper);

            mockProductRepository.Setup(x => x.Get(It.IsAny<Guid>())).ReturnsAsync(() => null);

            var result = await charactersQuery.Handle(new GetProductsByIdQuery(Guid.NewGuid()), new CancellationToken());

            Assert.Null(result);
        }

        private Product GetProduct()
        {
            return new Product
            {
                Name = "IPhone",
                Description = "IPhone 16",
                SubCategory = new SubCategory
                {
                    Value = "Mobile"
                },
                Brand = new Brand
                {
                    Name = "Apple"
                }
            };
        }
    }
}