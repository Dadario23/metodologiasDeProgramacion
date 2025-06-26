using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class CompararPorNombre : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetNombre() == b.GetNombre();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) < 0;
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return string.Compare(a.GetNombre(), b.GetNombre()) > 0;
    }
}
}