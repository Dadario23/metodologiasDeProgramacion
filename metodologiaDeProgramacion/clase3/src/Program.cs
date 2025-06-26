using System;
using clase3.src;
using clase3;

namespace clase3.src
{       
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN PATRONES PRACTICA 3 ===");
            Console.WriteLine("=== Factory Method y Observer ===\n");

            // --- Configuración inicial ---
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
            LectorDeDatos lector = new LectorDeDatos();

            // 1. Demostración Factory Method
            Console.WriteLine("=== Demostración Factory Method ===");

            FabricaDeComparables fabricaAlumnos = new FabricaDeAlumnos(generador, lector);
            FabricaDeComparables fabricaProfesores = new FabricaDeProfesores(generador, lector);

            Pila pilaAlumnos = new Pila();
            Cola colaProfesores = new Cola();

            Console.WriteLine("\nLlenando pila con 5 alumnos aleatorios:");
            LlenarColeccion(pilaAlumnos, 5, fabricaAlumnos);

            Console.WriteLine("\nLlenando cola con 3 profesores aleatorios:");
            LlenarColeccion(colaProfesores, 3, fabricaProfesores);

            Console.WriteLine("\nAlumnos en la pila:");
            ImprimirElementos(pilaAlumnos);

            Console.WriteLine("\nProfesores en la cola:");
            ImprimirElementos(colaProfesores);

            // 2. Implementamos Observer
            Console.WriteLine("\n=== Demostración Observer ===");

            Profesor profesor = (Profesor)fabricaProfesores.CrearPorTeclado();
            Pila alumnosObservadores = new Pila();
            LlenarColeccion(alumnosObservadores, 3, fabricaAlumnos);

            Console.WriteLine("\nRegistrando alumnos como observadores...");
            IIterador iterador = alumnosObservadores.CrearIterador();
            while (iterador.HaySiguiente())
            {
                Alumno alumno = (Alumno)iterador.Siguiente();
                profesor.AgregarObservador(alumno);
                Console.WriteLine($"- {alumno.GetNombre()} ahora observa al profesor {profesor.GetNombre()}");
            }


            Console.WriteLine("\nSimulación de clase:");
            profesor.HablarAlaClase();
            profesor.EscribirEnElPizarron();
                
        }

        static void LlenarColeccion(IColeccionable coleccion, int cantidad, FabricaDeComparables fabrica)
        {
            for (int i = 0; i < cantidad; i++)
            {
                coleccion.Agregar(fabrica.CrearAleatorio());
            }
        }

        static void ImprimirElementos(IColeccionable coleccion)
        {
            IIterador iterador = ((IIterable)coleccion).CrearIterador();
            while (iterador.HaySiguiente())
            {
                IComparable elemento = iterador.Siguiente();
                Console.WriteLine($"- {elemento}");
            }
        }
    }
}
