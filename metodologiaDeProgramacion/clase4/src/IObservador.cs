using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
   public interface IObservador
    {
        void Actualizar(Comparable valor);
    }
}