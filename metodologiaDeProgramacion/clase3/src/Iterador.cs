using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3
{
    public interface IIterador
    {
        void Primero();
        void Siguiente();   
        bool Fin();
        Comparable Actual();
    }
}