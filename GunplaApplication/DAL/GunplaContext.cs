using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using GunplaApplication.Models;

namespace GunplaApplication.DAL
{
    public class GunplaContext : DbContext
    {
        public GunplaContext() : base("GunplaContext")
        { 
        }

        public DbSet<Gundam> Gundams { get; set; }
        public DbSet<Gunpla> Gunplas { get; set; }
        public DbSet<Pilot> Pilots { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}