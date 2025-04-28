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
    public class GetFeaturesQueryTest
    {
        private readonly Mock<IFeatureRepository> mockFeatureRepository;
        private readonly Mock<ILogger<GetFeaturesQueryHandler>> mockLogger;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly IMapper mapper;

        public GetFeaturesQueryTest()
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            mapper = mappingConfig.CreateMapper();

            mockFeatureRepository = new Mock<IFeatureRepository>();
            mockCacheService = new Mock<ICacheService>();
            mockLogger = new Mock<ILogger<GetFeaturesQueryHandler>>();
        }

        [Fact]
        public async Task Should_FeaturesReturnFromCache_WhenCacheIsValid()
        {
            var categoriesQuery = new GetFeaturesQueryHandler(
                mockFeatureRepository.Object,
                mockCacheService.Object,
                mockLogger.Object,
                mapper
            );

            mockCacheService.Setup(x => x.Get<List<FeatureDTO>>(It.IsAny<string>()))
                .Returns(GetFeatureDTOList());

            var result = await categoriesQuery.Handle(new GetFeaturesQuery(), new CancellationToken());

            Assert.Equal("Display", result.First().Name);
            Assert.Single(result);
        }

        [Fact]
        public async Task Should_FeaturesReturnFromDatabase_WhenCacheIsInValid()
        {
            var categoriesQuery = new GetFeaturesQueryHandler(
                mockFeatureRepository.Object,
                mockCacheService.Object,
                mockLogger.Object,
                mapper
            );

            mockCacheService.Setup(x => x.Get<List<FeatureDTO>>(It.IsAny<string>()))
                .Returns(() => null);

            mockFeatureRepository.Setup(x => x.GetAll()).ReturnsAsync(GetFeatureList());

            var result = await categoriesQuery.Handle(new GetFeaturesQuery(), new CancellationToken());

            Assert.Equal("Storage", result.First().Name);

            Assert.Single(result);
        }

        private List<FeatureDTO> GetFeatureDTOList()
        {
            return new List<FeatureDTO>
            {
                new FeatureDTO
                {
                    Name = "Display",
                }
            };
        }

        private List<Feature> GetFeatureList()
        {
            return new List<Feature>
            {
                new Feature
                {
                    Name = "Storage",
                }
            };
        }
    }
}