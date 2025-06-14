using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
    public class FabricaDeProfesores : FabricaDeComparables
    {
        protected override Comparable CrearAleatorio()
        {
            return new Profesor(
                generador.StringAleatorio(10),
                generador.NumeroAleatorio(99999999),
                generador.NumeroAleatorio(30)
            );
        }

        protected override Comparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese datos del profesor:");
            Console.Write("Nombre: ");
            string nombre = lector.StringPorTeclado();
            Console.Write("DNI: ");
            int dni = lector.NumeroPorTeclado();
            Console.Write("Antigüedad: ");
            int antiguedad = lector.NumeroPorTeclado();
            
            return new Profesor(nombre, dni, antiguedad);
        }
    }
}