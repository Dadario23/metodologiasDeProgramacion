using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
    public class DecoradorNotaLetras : DecoradorAlumno
    {
        private static string[] notas = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };

        public DecoradorNotaLetras(Alumno alumno) : base(alumno) { }

        public override string MostrarCalificación() 
            => $"{_alumno.MostrarCalificación()} ({notas[_alumno.Calificación]})";
    }
}