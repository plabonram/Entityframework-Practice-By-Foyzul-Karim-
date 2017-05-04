using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace EntityframeworkPracticeByFoyzulKarim.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }



        public DbSet<Animal> Animals { get; set; }

    }
}