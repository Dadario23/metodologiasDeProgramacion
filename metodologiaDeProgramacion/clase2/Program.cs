using System;
using clase2;

class Program
{
    static void Main(string[] args)
    {       
        
        Conjunto conjunto = new Conjunto(); 
        LlenarAlumnos(conjunto);

        Console.WriteLine($"Cantidad de elementos: {conjunto.cuantos()}");

        cambiarEstrategia(conjunto, new CompararPorNombre());
        informar(conjunto, "por Nombre");

        cambiarEstrategia(conjunto, new CompararPorLegajo());
        informar(conjunto, "por Legajo");

        cambiarEstrategia(conjunto, new CompararPorPromedio());
        informar(conjunto, "por Promedio");

        cambiarEstrategia(conjunto, new CompararPorDni());
        informar(conjunto, "por DNI");
    }

    static void llenar(Coleccionable coleccion)
    {
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            int valorAleatorio = random.Next(1, 101);
            coleccion.agregar(new Numero(valorAleatorio));
        }
    }    

    static void LlenarAlumnos(Coleccionable coleccionable)
    {
        Random random = new Random();
        string[] nombres = {"Juan", "María", "Carlos", "Ana", "Luis", "Lucía", "Pedro", "Sofía"};
    
        for (int i = 0; i < 20; i++)
        {
            string nombre = nombres[random.Next(nombres.Length)];
            int dni = 30000000 + random.Next(10000000);
            int legajo = 10000 + random.Next(90000);
            float promedio = (float)Math.Round(1 + random.NextDouble() * 9, 1);
        
            coleccionable.agregar(new Alumno(nombre, dni, legajo, promedio));
        }
    }

        static void informar(Coleccionable coleccionable, string criterio)
    {
        Console.WriteLine($"\nComparación {criterio}");
        
        Alumno minimo = (Alumno)coleccionable.minimo();
        Alumno maximo = (Alumno)coleccionable.maximo();
        
        Console.WriteLine("Alumno 'mínimo':");
        Console.WriteLine($"- Nombre: {minimo.getNombre()}");
        Console.WriteLine($"- Legajo: {minimo.getLegajo()}");
        Console.WriteLine($"- Promedio: {minimo.getPromedio():0.0}");
        Console.WriteLine($"- DNI: {minimo.getDni()}");
        
        Console.WriteLine("\nAlumno 'máximo':");
        Console.WriteLine($"- Nombre: {maximo.getNombre()}");
        Console.WriteLine($"- Legajo: {maximo.getLegajo()}");
        Console.WriteLine($"- Promedio: {maximo.getPromedio():0.0}");
        Console.WriteLine($"- DNI: {maximo.getDni()}");
    }

        static void ImprimirElementos(IIterable coleccionable, string titulo = "Elementos")
    {
        Console.WriteLine($"\n=== {titulo} ===");
        
        IIterador iterador = coleccionable.CrearIterador();
        int contador = 1;
        
        for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente())
        {
            Console.WriteLine($"{contador++}. {iterador.Actual()}");
        }
        
        Console.WriteLine($"Total: {((Coleccionable)coleccionable).cuantos()} alumnos");
        Console.WriteLine("=====================");
    }

    static void cambiarEstrategia(Coleccionable coleccionable, IComparacionAlumno estrategia)
    {
        IIterador iterador = ((IIterable)coleccionable).CrearIterador();
        for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente())
        {
            if (iterador.Actual() is Alumno alumno)
            {
                Alumno.SetEstrategiaComparacion(estrategia);
            }
        }
    }
}