using System;
using clase1;

class Program
{
    static void Main(string[] args)
    {   
        // Estructuras
        Pila pila = new Pila();
        Cola cola = new Cola();
        
        llenarAlumnos(pila);
        llenarAlumnos(cola);
        
        ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

        
        Console.WriteLine("\n=== Comparando por LEGAJO ===");
        Alumno.SetCompararPorPromedio(false);
        informar(multiple);

        
        Console.WriteLine("\n=== Comparando por PROMEDIO ===");
        Alumno.SetCompararPorPromedio(true);
        informar(multiple);
            

        
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

    static void informar(Coleccionable coleccion)
{
    Console.WriteLine($"Cantidad de elementos: {coleccion.cuantos()}");
    
    Alumno minAlumno = (Alumno)coleccion.minimo();
    Alumno maxAlumno = (Alumno)coleccion.maximo();
    
    if (Alumno.GetCompararPorPromedio())
    {
        Console.WriteLine($"Alumno con menor promedio: {minAlumno.getNombre()} (Prom: {minAlumno.getPromedio()})");
        Console.WriteLine($"Alumno con mayor promedio: {maxAlumno.getNombre()} (Prom: {maxAlumno.getPromedio()})");
    }
    else
    {
        Console.WriteLine($"Alumno con menor legajo: {minAlumno.getNombre()} (Legajo: {minAlumno.getLegajo()})");
        Console.WriteLine($"Alumno con mayor legajo: {maxAlumno.getNombre()} (Legajo: {maxAlumno.getLegajo()})");
    }
}

    static void llenarAlumnos(Coleccionable coleccionable)
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
}