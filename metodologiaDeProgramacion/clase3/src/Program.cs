using System;
using clase3.src;
using clase3;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Colecciones y Observadores ===");
        Console.WriteLine("1. Trabajar con Números");
        Console.WriteLine("2. Trabajar con Alumnos");
        Console.WriteLine("3. Trabajar con Profesores");
        Console.WriteLine("4. Simular clase con Observer (Ejercicio 12-14)");
        Console.Write("Seleccione una opción: ");
        
        int opcion;
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out opcion))
        {
            Console.WriteLine("Opción inválida. Finalizando programa.");
            return;
        }

        switch (opcion)
        {
            case 1:
            case 2:
            case 3:
                ProcesarColeccion(opcion);
                break;
            case 4:
                SimularClase();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }

    static void ProcesarColeccion(int tipoElemento)
    {
        // Ejercicio 6: Menú unificado para colecciones
        Console.WriteLine("\n=== Seleccione tipo de colección ===");
        Console.WriteLine("1. Pila");
        Console.WriteLine("2. Cola");
        Console.WriteLine("3. Conjunto");
        Console.Write("Seleccione: ");
        int tipoColeccion;
        string? input = Console.ReadLine();
        if (!int.TryParse(input, out tipoColeccion))
        {
            Console.WriteLine("Tipo de colección inválido. Finalizando operación.");
            return;
        }

        Coleccionable coleccion = CrearColeccion(tipoColeccion);
        Alumno.SetEstrategiaComparacion(new CompararPorPromedio());
        LlenarColeccion(coleccion, tipoElemento);
        InformarColeccion(coleccion, tipoElemento);
    }

    static Coleccionable CrearColeccion(int tipo)
    {
        return tipo switch
        {
            1 => new Pila(),
            2 => new Cola(),
            3 => new Conjunto(),
            _ => throw new ArgumentException("Tipo de colección no válido")
        };
    }

    static void LlenarColeccion(Coleccionable coleccion, int tipoElemento)
    {
        Console.WriteLine($"\n=== Llenando colección ===");
    for (int i = 0; i < 20; i++)
    {
        Console.WriteLine($"Elemento {i + 1} de 20");
        Console.Write("¿Crear por teclado? (s/n): ");
        string? respuestaRaw = Console.ReadLine();
        if (respuestaRaw == null)
        {
            Console.WriteLine("Entrada inválida. Usando generación aleatoria por defecto.");
            respuestaRaw = "n";
        }
        string respuesta = respuestaRaw.ToLower();


        Comparable elemento;
        if (respuesta == "s")
        {
            elemento = FabricaDeComparables.CrearPorTeclado(tipoElemento); 
        }
        else
        {
            elemento = FabricaDeComparables.CrearAleatorio(tipoElemento); 
            Console.WriteLine($"Elemento generado: {elemento}");
        }

        coleccion.agregar(elemento);
    }
    }

    static void InformarColeccion(Coleccionable coleccion, int tipoElemento)
    {
        Console.WriteLine("\n=== Informe ===");
        Console.WriteLine($"Cantidad de elementos: {coleccion.cuantos()}");
        Console.WriteLine($"Elemento mínimo: {coleccion.minimo()}");
        Console.WriteLine($"Elemento máximo: {coleccion.maximo()}");

        // Verificación de elemento
        Console.WriteLine("\n=== Verificar elemento ===");
        Comparable buscado = FabricaDeComparables.CrearPorTeclado(tipoElemento);
        
        Console.WriteLine($"\nBuscando: {buscado}");
        bool encontrado = coleccion.contiene(buscado);
        
        if (encontrado)
        {
            Console.WriteLine("El elemento EXISTE en la colección");
        }
        else
        {
            Console.WriteLine("El elemento NO existe en la colección");
            Console.WriteLine("Elementos en colección:");
            if (coleccion is IIterable iterable)
            {
                ImprimirElementos(iterable); 
            }
        }
    }

    static void ImprimirElementos(IIterable coleccion)
    {
        Console.WriteLine("\n=== Elementos en la colección ===");
        IIterador iterador = coleccion.CrearIterador();
        int contador = 1;

        for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente())
        {
            Console.WriteLine($"{contador++}. {iterador.Actual()}");
        }
    }

    static void SimularClase()
    {
        // Ejercicio 14: Simulación de clase con Observer
        Console.WriteLine("\n=== Simulación de Clase ===");
        
        
        Profesor profesor = new Profesor("Lic. Martínez", 25456879, 10);
        
        // Crear 20 alumnos y asignarlos como observadores
        for (int i = 1; i <= 20; i++)
        {
            Alumno alumno = (Alumno)FabricaDeComparables.CrearAleatorio(2); 
            profesor.AgregarObservador(alumno);
            Console.WriteLine($"{alumno.getNombre()} listo para la clase");
        }

        // Ejercicio 13: Dictado de clases
        DictarClase(profesor);
    }

    static void DictarClase(Profesor profesor)
    {
        Console.WriteLine("\n=== Comienza la clase ===");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"\nAcción {i}:");
            profesor.HablarALaClase();
            System.Threading.Thread.Sleep(1500);
            profesor.EscribirEnElPizarron();
            System.Threading.Thread.Sleep(1500);
        }
        Console.WriteLine("\n=== La clase ha finalizado ===");
    }
}