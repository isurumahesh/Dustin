using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dustin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("842c7c6f-c42b-48ba-bea7-4addf1c38ead"));

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("bea6a7d8-c568-4bd7-8958-cc05b27ddf01"), new Guid("3e8b0c3e-039a-4825-87b3-3c8801456ffc") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("dfd513a6-e51d-43ab-b89f-60f57d1a930e"), new Guid("3e8b0c3e-039a-4825-87b3-3c8801456ffc") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("bea6a7d8-c568-4bd7-8958-cc05b27ddf01"), new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("dfd513a6-e51d-43ab-b89f-60f57d1a930e"), new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca") });

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("2ecfe94f-d647-4b54-8acc-6500a7519be6"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("bea6a7d8-c568-4bd7-8958-cc05b27ddf01"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("dfd513a6-e51d-43ab-b89f-60f57d1a930e"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("3e8b0c3e-039a-4825-87b3-3c8801456ffc"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8112aafb-43d8-498f-bc04-98b0e8fe1888"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc6b2ac6-a4a4-49c1-8ed3-08af09226f93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d954797e-ea5e-4728-b82b-5d20706ee5df"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("3ebfe19f-4e02-499d-878d-a49e8cd4e04a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("e9d621c8-3fe6-4e1d-b58b-855612a027e1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("0302357a-02cb-40d1-820f-e8ed85430e57"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("2807db30-76ed-4817-a657-28b6ef83c26a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("22963f77-d25c-4d87-a130-326e05ee8d27"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("98aa8de1-0ef1-40e8-9773-f41822e08eb4"), "Apple" },
                    { new Guid("d7e46006-01a7-4d0e-8f99-f79f5c9a0544"), "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6aea08c4-0f6b-4b3c-aea7-6b874c9cebc7"), "Appliances" },
                    { new Guid("e08d9dca-b65b-45ce-a261-401bb51aba8e"), "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("82bdebfe-de55-4dca-b710-d755f00b4296"), "Storage" },
                    { new Guid("cdfb6e29-c3ce-4848-847c-49f619f14243"), "Color" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { new Guid("714ab344-da8a-4831-8d97-4422fbc354ad"), new Guid("e08d9dca-b65b-45ce-a261-401bb51aba8e"), "Smartphones" },
                    { new Guid("c3acbf6a-4383-4a71-a555-b4cd1ae3e318"), new Guid("e08d9dca-b65b-45ce-a261-401bb51aba8e"), "Laptops" }
                });

            migrationBuilder.InsertData(
                table: "SubFeatures",
                columns: new[] { "Id", "FeatureId", "Value" },
                values: new object[,]
                {
                    { new Guid("2310246e-583f-4410-9fe2-a963e3c706b8"), new Guid("cdfb6e29-c3ce-4848-847c-49f619f14243"), "Black" },
                    { new Guid("b2af586a-d23a-46a9-bdb9-ed06dfe601fe"), new Guid("82bdebfe-de55-4dca-b710-d755f00b4296"), "128 GB" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("0199be6e-6269-4dba-8308-1d49e68adbdb"), new Guid("98aa8de1-0ef1-40e8-9773-f41822e08eb4"), "Apple's premium laptop", "MacBook Pro", new Guid("c3acbf6a-4383-4a71-a555-b4cd1ae3e318") },
                    { new Guid("a1bc16f9-ee06-4e72-be90-b9cc018b12a9"), new Guid("d7e46006-01a7-4d0e-8f99-f79f5c9a0544"), "Samsung's flagship smartphone", "Galaxy S21", new Guid("714ab344-da8a-4831-8d97-4422fbc354ad") }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Price", "ProductId", "Quantity", "Sku" },
                values: new object[,]
                {
                    { new Guid("44e70068-82b6-469c-b53f-56b6263a1b49"), 1499.99m, new Guid("a1bc16f9-ee06-4e72-be90-b9cc018b12a9"), 50, "GX-24-2023" },
                    { new Guid("98ffc17b-1c77-4ecb-b122-83e97c460657"), 2499.99m, new Guid("0199be6e-6269-4dba-8308-1d49e68adbdb"), 100, "MBP-16-2023" }
                });

            migrationBuilder.InsertData(
                table: "ProductItemSubFeatures",
                columns: new[] { "ProductItemId", "SubFeatureId" },
                values: new object[,]
                {
                    { new Guid("44e70068-82b6-469c-b53f-56b6263a1b49"), new Guid("2310246e-583f-4410-9fe2-a963e3c706b8") },
                    { new Guid("98ffc17b-1c77-4ecb-b122-83e97c460657"), new Guid("2310246e-583f-4410-9fe2-a963e3c706b8") },
                    { new Guid("44e70068-82b6-469c-b53f-56b6263a1b49"), new Guid("b2af586a-d23a-46a9-bdb9-ed06dfe601fe") },
                    { new Guid("98ffc17b-1c77-4ecb-b122-83e97c460657"), new Guid("b2af586a-d23a-46a9-bdb9-ed06dfe601fe") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6aea08c4-0f6b-4b3c-aea7-6b874c9cebc7"));

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("44e70068-82b6-469c-b53f-56b6263a1b49"), new Guid("2310246e-583f-4410-9fe2-a963e3c706b8") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("98ffc17b-1c77-4ecb-b122-83e97c460657"), new Guid("2310246e-583f-4410-9fe2-a963e3c706b8") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("44e70068-82b6-469c-b53f-56b6263a1b49"), new Guid("b2af586a-d23a-46a9-bdb9-ed06dfe601fe") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("98ffc17b-1c77-4ecb-b122-83e97c460657"), new Guid("b2af586a-d23a-46a9-bdb9-ed06dfe601fe") });

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("44e70068-82b6-469c-b53f-56b6263a1b49"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("98ffc17b-1c77-4ecb-b122-83e97c460657"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("2310246e-583f-4410-9fe2-a963e3c706b8"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("b2af586a-d23a-46a9-bdb9-ed06dfe601fe"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("82bdebfe-de55-4dca-b710-d755f00b4296"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("cdfb6e29-c3ce-4848-847c-49f619f14243"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0199be6e-6269-4dba-8308-1d49e68adbdb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1bc16f9-ee06-4e72-be90-b9cc018b12a9"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("98aa8de1-0ef1-40e8-9773-f41822e08eb4"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("d7e46006-01a7-4d0e-8f99-f79f5c9a0544"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("714ab344-da8a-4831-8d97-4422fbc354ad"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c3acbf6a-4383-4a71-a555-b4cd1ae3e318"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e08d9dca-b65b-45ce-a261-401bb51aba8e"));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3ebfe19f-4e02-499d-878d-a49e8cd4e04a"), "Samsung" },
                    { new Guid("e9d621c8-3fe6-4e1d-b58b-855612a027e1"), "Apple" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("22963f77-d25c-4d87-a130-326e05ee8d27"), "Electronics" },
                    { new Guid("842c7c6f-c42b-48ba-bea7-4addf1c38ead"), "Appliances" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("8112aafb-43d8-498f-bc04-98b0e8fe1888"), "Color" },
                    { new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca"), "Storage" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { new Guid("0302357a-02cb-40d1-820f-e8ed85430e57"), new Guid("22963f77-d25c-4d87-a130-326e05ee8d27"), "Laptops" },
                    { new Guid("2807db30-76ed-4817-a657-28b6ef83c26a"), new Guid("22963f77-d25c-4d87-a130-326e05ee8d27"), "Smartphones" }
                });

            migrationBuilder.InsertData(
                table: "SubFeatures",
                columns: new[] { "Id", "FeatureId", "Value" },
                values: new object[,]
                {
                    { new Guid("2ecfe94f-d647-4b54-8acc-6500a7519be6"), new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca"), "128 GB" },
                    { new Guid("3e8b0c3e-039a-4825-87b3-3c8801456ffc"), new Guid("8112aafb-43d8-498f-bc04-98b0e8fe1888"), "Black" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("bc6b2ac6-a4a4-49c1-8ed3-08af09226f93"), new Guid("3ebfe19f-4e02-499d-878d-a49e8cd4e04a"), "Samsung's flagship smartphone", "Galaxy S21", new Guid("2807db30-76ed-4817-a657-28b6ef83c26a") },
                    { new Guid("d954797e-ea5e-4728-b82b-5d20706ee5df"), new Guid("e9d621c8-3fe6-4e1d-b58b-855612a027e1"), "Apple's premium laptop", "MacBook Pro", new Guid("0302357a-02cb-40d1-820f-e8ed85430e57") }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Price", "ProductId", "Quantity", "Sku" },
                values: new object[,]
                {
                    { new Guid("bea6a7d8-c568-4bd7-8958-cc05b27ddf01"), 2499.99m, new Guid("d954797e-ea5e-4728-b82b-5d20706ee5df"), 100, "MBP-16-2023" },
                    { new Guid("dfd513a6-e51d-43ab-b89f-60f57d1a930e"), 1499.99m, new Guid("bc6b2ac6-a4a4-49c1-8ed3-08af09226f93"), 50, "GX-24-2023" }
                });

            migrationBuilder.InsertData(
                table: "ProductItemSubFeatures",
                columns: new[] { "ProductItemId", "SubFeatureId" },
                values: new object[,]
                {
                    { new Guid("bea6a7d8-c568-4bd7-8958-cc05b27ddf01"), new Guid("3e8b0c3e-039a-4825-87b3-3c8801456ffc") },
                    { new Guid("dfd513a6-e51d-43ab-b89f-60f57d1a930e"), new Guid("3e8b0c3e-039a-4825-87b3-3c8801456ffc") },
                    { new Guid("bea6a7d8-c568-4bd7-8958-cc05b27ddf01"), new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca") },
                    { new Guid("dfd513a6-e51d-43ab-b89f-60f57d1a930e"), new Guid("ede19ebf-e7d3-466a-9db4-1b67921765ca") }
                });
        }
    }
}
