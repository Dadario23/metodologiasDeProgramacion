using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace clase3.src
{
    public class FabricaDeProfesores : FabricaDeComparables
    {        
        public FabricaDeProfesores(GeneradorDeDatosAleatorios generador, LectorDeDatos lector) 
        : base(generador, lector) { }
        
        public override IComparable CrearAleatorio()
        {
            string nombre = generador.StringAleatorio(8); 
            int dni = generador.NumeroAleatorio(40000000) + 10000000; 
            int antiguedad = generador.NumeroAleatorio(40); 

            return new Profesor(nombre, dni, antiguedad);
        }
        
        public override IComparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese los datos del profesor:");
            Console.Write("Nombre: ");
            string nombre = lector.StringPorTeclado();
            
            Console.Write("DNI: ");
            int dni = lector.NumeroPorTeclado();
            
            Console.Write("Antigüedad (años): ");
            int antiguedad = lector.NumeroPorTeclado();
            
            return new Profesor(nombre, dni, antiguedad);
        }
    }
}