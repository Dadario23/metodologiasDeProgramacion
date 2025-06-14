using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class CompararPorPromedio : IComparacionAlumno
    {
        public bool SosIgual(Alumno a, Alumno b) => 
        Math.Abs(a.getPromedio() - b.getPromedio()) < 0.001f;
        public bool SosMenor(Alumno a, Alumno b) => a.getPromedio() < b.getPromedio();
        public bool SosMayor(Alumno a, Alumno b) => a.getPromedio() > b.getPromedio();
    }
}