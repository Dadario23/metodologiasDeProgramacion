using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class Conjunto : Coleccionable , IIterable
    {
        private List<Comparable> elementos = new List<Comparable>(); 

        public bool pertenece(Comparable elemento){
            foreach( Comparable elem in elementos){
                if(elem.sosIgual(elemento)){
                    return true;
                }
            }
            return false;
        }
        public void agregar(Comparable elemento){
            if(!pertenece(elemento)){
                elementos.Add(elemento);
            }

        }

        public int cuantos(){
            return elementos.Count;
        }
        public Comparable minimo()
    {
        if (elementos.Count == 0)
            throw new InvalidOperationException("El conjunto está vacío");
        
        Comparable min = elementos[0];
        foreach (Comparable elem in elementos)
        {
            if (elem.sosMenor(min))
            {
                min = elem;
            }
        }
        return min;
    }

        public Comparable maximo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("El conjunto está vacío");
        
            Comparable max = elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMayor(max))
                {
                    max = elem;
                }
            }
            return max;
        }

        public bool contiene(Comparable c)
        {
            return pertenece(c);
        }  

        public IIterador CrearIterador(){
            return new IteradorConjunto(this);
        }

        private class IteradorConjunto : IIterador
        {
            private readonly Conjunto conjunto; 
            private int posicionActual;         
        
            public IteradorConjunto(Conjunto conjunto)
            {
                this.conjunto = conjunto; 
                this.posicionActual = 0;  
            }
            
            public void Primero(){
                posicionActual = 0;
            }
            public void Siguiente(){
                if(!Fin()) 
                {
                    posicionActual++;
                }
            }   
            public bool Fin(){
                return posicionActual >= conjunto.elementos.Count;
            }
            public Comparable Actual(){
                if(Fin())
                {
                    throw new InvalidOperationException("El iterador ha llegado al final");
                }
                return conjunto.elementos[posicionActual];
            }
        }
    }
}