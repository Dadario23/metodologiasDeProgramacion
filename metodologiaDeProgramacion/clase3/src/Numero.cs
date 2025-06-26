using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class Numero : IComparable
    {
        private int valor;

        public Numero(int v)
        {
            valor = v;
        }

        public int GetValor()
        {
            return this.valor;
        }

        public bool SosIgual(IComparable c)
        {
            Numero otroNumero = (Numero)c;
            return this.valor == otroNumero.GetValor();
        }

        public bool SosMenor(IComparable c)
        {
            Numero otroNumero = (Numero)c;
            return this.valor < otroNumero.GetValor();
        }

        public bool SosMayor(IComparable c)
        {
            Numero otroNumero = (Numero)c;
            return this.valor > otroNumero.GetValor();
        }

        public override string ToString()
        {
            return valor.ToString();
        }


    }
}