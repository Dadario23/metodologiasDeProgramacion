using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class AlumnoMuyEstudioso : Alumno
    {
        public AlumnoMuyEstudioso(string nombre, int legajo, int dni) 
            : base(nombre, legajo, dni) { }

        public override int ResponderPregunta(int pregunta)
        {
            double probabilidad = random.NextDouble();
            return probabilidad switch
            {
                < 0.15 => 7,  // 15%
                < 0.35 => 8,  // 20%
                < 0.70 => 9,  // 35%
                _ => 10       // 30%
            };
        }
    }

}