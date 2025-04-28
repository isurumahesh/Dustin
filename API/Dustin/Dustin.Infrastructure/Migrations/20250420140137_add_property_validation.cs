using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Dustin.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class add_property_validation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "SubFeatures",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "SubCategories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "ProductItems",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Features",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "SubFeatures",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Sku",
                table: "ProductItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
