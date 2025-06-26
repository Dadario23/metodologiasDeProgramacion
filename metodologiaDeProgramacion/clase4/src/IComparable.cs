using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public interface IComparable
{
    bool SosIgual(IComparable comparable);
    bool SosMenor(IComparable comparable);
    bool SosMayor(IComparable comparable);
    
    int CompareTo(object? obj);
}
}