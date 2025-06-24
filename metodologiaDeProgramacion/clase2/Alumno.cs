using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
   public class Alumno : Persona, IComparable
    {
        private int legajo;
        private double promedio;
        private IEstrategiaComparacion estrategia;

        public Alumno(string nombre, int dni, int legajo, double promedio)
            : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new EstrategiaPorNombre(); // Estrategia por defecto
        }

        public int GetLegajo() => legajo;
        public double GetPromedio() => promedio;

        public void SetEstrategia(IEstrategiaComparacion estrategia)
        {
            this.estrategia = estrategia;
        }

        public override bool SosIgual(IComparable comparable)
        {
            return estrategia.Comparar(this, (Alumno)comparable);
        }

        public override bool SosMenor(IComparable comparable)
        {
            return !estrategia.Comparar(this, (Alumno)comparable);
        }

        public override bool SosMayor(IComparable comparable)
        {
            return estrategia.Comparar(this, (Alumno)comparable);
        }
    }
}