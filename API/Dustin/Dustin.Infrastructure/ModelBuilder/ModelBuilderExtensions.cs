using Dustin.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dustin.Infrastructure.Seed
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var electronicsCategoryId = Guid.NewGuid();
            var appliancesCategoryId = Guid.NewGuid();
            var audioCategoryId = Guid.NewGuid();

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = electronicsCategoryId, Name = "Computer & Tablets" },
                new Category { Id = appliancesCategoryId, Name = "Mobile phones & Accessories" },
                new Category { Id = audioCategoryId, Name = "Audio & video" }
            );

            // SubCategories
            var laptopSubCategoryId = Guid.NewGuid();
            var desktopCategoryId = Guid.NewGuid();
            var smartphoneSubCategoryId = Guid.NewGuid();
            var wearablesCategoryId = Guid.NewGuid();
            var televisonCategorydId = Guid.NewGuid();
            var headPhonesCategoryId = Guid.NewGuid();


            modelBuilder.Entity<SubCategory>().HasData(
                new SubCategory { Id = laptopSubCategoryId, Value = "Portable computers", CategoryId = electronicsCategoryId },
                new SubCategory { Id = desktopCategoryId, Value = "Desktop computers", CategoryId = electronicsCategoryId },

                new SubCategory { Id = smartphoneSubCategoryId, Value = "Smartphones", CategoryId = appliancesCategoryId },
                new SubCategory { Id = wearablesCategoryId, Value = "Wearables", CategoryId = appliancesCategoryId },

                new SubCategory { Id = televisonCategorydId, Value = "Televisions", CategoryId = audioCategoryId },
                new SubCategory { Id = headPhonesCategoryId, Value = "Headphones", CategoryId = audioCategoryId }
            );

            // Brands
            var appleBrandId = Guid.NewGuid();
            var samsungBrandId = Guid.NewGuid();

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = appleBrandId, Name = "Apple" },
                new Brand { Id = samsungBrandId, Name = "Samsung" }
            );

            // Features
            var colorFeatureId = Guid.NewGuid();
            var storageFeatureId = Guid.NewGuid();
            var screenFeatureId = Guid.NewGuid();
            var displayFeatureId = Guid.NewGuid();

            modelBuilder.Entity<Feature>().HasData(
                new Feature { Id = colorFeatureId, Name = "Color" },
                new Feature { Id = storageFeatureId, Name = "Storage" },
                new Feature { Id = screenFeatureId, Name = "Screen size" },
                new Feature { Id = displayFeatureId, Name = "Display technology" }
            );

            // SubFeatures
            var blackColorId = Guid.NewGuid();
            var storageSubFeatureId = Guid.NewGuid();

            modelBuilder.Entity<SubFeature>().HasData(
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

            );

            // Products
            var laptopProductId = Guid.NewGuid();
            var phoneProductId = Guid.NewGuid();

            modelBuilder.Entity<Product>().HasData(
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
            );

            // ProductItems
            var laptopItemId = Guid.NewGuid();
            var phoneItemId = Guid.NewGuid();

            modelBuilder.Entity<ProductItem>().HasData(
                new ProductItem
                {
                    Id = laptopItemId,
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
            );

            // ProductItemSubFeatures
            modelBuilder.Entity<ProductItemSubFeature>().HasData(
                new ProductItemSubFeature { ProductItemId = laptopItemId, SubFeatureId = blackColorId },
                new ProductItemSubFeature { ProductItemId = laptopItemId, SubFeatureId = storageSubFeatureId },
                new ProductItemSubFeature { ProductItemId = phoneItemId, SubFeatureId = blackColorId },
                new ProductItemSubFeature { ProductItemId = phoneItemId, SubFeatureId = storageSubFeatureId }
            );
        }

        public static void PropertyValidation(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(c => c.Name).IsRequired().HasMaxLength(200);
                entity.Property(c => c.Description).IsRequired();
            });

            modelBuilder.Entity<ProductItem>(entity =>
            {
                entity.Property(c => c.Sku).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Price).HasPrecision(18, 2);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.Property(c => c.Value).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<SubFeature>(entity =>
            {
                entity.Property(c => c.Value).IsRequired().HasMaxLength(100);
            });


        }
    }
}