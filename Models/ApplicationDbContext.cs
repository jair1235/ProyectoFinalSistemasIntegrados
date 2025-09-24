using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalSistemasIntegrados.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Testimonio> Testimonios { get; set; }
    }
}
