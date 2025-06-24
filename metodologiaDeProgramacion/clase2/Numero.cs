using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase2
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
            return valor;
        }
        public bool SosIgual(IComparable comparable)
        {
            Numero otro = (Numero)comparable;
            return valor == otro.GetValor();
        }

        public bool SosMenor(IComparable comparable)
        {
            Numero otro = (Numero)comparable;
            return valor < otro.GetValor();
        }

        public bool SosMayor(IComparable comparable)
        {
            Numero otro = (Numero)comparable;
            return valor > otro.GetValor();
        }

         
    }
}