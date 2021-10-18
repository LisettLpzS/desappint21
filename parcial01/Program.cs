using System;
using static System.Console;
using System.Collections.Generic;

namespace parcial01
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela miesc = null;
            Inicializa(ref miesc);
            Reporte(miesc);
        }

        static void Inicializa(ref Escuela e) {
            e = new Escuela("Universidad Autonoma de Zacatecas","Ruben Ibarra Reyes","Jardin Juarez 147");

            e.AgregarProfesor(new Profesor("Jorge Diaz",DateTime.Parse("1/1/2018"),"1A","Fisica",1200f));
            e.AgregarProfesor(new Profesor("Maria Pere",DateTime.Parse("10/2/2016"),"2A","Algebra",3400f));
            e.AgregarProfesor(new Profesor("Claudia Sid",DateTime.Parse("1/4/2019"),"4B","Calculo",3800f));
            e.AgregarProfesor(new Profesor("Carlos Lopez",DateTime.Parse("1/3/2016"),"8A","Quimica",1000f));

            e.profesores[0].AgrerAlumno(new Alumno("Fatima Soto",23,DateTime.Parse("1/1/2019"),true,new List<float> {7,7,7}));
            e.profesores[0].AgrerAlumno(new Alumno("Damian Diaz",25,DateTime.Parse("1/1/2016"),false,new List<float> {8,8,8}));
            e.profesores[0].AgrerAlumno(new Alumno("Carlos Soto",23,DateTime.Parse("1/1/2018"),true,new List<float> {6,6,6}));
            e.profesores[1].AgrerAlumno(new Alumno("Maria Ochoa",20,DateTime.Parse("1/10/2018"),true,new List<float> {9,9,9}));
            e.profesores[1].AgrerAlumno(new Alumno("Carlos Diaz",23,DateTime.Parse("1/10/2018"),false,new List<float> {8,8,8}));
            e.profesores[3].AgrerAlumno(new Alumno("Jose Ochoa",19,DateTime.Parse("1/10/2016"),false,new List<float> {6,6,6}));
        }

        static void Reporte(Escuela e) {
            Clear();
            WriteLine("\nDatos generales de la escuela:");
            WriteLine($"Nombre     :{e.nombre}");
            WriteLine($"Encargado  :{e.encargado}");
            WriteLine($"Domicilio  :{e.domicilio}");
            
            WriteLine($"Total profesores  : {e.profesores.Count}");
            WriteLine($"Total alumnos  : {e.TotalAlumnos}");
            WriteLine($"Total alumnos becados  : {e.TotalBecados}");
            WriteLine($"Total salario profesores  : {e.TotalSalario:N2}");

            WriteLine("\nDatos Generales de los profesores:\n");
            e.profesores.ForEach(p=>WriteLine(p.ToString()));
            WriteLine($"\nMayor Salario: {e.SalarioMayor:N2}");
            WriteLine($"\nMenor Salario: {e.SalarioMenor:N2}");

            WriteLine("\n>> Alumnos por profesor:");
            foreach(var p in e.profesores) {
                WriteLine($"\nNombre: {p.nombre} Grupo: {p.grupo}\n");
                if(p.alumnos.Count>0) {
                    p.alumnos.ForEach(a=>WriteLine(a.ToString()));
                    WriteLine($"\nMayor Promedio: {p.PromedioMayor}");
                    WriteLine($"Mayor Menor    : {p.PromedioMenor}");
                    WriteLine($"Total Becados : {p.TotalBecados}");
                } else {WriteLine("No tiene alumnos aun"); }
            }
        }
    }
}
