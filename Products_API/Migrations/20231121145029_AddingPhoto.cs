using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products_API.Migrations
{
    /// <inheritdoc />
    public partial class AddingPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0c4b94b8-65db-4437-b663-e83cbe28f244"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1245e4e6-c4ca-47c1-879f-bd45021375ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("190edce0-9e84-4454-9afb-87995331f05a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21edae4d-36e0-4524-9eb6-62671cfb5416"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2930ecb3-010c-416f-9732-82b0a4ef6d87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("340b6c19-bb97-497b-be9b-c827bc47dc82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40738584-3fd5-4b4f-9b9c-83ea211a04cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("529b956c-e3cb-4df1-a121-e0204bfaabbe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5fd89dee-1488-47f4-866d-5534893c6536"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cc7b047-80b1-49d2-a1fb-55a62baf83f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73d0cf05-6c04-43eb-9d58-ec7420ea6049"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d8e6db8-ca0e-46a3-bf07-9321e91bb9f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84c984eb-08c1-4e95-864f-95f2869a95ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("867ff752-5983-477f-baf4-c67626e73f21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("96197103-789c-4317-b9d9-3c7fdb39ee4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9719c292-29e3-415e-9f89-049be9ea477f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b65ecacb-ef4f-4a7f-8500-608485cb3242"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ca881095-16b0-461c-90f3-6176b1bfaf41"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb6b4d2a-44e5-4121-af59-6cbac24a1c2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d103b304-7f5c-4c3f-8f21-20650b789327"));

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { new Guid("0c4b94b8-65db-4437-b663-e83cbe28f244"), "Electronics", "Laptop", 999.99m, 15 },
                    { new Guid("1245e4e6-c4ca-47c1-879f-bd45021375ad"), "Education", "Book", 19.99m, 100 },
                    { new Guid("190edce0-9e84-4454-9afb-87995331f05a"), "Travel", "Hiking Backpack", 69.99m, 30 },
                    { new Guid("21edae4d-36e0-4524-9eb6-62671cfb5416"), "Electronics", "Power Bank", 49.99m, 40 },
                    { new Guid("2930ecb3-010c-416f-9732-82b0a4ef6d87"), "Home Office", "Desk Lamp", 29.99m, 20 },
                    { new Guid("340b6c19-bb97-497b-be9b-c827bc47dc82"), "Footwear", "Running Shoes", 79.99m, 40 },
                    { new Guid("40738584-3fd5-4b4f-9b9c-83ea211a04cf"), "Kitchen", "Cooking Utensils Set", 29.99m, 25 },
                    { new Guid("529b956c-e3cb-4df1-a121-e0204bfaabbe"), "Fitness", "Yoga Mat", 24.99m, 35 },
                    { new Guid("5fd89dee-1488-47f4-866d-5534893c6536"), "Stationery", "Notebook", 4.99m, 120 },
                    { new Guid("6cc7b047-80b1-49d2-a1fb-55a62baf83f9"), "Furniture", "Gaming Chair", 199.99m, 5 },
                    { new Guid("73d0cf05-6c04-43eb-9d58-ec7420ea6049"), "Electronics", "Smartphone", 699.99m, 25 },
                    { new Guid("7d8e6db8-ca0e-46a3-bf07-9321e91bb9f8"), "Apparel", "T-shirt", 12.99m, 50 },
                    { new Guid("84c984eb-08c1-4e95-864f-95f2869a95ec"), "Electronics", "Headphones", 49.99m, 30 },
                    { new Guid("867ff752-5983-477f-baf4-c67626e73f21"), "Stationery", "Pencil Set", 7.99m, 80 },
                    { new Guid("96197103-789c-4317-b9d9-3c7fdb39ee4d"), "Kitchen", "Coffee Mug", 9.99m, 75 },
                    { new Guid("9719c292-29e3-415e-9f89-049be9ea477f"), "Electronics", "External Hard Drive", 129.99m, 10 },
                    { new Guid("b65ecacb-ef4f-4a7f-8500-608485cb3242"), "Electronics", "Bluetooth Speaker", 89.99m, 18 },
                    { new Guid("ca881095-16b0-461c-90f3-6176b1bfaf41"), "Accessories", "Backpack", 39.99m, 60 },
                    { new Guid("cb6b4d2a-44e5-4121-af59-6cbac24a1c2f"), "Accessories", "Sunglasses", 59.99m, 45 },
                    { new Guid("d103b304-7f5c-4c3f-8f21-20650b789327"), "Gardening", "Gardening Gloves", 14.99m, 55 }
                });
        }
    }
}
