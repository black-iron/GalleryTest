using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using GalleryTest.Data.Models;

namespace GalleryTest.Data.DataProviders
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, DbMigration>());
        }


        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Media> Media { get; set; }
    }

    public class DbMigration : DbMigrationsConfiguration<DataContext>
    {
        public DbMigration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }
    }
}
