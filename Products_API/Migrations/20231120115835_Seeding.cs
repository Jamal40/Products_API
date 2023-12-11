﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products_API.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { new Guid("0986d321-0898-4140-b3eb-9ac02cc5bdda"), "Gardening", "Gardening Gloves", 14.99m, 55 },
                    { new Guid("10e7ef26-9bc1-4deb-8dd4-1c92a545d419"), "Electronics", "Smartphone", 699.99m, 25 },
                    { new Guid("2c9223e5-f3b9-4a20-9911-763f403b946f"), "Electronics", "Laptop", 999.99m, 15 },
                    { new Guid("2ec9deb7-28cf-40f9-a0fc-74f3d22fc802"), "Accessories", "Backpack", 39.99m, 60 },
                    { new Guid("33ce3209-20a6-487b-94e6-8874012a9d01"), "Electronics", "External Hard Drive", 129.99m, 10 },
                    { new Guid("560fe255-8a78-48f6-8e12-e4fa7ab0b000"), "Electronics", "Bluetooth Speaker", 89.99m, 18 },
                    { new Guid("5dcf0ce9-d2a5-4535-a15f-3f1696a5c3d6"), "Fitness", "Yoga Mat", 24.99m, 35 },
                    { new Guid("61bd2c87-3066-462a-ac24-02fcb3135b6f"), "Electronics", "Power Bank", 49.99m, 40 },
                    { new Guid("832a7b1b-a767-4e9f-8c98-5a48fb697bd8"), "Furniture", "Gaming Chair", 199.99m, 5 },
                    { new Guid("89df4890-222b-4e5f-8678-43cdb1d3d4b0"), "Kitchen", "Coffee Mug", 9.99m, 75 },
                    { new Guid("981e01e3-7a78-4e1c-b053-97834d053bac"), "Travel", "Hiking Backpack", 69.99m, 30 },
                    { new Guid("9b67a9dc-b9d3-4363-aec7-94e632dc388c"), "Education", "Book", 19.99m, 100 },
                    { new Guid("9c340cdb-b873-4580-a37a-aecb8d48d115"), "Kitchen", "Cooking Utensils Set", 29.99m, 25 },
                    { new Guid("a4d48f31-70e1-4296-b29a-4f2716fe49fe"), "Electronics", "Headphones", 49.99m, 30 },
                    { new Guid("b89628e3-688a-4c97-ad2d-913760bc6188"), "Stationery", "Notebook", 4.99m, 120 },
                    { new Guid("cba607e7-f08c-46fe-b85e-7cc65e2dfa3d"), "Accessories", "Sunglasses", 59.99m, 45 },
                    { new Guid("d916f7d0-34ce-4a12-8f92-105fad617bea"), "Stationery", "Pencil Set", 7.99m, 80 },
                    { new Guid("daf8ab6a-7221-49ef-91b5-1b3bdad6887b"), "Home Office", "Desk Lamp", 29.99m, 20 },
                    { new Guid("df87be09-5d49-4eac-81eb-3b05ab850f11"), "Footwear", "Running Shoes", 79.99m, 40 },
                    { new Guid("e29efb0c-fa07-437f-8186-28d0efa54db0"), "Apparel", "T-shirt", 12.99m, 50 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0986d321-0898-4140-b3eb-9ac02cc5bdda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10e7ef26-9bc1-4deb-8dd4-1c92a545d419"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2c9223e5-f3b9-4a20-9911-763f403b946f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ec9deb7-28cf-40f9-a0fc-74f3d22fc802"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("33ce3209-20a6-487b-94e6-8874012a9d01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("560fe255-8a78-48f6-8e12-e4fa7ab0b000"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5dcf0ce9-d2a5-4535-a15f-3f1696a5c3d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61bd2c87-3066-462a-ac24-02fcb3135b6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("832a7b1b-a767-4e9f-8c98-5a48fb697bd8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89df4890-222b-4e5f-8678-43cdb1d3d4b0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("981e01e3-7a78-4e1c-b053-97834d053bac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b67a9dc-b9d3-4363-aec7-94e632dc388c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c340cdb-b873-4580-a37a-aecb8d48d115"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4d48f31-70e1-4296-b29a-4f2716fe49fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b89628e3-688a-4c97-ad2d-913760bc6188"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cba607e7-f08c-46fe-b85e-7cc65e2dfa3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d916f7d0-34ce-4a12-8f92-105fad617bea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("daf8ab6a-7221-49ef-91b5-1b3bdad6887b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("df87be09-5d49-4eac-81eb-3b05ab850f11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e29efb0c-fa07-437f-8186-28d0efa54db0"));
        }
    }
}
