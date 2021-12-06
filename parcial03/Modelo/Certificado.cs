using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace parcial03.Modelo {
    public class Certificado {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Descripcion {get; set;}

        public ICollection<Pelicula> Pelicula {get; set;}
   }
}
