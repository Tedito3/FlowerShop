using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FlowerShop3.Models
{
    public class SystemDB : DbContext
    {
        public SystemDB() : base("SystemDBContextSMTH")
        {

        }
        public DbSet<Flowers> Flowers { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}