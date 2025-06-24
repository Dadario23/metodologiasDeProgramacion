using System;
using clase2;

namespace clase2
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN PATRONES PRACTICA 2 ===");
            Console.WriteLine("=== Strategy e Iterator ===\n");

            // 1. Creación de colecciones
            Console.WriteLine("Creando colecciones (Pila, Cola, Conjunto)...");
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();

            // 2. Llenar con alumnos
            Console.WriteLine("\nLlenando colecciones con alumnos...");
            LlenarAlumnos(pila);
            LlenarAlumnos(cola);
            LlenarAlumnos(conjunto);

            // 3. Demostración del patrón Iterator
            Console.WriteLine("\n=== Demostración del patrón Iterator ===");
            Console.WriteLine("\nElementos en la Pila:");
            ImprimirElementos(pila);

            Console.WriteLine("\nElementos en la Cola:");
            ImprimirElementos(cola);

            Console.WriteLine("\nElementos en el Conjunto (sin repetidos):");
            ImprimirElementos(conjunto);

            // 4. Demostración del patrón Strategy
            Console.WriteLine("\n=== Demostración del patrón Strategy ===");

            // Creación de estrategias
            IEstrategiaComparacion estrategiaNombre = new EstrategiaPorNombre();
            IEstrategiaComparacion estrategiaDni = new EstrategiaPorDNI();
            IEstrategiaComparacion estrategiaLegajo = new EstrategiaPorLegajo();
            IEstrategiaComparacion estrategiaPromedio = new EstrategiaPorPromedio();

            // Aplicar diferentes estrategias a la pila
            Console.WriteLine("\nCambiando estrategias en la Pila:");

            Console.WriteLine("\nEstrategia por Nombre:");
            CambiarEstrategia(pila, estrategiaNombre);
            InformarColeccion(pila);

            Console.WriteLine("\nEstrategia por DNI:");
            CambiarEstrategia(pila, estrategiaDni);
            InformarColeccion(pila);

            Console.WriteLine("\nEstrategia por Legajo:");
            CambiarEstrategia(pila, estrategiaLegajo);
            InformarColeccion(pila);

            Console.WriteLine("\nEstrategia por Promedio:");
            CambiarEstrategia(pila, estrategiaPromedio);
            InformarColeccion(pila);
        }

        static void LlenarAlumnos(IColeccionable coleccion)
        {
            Random random = new Random();
            string[] nombres = { "Juan", "Ana", "Luis", "Maria", "Carlos", "Sofia", "Pedro", "Laura" };

            for (int i = 0; i < 15; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)] + " " + nombres[random.Next(nombres.Length)];
                int dni = 30000000 + random.Next(1000000);
                int legajo = 1000 + random.Next(9000);
                double promedio = Math.Round(2 + random.NextDouble() * 8, 2); // Promedio entre 2.00 y 10.00

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccion.Agregar(alumno);
            }
        }

        static void ImprimirElementos(IColeccionable coleccion)
        {
            
            if (coleccion is IIterable iterable)
            {
                IIterador iterador = iterable.CrearIterador();
                while (iterador.HaySiguiente())
                {
                    if (iterador.Siguiente() is Alumno alumno)
                    {
                        Console.WriteLine($"- {alumno.GetNombre()} (DNI: {alumno.GetDNI()}, Legajo: {alumno.GetLegajo()}, Promedio: {alumno.GetPromedio()})");
                    }
                }
            }
            else
            {
                Console.WriteLine("La colección no implementa IIterable");
            }
        }

        static void CambiarEstrategia(IColeccionable coleccion, IEstrategiaComparacion estrategia)
        {
            if (coleccion is IIterable iterable)
            {
                IIterador iterador = iterable.CrearIterador();
                while (iterador.HaySiguiente())
                {
                    if (iterador.Siguiente() is Alumno alumno)
                    {
                        alumno.SetEstrategia(estrategia);
                    }
                }
            }
        }

                static void InformarColeccion(IColeccionable coleccion)
        {
            Console.WriteLine($"Cantidad de elementos: {coleccion.Cuantos()}");

            Alumno minimo = (Alumno)coleccion.Minimo();
            Console.WriteLine($"Alumno mínimo: {minimo.GetNombre()} (DNI: {minimo.GetDNI()}, Legajo: {minimo.GetLegajo()}, Promedio: {minimo.GetPromedio()})");

            Alumno maximo = (Alumno)coleccion.Maximo();
            Console.WriteLine($"Alumno máximo: {maximo.GetNombre()} (DNI: {maximo.GetDNI()}, Legajo: {maximo.GetLegajo()}, Promedio: {maximo.GetPromedio()})");
        }
    }
} 