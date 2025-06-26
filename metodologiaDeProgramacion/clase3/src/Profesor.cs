using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// OK

namespace clase3.src
{
    public class Profesor : Persona, IComparable, IObservable
    {
        // Atributos
        private int antiguedad;
        private List<IObservador> observadores = new List<IObservador>();

        // Constructor
        public Profesor(string nombre, int dni, int antiguedad) 
            : base(nombre, dni)
        {
            this.antiguedad = antiguedad;
        }

        
        public int GetAntiguedad() => antiguedad;

        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void Notificar(string evento)
        {
            foreach (var observador in observadores)
            {
                observador.Actualizar(evento);
            }
        }

        public void HablarAlaClase()
        {
            Console.WriteLine($"{GetNombre()} está hablando a la clase...");
            Notificar("hablar");
        }

        public void EscribirEnElPizarron()
        {
            Console.WriteLine($"{GetNombre()} escribe en el pizarrón...");
            Notificar("escribir");
        }

        // Opcional para el ejercicio 15 (AlumnoFavorito)
        /* public void HacerSilencio()
        {
            Console.WriteLine("¡Silencio, no se distraigan!");
        } */

        
        public override bool SosIgual(IComparable comparable)
        {
            Profesor otroProfesor = (Profesor)comparable;
            return this.antiguedad == otroProfesor.antiguedad;
        }

        public override bool SosMenor(IComparable comparable)
        {
            Profesor otroProfesor = (Profesor)comparable;
            return this.antiguedad < otroProfesor.antiguedad;
        }

        public override bool SosMayor(IComparable comparable)
        {
            Profesor otroProfesor = (Profesor)comparable;
            return this.antiguedad > otroProfesor.antiguedad;
        }

        
        public override string ToString()
        {
            return $"Profesor: {GetNombre()}, DNI: {GetDNI()}, Antigüedad: {antiguedad} años";
        }
    }
}