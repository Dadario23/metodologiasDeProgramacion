using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace clase3.src
{
     public abstract class FabricaDeComparables
    {
        protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos lector = new LectorDeDatos();
        
        
        public static Comparable CrearAleatorio(int opcion)
        {
            return CrearFabrica(opcion).CrearAleatorio();
        }
        
        public static Comparable CrearPorTeclado(int opcion)
        {
            return CrearFabrica(opcion).CrearPorTeclado();
        }
        
        // Método factory para crear fábricas concretas
        private static FabricaDeComparables CrearFabrica(int opcion)
        {
            return opcion switch
            {
                1 => new FabricaDeNumeros(),
                2 => new FabricaDeAlumnos(),
                3 => new FabricaDeProfesores(),
                _ => throw new ArgumentException("Opción no válida")
            };
        }
        
        
        protected abstract Comparable CrearAleatorio();
        protected abstract Comparable CrearPorTeclado();
    }
}