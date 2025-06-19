using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class OrdenInicio : OrdenEnAula1
    {
        private Aula aula;

        public OrdenInicio(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.comenzar();
        }
    }

}