using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase1
{
    public class Cola : Coleccionable
    {
        private List<Comparable> elementos = new List<Comparable>();

        public void encolar(Comparable c) => elementos.Add(c); 

         public Comparable desencolar()
         {
            if (elementos.Count == 0) 
            throw new InvalidOperationException("Cola vacía");

            Comparable primero = elementos[0];
            elementos.RemoveAt(0);
            return primero;
         }
        public int cuantos() => elementos.Count;
        public Comparable minimo()
        {
           if (elementos.Count == 0)
            throw new InvalidOperationException("La cola está vacía"); 
            
            Comparable min = elementos[0]; 
            for (int i = 1; i < elementos.Count; i++)
        {
            if (elementos[i].sosMenor(min))  
            min = elementos[i];         
        }
        return min;
        }
        public Comparable maximo()
        {
            if (elementos.Count == 0)
            throw new InvalidOperationException("La cola está vacía"); 
            Comparable max = elementos[0]; 
            for (int i = 1; i < elementos.Count; i++)
        {
            if (elementos[i].sosMayor(max))  
            max = elementos[i];         
        }
        return max;
        }
        public void agregar(Comparable c) => encolar(c);
        public bool contiene(Comparable c)
        {
            if (c == null) return false;  
    
        foreach (Comparable elem in elementos)
        {
        if (elem.sosIgual(c))  
            return true;
        }
        return false;
        } 
    }
}