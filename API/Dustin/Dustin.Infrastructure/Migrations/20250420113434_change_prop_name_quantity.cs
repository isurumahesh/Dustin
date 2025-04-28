using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dustin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class change_prop_name_quantity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ProductItems",
                newName: "Stock");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d38ac99a-4a13-4bc4-9b2c-f480be2076d5"), "Samsung" },
                    { new Guid("dc7a94d7-d58e-4e3c-ad4a-5ec79837e94f"), "Apple" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("449a5050-a860-48a9-8c7b-ac7844272de3"), "Electronics" },
                    { new Guid("f6ee6602-da5e-44cd-9e92-14ec95bbd5f7"), "Appliances" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("20416523-dd82-484d-9720-a4c9ace6e73c"), "Storage" },
                    { new Guid("a37cbe2d-06f8-4a4e-813d-63bc1ac6453b"), "Color" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { new Guid("454d4e2f-4053-4a5a-bc14-89cc43bf91df"), new Guid("449a5050-a860-48a9-8c7b-ac7844272de3"), "Smartphones" },
                    { new Guid("aa2cbafa-ed6c-4fda-a38f-29ef55878000"), new Guid("449a5050-a860-48a9-8c7b-ac7844272de3"), "Laptops" }
                });

            migrationBuilder.InsertData(
                table: "SubFeatures",
                columns: new[] { "Id", "FeatureId", "Value" },
                values: new object[,]
                {
                    { new Guid("4f3db966-8c73-4248-bb1e-5fedbcbc5a02"), new Guid("a37cbe2d-06f8-4a4e-813d-63bc1ac6453b"), "Black" },
                    { new Guid("8107889a-bb83-468e-ba4c-e2581c18cf17"), new Guid("20416523-dd82-484d-9720-a4c9ace6e73c"), "128 GB" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("a1f9bfb6-128b-46d8-9060-e4c15fcef052"), new Guid("dc7a94d7-d58e-4e3c-ad4a-5ec79837e94f"), "Apple's premium laptop", "MacBook Pro", new Guid("aa2cbafa-ed6c-4fda-a38f-29ef55878000") },
                    { new Guid("bd5eff15-fdc1-478d-b044-7fc89af83cc8"), new Guid("d38ac99a-4a13-4bc4-9b2c-f480be2076d5"), "Samsung's flagship smartphone", "Galaxy S21", new Guid("454d4e2f-4053-4a5a-bc14-89cc43bf91df") }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Price", "ProductId", "Sku", "Stock" },
                values: new object[,]
                {
                    { new Guid("42cb3133-69c0-4bb1-a85f-7a7dc8cec5aa"), 1499.99m, new Guid("bd5eff15-fdc1-478d-b044-7fc89af83cc8"), "GX-24-2023", 50 },
                    { new Guid("723da66d-aaaf-4bf6-a910-ee62fee1a438"), 2499.99m, new Guid("a1f9bfb6-128b-46d8-9060-e4c15fcef052"), "MBP-16-2023", 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductItemSubFeatures",
                columns: new[] { "ProductItemId", "SubFeatureId" },
                values: new object[,]
                {
                    { new Guid("42cb3133-69c0-4bb1-a85f-7a7dc8cec5aa"), new Guid("4f3db966-8c73-4248-bb1e-5fedbcbc5a02") },
                    { new Guid("723da66d-aaaf-4bf6-a910-ee62fee1a438"), new Guid("4f3db966-8c73-4248-bb1e-5fedbcbc5a02") },
                    { new Guid("42cb3133-69c0-4bb1-a85f-7a7dc8cec5aa"), new Guid("8107889a-bb83-468e-ba4c-e2581c18cf17") },
                    { new Guid("723da66d-aaaf-4bf6-a910-ee62fee1a438"), new Guid("8107889a-bb83-468e-ba4c-e2581c18cf17") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6ee6602-da5e-44cd-9e92-14ec95bbd5f7"));

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("42cb3133-69c0-4bb1-a85f-7a7dc8cec5aa"), new Guid("4f3db966-8c73-4248-bb1e-5fedbcbc5a02") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("723da66d-aaaf-4bf6-a910-ee62fee1a438"), new Guid("4f3db966-8c73-4248-bb1e-5fedbcbc5a02") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("42cb3133-69c0-4bb1-a85f-7a7dc8cec5aa"), new Guid("8107889a-bb83-468e-ba4c-e2581c18cf17") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("723da66d-aaaf-4bf6-a910-ee62fee1a438"), new Guid("8107889a-bb83-468e-ba4c-e2581c18cf17") });

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("42cb3133-69c0-4bb1-a85f-7a7dc8cec5aa"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("723da66d-aaaf-4bf6-a910-ee62fee1a438"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("4f3db966-8c73-4248-bb1e-5fedbcbc5a02"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("8107889a-bb83-468e-ba4c-e2581c18cf17"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("20416523-dd82-484d-9720-a4c9ace6e73c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("a37cbe2d-06f8-4a4e-813d-63bc1ac6453b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1f9bfb6-128b-46d8-9060-e4c15fcef052"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bd5eff15-fdc1-478d-b044-7fc89af83cc8"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("d38ac99a-4a13-4bc4-9b2c-f480be2076d5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("dc7a94d7-d58e-4e3c-ad4a-5ec79837e94f"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("454d4e2f-4053-4a5a-bc14-89cc43bf91df"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("aa2cbafa-ed6c-4fda-a38f-29ef55878000"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("449a5050-a860-48a9-8c7b-ac7844272de3"));

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "ProductItems",
                newName: "Quantity");

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
    }
}
