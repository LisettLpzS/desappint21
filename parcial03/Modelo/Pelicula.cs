using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace parcial03.Modelo {
    public class Pelicula {
        [Key]
        public int Id {get; set;}
        [Required]
        public string Titulo {get; set;}
        public string Historia {get; set;}
        [DataType(DataType.Date)]
        public DateTime FechaEstreno {get; set;}
        public int Duracion {get; set;}
        public int GeneroId {get; set;}
        public int CertificadoId {get; set;}
        public string Notas {get; set;}

        public ICollection<PeliculaActorRol> PeliculaActorRoles {get; set;}
        public ICollection<PeliculaProductor> PeliculaProductores {get; set;}
        public Genero Genero {get; set;}
        public Certificado Certificado {get; set;}
   }
}