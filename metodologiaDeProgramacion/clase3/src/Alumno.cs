using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class Alumno : Persona, IComparable, IObservador
    {
        // Atributos
        private int legajo;
        private double promedio;
        private IEstrategiaComparacion estrategia; 
        

        // Constructor
        public Alumno(string nombre, int dni, int legajo, double promedio) 
            : base(nombre, dni)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new EstrategiaPorNombre(); // Estrategia por defecto
        }

        // Propiedades
        public int GetLegajo() => legajo;
        public double GetPromedio() => promedio;

        // Métodos para Strategy (Práctica 2)
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
            return !estrategia.Comparar(this, (Alumno)comparable) && !this.SosIgual(comparable);
        }

        public override bool SosMayor(IComparable comparable)
        {
            return estrategia.Comparar(this, (Alumno)comparable);
        }

        public void Actualizar(string evento)
        {
            switch (evento)
            {
                case "hablar":
                    PrestarAtencion();
                    break;
                case "escribir":
                    Distraerse();
                    break;
            }
        }

        public void PrestarAtencion()
        {
            Console.WriteLine($"{GetNombre()} está prestando atención.");
        }

        public void Distraerse()
        {
            string[] distracciones = {
                "Mirando el celular",
                "Dibujando en el margen de la carpeta",
                "Tirando aviones de papel"
            };
            Random rnd = new Random();
            Console.WriteLine($"{GetNombre()} se distrae: {distracciones[rnd.Next(distracciones.Length)]}");
        }
        public override string ToString()
        {
            return $"Alumno: {GetNombre()}, DNI: {GetDNI()}, Legajo: {legajo}, Promedio: {promedio}";
        }
    }
}