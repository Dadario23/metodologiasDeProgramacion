using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class Pila : IColeccionable, IIterable
    {
        private List<IComparable> elementos = new List<IComparable>();

        public void Agregar(IComparable comparable) => elementos.Add(comparable);
        public int Cuantos() => elementos.Count;
        
        public bool Contiene(IComparable comparable)
        {
            foreach (var elem in elementos)
            {
                if (elem is Alumno alumno && comparable is Alumno alumnoComp)
                {
                    if (alumno.GetDNI() == alumnoComp.GetDNI()) 
                        return true;
                }
                else if (elem.SosIgual(comparable))
                    return true;
            }
            return false;
        }

        public IComparable Minimo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La pila está vacía");

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
                throw new InvalidOperationException("La pila está vacía");

            IComparable maximo = elementos[0];
            foreach (var elem in elementos)
            {
                if (elem.SosMayor(maximo))
                    maximo = elem;
            }
            return maximo;
        }
        public IIterador CrearIterador() => new IteradorPila(elementos);

        private class IteradorPila : IIterador
        {
            private int indice = 0;
            private List<IComparable> elementos;

            public IteradorPila(List<IComparable> elementos) => this.elementos = elementos;
            public bool HaySiguiente() => indice < elementos.Count;
            public IComparable Siguiente() => elementos[indice++];
        }
    }
}