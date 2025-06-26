using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class Alumno : Persona, IAlumnoDecorado, IComparable
    {
        private int calificacion;
        private int legajo;
        private double promedio;
        protected Random random = new Random();

        public Alumno(string nombre, int legajo, int dni) : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = 0;
            this.SetCalificacion(0);
        }

        // Implementación de IAlumnoDecorado
        public int GetLegajo() => legajo;
        public override string GetNombre() => base.GetNombre();
        public double GetPromedio() => promedio;
        public int GetCalificacion() => calificacion;
        public void SetCalificacion(int nota) => calificacion = nota;

        public virtual int ResponderPregunta(int pregunta)
        {
            return random.NextDouble() < 0.7 ? random.Next(1, 3) : 0;
        }

        public virtual string MostrarCalificacion()
        {
            return $"{base.GetNombre()} {calificacion}";
        }

        // Implementación explícita de IComparable
        int IComparable.CompareTo(object? obj)
        {
            if (obj == null) return 1;
            
            if (obj is IAlumnoDecorado otro)
            {
                int calComparison = this.calificacion.CompareTo(otro.GetCalificacion());
                if (calComparison != 0) return calComparison;
                
                if (obj is Alumno alumno) 
                    return this.legajo.CompareTo(alumno.legajo);
                    
                return 0;
            }
            
            throw new ArgumentException("El objeto no es IAlumnoDecorado");
        }

            public override bool SosIgual(IComparable comparable)
            {
                return this.calificacion == ((IAlumnoDecorado)comparable).GetCalificacion();
            }

            public override bool SosMenor(IComparable comparable)
            {
                return this.calificacion < ((IAlumnoDecorado)comparable).GetCalificacion();
            }

            public override bool SosMayor(IComparable comparable)
            {
                return this.calificacion > ((IAlumnoDecorado)comparable).GetCalificacion();
            }

    }

}