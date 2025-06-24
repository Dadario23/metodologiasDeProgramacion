using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class Cola : IColeccionable, IIterable
    {
        private List<IComparable> elementos = new List<IComparable>();

        public int Cuantos() => elementos.Count;

        public IComparable Minimo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La cola está vacía");

            IComparable minimo = elementos[0];
            foreach (var elem in elementos)
            {
                if (elem.SosMenor(minimo))
                    minimo = elem;
            }
            return minimo;
        }

        public IComparable Maximo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La cola está vacía");

            IComparable maximo = elementos[0];
            foreach (var elem in elementos)
            {
                if (elem.SosMayor(maximo))
                    maximo = elem;
            }
            return maximo;
        }

        public void Agregar(IComparable comparable) => elementos.Add(comparable);

        public bool Contiene(IComparable comparable)
        {
            foreach (var elem in elementos)
            {
                if (elem.SosIgual(comparable))
                    return true;
            }
            return false;
        }

        // Método específico de Cola (FIFO)
        public IComparable Desencolar()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La cola está vacía");

            IComparable primero = elementos[0];
            elementos.RemoveAt(0);
            return primero;
        }
        public IIterador CrearIterador() => new IteradorCola(this);

        private class IteradorCola : IIterador
        {
            private Cola cola;
            private int posicionActual = 0;

            public IteradorCola(Cola cola) => this.cola = cola;

            public bool HaySiguiente() => posicionActual < cola.elementos.Count;

            public IComparable Siguiente() => cola.elementos[posicionActual++];
        }
    }
}