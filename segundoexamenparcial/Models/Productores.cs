using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Productores{
        public int ProductorId {get;set}
        public string NombreProductor {get;set}



        public ICollection <PeliculasDirigidasPorProductores> PeliculasDirigidasPorProductores {get; set;}
    }
}