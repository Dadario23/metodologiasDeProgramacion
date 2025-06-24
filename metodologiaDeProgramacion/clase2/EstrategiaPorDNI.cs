using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class EstrategiaPorDNI : IEstrategiaComparacion
    {
        public bool Comparar(Alumno a1, Alumno a2)
        {
            return a1.GetDNI() > a2.GetDNI();
        }
    }
}