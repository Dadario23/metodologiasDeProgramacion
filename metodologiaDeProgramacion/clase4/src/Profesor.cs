using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.clase4
{
    public class Profesor : Persona, Comparable
    {
        private int antiguedad;
        private List<IObservador> observadores = new List<IObservador>();
        
        public Profesor(string n, int d, int a) : base(n, d) => antiguedad = a;
        
        public int GetAntiguedad() => antiguedad;
        
        public void HablarALaClase()
        {
            Console.WriteLine("Hablando de algún tema");
            Notificar(this); 
        }
        
        public void EscribirEnElPizarron()
        {
            Console.WriteLine("Escribiendo en el pizarrón");
            Notificar(this); 
        }
        
        public void AgregarObservador(IObservador o) => observadores.Add(o);
        
        private void Notificar(Comparable valor)
        {
            foreach (var o in observadores)
                o.Actualizar(valor);
        }
        
        // Implementación de Comparable
        public bool SosIgual(Comparable c) => 
            antiguedad == ((Profesor)c).antiguedad;
        
        public bool SosMenor(Comparable c) => 
            antiguedad < ((Profesor)c).antiguedad;
        
        public bool SosMayor(Comparable c) => 
            antiguedad > ((Profesor)c).antiguedad;
    }
}