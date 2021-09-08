
using System.Collections.Generic;

namespace p15controlbancario
{
    public class Banco {
        public Banco(string nombre,string direccion){
            this.nombre=nombre;
            this.direccion=direccion;
            clientes = new List<Cliente>();
        }
        public string nombre{get; private set;}
        public string direccion {get; private set;}
        public List<Cliente> clientes {get; set;}
        public void AgregarCliente(Cliente cliente){
            clientes.Add(cliente);
        }
    }
}