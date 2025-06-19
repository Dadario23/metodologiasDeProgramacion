using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase5.src
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {
        protected override Comparable CrearAleatorio()
        {
            return new AlumnoProxy(
                generador.StringAleatorio(10),
                generador.NumeroAleatorio(99999999),
                generador.NumeroAleatorio(99999),
                generador.NumeroAleatorio(10),
                false 
            );
        }

        protected override Comparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = lector.StringPorTeclado();
            Console.Write("DNI: ");
            int dni = lector.NumeroPorTeclado();
            Console.Write("Legajo: ");
            int legajo = lector.NumeroPorTeclado();
            Console.Write("Promedio: ");
            int promedio = lector.NumeroPorTeclado();

            return new AlumnoProxy(nombre, dni, legajo, promedio, false);
        }
    }

}