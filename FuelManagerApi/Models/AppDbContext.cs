using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;
using FuelManagerApi.Models;

namespace FuelManagerApi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasData(new Usuario 
            { 
                Id = 1, 
                Email = "klebersouza@pucminas.br",
                Password = BC.HashPassword("pucminas"),
                Perfil = Perfil.Administrador
            });
        }            

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}