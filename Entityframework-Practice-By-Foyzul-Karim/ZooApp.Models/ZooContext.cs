using System.Data.Entity;

namespace ZooApp.Models
{
    public class ZooContext : DbContext
    {





        public DbSet<Animal> Animals { get; set; }

       // public System.Data.Entity.DbSet<ZooApp.ViewModel.ViewAnimal> ViewAnimals { get; set; }

       // public System.Data.Entity.DbSet<ZooApp.ViewModel.ViewAnimal> ViewAnimals { get; set; }

    }
}
