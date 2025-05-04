using Dustin.Application.DTOs;
using Dustin.Domain.Constants;
using Dustin.Infrastructure.Data;
using FluentAssertions;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Dustin.IntegrationTests.Controllers
{
    public class BrandsControllerTest : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;
        private HttpClient _httpClient;

        public BrandsControllerTest(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;

            _httpClient = _factory.CreateClient(new Microsoft.AspNetCore.Mvc.Testing.WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Test");
        }

        [Fact]
        public async Task Should_ReturnBrandsList_FromDatabase()
        {
            using (var scope = _factory.Services.CreateScope())
            {
                var scopedSevices = scope.ServiceProvider;
                var memoryCache = scopedSevices.GetRequiredService<IMemoryCache>();
                memoryCache.Remove(CacheConstants.BrandsList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);
            }

            var response = await _httpClient.GetAsync("api/brands");
            var result = await response.Content.ReadFromJsonAsync<List<BrandDTO>>();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(2, result.Count);
        }
    }
}