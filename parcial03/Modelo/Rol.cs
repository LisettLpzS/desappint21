using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace parcial03.Modelo {
    public class Rol {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Tipo {get; set;}

        public ICollection<PeliculaActorRol> PeliculaActorRoles {get; set;}
 
   }
}