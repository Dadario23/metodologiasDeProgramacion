using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public interface IEstrategiaComparacion {
         bool Comparar(Alumno a1, Alumno a2);
    }
}