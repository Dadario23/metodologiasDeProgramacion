using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public interface IIterador
    {
        bool HaySiguiente();
        IComparable Siguiente();
    }
}