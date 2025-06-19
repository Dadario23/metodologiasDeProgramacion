using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public interface IAlumno : Comparable
    {
        int ResponderPregunta(int pregunta);
        string getNombre();
        int getCalificacion();
        void setCalificacion(int calificacion);
        string MostrarCalificacion();
        int getLegajo();
        float getPromedio();
    }
}