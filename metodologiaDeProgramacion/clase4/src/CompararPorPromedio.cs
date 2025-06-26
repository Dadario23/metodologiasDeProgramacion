using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class CompararPorPromedio : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetPromedio() == b.GetPromedio();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetPromedio() < b.GetPromedio();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetPromedio() > b.GetPromedio();
    }
}
}