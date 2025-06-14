using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class CompararPorDni : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.getDni() == b.getDni();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.getDni() < b.getDni();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.getDni() > b.getDni();
    }
}
}