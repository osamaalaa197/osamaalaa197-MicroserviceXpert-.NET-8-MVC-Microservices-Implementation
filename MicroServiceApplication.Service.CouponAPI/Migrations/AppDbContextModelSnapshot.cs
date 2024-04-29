﻿// <auto-generated />
using System;
using MicroServiceApplication.Service.CouponAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MicroServiceApplication.Service.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MicroServiceApplication.Service.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("LastUpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "OO100",
                            CreationDate = new DateTime(2024, 2, 25, 14, 11, 35, 17, DateTimeKind.Local).AddTicks(4620),
                            DiscountAmount = 10.0,
                            MinAmount = 30
                        },
                        new
                        {
                            CouponId = 2,
                            CouponCode = "FF100",
                            CreationDate = new DateTime(2024, 2, 25, 14, 11, 35, 17, DateTimeKind.Local).AddTicks(4698),
                            DiscountAmount = 20.0,
                            MinAmount = 50
                        },
                        new
                        {
                            CouponId = 3,
                            CouponCode = "AA105",
                            CreationDate = new DateTime(2024, 2, 25, 14, 11, 35, 17, DateTimeKind.Local).AddTicks(4708),
                            DiscountAmount = 25.0,
                            MinAmount = 80
                        },
                        new
                        {
                            CouponId = 4,
                            CouponCode = "BB105",
                            CreationDate = new DateTime(2024, 2, 25, 14, 11, 35, 17, DateTimeKind.Local).AddTicks(4716),
                            DiscountAmount = 30.0,
                            MinAmount = 100
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
