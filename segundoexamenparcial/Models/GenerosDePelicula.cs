using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class GenerosDePeliculas{
        public int GeneroId {get;set}
        public string Genero {get;set}


        public ICollection <Peliculas> Peliculas {get; set;}
    }
}