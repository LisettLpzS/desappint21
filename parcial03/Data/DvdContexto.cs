using Microsoft.EntityFrameworkCore;
using parcial03.Modelo;

namespace parcial03.Data {
    public class DvdContexto : DbContext {
        public DvdContexto(DbContextOptions<DvdContexto> opciones)
            : base(opciones) {}

        public DbSet<Actor> Actores {get; set;}
        public DbSet<Certificado> Certificados {get; set;}
        public DbSet<Genero> Generos {get; set;}
        public DbSet<Pelicula> Peliculas {get; set;}
        public DbSet<PeliculaActorRol> PeliculaActorRoles {get; set;}
        public DbSet<PeliculaProductor> PeliculaProductores {get; set;}
        public DbSet<Rol> Roles {get; set;}
        public DbSet<Productor> Productores {get; set;}

        protected override void OnModelCreating(ModelBuilder modelo) {
            modelo.Entity<PeliculaActorRol>().HasKey( k=> new {k.PeliculaId, k.ActorId, k.RolId});
            modelo.Entity<PeliculaProductor>().HasKey( k=> new {k.ProductorId, k.PeliculaId});
        }
    }
}
