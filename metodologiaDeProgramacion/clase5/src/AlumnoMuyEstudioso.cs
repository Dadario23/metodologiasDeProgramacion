using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class AlumnoMuyEstudioso : Alumno, IAlumno
{
    public AlumnoMuyEstudioso(string nombre, int dni, int legajo, float promedio) 
        : base(nombre, dni, legajo, promedio) { }

    public override int ResponderPregunta(int pregunta)
    {
        return pregunta % 3; 
    }
}
}