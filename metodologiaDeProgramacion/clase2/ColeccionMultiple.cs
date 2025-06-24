using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class ColeccionMultiple : IColeccionable
{
    private Pila pila;
    private Cola cola;

    public ColeccionMultiple(Pila pila, Cola cola)
    {
        this.pila = pila;
        this.cola = cola;
    }

    public int Cuantos()
    {
        return pila.Cuantos() + cola.Cuantos();
    }

    public IComparable Minimo()
    {
        IComparable minPila = pila.Minimo();
        IComparable minCola = cola.Minimo();
        
        if (minPila == null) return minCola;
        if (minCola == null) return minPila;
        
        return minPila.SosMenor(minCola) ? minPila : minCola;
    }

    public IComparable Maximo()
    {
        IComparable maxPila = pila.Maximo();
        IComparable maxCola = cola.Maximo();
        
        if (maxPila == null) return maxCola;
        if (maxCola == null) return maxPila;
        
        return maxPila.SosMayor(maxCola) ? maxPila : maxCola;
    }

    public void Agregar(IComparable comparable)
    {
        
    }

    public bool Contiene(IComparable comparable)
    {
        return pila.Contiene(comparable) || cola.Contiene(comparable);
    }
}
}