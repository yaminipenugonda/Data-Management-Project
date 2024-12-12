﻿// <auto-generated />
using System;
using MVCDHProject2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCDHProject2.Migrations
{
    [DbContext(typeof(MVCCoreDbContext))]
    [Migration("20241023043657_Update1")]
    partial class Update1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCDHProject2.Models.Customer", b =>
                {
                    b.Property<int>("Custid")
                        .HasColumnType("int");

                    b.Property<decimal?>("Balance")
                        .HasColumnType("Money");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Custid");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Custid = 101,
                            Balance = 50000.00m,
                            City = "Delhi",
                            Name = "Sai",
                            Status = true
                        },
                        new
                        {
                            Custid = 102,
                            Balance = 40000.00m,
                            City = "Mumbai",
                            Name = "Sonia",
                            Status = true
                        },
                        new
                        {
                            Custid = 103,
                            Balance = 30000.00m,
                            City = "Chennai",
                            Name = "Pankaj",
                            Status = true
                        },
                        new
                        {
                            Custid = 104,
                            Balance = 25000.00m,
                            City = "Bengaluru",
                            Name = "Samuels",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
