using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class DecoradorOrden : DecoradorAlumno
    {
        private int numero;

        public DecoradorOrden(IAlumnoDecorado comp, int numero) : base(comp)
        {
            this.numero = numero;
        }

        public override string MostrarCalificacion()
        {
            return $"{numero}) {componente.MostrarCalificacion()}"; 
        }
    }

}