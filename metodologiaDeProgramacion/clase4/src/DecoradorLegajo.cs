using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
    public class DecoradorLegajo : DecoradorAlumno
    {
        public DecoradorLegajo(Alumno alumno) : base(alumno) { }

        public override string MostrarCalificación()
        {
            return $"{base.MostrarCalificación()} (Legajo: {getLegajo()})";
        }
    }
}