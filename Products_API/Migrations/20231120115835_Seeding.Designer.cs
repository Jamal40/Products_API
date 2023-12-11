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
    [Migration("20231120115835_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2c9223e5-f3b9-4a20-9911-763f403b946f"),
                            Category = "Electronics",
                            Name = "Laptop",
                            Price = 999.99m,
                            QuantityInStock = 15
                        },
                        new
                        {
                            Id = new Guid("9b67a9dc-b9d3-4363-aec7-94e632dc388c"),
                            Category = "Education",
                            Name = "Book",
                            Price = 19.99m,
                            QuantityInStock = 100
                        },
                        new
                        {
                            Id = new Guid("a4d48f31-70e1-4296-b29a-4f2716fe49fe"),
                            Category = "Electronics",
                            Name = "Headphones",
                            Price = 49.99m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = new Guid("e29efb0c-fa07-437f-8186-28d0efa54db0"),
                            Category = "Apparel",
                            Name = "T-shirt",
                            Price = 12.99m,
                            QuantityInStock = 50
                        },
                        new
                        {
                            Id = new Guid("10e7ef26-9bc1-4deb-8dd4-1c92a545d419"),
                            Category = "Electronics",
                            Name = "Smartphone",
                            Price = 699.99m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = new Guid("89df4890-222b-4e5f-8678-43cdb1d3d4b0"),
                            Category = "Kitchen",
                            Name = "Coffee Mug",
                            Price = 9.99m,
                            QuantityInStock = 75
                        },
                        new
                        {
                            Id = new Guid("daf8ab6a-7221-49ef-91b5-1b3bdad6887b"),
                            Category = "Home Office",
                            Name = "Desk Lamp",
                            Price = 29.99m,
                            QuantityInStock = 20
                        },
                        new
                        {
                            Id = new Guid("df87be09-5d49-4eac-81eb-3b05ab850f11"),
                            Category = "Footwear",
                            Name = "Running Shoes",
                            Price = 79.99m,
                            QuantityInStock = 40
                        },
                        new
                        {
                            Id = new Guid("2ec9deb7-28cf-40f9-a0fc-74f3d22fc802"),
                            Category = "Accessories",
                            Name = "Backpack",
                            Price = 39.99m,
                            QuantityInStock = 60
                        },
                        new
                        {
                            Id = new Guid("33ce3209-20a6-487b-94e6-8874012a9d01"),
                            Category = "Electronics",
                            Name = "External Hard Drive",
                            Price = 129.99m,
                            QuantityInStock = 10
                        },
                        new
                        {
                            Id = new Guid("5dcf0ce9-d2a5-4535-a15f-3f1696a5c3d6"),
                            Category = "Fitness",
                            Name = "Yoga Mat",
                            Price = 24.99m,
                            QuantityInStock = 35
                        },
                        new
                        {
                            Id = new Guid("d916f7d0-34ce-4a12-8f92-105fad617bea"),
                            Category = "Stationery",
                            Name = "Pencil Set",
                            Price = 7.99m,
                            QuantityInStock = 80
                        },
                        new
                        {
                            Id = new Guid("832a7b1b-a767-4e9f-8c98-5a48fb697bd8"),
                            Category = "Furniture",
                            Name = "Gaming Chair",
                            Price = 199.99m,
                            QuantityInStock = 5
                        },
                        new
                        {
                            Id = new Guid("cba607e7-f08c-46fe-b85e-7cc65e2dfa3d"),
                            Category = "Accessories",
                            Name = "Sunglasses",
                            Price = 59.99m,
                            QuantityInStock = 45
                        },
                        new
                        {
                            Id = new Guid("560fe255-8a78-48f6-8e12-e4fa7ab0b000"),
                            Category = "Electronics",
                            Name = "Bluetooth Speaker",
                            Price = 89.99m,
                            QuantityInStock = 18
                        },
                        new
                        {
                            Id = new Guid("b89628e3-688a-4c97-ad2d-913760bc6188"),
                            Category = "Stationery",
                            Name = "Notebook",
                            Price = 4.99m,
                            QuantityInStock = 120
                        },
                        new
                        {
                            Id = new Guid("0986d321-0898-4140-b3eb-9ac02cc5bdda"),
                            Category = "Gardening",
                            Name = "Gardening Gloves",
                            Price = 14.99m,
                            QuantityInStock = 55
                        },
                        new
                        {
                            Id = new Guid("9c340cdb-b873-4580-a37a-aecb8d48d115"),
                            Category = "Kitchen",
                            Name = "Cooking Utensils Set",
                            Price = 29.99m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = new Guid("981e01e3-7a78-4e1c-b053-97834d053bac"),
                            Category = "Travel",
                            Name = "Hiking Backpack",
                            Price = 69.99m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = new Guid("61bd2c87-3066-462a-ac24-02fcb3135b6f"),
                            Category = "Electronics",
                            Name = "Power Bank",
                            Price = 49.99m,
                            QuantityInStock = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}