using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
     public class DecoradorEstado : DecoradorAlumno 
    {
        public DecoradorEstado(Alumno alumno) : base(alumno) { }

        public override string MostrarCalificación()
        {
            string estado = _alumno.Calificación >= 7 ? "PROMOCIÓN" : 
                           _alumno.Calificación >= 4 ? "APROBADO" : "DESAPROBADO";
            return $"{_alumno.MostrarCalificación()} ({estado})";
        }
    }
}