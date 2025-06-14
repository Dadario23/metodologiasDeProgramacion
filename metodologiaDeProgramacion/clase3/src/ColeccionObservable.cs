using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public abstract class ColeccionObservable : Coleccionable
    {
        private List<IObservador> observadores = new List<IObservador>();
        
        public void AgregarObservador(IObservador observador)
        {
            observadores.Add(observador);
        }
        
        protected void Notificar(Comparable valor)
        {
            foreach(var obs in observadores)
                obs.Actualizar(valor);
        }
        
        public abstract int cuantos();
        public abstract Comparable minimo();
        public abstract Comparable maximo();
        public abstract void agregar(Comparable comparable);
        public abstract bool contiene(Comparable comparable);
    }
}