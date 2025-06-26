using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public interface IAlumnoDecorado : IComparable
{
    string MostrarCalificacion();
    int ResponderPregunta(int pregunta);
    string GetNombre();
    int GetCalificacion();
    void SetCalificacion(int nota);
    int GetLegajo();
}

}