using System.Data.Entity;

namespace ZooApp.Models
{
    public class ZooContext : DbContext
    {





        public DbSet<Animal> Animals { get; set; }

        public DbSet<AnimalFood> AnimalFoods { get; set; }
        public DbSet<Food> Foods { get; set; }




    }
}
