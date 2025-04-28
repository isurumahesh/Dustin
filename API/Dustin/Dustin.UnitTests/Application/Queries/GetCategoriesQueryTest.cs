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
    public class GetCategoriesQueryTest
    {
        private readonly Mock<ICategoryRepository> mockCategoryRepository;
        private readonly Mock<ILogger<GetCategoriesQueryHandler>> mockLogger;
        private readonly Mock<ICacheService> mockCacheService;
        private readonly IMapper mapper;

        public GetCategoriesQueryTest()
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

            mockCategoryRepository = new Mock<ICategoryRepository>();
            mockCacheService = new Mock<ICacheService>();
            mockLogger = new Mock<ILogger<GetCategoriesQueryHandler>>();
        }

        [Fact]
        public async Task Should_CategoriesReturnFromCache_WhenCacheIsValid()
        {
            var categoriesQuery = new GetCategoriesQueryHandler(mockCategoryRepository.Object, mockCacheService.Object, mockLogger.Object, mapper);

            mockCacheService.Setup(x => x.Get<List<CategoryDTO>>(It.IsAny<string>()))
              .Returns(GetCategoryDTOList());

            var result = await categoriesQuery.Handle(new GetCategoriesQuery(), new CancellationToken());

            Assert.Equal("Mobiles", result.First().Name);
            Assert.Equal("SmartPhones", result.First().SubCategories.First().Value);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public async Task Should_CategoriesReturnFromDatabase_WhenCacheIsInValid()
        {
            var categoriesQuery = new GetCategoriesQueryHandler(mockCategoryRepository.Object, mockCacheService.Object, mockLogger.Object, mapper);
            mockCacheService.Setup(x => x.Get<List<CategoryDTO>>(It.IsAny<string>()))
               .Returns(() => null);

            mockCategoryRepository.Setup(x => x.GetAll()).ReturnsAsync(GetCategoryList());

            var result = await categoriesQuery.Handle(new GetCategoriesQuery(), new CancellationToken());

            Assert.Equal("Mobiles", result.First().Name);
            Assert.Equal("SmartPhones", result.First().SubCategories.First().Value);
            Assert.Equal(1, result.Count);
        }

        private List<CategoryDTO> GetCategoryDTOList()
        {
            return new List<CategoryDTO>
            {
                new CategoryDTO
                {
                    Name = "Mobiles",
                    SubCategories = new List<SubCategoryDTO>
                    {
                        new SubCategoryDTO { Value = "SmartPhones" }
                    }
                }
            };
        }

        private List<Category> GetCategoryList()
        {
            return new List<Category>
            {
                new Category
                {
                    Name = "Mobiles",
                    SubCategories = new List<SubCategory>
                    {
                        new SubCategory { Value = "SmartPhones" }
                    }
                }
            };
        }
    }
}