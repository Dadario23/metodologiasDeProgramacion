using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class CompararPorNombre : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.getNombre() == b.getNombre();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return string.Compare(a.getNombre(), b.getNombre()) < 0;
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return string.Compare(a.getNombre(), b.getNombre()) > 0;
    }
}
}