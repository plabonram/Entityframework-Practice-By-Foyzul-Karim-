using System.Data.Entity;

namespace ZooApp.Models
{
    class ZooContext : DbContext
    {





        public DbSet<Animal> Animals { get; set; }

    }
}
