using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class Pila : Coleccionable , IIterable
    {
        private List<Comparable> elementos = new List<Comparable>();
        public void apilar(Comparable c) => elementos.Add(c);

        public Comparable desapilar()
        {
            if (elementos.Count == 0) throw new InvalidOperationException("Pila vacía");
            Comparable ultimo = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);

            return ultimo;
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La pila está vacía");

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
            throw new InvalidOperationException("La pila está vacía");

            Comparable max = elementos[0]; 
            for (int i = 1; i < elementos.Count; i++)
            {
            if (elementos[i].sosMayor(max))  
            max = elementos[i];          
            }
            return max;
            }
        public void agregar(Comparable c)
        {
             elementos.Add(c);
        }

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

        public IIterador CrearIterador(){
            return new IteradorPila(this);
        }

        private class IteradorPila : IIterador
        {
            private readonly Pila pila; 
            private int posicionActual;         
        
            public IteradorPila(Pila pila)
            {
                this.pila = pila; 
                this.posicionActual = pila.elementos.Count - 1;
            }
            
            public void Primero(){
               posicionActual = pila.elementos.Count - 1;
            }
            public void Siguiente(){
                if(!Fin()) 
                {
                     posicionActual--;
                }
            }   
            public bool Fin(){
                return posicionActual < 0;
            }
            public Comparable Actual(){
                if(Fin())
                {
                    throw new InvalidOperationException("El iterador ha llegado al final");
                }
                    return pila.elementos[posicionActual];
            }
        }
    }
}