using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase1
{
    public class ColeccionMultiple : Coleccionable
    {
        private Pila pila = new Pila();
        private Cola cola = new Cola();

        public ColeccionMultiple(Pila pila, Cola cola){
            this.pila = pila;
            this.cola = cola;
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
    public void agregar(Comparable c)
    {
      
    }

    public bool contiene(Comparable c)
    {
      return pila.contiene(c) || cola.contiene(c); 
    }



  }
}