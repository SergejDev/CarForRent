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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Auto>()
            //    .HasRequired(a => a.AutoClass)
            //    .WithRequiredPrincipal(a => a.Auto)
            //    ;//.Map(a => a.MapKey("AutoClassId"));

            //modelBuilder.Entity<Auto>()
            //    .HasRequired(a => a.EngineType)
            //    .WithRequiredPrincipal(a => a.Auto)
            //    ;//.Map(a => a.MapKey("EngineTypeId"));

            //modelBuilder.Entity<Auto>()
            //    .HasRequired(a => a.GearboxType)
            //    .WithRequiredPrincipal(a => a.Auto)
            //    ;//.Map(a => a.MapKey("GearboxTypeId"));

            //modelBuilder.Entity<Auto>()
            //    .HasRequired(a => a.FuelType)
            //    .WithRequiredPrincipal(a => a.Auto)
            //    ;//.Map(a => a.MapKey("FuelTypeId"));

            base.OnModelCreating(modelBuilder);
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