using System;
using System.Collections.Generic;

namespace  parcial01
{
    public class Profesor {

        public Profesor() => alumnos = new List<Alumno>();

        public Profesor(string pnombre,DateTime pfechaing,string pgrupo, string pmateria,float psalario) : this()=>
         (nombre,fechaing,grupo,materia,salario) = (pnombre,pfechaing,pgrupo,pmateria,psalario);
        
        public string nombre {get; set;}
        public DateTime fechaing {get; set;}
        public string grupo {get; set;}
        public string materia {get; set;}
        public float salario {get; set;}
        public List<Alumno> alumnos {get; set;}

        public void AgrerAlumno(Alumno a) => alumnos.Add(a);

        public float PromedioMayor {
            get {
                float m=alumnos[0].prom;
                foreach (var a in alumnos)
                    if(a.prom>m) m=a.prom;
                return m;
            }
        }

        public float PromedioMenor {
            get {
                float m=alumnos[0].prom;
                foreach (var a in alumnos)
                    if(a.prom<m) m=a.prom;
                return m;
            }
        }

        public int antiguedad {
            get {
                return DateTime.Now.Year - fechaing.Year;
            }
        }

        public int TotalBecados {
            get {
                int s=0;
                foreach (var a in alumnos)
                    if(a.becado) s++;
                return s;
            }
        }

        public override string ToString() =>
            $"Nombre: {nombre,-12} FechaIng: {fechaing.ToString("dd/MM/yyy")} Materia: {materia,-8} " +
            $"Salario: {salario,-8:N2} Alumnos: {alumnos.Count} Antiguedad: {antiguedad}";
    }
}