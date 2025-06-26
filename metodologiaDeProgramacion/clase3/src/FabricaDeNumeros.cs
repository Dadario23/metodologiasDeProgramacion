using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace clase3.src
{

    public class FabricaDeNumeros : FabricaDeComparables
    {
        public FabricaDeNumeros(GeneradorDeDatosAleatorios generador, LectorDeDatos lector) 
        : base(generador, lector) { }
        
        public override IComparable CrearAleatorio()
        {
            int valor = generador.NumeroAleatorio(100);
            return new Numero(valor);
        }
        
        public override IComparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese un valor numérico:");
            int valor = lector.NumeroPorTeclado();
            return new Numero(valor);
        }
    }
}