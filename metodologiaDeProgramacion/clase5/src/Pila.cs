using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class Pila : Coleccionable, Ordenable
    {
        private List<Comparable> elementos = new List<Comparable>();

        private OrdenEnAula1? ordenInicio;
        private OrdenEnAula2? ordenLlegaAlumno;
        private OrdenEnAula1? ordenAulaLlena;

        public void push(Comparable c)
        {
            if (elementos.Count == 0 && ordenInicio != null)
                ordenInicio.ejecutar();

            elementos.Add(c);

            if (ordenLlegaAlumno != null)
                ordenLlegaAlumno.ejecutar(c);

            if (elementos.Count == 40 && ordenAulaLlena != null)
                ordenAulaLlena.ejecutar();
        }

        public Comparable pop()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("Pila vacía");

            var elem = elementos[elementos.Count - 1];
            elementos.RemoveAt(elementos.Count - 1);
            return elem;
        }

        public void agregar(Comparable c)
        {
            push(c);
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public Comparable minimo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La colección está vacía");

            return elementos.Min()!;
        }

        public Comparable maximo()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La colección está vacía");

            return elementos.Max()!;
        }

        public bool contiene(Comparable c)
        {
            return elementos.Any(e => e.sosIgual(c));
        }

        public void setOrdenInicio(OrdenEnAula1 orden)
        {
            this.ordenInicio = orden;
        }

        public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
        {
            this.ordenLlegaAlumno = orden;
        }

        public void setOrdenAulaLlena(OrdenEnAula1 orden)
        {
            this.ordenAulaLlena = orden;
        }
    }
}
