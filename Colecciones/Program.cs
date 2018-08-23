using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaracion e inicializacion de lista de alumnos
            List<Alumno> Alumnos = new List<Alumno>();

            //Declaracion y asignacion de valores de alumno1
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Rubén Bojórquez";
            alumno1.Materias.Add(new Materia("Fotografia", "FT543"));
            alumno1.Materias.Add(new Materia("Algreba", "MAT789"));
            alumno1.Materias.Add(new Materia("Esports", "ES643"));
            Alumnos.Add(alumno1);

            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Julio Camacho";
            alumno2.Materias.Add(new Materia("Microbiologia", "MB564"));
            alumno2.Materias.Add(new Materia("Matematicas", "MAT789"));
            alumno2.Materias.Add(new Materia("Introduccion", "ID753"));
            Alumnos.Add(alumno2);

            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Moises Gomez";
            alumno3.Materias.Add(new Materia("Aprender a aprender", "AA643"));
            alumno3.Materias.Add(new Materia("Quimica", "QMC89"));
            alumno3.Materias.Add(new Materia("Tronco comun", "TC753"));
            Alumnos.Add(alumno3);

            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Fernando Flores";
            alumno4.Materias.Add(new Materia("Odontologia", "OD941"));
            alumno4.Materias.Add(new Materia("Quimica", "QMC07"));
            alumno4.Materias.Add(new Materia("Bacteriologia", "B27043"));
            Alumnos.Add(alumno4);

            /* Materia matematicas = new Materia();
             matematicas.Nombre = "Matematicas";
             matematicas.Identificador = "MT123458";

             alumno1.Materias.Add(new Materia());
             alumno1.Materias.Add(matematicas);

             alumno1.Materias[0].Nombre = "Historia";
             alumno1.Materias[0].Identificador = "HT75265";

             alumno1.Materias.Add(new Materia());
             alumno1.Materias[2].Nombre = "Español";
             alumno1.Materias[2].Identificador = "ES852";

             //alumno.Materias.RemoveAt(1);
             //alumno.Materias.RemoveAt(1);
             //alumno.Materias.Clear();

             foreach(Materia materia in alumno1.Materias)
             {
                 Console.WriteLine("Materia: " + materia.Nombre);
             }*/

            foreach(Alumno elemento in Alumnos)
            {
                Console.WriteLine("Nombre: " + elemento.Nombre);
                foreach(Materia materia in elemento.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }

             Console.ReadLine();
        }
    }
}
