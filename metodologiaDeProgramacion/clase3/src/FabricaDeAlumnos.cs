using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace clase3.src
{
    public class FabricaDeAlumnos : FabricaDeComparables
    {        
        public FabricaDeAlumnos(GeneradorDeDatosAleatorios generador, LectorDeDatos lector) 
        : base(generador, lector) { }
        
        public override IComparable CrearAleatorio()
        {
            string nombre = generador.StringAleatorio(8); 
            int dni = generador.NumeroAleatorio(40000000) + 10000000; 
            int legajo = generador.NumeroAleatorio(20000); 
            int promedio = generador.NumeroAleatorio(10); 

            return new Alumno(nombre, dni, legajo, promedio);
        }
        
        public override IComparable CrearPorTeclado()
        {
            Console.WriteLine("Ingrese los datos del alumno:");
            Console.Write("Nombre: ");
            string nombre = lector.StringPorTeclado();
            
            Console.Write("DNI: ");
            int dni = lector.NumeroPorTeclado();
            
            Console.Write("Legajo: ");
            int legajo = lector.NumeroPorTeclado();
            
            Console.Write("Promedio: ");
            int promedio = lector.NumeroPorTeclado();
            
            return new Alumno(nombre, dni, legajo, promedio);
        }
    }
}