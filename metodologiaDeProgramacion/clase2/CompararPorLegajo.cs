using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class CompararPorLegajo : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.getLegajo() == b.getLegajo();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.getLegajo() < b.getLegajo();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.getLegajo() > b.getLegajo();
    }
}
}