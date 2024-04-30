using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products_API.Migrations
{
    /// <inheritdoc />
    public partial class Ensure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0353626d-87f2-4298-b586-622a3178cc58"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2152fdec-0848-4cf4-a196-0ec494f78de6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26b2934c-227d-44d6-9cec-703de7358cd8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3707d1e4-24a2-4de3-a21b-fec58a2e3636"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a22f41f-05eb-4e4c-a78a-028ddb664308"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4096716f-ef86-49e7-9841-b6eb555a1539"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a294bce-cd42-4ba3-9077-1fe0fadc7b18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("55454457-1d2a-436d-9486-be8bc29bef93"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5da4e262-05d4-4e28-bb85-5b232721931d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("762d5f2e-f41c-411d-83a2-5197b1245570"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79c3763f-ecd9-4624-b15b-c980c36ab384"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af3cbc70-13dd-4f53-9318-ff11557693b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b1383b11-647f-44dd-ba0d-6e640b903a69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("babba11a-cc8b-4caa-9a13-e4a63f1e713f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6df95d1-b096-4212-b019-9d981e576626"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9e06bd4-1b6a-4604-a9eb-44979fd0fb89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f1abfbe1-5afc-47da-85d9-9ba92fc887b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f86bca1e-ac2c-42a8-9f81-5c0cad4b42c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb6d3078-aba8-40f4-a43e-a1a1d69ba7f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fe3d1622-28aa-4106-b7dd-62536786e313"));

            migrationBuilder.EnsureSchema(
                name: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "Products");

            migrationBuilder.InsertData(
                schema: "Products",
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Photo", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { new Guid("03aa37da-5134-4305-b422-3d6e0b9ad552"), "Electronics", "Power Bank", "", 49.99m, 40 },
                    { new Guid("1120be38-e897-46b4-9011-b232a4a48431"), "Kitchen", "Coffee Mug", "", 9.99m, 75 },
                    { new Guid("262b1fda-ba35-4a66-87d8-0ca0fd282346"), "Fitness", "Yoga Mat", "", 24.99m, 35 },
                    { new Guid("66f2396e-3fe0-4717-8759-01fdeb259574"), "Stationery", "Pencil Set", "", 7.99m, 80 },
                    { new Guid("68a8e963-0346-4d85-84ab-d23746c56a4e"), "Footwear", "Running Shoes", "", 79.99m, 40 },
                    { new Guid("69777be2-869c-4ac5-8fc1-73f6f1ae27d4"), "Accessories", "Backpack", "", 39.99m, 60 },
                    { new Guid("6d5ceb81-5fc7-4ea6-a758-3bcc58c18d5d"), "Accessories", "Sunglasses", "", 59.99m, 45 },
                    { new Guid("795c83b4-c96e-4fdd-827b-cb853ba8744b"), "Electronics", "Headphones", "", 49.99m, 30 },
                    { new Guid("7f990d18-ac89-428f-8a19-d2ea68930533"), "Stationery", "Notebook", "", 4.99m, 120 },
                    { new Guid("99c08740-b6c9-4e3d-bdf8-d76663aca988"), "Education", "Book", "", 19.99m, 100 },
                    { new Guid("a467fc67-4bf1-43b7-a1db-1fe8670b0a12"), "Travel", "Hiking Backpack", "", 69.99m, 30 },
                    { new Guid("aaa2e9dd-8d74-4f63-83be-7e39210c1b33"), "Electronics", "Bluetooth Speaker", "", 89.99m, 18 },
                    { new Guid("aac29d12-b713-47b6-95ef-76ab598259d1"), "Electronics", "External Hard Drive", "", 129.99m, 10 },
                    { new Guid("c5946c14-d71f-4b79-a671-0b4f0be7bd8d"), "Apparel", "T-shirt", "", 12.99m, 50 },
                    { new Guid("c65aee82-fd64-4246-84d5-5cd122773ce3"), "Kitchen", "Cooking Utensils Set", "", 29.99m, 25 },
                    { new Guid("def0e035-4ddd-4b0a-b486-54d0a0dd46d5"), "Electronics", "Laptop", "", 999.99m, 15 },
                    { new Guid("e2be478e-3d72-4505-b3b2-b74377ed891d"), "Gardening", "Gardening Gloves", "", 14.99m, 55 },
                    { new Guid("f2b7ee41-5789-4734-9efb-c932592bca8f"), "Electronics", "Smartphone", "", 699.99m, 25 },
                    { new Guid("f6fb985c-c3e5-4c39-94c2-aafd63ae55a3"), "Furniture", "Gaming Chair", "", 199.99m, 5 },
                    { new Guid("f9dff800-437d-4c85-86b2-298fd75f6011"), "Home Office", "Desk Lamp", "", 29.99m, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03aa37da-5134-4305-b422-3d6e0b9ad552"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1120be38-e897-46b4-9011-b232a4a48431"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("262b1fda-ba35-4a66-87d8-0ca0fd282346"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66f2396e-3fe0-4717-8759-01fdeb259574"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("68a8e963-0346-4d85-84ab-d23746c56a4e"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("69777be2-869c-4ac5-8fc1-73f6f1ae27d4"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d5ceb81-5fc7-4ea6-a758-3bcc58c18d5d"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("795c83b4-c96e-4fdd-827b-cb853ba8744b"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7f990d18-ac89-428f-8a19-d2ea68930533"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("99c08740-b6c9-4e3d-bdf8-d76663aca988"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a467fc67-4bf1-43b7-a1db-1fe8670b0a12"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aaa2e9dd-8d74-4f63-83be-7e39210c1b33"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aac29d12-b713-47b6-95ef-76ab598259d1"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5946c14-d71f-4b79-a671-0b4f0be7bd8d"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c65aee82-fd64-4246-84d5-5cd122773ce3"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("def0e035-4ddd-4b0a-b486-54d0a0dd46d5"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e2be478e-3d72-4505-b3b2-b74377ed891d"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2b7ee41-5789-4734-9efb-c932592bca8f"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6fb985c-c3e5-4c39-94c2-aafd63ae55a3"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9dff800-437d-4c85-86b2-298fd75f6011"));

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "Products",
                newName: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Photo", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { new Guid("0353626d-87f2-4298-b586-622a3178cc58"), "Travel", "Hiking Backpack", "", 69.99m, 30 },
                    { new Guid("2152fdec-0848-4cf4-a196-0ec494f78de6"), "Apparel", "T-shirt", "", 12.99m, 50 },
                    { new Guid("26b2934c-227d-44d6-9cec-703de7358cd8"), "Electronics", "Laptop", "", 999.99m, 15 },
                    { new Guid("3707d1e4-24a2-4de3-a21b-fec58a2e3636"), "Kitchen", "Coffee Mug", "", 9.99m, 75 },
                    { new Guid("3a22f41f-05eb-4e4c-a78a-028ddb664308"), "Electronics", "Smartphone", "", 699.99m, 25 },
                    { new Guid("4096716f-ef86-49e7-9841-b6eb555a1539"), "Electronics", "External Hard Drive", "", 129.99m, 10 },
                    { new Guid("4a294bce-cd42-4ba3-9077-1fe0fadc7b18"), "Electronics", "Headphones", "", 49.99m, 30 },
                    { new Guid("55454457-1d2a-436d-9486-be8bc29bef93"), "Fitness", "Yoga Mat", "", 24.99m, 35 },
                    { new Guid("5da4e262-05d4-4e28-bb85-5b232721931d"), "Accessories", "Sunglasses", "", 59.99m, 45 },
                    { new Guid("762d5f2e-f41c-411d-83a2-5197b1245570"), "Electronics", "Power Bank", "", 49.99m, 40 },
                    { new Guid("79c3763f-ecd9-4624-b15b-c980c36ab384"), "Gardening", "Gardening Gloves", "", 14.99m, 55 },
                    { new Guid("af3cbc70-13dd-4f53-9318-ff11557693b1"), "Accessories", "Backpack", "", 39.99m, 60 },
                    { new Guid("b1383b11-647f-44dd-ba0d-6e640b903a69"), "Education", "Book", "", 19.99m, 100 },
                    { new Guid("babba11a-cc8b-4caa-9a13-e4a63f1e713f"), "Footwear", "Running Shoes", "", 79.99m, 40 },
                    { new Guid("c6df95d1-b096-4212-b019-9d981e576626"), "Stationery", "Notebook", "", 4.99m, 120 },
                    { new Guid("c9e06bd4-1b6a-4604-a9eb-44979fd0fb89"), "Kitchen", "Cooking Utensils Set", "", 29.99m, 25 },
                    { new Guid("f1abfbe1-5afc-47da-85d9-9ba92fc887b8"), "Home Office", "Desk Lamp", "", 29.99m, 20 },
                    { new Guid("f86bca1e-ac2c-42a8-9f81-5c0cad4b42c4"), "Stationery", "Pencil Set", "", 7.99m, 80 },
                    { new Guid("fb6d3078-aba8-40f4-a43e-a1a1d69ba7f9"), "Electronics", "Bluetooth Speaker", "", 89.99m, 18 },
                    { new Guid("fe3d1622-28aa-4106-b7dd-62536786e313"), "Furniture", "Gaming Chair", "", 199.99m, 5 }
                });
        }
    }
}
