using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class Peliculas{
        public int TituloId {get;set}
        public string NombreP {get;set}
        public string Historia {get;set}
        public DateTime FechaRealizada {get;set}
        public int Duracion{get;set}
        public string GeneroId {get;set}
        public int CertificadoId {get;set}
        public string Informacion {get;set}

        public ICollection<RolesdeActoresenP> RolesdeActoresenP {get; set;}
        public ICollection<PeliculasDirigidasPorProductores> PeliculasDirigidasPorProductores {get; set;}
        public GenerosDePeliculas GenerosDePeliculas {get; set;}
        public CertificadosDePeliculas CertificadosDePeliculas {get; set;}
    }

}
