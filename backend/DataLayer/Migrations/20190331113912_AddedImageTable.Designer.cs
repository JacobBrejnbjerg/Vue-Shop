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
    [Migration("20190331113912_AddedImageTable")]
    partial class AddedImageTable
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

                    b.Property<string>("Name")
                        .IsRequired();

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

                    b.Property<string>("Name")
                        .IsRequired();

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

                    b.Property<int>("FKImageId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5, 2)");

                    b.Property<int>("Size");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ClothingId");

                    b.HasIndex("FKBrandId");

                    b.HasIndex("FKCategoryId");

                    b.HasIndex("FKImageId");

                    b.ToTable("Clothing");

                    b.HasData(
                        new
                        {
                            ClothingId = 1,
                            Color = 1,
                            Description = "Polo Ralph Lauren",
                            FKBrandId = 1,
                            FKCategoryId = 9,
                            FKImageId = 1,
                            Price = 25m,
                            Size = 2,
                            Title = "Polo Ralph Lauren"
                        },
                        new
                        {
                            ClothingId = 2,
                            Color = 4,
                            Description = "Grønne bukser",
                            FKBrandId = 2,
                            FKCategoryId = 3,
                            FKImageId = 2,
                            Price = 20m,
                            Size = 1,
                            Title = "Grønne bukser"
                        },
                        new
                        {
                            ClothingId = 3,
                            Color = 6,
                            Description = "Gule underbukser",
                            FKBrandId = 4,
                            FKCategoryId = 4,
                            FKImageId = 3,
                            Price = 5m,
                            Size = 3,
                            Title = "Gule underbukser"
                        });
                });

            modelBuilder.Entity("DataLayer.Entities.Costumer", b =>
                {
                    b.Property<int>("CostumerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("PaymentMethod");

                    b.HasKey("CostumerId");

                    b.ToTable("Costumers");
                });

            modelBuilder.Entity("DataLayer.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AltText")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("ImageId");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            ImageId = 1,
                            AltText = "Polo Ralph Lauren",
                            Url = "https://admin.kaufmannstatic.com/Images/158260_sort_01-T20190211074923.jpg?i=158260_sort_01-T20190211074923.jpg"
                        },
                        new
                        {
                            ImageId = 2,
                            AltText = "Grønne bukser",
                            Url = "http://www.maconresidence.eu/images/large/tommy-hilfiger/Nyt%20K%C3%B8b%20Tommy%20Hilfiger%20Gr%C3%B8nne%20Blandet%20Blend%20Bukser%20til%20B%C3%B8rn%20Outlet%20187_LRG.jpg"
                        },
                        new
                        {
                            ImageId = 3,
                            AltText = "Gule underbukser",
                            Url = "https://www.fashionhero.dk/shared/9/9520a88e8980e6334a8ab327cd4b710b_h940w940_min.jpg"
                        });
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

                    b.Property<int>("FKOrderId");

                    b.Property<int>("Amount");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(5, 2)");

                    b.HasKey("FKClothingId", "FKOrderId");

                    b.HasIndex("FKOrderId");

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

                    b.HasOne("DataLayer.Entities.Image", "Image")
                        .WithMany("Clothing")
                        .HasForeignKey("FKImageId")
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
                    b.HasOne("DataLayer.Entities.Clothing", "Clothing")
                        .WithMany("OrderLines")
                        .HasForeignKey("FKClothingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataLayer.Entities.Order", "Order")
                        .WithMany("OrderLines")
                        .HasForeignKey("FKOrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
