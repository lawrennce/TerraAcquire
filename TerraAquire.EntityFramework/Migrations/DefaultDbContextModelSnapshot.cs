﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TerraAquire.EntityFramework;

#nullable disable

namespace TerraAquire.EntityFramework.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TerraAquire.Data.HouseModel", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ARmodel")
                        .HasColumnType("longtext");

                    b.Property<string>("Content")
                        .HasColumnType("longtext");

                    b.Property<string>("Features")
                        .HasColumnType("longtext");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("HouseModels");

                    b.HasData(
                        new
                        {
                            Id = new Guid("91a4e383-5133-4675-ad4e-24ef11bb4c00"),
                            Content = "1 Bathroom Studio Type",
                            Features = "1 Bathroom Studio Type",
                            IsActive = true,
                            Name = "Kame House"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
