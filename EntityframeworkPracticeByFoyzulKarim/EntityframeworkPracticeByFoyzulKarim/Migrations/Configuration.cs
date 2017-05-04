using EntityframeworkPracticeByFoyzulKarim.Models;

namespace EntityframeworkPracticeByFoyzulKarim.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityframeworkPracticeByFoyzulKarim.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EntityframeworkPracticeByFoyzulKarim.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Animals.Add(new Animal() {Name = "Cat",Food = "Fish",Origin = "Bangladesh",Quantity = 5});
            context.SaveChanges();
        }
    }
}
