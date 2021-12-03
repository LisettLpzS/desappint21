using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class RolesdeActoresenP{
        

        public Actores Actores {get; set;}
        public Roles Roles {get; set;}
        public Peliculas Peliculas {get; set;}
    }
}