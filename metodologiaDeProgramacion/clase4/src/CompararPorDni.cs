using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class CompararPorDni : IComparacionAlumno
{
    public bool SosIgual(Alumno a, Alumno b)
    {
        return a.GetDNI() == b.GetDNI();
    }

    public bool SosMenor(Alumno a, Alumno b)
    {
        return a.GetDNI() < b.GetDNI();
    }

    public bool SosMayor(Alumno a, Alumno b)
    {
        return a.GetDNI() > b.GetDNI();
    }
}
}