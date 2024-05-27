using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using TerraAquire.Data;

namespace TerraAquire.EntityFramework
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<HouseModel>? HouseModels { get; set; }
        public DbSet<TrippingCustomer>? TrippingCustomers { get; set; }
        public  DbSet<Tripping>? Trippings {  get; set; }
        public DbSet<User>? Users { get; set; }
        public DefaultDbContext(DbContextOptions options)

        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<HouseModel>? houseModels = new List<HouseModel>()
            {
                new HouseModel()
                {
                    Id = Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c00"),
                    Name = "Model House A",
                    Features = "1 Bathroom, 2 Bedroom, Livingroom, Kitchen, Dinning",
                    Content = "1 Bathroom, two story",
                    IsActive = true,
                }
            };
            List<User>? user = new List<User>()
            {
                new User()
                {
                    Id = Guid.Parse("7fda491d-6017-445d-ac77-59f87e640778"),
                    Role = Role.Admin, 
                    EmailAddress = "johndaryl@gmail.com",
                    Password = "lawrence",
                    FirstName = "john daryl",
                    LastName = "uy",
                   
                },
                 new User()
                {
                    Id = Guid.Parse("bb7fbc7d-1e9e-4a3b-9902-a30605edd9e0"),
                    Role = Role.Agent,
                    EmailAddress = "neil@gmail.com",
                    Password = "sigesigesige",
                    FirstName = "neil",
                    LastName = "silvestre",

                },
                 new User()
                {
                    Id = Guid.Parse("84adfe15-1c72-44af-a52d-140ae13dd6ac"),
                    Role = Role.Customer,
                    EmailAddress = "jayroaalma@gmail.com",
                    Password = "babydave",
                    FirstName = "jayroa",
                    LastName = "alma",

                },
                   new User()
                {
                    Id = Guid.Parse("1a795efd-c23a-4107-bd34-a0e8910277ab"),
                    Role = Role.Staff,
                    EmailAddress = "justine@gmail.com",
                    Password = "babyjustine",
                    FirstName = "justine",
                    LastName = "pics",

                }
            };
            List<Tripping>? trippings = new List<Tripping>()
            {
                new Tripping()
                {
                   Id = Guid.Parse("0276a4b7-6f0b-4e5e-af54-51382e92216f"),
                   AgentId = Guid.Parse("bb7fbc7d-1e9e-4a3b-9902-a30605edd9e0"),
                   DateTime = DateTime.Parse("22/05/2024"),
                }
            };

            List<TrippingCustomer>? trippingCustomers = new List<TrippingCustomer>()
            {
                new TrippingCustomer()
                {
                   Id = Guid.Parse("8c4bb8af-0d01-444d-9c34-530a933e01c8"),
                    TrippingId = Guid.Parse("0276a4b7-6f0b-4e5e-af54-51382e92216f"),
                   CustomerId =  Guid.Parse("84adfe15-1c72-44af-a52d-140ae13dd6ac"),
                },
                //new HouseModel()
                //{
                //    Id = Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c01"),
                //    IsActive = true,
                //},
            };


            modelBuilder.Entity<HouseModel>().HasData(houseModels);
            modelBuilder.Entity<User>().HasData(user);
            modelBuilder.Entity<Tripping>().HasData(trippings);
            modelBuilder.Entity<TrippingCustomer>().HasData(trippingCustomers);
        }
    }
}