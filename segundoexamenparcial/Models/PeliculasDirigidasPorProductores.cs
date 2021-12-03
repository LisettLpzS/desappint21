using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class PeliculasDirigidasPorProductores{
        public int ProductoresId {get;set}
        public int TituloId {get;set}

        public Peliculas Peliculas {get; set;}
        public Productores Productores {get; set;}
    }
}