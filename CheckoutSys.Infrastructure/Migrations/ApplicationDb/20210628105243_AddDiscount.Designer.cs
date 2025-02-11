﻿// <auto-generated />
using System;
using CheckoutSys.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CheckoutSys.Infrastructure.Migrations.ApplicationDb
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210628105243_AddDiscount")]
    partial class AddDiscount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("AspNetCoreHero.EntityFrameworkCore.AuditTrail.Models.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AffectedColumns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NewValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimaryKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("CheckoutSys.Domain.Entities.Catalog.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Barcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NotReturnable")
                        .HasColumnType("bit");

                    b.Property<int>("OrderMaximumQuantity")
                        .HasColumnType("int");

                    b.Property<int>("OrderMinimumQuantity")
                        .HasColumnType("int");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barcode = "barcode",
                            CreatedBy = "ck",
                            CreatedOn = new DateTime(2021, 6, 28, 10, 52, 29, 596, DateTimeKind.Utc).AddTicks(6484),
                            Description = "Apple",
                            IsDeleted = false,
                            IsPublished = true,
                            Name = "Apple",
                            NotReturnable = true,
                            OrderMaximumQuantity = 200,
                            OrderMinimumQuantity = 0,
                            ProductCategoryId = 0,
                            Rate = 0.6m,
                            StockQuantity = 200
                        },
                        new
                        {
                            Id = 2,
                            Barcode = "barcode",
                            CreatedBy = "ck",
                            CreatedOn = new DateTime(2021, 6, 28, 10, 52, 29, 600, DateTimeKind.Utc).AddTicks(1403),
                            Description = "Orange",
                            IsDeleted = false,
                            IsPublished = true,
                            Name = "Orange",
                            NotReturnable = true,
                            OrderMaximumQuantity = 200,
                            OrderMinimumQuantity = 0,
                            ProductCategoryId = 0,
                            Rate = 0.25m,
                            StockQuantity = 200
                        });
                });

            modelBuilder.Entity("CheckoutSys.Domain.Entities.Catalog.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Fruits",
                            ParentCategoryId = 0
                        });
                });

            modelBuilder.Entity("CheckoutSys.Domain.Entities.Discount.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BundleSelectionOperation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BundleSelectionProductId")
                        .HasColumnType("int");

                    b.Property<int>("BundleSelectionQuantity")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiscountLimitation")
                        .HasColumnType("int");

                    b.Property<int>("DiscountLimitationId")
                        .HasColumnType("int");

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DiscountType")
                        .HasColumnType("int");

                    b.Property<int>("DiscountTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCumulative")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductBundleEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("LimitationTimes")
                        .HasColumnType("int");

                    b.Property<decimal?>("MaximumDiscountAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("MaximumDiscountedQuantity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDateUtc")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UsePercentage")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });
#pragma warning restore 612, 618
        }
    }
}
