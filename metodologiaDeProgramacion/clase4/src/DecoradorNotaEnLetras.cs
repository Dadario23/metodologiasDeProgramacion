using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class DecoradorNotaEnLetras : DecoradorAlumno
    {
        private static readonly string[] letras = {
            "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO",
            "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"
        };

        public DecoradorNotaEnLetras(IAlumnoDecorado comp) : base(comp) { }

        public override string MostrarCalificacion()
        {
            int nota = componente.GetCalificacion();
            string letra = (nota >= 0 && nota <= 10) ? letras[nota] : "DESCONOCIDA";
            return $"{componente.MostrarCalificacion()} ({letra})";
        }
    }

}