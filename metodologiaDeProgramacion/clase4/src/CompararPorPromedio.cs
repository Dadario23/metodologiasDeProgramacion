using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
    public class CompararPorPromedio : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.getPromedio() == b.getPromedio();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.getPromedio() < b.getPromedio();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.getPromedio() > b.getPromedio();
    }
}
}