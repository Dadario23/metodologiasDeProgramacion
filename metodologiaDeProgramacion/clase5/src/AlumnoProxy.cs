using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class AlumnoProxy : IAlumno
    {
        private string nombre;
        private int dni;
        private int legajo;
        private float promedio;
        private bool esEstudioso;
        private int calificacion;
        private Alumno? alumnoReal = null;

        public AlumnoProxy(string nombre, int dni, int legajo, float promedio, bool esEstudioso)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.legajo = legajo;
            this.promedio = promedio;
            this.esEstudioso = esEstudioso;
        }

        private Alumno ObtenerAlumnoReal()
        {
            if (alumnoReal == null)
            {
                alumnoReal = esEstudioso
                    ? new AlumnoMuyEstudioso(nombre, dni, legajo, promedio)
                    : new Alumno(nombre, dni, legajo, promedio);
                alumnoReal.setCalificacion(this.calificacion);
            }
            return alumnoReal;
        }

        public int ResponderPregunta(int pregunta)
        {
            return ObtenerAlumnoReal().ResponderPregunta(pregunta);
        }

        public string getNombre() => this.nombre;

        public int getCalificacion() => this.calificacion;

        public void setCalificacion(int calificacion)
        {
            this.calificacion = calificacion;
            if (alumnoReal != null)
            {
                alumnoReal.setCalificacion(calificacion);
            }
        }

        public string MostrarCalificacion()
        {
            return $"{nombre}    {calificacion}";
        }

        public int getLegajo() => this.legajo;

        public float getPromedio() => this.promedio;

        public bool sosIgual(Comparable c)
        {
            return ObtenerAlumnoReal().sosIgual(c);
        }

        public bool sosMenor(Comparable c)
        {
            return ObtenerAlumnoReal().sosMenor(c);
        }

        public bool sosMayor(Comparable c)
        {
            return ObtenerAlumnoReal().sosMayor(c);
        }

        public override string ToString()
        {
            return $"{nombre} (Proxy)";
        }
    }

}