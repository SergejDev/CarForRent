using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CarForRent.Models
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Auto> Autos { get; set; }

        public DbSet<AutoClass> AutoClasses { get; set; }

        public DbSet<EngineType> EngineTypes { get; set; }

        public DbSet<FuelType> FuelTypes { get; set; }

        public DbSet<GearboxType> GearboxTypes { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}