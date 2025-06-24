using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public interface IComparable
    {
        bool SosIgual(IComparable comparable);
        bool SosMenor(IComparable comparable);
        bool SosMayor(IComparable comparable);
    }
}