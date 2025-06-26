using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
   public interface IObservador
    {
        void Actualizar(IComparable valor);
    }
}