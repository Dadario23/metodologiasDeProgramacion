using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class DecoradorLegajo : DecoradorAlumno
    {
        public DecoradorLegajo(IAlumnoDecorado comp) : base(comp) { }

        public override string MostrarCalificacion()
        {
            return $"{componente.MostrarCalificacion()} (Legajo: {componente.GetLegajo()})";
        }
    }

}