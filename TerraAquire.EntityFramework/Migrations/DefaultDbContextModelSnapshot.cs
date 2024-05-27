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
                            Content = "1 Bathroom, two story",
                            Features = "1 Bathroom, 2 Bedroom, Livingroom, Kitchen, Dinning",
                            IsActive = true,
                            Name = "Model House A"
                        });
                });

            modelBuilder.Entity("TerraAquire.Data.Tripping", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AgentId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("AgentId");

                    b.ToTable("Trippings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0276a4b7-6f0b-4e5e-af54-51382e92216f"),
                            AgentId = new Guid("bb7fbc7d-1e9e-4a3b-9902-a30605edd9e0"),
                            DateTime = new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("TerraAquire.Data.TrippingCustomer", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("char(36)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid?>("TrippingId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("TrippingCustomers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8c4bb8af-0d01-444d-9c34-530a933e01c8"),
                            CustomerId = new Guid("84adfe15-1c72-44af-a52d-140ae13dd6ac"),
                            TrippingId = new Guid("0276a4b7-6f0b-4e5e-af54-51382e92216f")
                        });
                });

            modelBuilder.Entity("TerraAquire.Data.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("ProfileImage")
                        .HasColumnType("longtext");

                    b.Property<int?>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7fda491d-6017-445d-ac77-59f87e640778"),
                            EmailAddress = "johndaryl@gmail.com",
                            FirstName = "john daryl",
                            LastName = "uy",
                            Password = "lawrence",
                            Role = 0
                        },
                        new
                        {
                            Id = new Guid("bb7fbc7d-1e9e-4a3b-9902-a30605edd9e0"),
                            EmailAddress = "neil@gmail.com",
                            FirstName = "neil",
                            LastName = "silvestre",
                            Password = "sigesigesige",
                            Role = 2
                        },
                        new
                        {
                            Id = new Guid("84adfe15-1c72-44af-a52d-140ae13dd6ac"),
                            EmailAddress = "jayroaalma@gmail.com",
                            FirstName = "jayroa",
                            LastName = "alma",
                            Password = "babydave",
                            Role = 3
                        },
                        new
                        {
                            Id = new Guid("1a795efd-c23a-4107-bd34-a0e8910277ab"),
                            EmailAddress = "justine@gmail.com",
                            FirstName = "justine",
                            LastName = "pics",
                            Password = "babyjustine",
                            Role = 1
                        });
                });

            modelBuilder.Entity("TerraAquire.Data.Tripping", b =>
                {
                    b.HasOne("TerraAquire.Data.User", "Agent")
                        .WithMany()
                        .HasForeignKey("AgentId");

                    b.Navigation("Agent");
                });

            modelBuilder.Entity("TerraAquire.Data.TrippingCustomer", b =>
                {
                    b.HasOne("TerraAquire.Data.User", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}