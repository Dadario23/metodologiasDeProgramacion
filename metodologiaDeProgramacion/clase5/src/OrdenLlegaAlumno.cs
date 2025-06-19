using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class OrdenLlegaAlumno : OrdenEnAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable alumno)
        {
            aula.nuevoAlumno(alumno);
        }
    }

}