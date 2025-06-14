using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class ColeccionMultiple : Coleccionable
    {
        private Coleccionable pila;
        private Coleccionable cola;
        
        public ColeccionMultiple(Coleccionable p, Coleccionable c)
        {
            this.pila = p;
            this.cola = c;
        }
        
        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }
        
        public Comparable minimo()
        {
            Comparable minPila = pila.minimo();
            Comparable minCola = cola.minimo();
            return minPila.sosMenor(minCola) ? minPila : minCola;
        }
        
        public Comparable maximo()
        {
            Comparable maxPila = pila.maximo();
            Comparable maxCola = cola.maximo();
            return maxPila.sosMayor(maxCola) ? maxPila : maxCola;
        }
        
        public void agregar(Comparable comparable)
        {
            
        }
        
        public bool contiene(Comparable comparable)
        {
            return pila.contiene(comparable) || cola.contiene(comparable);
        }
    }
}