using Dustin.Domain.Entities;
using Dustin.Infrastructure.Data;

namespace Dustin.IntegrationTests
{
    public class Seeding
    {
        public static void InitializeTestDb(DustinDbContext context)
        {
            // Ensure the database is created
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                var electronicsCategoryId = Guid.NewGuid();
                var appliancesCategoryId = Guid.NewGuid();
                var audioCategoryId = Guid.NewGuid();

                var categories = new List<Category>
        {
            new Category { Id = electronicsCategoryId, Name = "Computer & Tablets" },
            new Category { Id = appliancesCategoryId, Name = "Mobile phones & Accessories" },
            new Category { Id = audioCategoryId, Name = "Audio & video" },
        };
                context.Categories.AddRange(categories);

                var laptopSubCategoryId = Guid.NewGuid();
                var desktopCategoryId = Guid.NewGuid();
                var smartphoneSubCategoryId = Guid.NewGuid();
                var wearablesCategoryId = Guid.NewGuid();
                var televisonCategorydId = Guid.NewGuid();
                var headPhonesCategoryId = Guid.NewGuid();

                var subCategories = new List<SubCategory>
        {
            new SubCategory { Id = laptopSubCategoryId, Value = "Portable computers", CategoryId = electronicsCategoryId },
            new SubCategory { Id = desktopCategoryId, Value = "Desktop computers", CategoryId = electronicsCategoryId },
            new SubCategory { Id = smartphoneSubCategoryId, Value = "Smartphones", CategoryId = appliancesCategoryId },
            new SubCategory { Id = wearablesCategoryId, Value = "Wearables", CategoryId = appliancesCategoryId },
            new SubCategory { Id = televisonCategorydId, Value = "Televisions", CategoryId = audioCategoryId },
            new SubCategory { Id = headPhonesCategoryId, Value = "Headphones", CategoryId = audioCategoryId },
        };
                context.SubCategories.AddRange(subCategories);

                var appleBrandId = new Guid("e09fb61b-9a68-470e-9487-410e445a4d2a");
                var samsungBrandId = Guid.NewGuid();

                var brands = new List<Brand>
        {
            new Brand { Id = appleBrandId, Name = "Apple" },
            new Brand { Id = samsungBrandId, Name = "Samsung" },
        };
                context.Brands.AddRange(brands);

                var colorFeatureId = Guid.NewGuid();
                var storageFeatureId = Guid.NewGuid();
                var screenFeatureId = Guid.NewGuid();
                var displayFeatureId = Guid.NewGuid();

                var features = new List<Feature>
        {
            new Feature { Id = colorFeatureId, Name = "Color" },
            new Feature { Id = storageFeatureId, Name = "Storage" },
            new Feature { Id = screenFeatureId, Name = "Screen size" },
            new Feature { Id = displayFeatureId, Name = "Display technology" }
        };
                context.Features.AddRange(features);

                var blackColorId = Guid.NewGuid();
                var storageSubFeatureId = Guid.NewGuid();

                var subFeatures = new List<SubFeature>
        {
            new SubFeature { Id = blackColorId, Value = "Black", FeatureId = colorFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "Red", FeatureId = colorFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "Green", FeatureId = colorFeatureId },
            new SubFeature { Id = storageSubFeatureId, Value = "128 GB", FeatureId = storageFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "256 GB", FeatureId = storageFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "1 TB", FeatureId = storageFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "6", FeatureId = screenFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "15.6", FeatureId = screenFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "55", FeatureId = screenFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "LCD", FeatureId = displayFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "LED", FeatureId = displayFeatureId },
            new SubFeature { Id = Guid.NewGuid(), Value = "OLED", FeatureId = displayFeatureId }
        };
                context.SubFeatures.AddRange(subFeatures);

                var laptopProductId = Guid.NewGuid();
                var phoneProductId = Guid.NewGuid();

                var products = new List<Product>
        {
            new Product
            {
                Id = laptopProductId,
                Name = "MacBook Pro",
                Description = "Apple's premium laptop",
                SubCategoryId = laptopSubCategoryId,
                BrandId = appleBrandId
            },
            new Product
            {
                Id = phoneProductId,
                Name = "Galaxy S21",
                Description = "Samsung's flagship smartphone",
                SubCategoryId = smartphoneSubCategoryId,
                BrandId = samsungBrandId
            }
        };
                context.Products.AddRange(products);

                var laptopItemId = Guid.NewGuid();
                var phoneItemId = Guid.NewGuid();

                var productItems = new List<ProductItem>
        {
            new ProductItem
            {
                Id = Guid.NewGuid(),
                Sku = "MBP-16-2023",
                Stock = 100,
                Price = 2499.99m,
                ProductId = laptopProductId
            },
            new ProductItem
            {
                Id = phoneItemId,
                Sku = "GX-24-2023",
                Stock = 50,
                Price = 1499.99m,
                ProductId = phoneProductId
            }
        };
                context.ProductItems.AddRange(productItems);

                var productItemSubFeatures = new List<ProductItemSubFeature>
        {
            new ProductItemSubFeature { ProductItemId = laptopItemId, SubFeatureId = blackColorId },
            new ProductItemSubFeature { ProductItemId = laptopItemId, SubFeatureId = storageSubFeatureId },
            new ProductItemSubFeature { ProductItemId = phoneItemId, SubFeatureId = blackColorId },
            new ProductItemSubFeature { ProductItemId = phoneItemId, SubFeatureId = storageSubFeatureId }
        };
                context.ProductItemSubFeatures.AddRange(productItemSubFeatures);

                context.SaveChanges();
            }
        }
    }
}