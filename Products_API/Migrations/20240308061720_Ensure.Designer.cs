﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Products_API.Data;

#nullable disable

namespace Products_API.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20240308061720_Ensure")]
    partial class Ensure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Products")
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Products_API.Data.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products", "Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("def0e035-4ddd-4b0a-b486-54d0a0dd46d5"),
                            Category = "Electronics",
                            Name = "Laptop",
                            Photo = "",
                            Price = 999.99m,
                            QuantityInStock = 15
                        },
                        new
                        {
                            Id = new Guid("99c08740-b6c9-4e3d-bdf8-d76663aca988"),
                            Category = "Education",
                            Name = "Book",
                            Photo = "",
                            Price = 19.99m,
                            QuantityInStock = 100
                        },
                        new
                        {
                            Id = new Guid("795c83b4-c96e-4fdd-827b-cb853ba8744b"),
                            Category = "Electronics",
                            Name = "Headphones",
                            Photo = "",
                            Price = 49.99m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = new Guid("c5946c14-d71f-4b79-a671-0b4f0be7bd8d"),
                            Category = "Apparel",
                            Name = "T-shirt",
                            Photo = "",
                            Price = 12.99m,
                            QuantityInStock = 50
                        },
                        new
                        {
                            Id = new Guid("f2b7ee41-5789-4734-9efb-c932592bca8f"),
                            Category = "Electronics",
                            Name = "Smartphone",
                            Photo = "",
                            Price = 699.99m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = new Guid("1120be38-e897-46b4-9011-b232a4a48431"),
                            Category = "Kitchen",
                            Name = "Coffee Mug",
                            Photo = "",
                            Price = 9.99m,
                            QuantityInStock = 75
                        },
                        new
                        {
                            Id = new Guid("f9dff800-437d-4c85-86b2-298fd75f6011"),
                            Category = "Home Office",
                            Name = "Desk Lamp",
                            Photo = "",
                            Price = 29.99m,
                            QuantityInStock = 20
                        },
                        new
                        {
                            Id = new Guid("68a8e963-0346-4d85-84ab-d23746c56a4e"),
                            Category = "Footwear",
                            Name = "Running Shoes",
                            Photo = "",
                            Price = 79.99m,
                            QuantityInStock = 40
                        },
                        new
                        {
                            Id = new Guid("69777be2-869c-4ac5-8fc1-73f6f1ae27d4"),
                            Category = "Accessories",
                            Name = "Backpack",
                            Photo = "",
                            Price = 39.99m,
                            QuantityInStock = 60
                        },
                        new
                        {
                            Id = new Guid("aac29d12-b713-47b6-95ef-76ab598259d1"),
                            Category = "Electronics",
                            Name = "External Hard Drive",
                            Photo = "",
                            Price = 129.99m,
                            QuantityInStock = 10
                        },
                        new
                        {
                            Id = new Guid("262b1fda-ba35-4a66-87d8-0ca0fd282346"),
                            Category = "Fitness",
                            Name = "Yoga Mat",
                            Photo = "",
                            Price = 24.99m,
                            QuantityInStock = 35
                        },
                        new
                        {
                            Id = new Guid("66f2396e-3fe0-4717-8759-01fdeb259574"),
                            Category = "Stationery",
                            Name = "Pencil Set",
                            Photo = "",
                            Price = 7.99m,
                            QuantityInStock = 80
                        },
                        new
                        {
                            Id = new Guid("f6fb985c-c3e5-4c39-94c2-aafd63ae55a3"),
                            Category = "Furniture",
                            Name = "Gaming Chair",
                            Photo = "",
                            Price = 199.99m,
                            QuantityInStock = 5
                        },
                        new
                        {
                            Id = new Guid("6d5ceb81-5fc7-4ea6-a758-3bcc58c18d5d"),
                            Category = "Accessories",
                            Name = "Sunglasses",
                            Photo = "",
                            Price = 59.99m,
                            QuantityInStock = 45
                        },
                        new
                        {
                            Id = new Guid("aaa2e9dd-8d74-4f63-83be-7e39210c1b33"),
                            Category = "Electronics",
                            Name = "Bluetooth Speaker",
                            Photo = "",
                            Price = 89.99m,
                            QuantityInStock = 18
                        },
                        new
                        {
                            Id = new Guid("7f990d18-ac89-428f-8a19-d2ea68930533"),
                            Category = "Stationery",
                            Name = "Notebook",
                            Photo = "",
                            Price = 4.99m,
                            QuantityInStock = 120
                        },
                        new
                        {
                            Id = new Guid("e2be478e-3d72-4505-b3b2-b74377ed891d"),
                            Category = "Gardening",
                            Name = "Gardening Gloves",
                            Photo = "",
                            Price = 14.99m,
                            QuantityInStock = 55
                        },
                        new
                        {
                            Id = new Guid("c65aee82-fd64-4246-84d5-5cd122773ce3"),
                            Category = "Kitchen",
                            Name = "Cooking Utensils Set",
                            Photo = "",
                            Price = 29.99m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = new Guid("a467fc67-4bf1-43b7-a1db-1fe8670b0a12"),
                            Category = "Travel",
                            Name = "Hiking Backpack",
                            Photo = "",
                            Price = 69.99m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = new Guid("03aa37da-5134-4305-b422-3d6e0b9ad552"),
                            Category = "Electronics",
                            Name = "Power Bank",
                            Photo = "",
                            Price = 49.99m,
                            QuantityInStock = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}