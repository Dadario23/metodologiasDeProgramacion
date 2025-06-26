using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public interface IComparacionAlumno
    {
        bool SosIgual(Alumno a, Alumno b);
        bool SosMenor(Alumno a, Alumno b);
        bool SosMayor(Alumno a, Alumno b);
    }
}