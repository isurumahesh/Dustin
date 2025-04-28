using AutoMapper;
using Dustin.Application;
using Dustin.Application.DTOs;
using Dustin.Application.Interfaces;
using Dustin.Application.Queries;
using Dustin.Domain.Entities;
using Dustin.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Moq;

namespace Dustin.UnitTests.Application.Queries
{
    public class GetBrandsQueryTest
    {
        private readonly Mock<IBrandRepository> mockBrandRepository;
        private readonly Mock<ILogger<GetBrandsQueryHandler>> mockLogger;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly IMapper mapper;

        public GetBrandsQueryTest()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            mapper = mappingConfig.CreateMapper();

            mockBrandRepository = new Mock<IBrandRepository>();
            mockCacheService = new Mock<ICacheService>();
            mockLogger = new Mock<ILogger<GetBrandsQueryHandler>>();
        }

        [Fact]
        public async Task Should_BrandsReturnFromCache_WhenCacheIsValid()
        {
            var categoriesQuery = new GetBrandsQueryHandler(
                mockBrandRepository.Object,
                mockCacheService.Object,
                mockLogger.Object,
                mapper
            );

            mockCacheService.Setup(x => x.Get<List<BrandDTO>>(It.IsAny<string>()))
                .Returns(GetBrandDTOList());

            var result = await categoriesQuery.Handle(new GetBrandsQuery(), new CancellationToken());

            Assert.Equal("Apple", result.First().Name);
            Assert.Single(result);
        }

        [Fact]
        public async Task Should_BrandsReturnFromDatabase_WhenCacheIsInValid()
        {
            var categoriesQuery = new GetBrandsQueryHandler(
                mockBrandRepository.Object,
                mockCacheService.Object,
                mockLogger.Object,
                mapper
            );

            mockCacheService.Setup(x => x.Get<List<BrandDTO>>(It.IsAny<string>()))
                .Returns(() => null);

            mockBrandRepository.Setup(x => x.GetAll()).ReturnsAsync(GetBrandList());

            var result = await categoriesQuery.Handle(new GetBrandsQuery(), new CancellationToken());

            Assert.Equal("Category", result.First().Name);

            Assert.Single(result);
        }

        private List<BrandDTO> GetBrandDTOList()
        {
            return new List<BrandDTO>
            {
                new BrandDTO
                {
                    Name = "Apple",
                }
            };
        }

        private List<Brand> GetBrandList()
        {
            return new List<Brand>
            {
                new Brand
                {
                    Name = "Category",
                }
            };
        }
    }
}