using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
    public class DecoradorRecuadro : DecoradorAlumno
{
    public DecoradorRecuadro(Alumno alumno) : base(alumno) { }

    public override string MostrarCalificación()
    {
        string linea = new string('*', 30);
        return $"{linea}\n* {_alumno.MostrarCalificación().PadRight(26)} *\n{linea}";
    }
}
}