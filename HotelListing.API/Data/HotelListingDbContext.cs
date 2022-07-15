using System;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Country>().HasData(
        //        new Country
        //        {
        //            Id = 1,
        //            Name = "Jamaica",
        //            ShortName = "JM"
        //        },
        //        new Country
        //        {
        //            Id = 2,
        //            Name = "Bahamas",
        //            ShortName = "BS"
        //        },
        //        new Country
        //        {
        //            Id = 3,
        //            Name = "Cayman Island",
        //            ShortName = "CI"
        //        });

        //    modelBuilder.Entity<Country>().HasData(
        //        new Hotel
        //        {
        //            Id = 1,
        //            Name = "Sandals",
        //            Address = "Negril",
        //            CountryId = 1,
        //            Rating = 4.5
        //        },
        //        new Hotel
        //        {
        //            Id = 2,
        //            Name = "Days Inn",
        //            Address = "Mercer",
        //            CountryId = 2,
        //            Rating = 2.1
        //        },
        //        new Hotel
        //        {
        //            Id = 3,
        //            Name = "Comfort Suites",
        //            Address = "George Town",
        //            CountryId = 3,
        //            Rating = 4.2
        //        },
        //        new Hotel
        //        {
        //            Id = 4,
        //            Name = "Grand Palldium",
        //            Address = "Nassua",
        //            CountryId = 2,
        //            Rating = 4.9
        //        });
        //}
    }
}

