using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public interface Comparable
    {
        bool sosIgual(Comparable c);

        bool sosMenor(Comparable c);

        bool sosMayor(Comparable c);
    }
}