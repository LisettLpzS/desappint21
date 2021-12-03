using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class Roles{

        public ICollection <RolesdeActoresenP> RolesdeActoresenP {get; set;}
    }
}