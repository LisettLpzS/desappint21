using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 

namespace parcial03.Modelo {
    public class Productor {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        [EmailAddress]
        public string Correo {get; set;}
        [Url]
        public string SitioWeb {get; set;}
        
        public ICollection<PeliculaProductor> PeliculaProductores {get; set;}
   }
}