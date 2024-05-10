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
        public DefaultDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<HouseModel>? houseModels = new List<HouseModel>() {
                new HouseModel()
                {
                    Id = Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c00"),
                    Name = "Kame House",
                    Features ="1 Bathroom Studio Type",
                    Content ="1 Bathroom Studio Type",
                    IsActive = true,
                },
                //new HouseModel()
                //{
                //    Id = Guid.Parse("91a4e383-5133-4675-ad4e-24ef11bb4c01"),

                //    IsActive = true,
                //},
            };
            modelBuilder.Entity<HouseModel>().HasData(houseModels);
        }
    }
}