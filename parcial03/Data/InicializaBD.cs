using parcial03.Modelo;
using System.Linq;
using System;

namespace parcial03.Data {
    public class InicializaBD {
        public static void Inicializar(DvdContexto contexto) {
            contexto.Database.EnsureCreated();
            if(contexto.Peliculas.Any()) {
                return;
            }
            //Agregar Actores
            var actores = new Actor[] {
                new Actor { Nombre="Pedro Infante"},
                new Actor { Nombre="Cantinflas"},
                new Actor { Nombre="Jorge Negrete"},
                new Actor { Nombre="Pedro Almendariz"},
                new Actor { Nombre="Dolores del Rio"},
            };
            foreach(Actor a in actores) contexto.Actores.Add(a);
            contexto.SaveChanges();
            //Agregar Roles
            var roles = new Rol[] {
                new Rol { Tipo="Personaje principal"},
                new Rol { Tipo="Personaje secundario"},
                new Rol { Tipo="Extra"},
                new Rol { Tipo="Doble de acción"},
                new Rol { Tipo="Camafeo"},
            };
            foreach(Rol r in roles) contexto.Roles.Add(r);
            contexto.SaveChanges();
            //Agregar Generos
            var generos = new Genero[] {
                new Genero { Descripcion="Acción"},
                new Genero { Descripcion="Aventura"},
                new Genero { Descripcion="Comedia"},
                new Genero { Descripcion="Drama"},
                new Genero { Descripcion="Terror"},
                new Genero { Descripcion="Ciencia Ficción"},
            };
            foreach(Genero g in generos) contexto.Generos.Add(g);
            contexto.SaveChanges();
            //Agregar Certificados
            var Certificados = new Certificado[] {
                new Certificado { Descripcion="U"},
                new Certificado { Descripcion="PG"},
                new Certificado { Descripcion="12A"},
                new Certificado { Descripcion="15"},
                new Certificado { Descripcion="18"},
            };
            foreach(Certificado c in Certificados) contexto.Certificados.Add(c);
            contexto.SaveChanges();
            //Agregar Pelicula Productor
            var productores  = new Productor[] {
                new Productor { Nombre="Guillermo del Toro", Correo="memotoro@gmail.com",SitioWeb="http://www.deltoro.com.mx"},
                new Productor { Nombre="Alfonso Cuaron", Correo="ac@gmail.com",SitioWeb="http://www.cuaronmovies.com"},
                new Productor { Nombre="Diego Luna", Correo="dg@gmail.com",SitioWeb="http://www.diegomovies.com.mx"},
            };
            foreach(Productor p in productores) contexto.Productores.Add(p);
            contexto.SaveChanges();
            //Agregar Peliculas
            var peliculas  = new Pelicula[] {
                new Pelicula { Titulo="Macario",Historia="Ahi MAcario",FechaEstreno=DateTime.Parse("1/1/1945"),
                    Duracion=120, GeneroId=generos.Single(g=>g.Descripcion=="Drama").Id,
                    CertificadoId=Certificados.Single(c=>c.Descripcion=="U").Id}
            };
            foreach(Pelicula p in peliculas) contexto.Peliculas.Add(p);
            contexto.SaveChanges();

            //Agregar Pelicula Actor Rol
           
        }
    }
}