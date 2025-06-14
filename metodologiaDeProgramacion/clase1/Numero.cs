using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase1
{
    public class Numero : Comparable
    {
        private int valor;

        public Numero(int v)
        {
            valor = v;
        }

        public int getValor()
        {
            return this.valor;
        }

        public bool sosIgual(Comparable c)
        {
            Numero otroNumero = (Numero)c;
            return this.valor == otroNumero.getValor();
        }

        public bool sosMenor(Comparable c)
        {
            Numero otroNumero = (Numero)c;
            return this.valor < otroNumero.getValor();
        }

        public bool sosMayor(Comparable c)
        {
            Numero otroNumero = (Numero)c;
            return this.valor > otroNumero.getValor();
        }

         
    }
}