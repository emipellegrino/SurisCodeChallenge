using Microsoft.EntityFrameworkCore;
using SurisCodeChallenge.Models.Entidades;

namespace SurisCodeChallenge.Models
{
    public class ReservasContext : DbContext
    {
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        public ReservasContext(DbContextOptions<ReservasContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Servicio>().HasData(
                new Servicio { Id = 1, Nombre = "casamiento" },
                new Servicio { Id = 2, Nombre = "quincianiera" },
                new Servicio { Id = 3, Nombre = "bautizmo" }
            );
        }

    }
}
