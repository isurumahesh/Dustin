﻿using Dustin.Application.DTOs;
using Dustin.Domain.Constants;
using Dustin.Infrastructure.Data;
using FluentAssertions;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Dustin.IntegrationTests.Controllers
{
    public class CategoriesControllerTest : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;
        private HttpClient _httpClient;

        public CategoriesControllerTest(CustomWebApplicationFactory<Program> factory)
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
                memoryCache.Remove(CacheConstants.CategoriesList);
                var db = scopedSevices.GetRequiredService<DustinDbContext>();

                db.Database.EnsureCreated();
                Seeding.InitializeTestDb(db);
            }

            var response = await _httpClient.GetAsync("api/categories");
            var result = await response.Content.ReadFromJsonAsync<List<BrandDTO>>();

            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            result.Should().HaveCount(3);
        }
    }
}