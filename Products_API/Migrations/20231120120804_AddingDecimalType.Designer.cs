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
    [Migration("20231120120804_AddingDecimalType")]
    partial class AddingDecimalType
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
                            Id = new Guid("0c4b94b8-65db-4437-b663-e83cbe28f244"),
                            Category = "Electronics",
                            Name = "Laptop",
                            Price = 999.99m,
                            QuantityInStock = 15
                        },
                        new
                        {
                            Id = new Guid("1245e4e6-c4ca-47c1-879f-bd45021375ad"),
                            Category = "Education",
                            Name = "Book",
                            Price = 19.99m,
                            QuantityInStock = 100
                        },
                        new
                        {
                            Id = new Guid("84c984eb-08c1-4e95-864f-95f2869a95ec"),
                            Category = "Electronics",
                            Name = "Headphones",
                            Price = 49.99m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = new Guid("7d8e6db8-ca0e-46a3-bf07-9321e91bb9f8"),
                            Category = "Apparel",
                            Name = "T-shirt",
                            Price = 12.99m,
                            QuantityInStock = 50
                        },
                        new
                        {
                            Id = new Guid("73d0cf05-6c04-43eb-9d58-ec7420ea6049"),
                            Category = "Electronics",
                            Name = "Smartphone",
                            Price = 699.99m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = new Guid("96197103-789c-4317-b9d9-3c7fdb39ee4d"),
                            Category = "Kitchen",
                            Name = "Coffee Mug",
                            Price = 9.99m,
                            QuantityInStock = 75
                        },
                        new
                        {
                            Id = new Guid("2930ecb3-010c-416f-9732-82b0a4ef6d87"),
                            Category = "Home Office",
                            Name = "Desk Lamp",
                            Price = 29.99m,
                            QuantityInStock = 20
                        },
                        new
                        {
                            Id = new Guid("340b6c19-bb97-497b-be9b-c827bc47dc82"),
                            Category = "Footwear",
                            Name = "Running Shoes",
                            Price = 79.99m,
                            QuantityInStock = 40
                        },
                        new
                        {
                            Id = new Guid("ca881095-16b0-461c-90f3-6176b1bfaf41"),
                            Category = "Accessories",
                            Name = "Backpack",
                            Price = 39.99m,
                            QuantityInStock = 60
                        },
                        new
                        {
                            Id = new Guid("9719c292-29e3-415e-9f89-049be9ea477f"),
                            Category = "Electronics",
                            Name = "External Hard Drive",
                            Price = 129.99m,
                            QuantityInStock = 10
                        },
                        new
                        {
                            Id = new Guid("529b956c-e3cb-4df1-a121-e0204bfaabbe"),
                            Category = "Fitness",
                            Name = "Yoga Mat",
                            Price = 24.99m,
                            QuantityInStock = 35
                        },
                        new
                        {
                            Id = new Guid("867ff752-5983-477f-baf4-c67626e73f21"),
                            Category = "Stationery",
                            Name = "Pencil Set",
                            Price = 7.99m,
                            QuantityInStock = 80
                        },
                        new
                        {
                            Id = new Guid("6cc7b047-80b1-49d2-a1fb-55a62baf83f9"),
                            Category = "Furniture",
                            Name = "Gaming Chair",
                            Price = 199.99m,
                            QuantityInStock = 5
                        },
                        new
                        {
                            Id = new Guid("cb6b4d2a-44e5-4121-af59-6cbac24a1c2f"),
                            Category = "Accessories",
                            Name = "Sunglasses",
                            Price = 59.99m,
                            QuantityInStock = 45
                        },
                        new
                        {
                            Id = new Guid("b65ecacb-ef4f-4a7f-8500-608485cb3242"),
                            Category = "Electronics",
                            Name = "Bluetooth Speaker",
                            Price = 89.99m,
                            QuantityInStock = 18
                        },
                        new
                        {
                            Id = new Guid("5fd89dee-1488-47f4-866d-5534893c6536"),
                            Category = "Stationery",
                            Name = "Notebook",
                            Price = 4.99m,
                            QuantityInStock = 120
                        },
                        new
                        {
                            Id = new Guid("d103b304-7f5c-4c3f-8f21-20650b789327"),
                            Category = "Gardening",
                            Name = "Gardening Gloves",
                            Price = 14.99m,
                            QuantityInStock = 55
                        },
                        new
                        {
                            Id = new Guid("40738584-3fd5-4b4f-9b9c-83ea211a04cf"),
                            Category = "Kitchen",
                            Name = "Cooking Utensils Set",
                            Price = 29.99m,
                            QuantityInStock = 25
                        },
                        new
                        {
                            Id = new Guid("190edce0-9e84-4454-9afb-87995331f05a"),
                            Category = "Travel",
                            Name = "Hiking Backpack",
                            Price = 69.99m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = new Guid("21edae4d-36e0-4524-9eb6-62671cfb5416"),
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
