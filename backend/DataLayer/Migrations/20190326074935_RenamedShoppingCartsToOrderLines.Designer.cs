﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20190326074935_RenamedShoppingCartsToOrderLines")]
    partial class RenamedShoppingCartsToOrderLines
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            Name = "Ralph Lauren"
                        },
                        new
                        {
                            BrandId = 2,
                            Name = "Tommy Hilfiger"
                        },
                        new
                        {
                            BrandId = 3,
                            Name = "Nike"
                        },
                        new
                        {
                            BrandId = 4,
                            Name = "Hugo Boss"
                        },
                        new
                        {
                            BrandId = 5,
                            Name = "Burberry"
                        },
                        new
                        {
                            BrandId = 6,
                            Name = "Levi Strauss & Co."
                        },
                        new
                        {
                            BrandId = 7,
                            Name = "Gucci"
                        },
                        new
                        {
                            BrandId = 8,
                            Name = "Lacoste"
                        },
                        new
                        {
                            BrandId = 9,
                            Name = "Adidas"
                        },
                        new
                        {
                            BrandId = 10,
                            Name = "Versace"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Accessories"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Jackets and coats"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Trousers and shorts"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Underwear"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Suits"
                        },
                        new
                        {
                            CategoryId = 6,
                            Name = "Skirts and dresses"
                        },
                        new
                        {
                            CategoryId = 7,
                            Name = "Shoes, boots and slippers"
                        },
                        new
                        {
                            CategoryId = 8,
                            Name = "Sweaters and waistcoats"
                        },
                        new
                        {
                            CategoryId = 9,
                            Name = "Shirts, t-shirts and tops"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Clothing", b =>
                {
                    b.Property<int>("ClothingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Color");

                    b.Property<string>("Description");

                    b.Property<int>("FKBrandId");

                    b.Property<int>("FKCategoryId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("Size");

                    b.Property<string>("Title");

                    b.HasKey("ClothingId");

                    b.HasIndex("FKBrandId");

                    b.HasIndex("FKCategoryId");

                    b.ToTable("Clothing");
                });

            modelBuilder.Entity("DataLayer.Entities.Costumer", b =>
                {
                    b.Property<int>("CostumerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int>("PaymentMethod");

                    b.Property<string>("Shipment");

                    b.HasKey("CostumerId");

                    b.ToTable("Costumers");
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("FKCostumerId");

                    b.HasKey("OrderId");

                    b.HasIndex("FKCostumerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataLayer.Entities.OrderLine", b =>
                {
                    b.Property<int>("FKClothingId");

                    b.Property<int>("FKCheckoutId");

                    b.Property<int>("Amount");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("FKClothingId", "FKCheckoutId");

                    b.HasIndex("FKCheckoutId");

                    b.ToTable("OrderLines");
                });

            modelBuilder.Entity("DataLayer.Entities.Clothing", b =>
                {
                    b.HasOne("DataLayer.Entities.Brand", "Brand")
                        .WithMany("Clothing")
                        .HasForeignKey("FKBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLayer.Entities.Category", "Category")
                        .WithMany("Clothing")
                        .HasForeignKey("FKCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.Entities.Order", b =>
                {
                    b.HasOne("DataLayer.Entities.Costumer", "Costumer")
                        .WithMany("Orders")
                        .HasForeignKey("FKCostumerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataLayer.Entities.OrderLine", b =>
                {
                    b.HasOne("DataLayer.Entities.Order", "Checkout")
                        .WithMany("OrderLines")
                        .HasForeignKey("FKCheckoutId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLayer.Entities.Clothing", "Clothing")
                        .WithMany("OrderLines")
                        .HasForeignKey("FKClothingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
