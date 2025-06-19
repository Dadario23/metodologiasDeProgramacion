using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class Aula
    {
        private Teacher? teacher;

        public void comenzar()
        {
            Console.WriteLine("Iniciando clase...");
            teacher = new Teacher();
        }

        public void nuevoAlumno(Comparable alumno)
        {
            if (teacher != null && alumno is IAlumno a)
            {
                Student adaptado = new AlumnoAdapter(a);
                teacher.goToClass(adaptado);
            }
        }

        public void claseLista()
        {
            if (teacher == null)
            {
                Console.WriteLine("No hay teacher asignado");
                return;
            }

            // Versión minimalista que no interfiere con Teacher
            Console.WriteLine("\n=== Resumen final ===\n");
            Console.WriteLine("Proceso educativo completado correctamente");
        }
    }

}