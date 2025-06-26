using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase4.src
{
    public class Profesor : Persona, IComparable
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
        
        private void Notificar(IComparable valor)
        {
            foreach (var o in observadores)
                o.Actualizar(valor);
        }
        
        public override bool SosIgual(IComparable c) => 
            antiguedad == ((Profesor)c).antiguedad;
        
        public override bool SosMenor(IComparable c) => 
            antiguedad < ((Profesor)c).antiguedad;
        
        public override bool SosMayor(IComparable c) => 
            antiguedad > ((Profesor)c).antiguedad;
    }
}