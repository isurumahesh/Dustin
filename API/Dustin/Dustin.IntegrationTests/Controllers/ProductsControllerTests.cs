using Dustin.Application.DTOs;
using Dustin.Domain.Constants;
using Dustin.Infrastructure.Data;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace Dustin.IntegrationTests.Controllers
{
    public class ProductsControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;
        private HttpClient _httpClient;
        private Guid ProductId = Guid.NewGuid();

        public ProductsControllerTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;

            _httpClient = _factory.CreateClient(new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Test");
        }

        [Fact]
        public async Task Should_ReturnProductsList_FromDatabase()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.ProductsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                await db.Database.EnsureDeletedAsync();
                db.Database.EnsureCreated();

                Seeding.InitializeTestDb(db);
            }

            var response = await _httpClient.GetAsync("/api/products");
            var result = await response.Content.ReadFromJsonAsync<List<BrandDTO>>();

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            result.Should().HaveCount(2);
        }

        [Fact]
        public async Task Should_ReturnBadRequest_WhenCreatingProduct_ForInvalidData()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.ProductsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                await db.Database.EnsureDeletedAsync();
                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);
            }

            var createProductDTO = new CreateProductDTO
            {
                Name = "IPhone",
            };

            var data = JsonConvert.SerializeObject(createProductDTO);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/products", content);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Should_ReturnBadRequest_WhenUpdatingProduct_ForInvalidData()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.ProductsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                await db.Database.EnsureDeletedAsync();
                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);
            }

            var createProductDTO = new CreateProductDTO
            {
                Name = "IPhone",
            };

            var data = JsonConvert.SerializeObject(createProductDTO);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/products/{ProductId}", content);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }

        [Fact]
        public async Task Should_ReturnCreated_WhenCreatingProduct_ForValidData()
        {
            var brandId = Guid.NewGuid();
            var subCategoryId = Guid.NewGuid();

            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.ProductsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                await db.Database.EnsureDeletedAsync();
                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);
                brandId = db.Brands.First().Id;
                subCategoryId = db.SubCategories.First().Id;
            }

            var createProductDTO = new CreateProductDTO
            {
                Name = "IPhone",
                BrandId = brandId,
                SubCategoryId = subCategoryId,
                Description = "Description",
                ProductItems = new List<CreateProductItemDTO> { new CreateProductItemDTO
                {
                    Price=100,
                    Sku="Sku",
                    Stock=20,
                } }
            };

            var data = JsonConvert.SerializeObject(createProductDTO);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/products", content);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.Created);
        }

        [Fact]
        public async Task Should_ReturnSuccess_WhenUpdatingProduct_ForValidData()
        {
            var brandId = Guid.NewGuid();
            var subCategoryId = Guid.NewGuid();
            var productId = Guid.NewGuid();
            var productItemId = Guid.NewGuid();

            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.ProductsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                await db.Database.EnsureDeletedAsync();
                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);

                brandId = db.Brands.First().Id;
                subCategoryId = db.SubCategories.First().Id;
                productId = db.Products.Include(a => a.ProductItems).First().Id;
                productItemId = db.Products.First().ProductItems.First().Id;
            }

            var updateProductDto = new UpdateProductDTO
            {
                Id = productId,
                Name = "MacBook Pro updated",
                BrandId = brandId,
                SubCategoryId = subCategoryId,
                Description = "Description",
                ProductItems = new List<UpdateProductItemDTO> { new UpdateProductItemDTO
                {
                    Id=productItemId,
                    Price=100,
                    Sku="Sku",
                    Stock=20,
                } }
            };

            var data = JsonConvert.SerializeObject(updateProductDto);
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync($"api/products/{productId}", content);

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.NoContent);
        }

        [Fact]
        public async Task Should_ReturnNoContent_WhenDeletingProduct_ForValidId()
        {
            var productId = Guid.NewGuid();
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.ProductsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                await db.Database.EnsureDeletedAsync();
                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);

                productId = db.Products.Include(a => a.ProductItems).First().Id;
            }

            var response = await _httpClient.DeleteAsync($"api/products/{productId}");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.NoContent);
        }

        [Fact]
        public async Task Should_ReturnBadRequest_WhenDeletingProduct_ForInValidId()
        {
            var productId = Guid.Empty;

            var response = await _httpClient.DeleteAsync($"api/products/{productId}");

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.BadRequest);
        }
    }
}