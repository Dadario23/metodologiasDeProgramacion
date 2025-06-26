using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public interface Ordenable
    {
        void setOrdenInicio(OrdenEnAula1 orden);
        void setOrdenLlegaAlumno(OrdenEnAula2 orden);
        void setOrdenAulaLlena(OrdenEnAula1 orden);
        
    }

}