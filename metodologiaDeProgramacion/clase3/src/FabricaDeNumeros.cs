using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        protected override Comparable CrearAleatorio() => 
            new Numero(generador.NumeroAleatorio(1000));
        
        protected override Comparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese un número:");
            return new Numero(lector.NumeroPorTeclado());
        }
    }
}