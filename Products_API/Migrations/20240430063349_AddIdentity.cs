using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Products_API.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Products",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Products",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "Products",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Products",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "Products",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Products",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Products",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "Products",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "Products",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Products",
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Photo", "Price", "QuantityInStock" },
                values: new object[,]
                {
                    { new Guid("1474695d-8917-4eb1-885f-51405e84c328"), "Accessories", "Backpack", "", 39.99m, 60 },
                    { new Guid("2bcffbf6-c7ee-4697-bddb-51edf8392020"), "Electronics", "Laptop", "", 999.99m, 15 },
                    { new Guid("527b6054-7333-4df8-8611-763d2287655d"), "Home Office", "Desk Lamp", "", 29.99m, 20 },
                    { new Guid("6488084c-0361-4073-ba32-c9238b135ea3"), "Electronics", "Bluetooth Speaker", "", 89.99m, 18 },
                    { new Guid("6ff420f0-3aa8-4175-818d-69ee902c2eeb"), "Electronics", "Headphones", "", 49.99m, 30 },
                    { new Guid("7241af14-83eb-4bb2-a540-fe857cfe1f4e"), "Kitchen", "Cooking Utensils Set", "", 29.99m, 25 },
                    { new Guid("72caf547-182a-4f7e-9e66-9792dacd3850"), "Electronics", "Power Bank", "", 49.99m, 40 },
                    { new Guid("780daec1-d4b0-40a2-86e0-33d36f0c4ee5"), "Fitness", "Yoga Mat", "", 24.99m, 35 },
                    { new Guid("a7252c47-5b66-4d00-9341-ebcac68cdda6"), "Footwear", "Running Shoes", "", 79.99m, 40 },
                    { new Guid("b21450c0-b711-474c-b54d-a8ecc371994c"), "Stationery", "Pencil Set", "", 7.99m, 80 },
                    { new Guid("c1e04c29-b842-4361-bd4a-f408ba388a4b"), "Electronics", "External Hard Drive", "", 129.99m, 10 },
                    { new Guid("c20ef97c-484b-4a0d-8ce5-e9afbf6277c0"), "Stationery", "Notebook", "", 4.99m, 120 },
                    { new Guid("c64f5e43-368b-4973-aea7-15ba1b7dafa8"), "Apparel", "T-shirt", "", 12.99m, 50 },
                    { new Guid("cc7ee6ef-9f08-4d46-8429-241ad088c83b"), "Accessories", "Sunglasses", "", 59.99m, 45 },
                    { new Guid("d4e49fe7-0d5a-41f6-a0c0-43d1637a237f"), "Gardening", "Gardening Gloves", "", 14.99m, 55 },
                    { new Guid("dc92d008-c4c2-45f4-aa3a-eca93ca67c5b"), "Furniture", "Gaming Chair", "", 199.99m, 5 },
                    { new Guid("e204027b-7edb-4eb5-b58b-e3aa351213e4"), "Kitchen", "Coffee Mug", "", 9.99m, 75 },
                    { new Guid("eab5e86c-4806-42c4-9d9e-39abf9f674ad"), "Electronics", "Smartphone", "", 699.99m, 25 },
                    { new Guid("faa7abda-f35f-43ea-95a5-8d85168d71b7"), "Travel", "Hiking Backpack", "", 69.99m, 30 },
                    { new Guid("ff82e9c7-cc1a-4075-ae64-90bafb30810a"), "Education", "Book", "", 19.99m, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "Products",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "Products",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "Products",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "Products",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "Products",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "Products",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "Products",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "Products");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "Products");

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1474695d-8917-4eb1-885f-51405e84c328"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2bcffbf6-c7ee-4697-bddb-51edf8392020"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("527b6054-7333-4df8-8611-763d2287655d"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6488084c-0361-4073-ba32-c9238b135ea3"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ff420f0-3aa8-4175-818d-69ee902c2eeb"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7241af14-83eb-4bb2-a540-fe857cfe1f4e"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72caf547-182a-4f7e-9e66-9792dacd3850"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("780daec1-d4b0-40a2-86e0-33d36f0c4ee5"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a7252c47-5b66-4d00-9341-ebcac68cdda6"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b21450c0-b711-474c-b54d-a8ecc371994c"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1e04c29-b842-4361-bd4a-f408ba388a4b"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c20ef97c-484b-4a0d-8ce5-e9afbf6277c0"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c64f5e43-368b-4973-aea7-15ba1b7dafa8"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cc7ee6ef-9f08-4d46-8429-241ad088c83b"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d4e49fe7-0d5a-41f6-a0c0-43d1637a237f"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc92d008-c4c2-45f4-aa3a-eca93ca67c5b"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e204027b-7edb-4eb5-b58b-e3aa351213e4"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eab5e86c-4806-42c4-9d9e-39abf9f674ad"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("faa7abda-f35f-43ea-95a5-8d85168d71b7"));

            migrationBuilder.DeleteData(
                schema: "Products",
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff82e9c7-cc1a-4075-ae64-90bafb30810a"));

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
    }
}
