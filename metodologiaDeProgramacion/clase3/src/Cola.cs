using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class Cola : ColeccionObservable, IIterable  
    {
        private List<Comparable> elementos = new List<Comparable>();

        public void encolar(Comparable c)
        {
            elementos.Add(c);
            Notificar(c);  
        }

        public Comparable desencolar()
        {
            if (elementos.Count == 0) 
                throw new InvalidOperationException("Cola vacía");
            Comparable primero = elementos[0];
            elementos.RemoveAt(0);
            return primero;
        }
        
        
        public override int cuantos() => elementos.Count;
        
        public override Comparable minimo()
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
        
        public override Comparable maximo()
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
        
        public override void agregar(Comparable c) => encolar(c);

        public override bool contiene(Comparable comparable)
        {
            foreach (var elemento in elementos)
            {
                
                if (elemento.sosIgual(comparable))
                    return true;
            }
            return false;
        }
        
        public IIterador CrearIterador() => new IteradorCola(this);

        private class IteradorCola : IIterador
        {
            private readonly Cola cola;
            private int posicionActual;

            public IteradorCola(Cola cola)
            {
                this.cola = cola;
                this.posicionActual = 0;
            }

            public void Primero() => posicionActual = 0;

            public void Siguiente()
            {
                if (!Fin())
                    posicionActual++;
            }

            public bool Fin() => posicionActual >= cola.elementos.Count;

            public Comparable Actual()
            {
                if (Fin())
                    throw new InvalidOperationException("El iterador ha llegado al final");
                return cola.elementos[posicionActual];
            }
        }
    }
}