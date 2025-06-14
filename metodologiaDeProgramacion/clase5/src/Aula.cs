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
    if (teacher != null)
    {
        Student adaptado = new AlumnoAdapter((Alumno)alumno); 

        teacher.goToClass(adaptado);
    }
}


    public void claseLista()
    {
        teacher?.teachingAClass();
    }
}

}