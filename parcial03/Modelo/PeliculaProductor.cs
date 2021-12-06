

namespace parcial03.Modelo {
    public class PeliculaProductor {
        public int ProductorId {get; set;}
        public int PeliculaId {get; set;}

        public Productor Productor {get; set;}
        public Pelicula Pelicula {get; set;}
   }
}