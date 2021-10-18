using System.Collections.Generic;

namespace parcial01
{
    public class Escuela {
        public Escuela() => profesores = new List<Profesor>();

        public Escuela(string pnombre, string pencargado, string pdomicilio): this()=>
         (nombre,encargado,domicilio) = (pnombre,pencargado,pdomicilio);

        public string nombre {get; set;}
        public string encargado {get; set;}
        public string domicilio {get; set;}
        public List<Profesor> profesores {get; set;}

        public void AgregarProfesor(Profesor p) => profesores.Add(p);

        public float SalarioMayor {
            get {
                float m=profesores[0].salario;
                foreach (var p in profesores)
                    if(p.salario>m) m = p.salario;
                return m;
            }
        }
        public float SalarioMenor {
            get {
                float m=profesores[0].salario;
                foreach (var p in profesores)
                    if(p.salario<m) m = p.salario;
                return m;
            }
        }
        public float TotalSalario {
            get {
                float s=0;
                foreach (var p in profesores)
                    s+=p.salario;
                return s;
            }
        }
        public int TotalAlumnos {
            get {
                int s=0;
                foreach (var p in profesores)
                    s+=p.alumnos.Count;
                return s;
            }
        }
        public float TotalBecados {
            get {
                int s=0;
                foreach (var p in profesores)
                    s+=p.TotalBecados;
                return s;
            }
        }
    }
}