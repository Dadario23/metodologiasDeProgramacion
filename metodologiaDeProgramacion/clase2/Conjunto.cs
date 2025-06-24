using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
{
    public class Conjunto : IColeccionable, IIterable
    {
        private List<IComparable> elementos = new List<IComparable>();
        public int Cuantos()
        {
            return elementos.Count;
        }

        public IComparable Minimo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("El conjunto está vacío");

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
                throw new InvalidOperationException("El conjunto está vacío");

            IComparable maximo = elementos[0];
            foreach (var elem in elementos)
            {
                if (elem.SosMayor(maximo))
                    maximo = elem;
            }
            return maximo;
        }

        public void Agregar(IComparable comparable)
        {
            if (!Contiene(comparable))
            {
                elementos.Add(comparable);
            }
        }

        public bool Contiene(IComparable comparable)
        {
            foreach (var elem in elementos)
            {
                if (elem.SosIgual(comparable))
                    return true;
            }
            return false;
        }

        // Métodos de IIterable
        public IIterador CrearIterador()
        {
            return new IteradorConjunto(elementos);
        }

        // Clase interna IteradorConjunto
        private class IteradorConjunto : IIterador
        {
            private int indice = 0;
            private List<IComparable> elementos;

            public IteradorConjunto(List<IComparable> elementos)
            {
                this.elementos = elementos;
            }

            public bool HaySiguiente()
            {
                return indice < elementos.Count;
            }

            public IComparable Siguiente()
            {
                return elementos[indice++];
            }
        }
        public void ImprimirElementos()
        {
            Console.WriteLine("Elementos en el Conjunto:");
            foreach (var elem in elementos)
            {
                if (elem is Alumno alumno)
                {
                    Console.WriteLine($"- Nombre: {alumno.GetNombre()}, DNI: {alumno.GetDNI()}, Legajo: {alumno.GetLegajo()}, Promedio: {alumno.GetPromedio()}");
                }
                else if (elem is Numero numero)
                {
                    Console.WriteLine($"- Número: {numero.GetValor()}");
                }
            }
        }
    }
}