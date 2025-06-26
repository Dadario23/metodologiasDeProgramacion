using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public interface IEstrategiaComparacion
    {
        bool Comparar(Alumno a1, Alumno a2);
    }
}