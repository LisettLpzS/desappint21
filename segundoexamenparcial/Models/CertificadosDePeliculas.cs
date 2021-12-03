using System;
using System.ComponentModel.DataAnnotations;

namespace segundoexamenparcial.Modelo
{
    public class CertificadosDePeliculas{
        public int CertificadoId {get;set}
        public string Certificado {get;set}

        public ICollection <Peliculas> Peliculas {get; set;}
    }
}