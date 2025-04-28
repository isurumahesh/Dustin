using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dustin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_audit_fields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("9e28ec12-e4b6-4017-8d88-711ccf716e1a"), new Guid("2a393d00-fa21-456e-ab3c-d7a24f7a7d06") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("b47024fc-ca53-4b22-8a90-ca4b3672e2b8"), new Guid("2a393d00-fa21-456e-ab3c-d7a24f7a7d06") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("9e28ec12-e4b6-4017-8d88-711ccf716e1a"), new Guid("97381031-9c33-4495-a3e1-5112718abfcc") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("b47024fc-ca53-4b22-8a90-ca4b3672e2b8"), new Guid("97381031-9c33-4495-a3e1-5112718abfcc") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b89ff21-09f0-435b-9ce3-733ff103802d"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("6d3d59d4-c8ff-40c3-b3ef-d48495f967a4"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("8471ff39-fff3-4d22-9785-e2da3459f0fc"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("c2ddb826-3e48-4ec9-a1ac-f31b61e0c484"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("1b98e4ec-db65-45a3-8386-77f8e8e3d069"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("5cc262c8-97ef-49ee-8237-f537eba10a65"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("7816e36b-4036-4f35-b78b-6083ef5ba8ee"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("7fdce65f-7160-40af-a257-a9e845f3fdef"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("897ac5d7-dde9-48e8-bbed-3d67f52f2a22"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("8b4039db-eb83-4b47-a110-c7dcb67c7cd2"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("92580012-739e-4723-834c-9591b9fe5074"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("99957586-9832-474e-a747-8f87f37aa2ff"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("ad94f789-d72e-4a94-b6cb-412d75bb255b"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("c9a5243a-1960-4e54-ada7-18736ebc23d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f4a0f85d-ddfd-431e-a5a3-218be777812b"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("20790215-ec2f-466d-87d3-1eb33e47981c"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("90ec0370-9d26-472d-981c-edd32f66c176"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("9e28ec12-e4b6-4017-8d88-711ccf716e1a"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("b47024fc-ca53-4b22-8a90-ca4b3672e2b8"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("2a393d00-fa21-456e-ab3c-d7a24f7a7d06"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("97381031-9c33-4495-a3e1-5112718abfcc"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("78fd97ac-be26-4ea1-997c-2b71e306fdd1"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("b1d597fa-aa4c-4895-aadc-f3c7044c96d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("153b5de0-c083-43da-bd08-39ebf52a2aaa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95c5edce-b0d6-46d9-9e1f-274ca9d4a20a"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4bf10957-c74c-4cbc-a3e2-101edf2c5c91"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("4cf3ad09-b33a-4dff-a4cf-ae216857a12e"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("80f9416a-0437-4866-b9bd-6361242bcd57"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("881a9280-dc5a-4633-9ee1-495973f9866e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2a840a3f-bab3-4898-8256-4b899a4e11e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74ba6fae-9f0b-47bc-8c35-099adae59190"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("65890000-8e91-4c87-85ae-e53fe8c126d5"), "Samsung" },
                    { new Guid("f9deed5e-0fc5-45cb-b4b6-818797de0dab"), "Apple" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b81e92c-11db-44a6-b5f9-736c1a73b352"), "Computer & Tablets" },
                    { new Guid("61f180f4-47ed-4fe8-8e9d-03e076ed2ba8"), "Audio & video" },
                    { new Guid("e48343cb-e086-461b-96c7-7b7bcc2beea2"), "Mobile phones & Accessories" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6c5d393d-17d6-470e-8a01-4690745f2f63"), "Color" },
                    { new Guid("8bc74995-9635-47b2-ae3a-67cbed8fb038"), "Display technology" },
                    { new Guid("e86c2ec2-4258-4ca4-a760-3ac757db1021"), "Screen size" },
                    { new Guid("ede5775e-9ac0-475a-b7d5-1937e7bffa11"), "Storage" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { new Guid("32784cf7-88da-4525-bcb8-7002793058e9"), new Guid("e48343cb-e086-461b-96c7-7b7bcc2beea2"), "Smartphones" },
                    { new Guid("3310e87b-8e76-4c53-ac56-b3143b072e6b"), new Guid("1b81e92c-11db-44a6-b5f9-736c1a73b352"), "Portable computers" },
                    { new Guid("605496f1-894a-4bff-9e77-d0bd11350d15"), new Guid("61f180f4-47ed-4fe8-8e9d-03e076ed2ba8"), "Headphones" },
                    { new Guid("ae1fc360-ad1b-4d28-aa17-1044aa610b69"), new Guid("e48343cb-e086-461b-96c7-7b7bcc2beea2"), "Wearables" },
                    { new Guid("d5c0ff69-ce62-4fc6-bcc7-a662837e3332"), new Guid("61f180f4-47ed-4fe8-8e9d-03e076ed2ba8"), "Televisions" },
                    { new Guid("f4ac92df-9dc3-4074-bd73-fcd203e586fb"), new Guid("1b81e92c-11db-44a6-b5f9-736c1a73b352"), "Desktop computers" }
                });

            migrationBuilder.InsertData(
                table: "SubFeatures",
                columns: new[] { "Id", "FeatureId", "Value" },
                values: new object[,]
                {
                    { new Guid("30d49318-0022-457c-b57b-1e13a4777728"), new Guid("6c5d393d-17d6-470e-8a01-4690745f2f63"), "Black" },
                    { new Guid("3eec4e77-0f20-4922-82e1-58cfeff0aef2"), new Guid("e86c2ec2-4258-4ca4-a760-3ac757db1021"), "15.6" },
                    { new Guid("6aa8652d-bc81-489d-815b-c96fb495107d"), new Guid("8bc74995-9635-47b2-ae3a-67cbed8fb038"), "LCD" },
                    { new Guid("878f7abb-d1cd-4233-bb51-5ff86d18dcb4"), new Guid("ede5775e-9ac0-475a-b7d5-1937e7bffa11"), "256 GB" },
                    { new Guid("8dac1f07-d83b-43af-9c15-8e285f716d3a"), new Guid("8bc74995-9635-47b2-ae3a-67cbed8fb038"), "LED" },
                    { new Guid("90db00cd-f799-4070-b18c-e6a39bf92053"), new Guid("6c5d393d-17d6-470e-8a01-4690745f2f63"), "Green" },
                    { new Guid("9d444760-7964-4971-ade1-893f8c27ce45"), new Guid("ede5775e-9ac0-475a-b7d5-1937e7bffa11"), "1 TB" },
                    { new Guid("a260eb86-718e-4c91-beea-a524becd91b1"), new Guid("e86c2ec2-4258-4ca4-a760-3ac757db1021"), "6" },
                    { new Guid("a5fb4233-4539-4e39-8ca1-b43b467b1dad"), new Guid("e86c2ec2-4258-4ca4-a760-3ac757db1021"), "55" },
                    { new Guid("bc09ed7d-d686-4ad0-a7a2-9e5588f79240"), new Guid("ede5775e-9ac0-475a-b7d5-1937e7bffa11"), "128 GB" },
                    { new Guid("e4aeeca4-9c5e-4fb6-9487-2f528bf4acd3"), new Guid("6c5d393d-17d6-470e-8a01-4690745f2f63"), "Red" },
                    { new Guid("f5cd8297-78a0-4ac8-919b-ee553032a855"), new Guid("8bc74995-9635-47b2-ae3a-67cbed8fb038"), "OLED" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedAt", "Description", "Name", "SubCategoryId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0f9ddaed-eaaa-45f6-9ba0-88f8abb5697e"), new Guid("f9deed5e-0fc5-45cb-b4b6-818797de0dab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple's premium laptop", "MacBook Pro", new Guid("3310e87b-8e76-4c53-ac56-b3143b072e6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7501c64f-4dbf-43c8-8521-5941d65e1e42"), new Guid("65890000-8e91-4c87-85ae-e53fe8c126d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung's flagship smartphone", "Galaxy S21", new Guid("32784cf7-88da-4525-bcb8-7002793058e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Price", "ProductId", "Sku", "Stock" },
                values: new object[,]
                {
                    { new Guid("808935ec-4b06-4f6f-b3aa-9fcb3ee1fe6d"), 2499.99m, new Guid("0f9ddaed-eaaa-45f6-9ba0-88f8abb5697e"), "MBP-16-2023", 100 },
                    { new Guid("954e45cf-689a-4a14-b18d-ea1370fa5b10"), 1499.99m, new Guid("7501c64f-4dbf-43c8-8521-5941d65e1e42"), "GX-24-2023", 50 }
                });

            migrationBuilder.InsertData(
                table: "ProductItemSubFeatures",
                columns: new[] { "ProductItemId", "SubFeatureId" },
                values: new object[,]
                {
                    { new Guid("808935ec-4b06-4f6f-b3aa-9fcb3ee1fe6d"), new Guid("30d49318-0022-457c-b57b-1e13a4777728") },
                    { new Guid("954e45cf-689a-4a14-b18d-ea1370fa5b10"), new Guid("30d49318-0022-457c-b57b-1e13a4777728") },
                    { new Guid("808935ec-4b06-4f6f-b3aa-9fcb3ee1fe6d"), new Guid("bc09ed7d-d686-4ad0-a7a2-9e5588f79240") },
                    { new Guid("954e45cf-689a-4a14-b18d-ea1370fa5b10"), new Guid("bc09ed7d-d686-4ad0-a7a2-9e5588f79240") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("808935ec-4b06-4f6f-b3aa-9fcb3ee1fe6d"), new Guid("30d49318-0022-457c-b57b-1e13a4777728") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("954e45cf-689a-4a14-b18d-ea1370fa5b10"), new Guid("30d49318-0022-457c-b57b-1e13a4777728") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("808935ec-4b06-4f6f-b3aa-9fcb3ee1fe6d"), new Guid("bc09ed7d-d686-4ad0-a7a2-9e5588f79240") });

            migrationBuilder.DeleteData(
                table: "ProductItemSubFeatures",
                keyColumns: new[] { "ProductItemId", "SubFeatureId" },
                keyValues: new object[] { new Guid("954e45cf-689a-4a14-b18d-ea1370fa5b10"), new Guid("bc09ed7d-d686-4ad0-a7a2-9e5588f79240") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("605496f1-894a-4bff-9e77-d0bd11350d15"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("ae1fc360-ad1b-4d28-aa17-1044aa610b69"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5c0ff69-ce62-4fc6-bcc7-a662837e3332"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4ac92df-9dc3-4074-bd73-fcd203e586fb"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("3eec4e77-0f20-4922-82e1-58cfeff0aef2"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("6aa8652d-bc81-489d-815b-c96fb495107d"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("878f7abb-d1cd-4233-bb51-5ff86d18dcb4"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("8dac1f07-d83b-43af-9c15-8e285f716d3a"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("90db00cd-f799-4070-b18c-e6a39bf92053"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("9d444760-7964-4971-ade1-893f8c27ce45"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("a260eb86-718e-4c91-beea-a524becd91b1"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("a5fb4233-4539-4e39-8ca1-b43b467b1dad"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("e4aeeca4-9c5e-4fb6-9487-2f528bf4acd3"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("f5cd8297-78a0-4ac8-919b-ee553032a855"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("61f180f4-47ed-4fe8-8e9d-03e076ed2ba8"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("8bc74995-9635-47b2-ae3a-67cbed8fb038"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("e86c2ec2-4258-4ca4-a760-3ac757db1021"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("808935ec-4b06-4f6f-b3aa-9fcb3ee1fe6d"));

            migrationBuilder.DeleteData(
                table: "ProductItems",
                keyColumn: "Id",
                keyValue: new Guid("954e45cf-689a-4a14-b18d-ea1370fa5b10"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("30d49318-0022-457c-b57b-1e13a4777728"));

            migrationBuilder.DeleteData(
                table: "SubFeatures",
                keyColumn: "Id",
                keyValue: new Guid("bc09ed7d-d686-4ad0-a7a2-9e5588f79240"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("6c5d393d-17d6-470e-8a01-4690745f2f63"));

            migrationBuilder.DeleteData(
                table: "Features",
                keyColumn: "Id",
                keyValue: new Guid("ede5775e-9ac0-475a-b7d5-1937e7bffa11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f9ddaed-eaaa-45f6-9ba0-88f8abb5697e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7501c64f-4dbf-43c8-8521-5941d65e1e42"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("65890000-8e91-4c87-85ae-e53fe8c126d5"));

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: new Guid("f9deed5e-0fc5-45cb-b4b6-818797de0dab"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("32784cf7-88da-4525-bcb8-7002793058e9"));

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: new Guid("3310e87b-8e76-4c53-ac56-b3143b072e6b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b81e92c-11db-44a6-b5f9-736c1a73b352"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e48343cb-e086-461b-96c7-7b7bcc2beea2"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4bf10957-c74c-4cbc-a3e2-101edf2c5c91"), "Samsung" },
                    { new Guid("4cf3ad09-b33a-4dff-a4cf-ae216857a12e"), "Apple" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2a840a3f-bab3-4898-8256-4b899a4e11e6"), "Computer & Tablets" },
                    { new Guid("74ba6fae-9f0b-47bc-8c35-099adae59190"), "Mobile phones & Accessories" },
                    { new Guid("f4a0f85d-ddfd-431e-a5a3-218be777812b"), "Audio & video" }
                });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("20790215-ec2f-466d-87d3-1eb33e47981c"), "Display technology" },
                    { new Guid("78fd97ac-be26-4ea1-997c-2b71e306fdd1"), "Color" },
                    { new Guid("90ec0370-9d26-472d-981c-edd32f66c176"), "Screen size" },
                    { new Guid("b1d597fa-aa4c-4895-aadc-f3c7044c96d6"), "Storage" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "Value" },
                values: new object[,]
                {
                    { new Guid("3b89ff21-09f0-435b-9ce3-733ff103802d"), new Guid("f4a0f85d-ddfd-431e-a5a3-218be777812b"), "Headphones" },
                    { new Guid("6d3d59d4-c8ff-40c3-b3ef-d48495f967a4"), new Guid("f4a0f85d-ddfd-431e-a5a3-218be777812b"), "Televisions" },
                    { new Guid("80f9416a-0437-4866-b9bd-6361242bcd57"), new Guid("74ba6fae-9f0b-47bc-8c35-099adae59190"), "Smartphones" },
                    { new Guid("8471ff39-fff3-4d22-9785-e2da3459f0fc"), new Guid("2a840a3f-bab3-4898-8256-4b899a4e11e6"), "Desktop computers" },
                    { new Guid("881a9280-dc5a-4633-9ee1-495973f9866e"), new Guid("2a840a3f-bab3-4898-8256-4b899a4e11e6"), "Portable computers" },
                    { new Guid("c2ddb826-3e48-4ec9-a1ac-f31b61e0c484"), new Guid("74ba6fae-9f0b-47bc-8c35-099adae59190"), "Wearables" }
                });

            migrationBuilder.InsertData(
                table: "SubFeatures",
                columns: new[] { "Id", "FeatureId", "Value" },
                values: new object[,]
                {
                    { new Guid("1b98e4ec-db65-45a3-8386-77f8e8e3d069"), new Guid("20790215-ec2f-466d-87d3-1eb33e47981c"), "OLED" },
                    { new Guid("2a393d00-fa21-456e-ab3c-d7a24f7a7d06"), new Guid("78fd97ac-be26-4ea1-997c-2b71e306fdd1"), "Black" },
                    { new Guid("5cc262c8-97ef-49ee-8237-f537eba10a65"), new Guid("90ec0370-9d26-472d-981c-edd32f66c176"), "55" },
                    { new Guid("7816e36b-4036-4f35-b78b-6083ef5ba8ee"), new Guid("20790215-ec2f-466d-87d3-1eb33e47981c"), "LCD" },
                    { new Guid("7fdce65f-7160-40af-a257-a9e845f3fdef"), new Guid("78fd97ac-be26-4ea1-997c-2b71e306fdd1"), "Green" },
                    { new Guid("897ac5d7-dde9-48e8-bbed-3d67f52f2a22"), new Guid("20790215-ec2f-466d-87d3-1eb33e47981c"), "LED" },
                    { new Guid("8b4039db-eb83-4b47-a110-c7dcb67c7cd2"), new Guid("78fd97ac-be26-4ea1-997c-2b71e306fdd1"), "Red" },
                    { new Guid("92580012-739e-4723-834c-9591b9fe5074"), new Guid("90ec0370-9d26-472d-981c-edd32f66c176"), "6" },
                    { new Guid("97381031-9c33-4495-a3e1-5112718abfcc"), new Guid("b1d597fa-aa4c-4895-aadc-f3c7044c96d6"), "128 GB" },
                    { new Guid("99957586-9832-474e-a747-8f87f37aa2ff"), new Guid("b1d597fa-aa4c-4895-aadc-f3c7044c96d6"), "256 GB" },
                    { new Guid("ad94f789-d72e-4a94-b6cb-412d75bb255b"), new Guid("b1d597fa-aa4c-4895-aadc-f3c7044c96d6"), "1 TB" },
                    { new Guid("c9a5243a-1960-4e54-ada7-18736ebc23d6"), new Guid("90ec0370-9d26-472d-981c-edd32f66c176"), "15.6" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "Description", "Name", "SubCategoryId" },
                values: new object[,]
                {
                    { new Guid("153b5de0-c083-43da-bd08-39ebf52a2aaa"), new Guid("4cf3ad09-b33a-4dff-a4cf-ae216857a12e"), "Apple's premium laptop", "MacBook Pro", new Guid("881a9280-dc5a-4633-9ee1-495973f9866e") },
                    { new Guid("95c5edce-b0d6-46d9-9e1f-274ca9d4a20a"), new Guid("4bf10957-c74c-4cbc-a3e2-101edf2c5c91"), "Samsung's flagship smartphone", "Galaxy S21", new Guid("80f9416a-0437-4866-b9bd-6361242bcd57") }
                });

            migrationBuilder.InsertData(
                table: "ProductItems",
                columns: new[] { "Id", "Price", "ProductId", "Sku", "Stock" },
                values: new object[,]
                {
                    { new Guid("9e28ec12-e4b6-4017-8d88-711ccf716e1a"), 1499.99m, new Guid("95c5edce-b0d6-46d9-9e1f-274ca9d4a20a"), "GX-24-2023", 50 },
                    { new Guid("b47024fc-ca53-4b22-8a90-ca4b3672e2b8"), 2499.99m, new Guid("153b5de0-c083-43da-bd08-39ebf52a2aaa"), "MBP-16-2023", 100 }
                });

            migrationBuilder.InsertData(
                table: "ProductItemSubFeatures",
                columns: new[] { "ProductItemId", "SubFeatureId" },
                values: new object[,]
                {
                    { new Guid("9e28ec12-e4b6-4017-8d88-711ccf716e1a"), new Guid("2a393d00-fa21-456e-ab3c-d7a24f7a7d06") },
                    { new Guid("b47024fc-ca53-4b22-8a90-ca4b3672e2b8"), new Guid("2a393d00-fa21-456e-ab3c-d7a24f7a7d06") },
                    { new Guid("9e28ec12-e4b6-4017-8d88-711ccf716e1a"), new Guid("97381031-9c33-4495-a3e1-5112718abfcc") },
                    { new Guid("b47024fc-ca53-4b22-8a90-ca4b3672e2b8"), new Guid("97381031-9c33-4495-a3e1-5112718abfcc") }
                });
        }
    }
}
