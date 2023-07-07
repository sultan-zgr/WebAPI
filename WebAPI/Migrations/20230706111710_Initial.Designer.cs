﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20230706111710_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Data.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 7, 3, 14, 17, 9, 607, DateTimeKind.Local).AddTicks(3601),
                            Name = "Bilgisayar",
                            Price = 15000m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 6, 14, 17, 9, 608, DateTimeKind.Local).AddTicks(6451),
                            Name = "Telefon",
                            Price = 10000m,
                            Stock = 300
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 5, 7, 14, 17, 9, 608, DateTimeKind.Local).AddTicks(6482),
                            Name = "Klavye",
                            Price = 100m,
                            Stock = 1000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
