using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Actores {
        [Key]
        public int ActorId {get; set;}
        public string Nombre {get; set;}
        public string Notas {get; set;}

        public ICollection<RolesdeActoresenP> RolesdeActoresenP {get; set;}    
    }
}