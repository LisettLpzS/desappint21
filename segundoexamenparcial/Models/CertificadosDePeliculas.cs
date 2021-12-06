using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace segundoexamenparcial.Modelo
{
    public class CertificadosDePeliculas{
        public int CertificadoId {get;set}
        public string Certificado {get;set}

        public ICollection <Peliculas> Peliculas {get; set;}
    }
}