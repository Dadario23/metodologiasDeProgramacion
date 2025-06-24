using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class EstrategiaPorPromedio : IEstrategiaComparacion
    {
        public bool Comparar(Alumno a1, Alumno a2)
        {
            return a1.GetPromedio() > a2.GetPromedio();
        }
    }
}