using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
     public class DecoradorEstado : DecoradorAlumno
    {
        public DecoradorEstado(IAlumnoDecorado comp) : base(comp) { }

        public override string MostrarCalificacion()
        {
            int nota = componente.GetCalificacion();
            string estado = nota >= 7 ? "PROMOCION" : (nota >= 4 ? "APROBADO" : "DESAPROBADO");
            return $"{componente.MostrarCalificacion()} ({estado})";
        }
    }

}