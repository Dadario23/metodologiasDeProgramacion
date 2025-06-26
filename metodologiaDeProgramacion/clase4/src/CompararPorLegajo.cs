using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class CompararPorLegajo : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetLegajo() == b.GetLegajo();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetLegajo() < b.GetLegajo();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetLegajo() > b.GetLegajo();
    }
}
}