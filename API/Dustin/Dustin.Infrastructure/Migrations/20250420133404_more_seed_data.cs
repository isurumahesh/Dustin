using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dustin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class more_seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("f35a338c-b670-4db7-8200-341f54fd5e08"), "Apple" },
                    { new Guid("f80cc0f3-312c-4492-ba91-fe81b5d3d9f1"), "Samsung" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09e90f89-ffc7-48fe-942d-86b175057c76"), "Audio & video" },
                    { new Guid("144118e0-8c56-4d95-8675-5152accf7478"), "Computer & Tablets" },
                    { new Guid("8267f7b5-b8c2-45fc-9a7a-172bd7bcb956"), "Mobile phones & Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6b97e3e3-cbf9-4369-ba6d-f2e1e41a5a62"), "Color" },
                    { new Guid("7ca729e8-c814-429e-97e5-78b6805ddf65"), "Display technology" },
                    { new Guid("8cce2447-a3c9-4d08-8289-808a534c4351"), "Storage" },
                    { new Guid("db51329a-17f1-4185-88a6-fde355db5576"), "Screen size" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { new Guid("03394997-4a75-42d6-8466-5b1e7b2e2ce6"), new Guid("8267f7b5-b8c2-45fc-9a7a-172bd7bcb956"), "Smartphones" },
                    { new Guid("07606316-1c3e-4b9f-8bf0-f7dee877f9c9"), new Guid("144118e0-8c56-4d95-8675-5152accf7478"), "Portable computers" },
                    { new Guid("26d4a103-a32e-47ef-a46e-ffbee635cc61"), new Guid("09e90f89-ffc7-48fe-942d-86b175057c76"), "Headphones" },
                    { new Guid("7639844a-3681-400f-b5bf-625188a5b3f1"), new Guid("8267f7b5-b8c2-45fc-9a7a-172bd7bcb956"), "Wearables" },
                    { new Guid("9a9d3258-3d44-4afa-9a9c-34977becf56d"), new Guid("144118e0-8c56-4d95-8675-5152accf7478"), "Desktop computers" },
                    { new Guid("dbaaf996-fd1b-4d07-a736-db25f7fb7867"), new Guid("09e90f89-ffc7-48fe-942d-86b175057c76"), "Televisions" }
                });

            migrationBuilder.InsertData(
                table: "SubFeatures",
                columns: new[] { "Id", "FeatureId", "Value" },
                values: new object[,]
                {
                    { new Guid("14115095-8d4e-4d60-a1fa-7062babdc6cd"), new Guid("7ca729e8-c814-429e-97e5-78b6805ddf65"), "OLED" },
                    { new Guid("3192e327-8c6b-40de-8252-f42214880e2d"), new Guid("db51329a-17f1-4185-88a6-fde355db5576"), "6" },
                    { new Guid("5098d795-f8e4-45a3-8c3b-58e53aa339eb"), new Guid("8cce2447-a3c9-4d08-8289-808a534c4351"), "256 GB" },
                    { new Guid("553f6c38-a8f2-4c36-9402-4bb5b79026a1"), new Guid("6b97e3e3-cbf9-4369-ba6d-f2e1e41a5a62"), "Green" },
                    { new Guid("5d6d2dc8-cf3e-4080-895a-789c051b43da"), new Guid("6b97e3e3-cbf9-4369-ba6d-f2e1e41a5a62"), "Black" },
                    { new Guid("6c1d648b-40da-44ca-a64e-6d40a8125cbb"), new Guid("8cce2447-a3c9-4d08-8289-808a534c4351"), "1 TB" },
                    { new Guid("878aab4b-99ec-4b4b-b431-d4badfce6429"), new Guid("7ca729e8-c814-429e-97e5-78b6805ddf65"), "LED" },
                    { new Guid("8f662d5b-9634-4da9-837d-39a1e0f4c634"), new Guid("8cce2447-a3c9-4d08-8289-808a534c4351"), "128 GB" },
                    { new Guid("908d5fe6-b227-4e66-941d-69b616f0e79f"), new Guid("db51329a-17f1-4185-88a6-fde355db5576"), "55" },
                    { new Guid("a5b33f83-0924-4d5a-852e-9c4810c02d71"), new Guid("6b97e3e3-cbf9-4369-ba6d-f2e1e41a5a62"), "Red" },
                    { new Guid("c52b0dd1-7c5a-49fd-84a0-7899403bec7a"), new Guid("7ca729e8-c814-429e-97e5-78b6805ddf65"), "LCD" },
                    { new Guid("e3fbf89e-06a9-4032-b871-ae40ac0b2731"), new Guid("db51329a-17f1-4185-88a6-fde355db5576"), "15.6" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("1d469824-3583-4c0c-9d88-df0cbd45b1ea"), new Guid("f35a338c-b670-4db7-8200-341f54fd5e08"), "Apple's premium laptop", "MacBook Pro", new Guid("07606316-1c3e-4b9f-8bf0-f7dee877f9c9") },
                    { new Guid("d3f63193-4cf6-44d3-a08c-18dba0dad8ea"), new Guid("f80cc0f3-312c-4492-ba91-fe81b5d3d9f1"), "Samsung's flagship smartphone", "Galaxy S21", new Guid("03394997-4a75-42d6-8466-5b1e7b2e2ce6") }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Price", "ProductId", "Sku", "Stock" },
                values: new object[,]
                {
                    { new Guid("9644b268-d0a4-4b81-95d7-72ece534b401"), 1499.99m, new Guid("d3f63193-4cf6-44d3-a08c-18dba0dad8ea"), "GX-24-2023", 50 },
                    { new Guid("f8a781de-3768-42c5-b7ae-8d4102482d74"), 2499.99m, new Guid("1d469824-3583-4c0c-9d88-df0cbd45b1ea"), "MBP-16-2023", 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductItemSubFeatures",
                columns: new[] { "ProductItemId", "SubFeatureId" },
                values: new object[,]
                {
                    { new Guid("9644b268-d0a4-4b81-95d7-72ece534b401"), new Guid("5d6d2dc8-cf3e-4080-895a-789c051b43da") },
                    { new Guid("f8a781de-3768-42c5-b7ae-8d4102482d74"), new Guid("5d6d2dc8-cf3e-4080-895a-789c051b43da") },
                    { new Guid("9644b268-d0a4-4b81-95d7-72ece534b401"), new Guid("8f662d5b-9634-4da9-837d-39a1e0f4c634") },
                    { new Guid("f8a781de-3768-42c5-b7ae-8d4102482d74"), new Guid("8f662d5b-9634-4da9-837d-39a1e0f4c634") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("9644b268-d0a4-4b81-95d7-72ece534b401"), new Guid("5d6d2dc8-cf3e-4080-895a-789c051b43da") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("f8a781de-3768-42c5-b7ae-8d4102482d74"), new Guid("5d6d2dc8-cf3e-4080-895a-789c051b43da") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("9644b268-d0a4-4b81-95d7-72ece534b401"), new Guid("8f662d5b-9634-4da9-837d-39a1e0f4c634") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("f8a781de-3768-42c5-b7ae-8d4102482d74"), new Guid("8f662d5b-9634-4da9-837d-39a1e0f4c634") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("26d4a103-a32e-47ef-a46e-ffbee635cc61"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("7639844a-3681-400f-b5bf-625188a5b3f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("9a9d3258-3d44-4afa-9a9c-34977becf56d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("dbaaf996-fd1b-4d07-a736-db25f7fb7867"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("14115095-8d4e-4d60-a1fa-7062babdc6cd"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("3192e327-8c6b-40de-8252-f42214880e2d"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("5098d795-f8e4-45a3-8c3b-58e53aa339eb"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("553f6c38-a8f2-4c36-9402-4bb5b79026a1"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("6c1d648b-40da-44ca-a64e-6d40a8125cbb"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("878aab4b-99ec-4b4b-b431-d4badfce6429"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("908d5fe6-b227-4e66-941d-69b616f0e79f"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("a5b33f83-0924-4d5a-852e-9c4810c02d71"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("c52b0dd1-7c5a-49fd-84a0-7899403bec7a"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("e3fbf89e-06a9-4032-b871-ae40ac0b2731"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09e90f89-ffc7-48fe-942d-86b175057c76"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("7ca729e8-c814-429e-97e5-78b6805ddf65"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("db51329a-17f1-4185-88a6-fde355db5576"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("9644b268-d0a4-4b81-95d7-72ece534b401"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("f8a781de-3768-42c5-b7ae-8d4102482d74"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("5d6d2dc8-cf3e-4080-895a-789c051b43da"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("8f662d5b-9634-4da9-837d-39a1e0f4c634"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6b97e3e3-cbf9-4369-ba6d-f2e1e41a5a62"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8cce2447-a3c9-4d08-8289-808a534c4351"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d469824-3583-4c0c-9d88-df0cbd45b1ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3f63193-4cf6-44d3-a08c-18dba0dad8ea"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f35a338c-b670-4db7-8200-341f54fd5e08"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f80cc0f3-312c-4492-ba91-fe81b5d3d9f1"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("03394997-4a75-42d6-8466-5b1e7b2e2ce6"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("07606316-1c3e-4b9f-8bf0-f7dee877f9c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("144118e0-8c56-4d95-8675-5152accf7478"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8267f7b5-b8c2-45fc-9a7a-172bd7bcb956"));

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
    }
}
