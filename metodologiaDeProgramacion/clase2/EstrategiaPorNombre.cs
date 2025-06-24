using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class EstrategiaPorNombre : IEstrategiaComparacion
    {
        public bool Comparar(Alumno a1, Alumno a2)
        {
            return string.Compare(a1.GetNombre(), a2.GetNombre()) > 0;
        }
    }
}