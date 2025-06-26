using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class Alumno : Persona, IAlumno
    {
        private int legajo;
        private float promedio;
        private int calificacion;
        private static bool compararPorPromedio = false;

        public Alumno(string nombre, int dni, int legajo, float promedio) 
            : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
        }

        public virtual int ResponderPregunta(int pregunta)
        {
            Random rnd = new Random();
            return rnd.Next(1, 4); 
        }

        public int getCalificacion() => this.calificacion;

        public void setCalificacion(int calificacion) => this.calificacion = calificacion;

        public string MostrarCalificacion() => $"{getNombre()}    {calificacion}";

        public int getLegajo() => legajo;

        public float getPromedio() => promedio;

        public new string getNombre() => base.getNombre();

        public static void SetCompararPorPromedio(bool porPromedio)
        {
            compararPorPromedio = porPromedio;
        }

        public static bool GetCompararPorPromedio()
        {
            return compararPorPromedio;
        }

        public override bool sosIgual(Comparable c)
        {
            if (c is IAlumno otro)
            {
                return compararPorPromedio ? 
                    this.promedio == otro.getPromedio() : 
                    this.legajo == otro.getLegajo();
            }
            return false;
        }

        public override bool sosMenor(Comparable c)
        {
            if (c is IAlumno otro)
            {
                return compararPorPromedio ? 
                    this.promedio < otro.getPromedio() : 
                    this.legajo < otro.getLegajo();
            }
            return false;
        }

        public override bool sosMayor(Comparable c)
        {
            if (c is IAlumno otro)
            {
                return compararPorPromedio ? 
                    this.promedio > otro.getPromedio() : 
                    this.legajo > otro.getLegajo();
            }
            return false;
        }
    }
}