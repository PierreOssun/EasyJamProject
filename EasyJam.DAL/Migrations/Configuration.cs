using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EasyJam.DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EasyJam.DAL.EasyJamContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EasyJam.DAL.EasyJamContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
