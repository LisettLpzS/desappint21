using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class PeliculasDirigidasPorProductores{
        public int ProductoresId {get;set}
        public int TituloId {get;set}


        public ICollection<Peliculas> Peliculas {get; set;}
        public ICollection<Productores> Productores {get; set;}
    }
}